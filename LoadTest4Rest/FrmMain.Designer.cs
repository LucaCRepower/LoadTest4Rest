namespace com.Repower.LoadTest4Rest
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.btnExecution = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboJobList = new System.Windows.Forms.ComboBox();
            this.nudVisitors = new System.Windows.Forms.NumericUpDown();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwExecData = new System.Windows.Forms.DataGridView();
            this.CallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigmaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExecData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConfig
            // 
            this.pnlConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfig.Controls.Add(this.btnExecution);
            this.pnlConfig.Controls.Add(this.label4);
            this.pnlConfig.Controls.Add(this.cboJobList);
            this.pnlConfig.Controls.Add(this.nudVisitors);
            this.pnlConfig.Controls.Add(this.txtServerUrl);
            this.pnlConfig.Controls.Add(this.label3);
            this.pnlConfig.Controls.Add(this.label2);
            this.pnlConfig.Controls.Add(this.label1);
            this.pnlConfig.Location = new System.Drawing.Point(13, 14);
            this.pnlConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(1010, 125);
            this.pnlConfig.TabIndex = 0;
            // 
            // btnExecution
            // 
            this.btnExecution.BackColor = System.Drawing.Color.Gray;
            this.btnExecution.Enabled = false;
            this.btnExecution.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExecution.Location = new System.Drawing.Point(865, 12);
            this.btnExecution.Name = "btnExecution";
            this.btnExecution.Size = new System.Drawing.Size(130, 103);
            this.btnExecution.TabIndex = 1;
            this.btnExecution.Text = "Esegui";
            this.btnExecution.UseVisualStyleBackColor = false;
            this.btnExecution.Click += new System.EventHandler(this.btnExecution_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "( es http://localhost:3000/api)";
            // 
            // cboJobList
            // 
            this.cboJobList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboJobList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboJobList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJobList.FormattingEnabled = true;
            this.cboJobList.Location = new System.Drawing.Point(171, 87);
            this.cboJobList.Name = "cboJobList";
            this.cboJobList.Size = new System.Drawing.Size(455, 28);
            this.cboJobList.TabIndex = 6;
            // 
            // nudVisitors
            // 
            this.nudVisitors.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudVisitors.Location = new System.Drawing.Point(171, 49);
            this.nudVisitors.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudVisitors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVisitors.Name = "nudVisitors";
            this.nudVisitors.Size = new System.Drawing.Size(84, 26);
            this.nudVisitors.TabIndex = 4;
            this.nudVisitors.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtServerUrl
            // 
            this.txtServerUrl.Location = new System.Drawing.Point(171, 12);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(455, 26);
            this.txtServerUrl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero di Visitatori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Job da eseguire:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url del server:";
            // 
            // dgwExecData
            // 
            this.dgwExecData.AllowUserToAddRows = false;
            this.dgwExecData.AllowUserToDeleteRows = false;
            this.dgwExecData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwExecData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwExecData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExecData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CallName,
            this.errorsCol,
            this.sigmaCol,
            this.avgValue,
            this.minValue,
            this.maxValue});
            this.dgwExecData.Location = new System.Drawing.Point(13, 148);
            this.dgwExecData.MultiSelect = false;
            this.dgwExecData.Name = "dgwExecData";
            this.dgwExecData.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwExecData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwExecData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwExecData.Size = new System.Drawing.Size(1010, 511);
            this.dgwExecData.TabIndex = 1;
            // 
            // CallName
            // 
            this.CallName.Frozen = true;
            this.CallName.HeaderText = "Nome Job\\Call";
            this.CallName.Name = "CallName";
            this.CallName.ReadOnly = true;
            this.CallName.Width = 300;
            // 
            // errorsCol
            // 
            this.errorsCol.Frozen = true;
            this.errorsCol.HeaderText = "Errori";
            this.errorsCol.Name = "errorsCol";
            this.errorsCol.ReadOnly = true;
            // 
            // sigmaCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.sigmaCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.sigmaCol.Frozen = true;
            this.sigmaCol.HeaderText = "Deviazione";
            this.sigmaCol.Name = "sigmaCol";
            this.sigmaCol.ReadOnly = true;
            // 
            // avgValue
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.avgValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.avgValue.Frozen = true;
            this.avgValue.HeaderText = "Valore Medio";
            this.avgValue.Name = "avgValue";
            this.avgValue.ReadOnly = true;
            // 
            // minValue
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.minValue.DefaultCellStyle = dataGridViewCellStyle4;
            this.minValue.Frozen = true;
            this.minValue.HeaderText = "Valore Minimo";
            this.minValue.Name = "minValue";
            this.minValue.ReadOnly = true;
            // 
            // maxValue
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.maxValue.DefaultCellStyle = dataGridViewCellStyle5;
            this.maxValue.Frozen = true;
            this.maxValue.HeaderText = "Valore Massimo";
            this.maxValue.Name = "maxValue";
            this.maxValue.ReadOnly = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 671);
            this.Controls.Add(this.dgwExecData);
            this.Controls.Add(this.pnlConfig);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Test di Carico per server REST";
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExecData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudVisitors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboJobList;
        private System.Windows.Forms.Button btnExecution;
        private System.Windows.Forms.DataGridView dgwExecData;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn minCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigmaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn minValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxValue;
    }
}

