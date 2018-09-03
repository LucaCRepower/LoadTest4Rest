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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.nudVisitors = new System.Windows.Forms.NumericUpDown();
            this.cboJobList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExecution = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExecution);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboJobList);
            this.panel1.Controls.Add(this.nudVisitors);
            this.panel1.Controls.Add(this.txtServerUrl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 125);
            this.panel1.TabIndex = 0;
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
            // txtServerUrl
            // 
            this.txtServerUrl.Location = new System.Drawing.Point(171, 12);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(455, 26);
            this.txtServerUrl.TabIndex = 1;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1010, 511);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 671);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Test di Carico per server REST";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudVisitors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboJobList;
        private System.Windows.Forms.Button btnExecution;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

