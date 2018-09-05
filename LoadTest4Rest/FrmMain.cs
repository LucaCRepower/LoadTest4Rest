using com.Repower.LoadTest4Rest.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.Repower.LoadTest4Rest
{
    public partial class FrmMain : Form
    {
        private const int FIXED_ROWS = 6;
        DataGridViewCellStyle dgvStyleError, dgvStyleNormal;

        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
            this.txtServerUrl.Validated += Guidata_Validated;
            this.nudVisitors.Validated += Guidata_Validated;
            this.cboJobList.SelectedIndexChanged += Guidata_Validated;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ServicePointManager.DefaultConnectionLimit = 1000;
            cboJobList.Items.AddRange(JobInfo.Load().ToArray());
            CallInfo.Load();
            cboJobList.SelectedItem = null;
            txtServerUrl.Text = Properties.Settings.Default.serverName ?? "";
            nudVisitors.Value = Properties.Settings.Default.visitorNumber;
            dgvStyleError = new DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.Red
            };
            dgvStyleNormal = new DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.White
            };

        }


        private void Guidata_Validated(object sender, EventArgs e)
        {

            btnExecution.Enabled = (Uri.IsWellFormedUriString(txtServerUrl.Text, UriKind.RelativeOrAbsolute) &&
                                cboJobList.SelectedIndex > -1);

            txtServerUrl.Text = (txtServerUrl.Text ?? "").Trim();
            if (!(txtServerUrl.Text.StartsWith("http://") || txtServerUrl.Text.StartsWith("https://")))
            {
                txtServerUrl.Text = "http://" + txtServerUrl.Text.Trim();
            }

            if (txtServerUrl.Text.EndsWith("/") && !string.IsNullOrWhiteSpace(txtServerUrl.Text))
            {
                txtServerUrl.Text = txtServerUrl.Text.Substring(0, txtServerUrl.Text.Length - 1);
            }

            btnExecution.BackColor = btnExecution.Enabled ? Color.Green : Color.Gray;
        }

        /// <summary>
        /// Esecuzione dei test.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecution_Click(object sender, EventArgs e)
        {
            pnlConfig.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            LoadTestExecutor tester = new LoadTestExecutor();
            try
            {
                JobInfo theJob = (JobInfo)cboJobList.SelectedItem;
                InitializeGrid(nudVisitors.Value, theJob);
                List<FeedbackInfo> feedback = tester.Execute(txtServerUrl.Text, (int)nudVisitors.Value, theJob);
                ShowTotals(feedback);
                ShowCallOnGrid(feedback, theJob);
            }
            finally
            {
                pnlConfig.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Visualizza i totali, sulla griglia
        /// </summary>
        /// <param name="feedback"></param>
        private void ShowTotals(List<FeedbackInfo> feedback)
        {
            DataGridViewRow row = this.dgwExecData.Rows[0];

            List<double> values = new List<double>();
            List<double> grouping = new List<double>();
            List<bool> errors = new List<bool>();

            foreach (FeedbackInfo fb in feedback)
            {
                bool failed = fb.Executions.Any(e => e.Failed);
                double total = fb.Executions.Select(e => e.ExecTime.TotalMilliseconds).Sum();

                if (!failed)
                {
                    grouping.Add(total);
                }

                errors.Add(failed);
                values.Add(total);

            }

            WriteRow(row, grouping, values, errors);

        }

        /// <summary>
        /// Scrive i dati sulla riga passata come parametro.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="avg"></param>
        /// <param name="sigma"></param>
        /// <param name="values"></param>
        /// <param name="errors"></param>
        private void WriteRow(DataGridViewRow row, List<double> grouping, List<double> values, List<bool> errors)
        {

            double max = grouping.DefaultIfEmpty().Max(),
                       min = grouping.DefaultIfEmpty().Min(),
                       avg = grouping.DefaultIfEmpty().Average(),
                       sigma = StandardDeviation(grouping);

            int errori = errors.Where(e => e).Count();
            row.Cells[1].Value = errori;

            row.Cells[1].Style = (errori > 0) ? dgvStyleError : dgvStyleNormal;

            row.Cells[2].Value = FormatTimeSpan(sigma);
            row.Cells[3].Value = FormatTimeSpan(avg);
            row.Cells[4].Value = FormatTimeSpan(min);
            row.Cells[5].Value = FormatTimeSpan(max);


            for (int x = 0; x < values.Count(); ++x)
            {
                if (errors[x])
                {
                    row.Cells[FIXED_ROWS + x].Style = dgvStyleError;
                    row.Cells[FIXED_ROWS + x].Value = "--";
                }
                else
                {
                    row.Cells[FIXED_ROWS + x].Value = FormatTimeSpan(values[x]);
                }
            }
        }

        /// <summary>
        /// Inizializza la griglia, dato Job e numero di visitatori
        /// </summary>
        /// <param name="visitorNumber"></param>
        /// <param name="theJob"></param>
        private void InitializeGrid(decimal visitorNumber, JobInfo theJob)
        {

            dgwExecData.Rows.Clear();
            while (dgwExecData.Columns.Count > FIXED_ROWS)
            {
                dgwExecData.Columns.RemoveAt(FIXED_ROWS);
            }

            DataGridViewCellStyle dgvStyle2 = new DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            };

            for (int x = 0; x < visitorNumber; ++x)
            {
                dgwExecData.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Frozen = false,
                    HeaderText = $"#{x + 1}",
                    Name = "colThread" + x,
                    ReadOnly = true,
                    Width = 100,
                    DefaultCellStyle = dgvStyle2
                });
            }

            // job row
            dgwExecData.Rows.Add(new string[] { "Tempo totale", "?", "?", "?", "?", "?" });

            // call rows
            foreach (string call in theJob.Calls)
            {
                dgwExecData.Rows.Add(new string[] { call, "?", "?", "?", "?", "?" });
            }

        }

        /// <summary>
        /// Visualizza sulla griglia i dati di esecuzione delle call
        /// </summary>
        /// <param name="feedback"></param>
        /// <param name="theJob"></param>
        private void ShowCallOnGrid(List<FeedbackInfo> feedback, JobInfo theJob)
        {
            int visitors = feedback.Count();
            foreach (string call in theJob.Calls)
            {
                DataGridViewRow row = GetRowByNameCall(call);
                if (row == null)
                {
                    return;
                }

                List<double> values = new List<double>();
                List<double> grouping = new List<double>();
                List<bool> errors = new List<bool>();

                foreach (FeedbackInfo fb in feedback)
                {
                    ExecutionInfo exec = fb.Executions.Where(e => e.Name == call).FirstOrDefault();
                    if (exec == null)
                    {
                        continue;
                    }

                    bool failed = exec.Failed;
                    double total = exec.ExecTime.TotalMilliseconds;

                    if (!failed)
                    {
                        grouping.Add(total);
                    }

                    errors.Add(failed);
                    values.Add(total);

                }


                WriteRow(row, grouping, values, errors);


            }
        }

        /// <summary>
        /// Recupera la riga della chiama dalla griglia.
        /// </summary>
        /// <param name="call"></param>
        /// <returns></returns>
        private DataGridViewRow GetRowByNameCall(string call)
        {
            DataGridViewRow row = null;
            foreach (DataGridViewRow r1 in this.dgwExecData.Rows)
            {
                if (r1.Cells[0].Value.ToString() == call)
                {
                    row = r1;
                    break;
                }
            }

            return row;

        }

        /// <summary>
        /// Trasformazione del timespan in una stringa
        /// Per ora, viene visualizzato in secondi e parziali
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        private string FormatTimeSpan(double ts)
        {
            return TimeSpan.FromMilliseconds(ts).TotalSeconds.ToString("#0.000");
        }

        /// <summary>
        /// Calcolo della deviazione standard.
        /// </summary>
        /// <param name="valueList"></param>
        /// <returns></returns>
        private static double StandardDeviation(List<double> valueList)
        {

            double M = 0.0;
            double S = 0.0;
            int k = 1;
            foreach (double value in valueList)
            {
                double tmpM = M;
                M += (value - tmpM) / k;
                S += (value - tmpM) * (value - M);
                k++;
            }

            if (S == 0 || k == 1)
            {
                return 0;
            }
            else
            {
                return Math.Sqrt(S / (k - 1));
            }

        }
    }
}
