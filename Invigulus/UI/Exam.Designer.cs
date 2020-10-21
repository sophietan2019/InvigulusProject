namespace UI
{
    partial class Exam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMaxAttemps = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvExamData = new System.Windows.Forms.DataGridView();
            this.ExaminerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamMaxDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxAllowedAttemptsPerPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.mtxbDurationT = new System.Windows.Forms.MaskedTextBox();
            this.mtxbStrTime = new System.Windows.Forms.MaskedTextBox();
            this.mtxbEndTime = new System.Windows.Forms.MaskedTextBox();
            this.txbExamID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max Attemps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(11, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "End Date";
            // 
            // txbMaxAttemps
            // 
            this.txbMaxAttemps.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaxAttemps.Location = new System.Drawing.Point(138, 150);
            this.txbMaxAttemps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbMaxAttemps.Name = "txbMaxAttemps";
            this.txbMaxAttemps.Size = new System.Drawing.Size(112, 27);
            this.txbMaxAttemps.TabIndex = 3;
            this.txbMaxAttemps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaxAttemps_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(16, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "End Time";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(47, 443);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 27);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(166, 443);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 27);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(286, 443);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 27);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvExamData
            // 
            this.dgvExamData.AllowUserToAddRows = false;
            this.dgvExamData.AllowUserToDeleteRows = false;
            this.dgvExamData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvExamData.BackgroundColor = System.Drawing.Color.White;
            this.dgvExamData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExamData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExaminerID,
            this.ExamID,
            this.ExamMaxDuration,
            this.MaxAllowedAttemptsPerPerson,
            this.ExamStartDate,
            this.ExamStartTime,
            this.ExamEndDate,
            this.ExamEndTime,
            this.Column1,
            this.Column2});
            this.dgvExamData.Location = new System.Drawing.Point(484, 29);
            this.dgvExamData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvExamData.Name = "dgvExamData";
            this.dgvExamData.ReadOnly = true;
            this.dgvExamData.RowHeadersWidth = 51;
            this.dgvExamData.RowTemplate.Height = 24;
            this.dgvExamData.Size = new System.Drawing.Size(1000, 800);
            this.dgvExamData.TabIndex = 18;
            this.dgvExamData.DoubleClick += new System.EventHandler(this.dgvExamData_DoubleClick);
            // 
            // ExaminerID
            // 
            this.ExaminerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ExaminerID.DataPropertyName = "ExaminerID";
            this.ExaminerID.HeaderText = "Examiner ID";
            this.ExaminerID.MinimumWidth = 6;
            this.ExaminerID.Name = "ExaminerID";
            this.ExaminerID.ReadOnly = true;
            this.ExaminerID.Width = 128;
            // 
            // ExamID
            // 
            this.ExamID.DataPropertyName = "ExamID";
            this.ExamID.HeaderText = "Exam ID";
            this.ExamID.MinimumWidth = 6;
            this.ExamID.Name = "ExamID";
            this.ExamID.ReadOnly = true;
            this.ExamID.Width = 125;
            // 
            // ExamMaxDuration
            // 
            this.ExamMaxDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ExamMaxDuration.DataPropertyName = "ExamMaxDuration";
            dataGridViewCellStyle7.NullValue = null;
            this.ExamMaxDuration.DefaultCellStyle = dataGridViewCellStyle7;
            this.ExamMaxDuration.HeaderText = "Duration Time";
            this.ExamMaxDuration.MinimumWidth = 6;
            this.ExamMaxDuration.Name = "ExamMaxDuration";
            this.ExamMaxDuration.ReadOnly = true;
            this.ExamMaxDuration.Width = 139;
            // 
            // MaxAllowedAttemptsPerPerson
            // 
            this.MaxAllowedAttemptsPerPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaxAllowedAttemptsPerPerson.DataPropertyName = "MaxAllowedAttemptsPerPerson";
            dataGridViewCellStyle8.NullValue = null;
            this.MaxAllowedAttemptsPerPerson.DefaultCellStyle = dataGridViewCellStyle8;
            this.MaxAllowedAttemptsPerPerson.HeaderText = "Max Attemps";
            this.MaxAllowedAttemptsPerPerson.MinimumWidth = 6;
            this.MaxAllowedAttemptsPerPerson.Name = "MaxAllowedAttemptsPerPerson";
            this.MaxAllowedAttemptsPerPerson.ReadOnly = true;
            this.MaxAllowedAttemptsPerPerson.Width = 129;
            // 
            // ExamStartDate
            // 
            this.ExamStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ExamStartDate.DataPropertyName = "ExamStartDate";
            dataGridViewCellStyle9.NullValue = null;
            this.ExamStartDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.ExamStartDate.HeaderText = "Start Date";
            this.ExamStartDate.MinimumWidth = 6;
            this.ExamStartDate.Name = "ExamStartDate";
            this.ExamStartDate.ReadOnly = true;
            this.ExamStartDate.Width = 111;
            // 
            // ExamStartTime
            // 
            this.ExamStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ExamStartTime.DataPropertyName = "ExamStartTime";
            dataGridViewCellStyle10.NullValue = null;
            this.ExamStartTime.DefaultCellStyle = dataGridViewCellStyle10;
            this.ExamStartTime.HeaderText = "Start Time";
            this.ExamStartTime.MinimumWidth = 6;
            this.ExamStartTime.Name = "ExamStartTime";
            this.ExamStartTime.ReadOnly = true;
            this.ExamStartTime.Width = 111;
            // 
            // ExamEndDate
            // 
            this.ExamEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ExamEndDate.DataPropertyName = "ExamEndDate";
            dataGridViewCellStyle11.NullValue = null;
            this.ExamEndDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.ExamEndDate.HeaderText = "End Date";
            this.ExamEndDate.MinimumWidth = 6;
            this.ExamEndDate.Name = "ExamEndDate";
            this.ExamEndDate.ReadOnly = true;
            this.ExamEndDate.Width = 106;
            // 
            // ExamEndTime
            // 
            this.ExamEndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ExamEndTime.DataPropertyName = "ExamEndTime";
            dataGridViewCellStyle12.NullValue = null;
            this.ExamEndTime.DefaultCellStyle = dataGridViewCellStyle12;
            this.ExamEndTime.HeaderText = "End Time";
            this.ExamEndTime.MinimumWidth = 6;
            this.ExamEndTime.Name = "ExamEndTime";
            this.ExamEndTime.ReadOnly = true;
            this.ExamEndTime.Width = 106;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ExamAdministrator";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ExamTakens";
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(113, 202);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(295, 27);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(113, 305);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(295, 27);
            this.dtpEndDate.TabIndex = 7;
            // 
            // mtxbDurationT
            // 
            this.mtxbDurationT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbDurationT.Location = new System.Drawing.Point(138, 96);
            this.mtxbDurationT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxbDurationT.Mask = "00:00:00";
            this.mtxbDurationT.Name = "mtxbDurationT";
            this.mtxbDurationT.Size = new System.Drawing.Size(112, 27);
            this.mtxbDurationT.TabIndex = 2;
            // 
            // mtxbStrTime
            // 
            this.mtxbStrTime.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbStrTime.Location = new System.Drawing.Point(138, 257);
            this.mtxbStrTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxbStrTime.Mask = "00:00:00";
            this.mtxbStrTime.Name = "mtxbStrTime";
            this.mtxbStrTime.Size = new System.Drawing.Size(112, 27);
            this.mtxbStrTime.TabIndex = 5;
            // 
            // mtxbEndTime
            // 
            this.mtxbEndTime.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbEndTime.Location = new System.Drawing.Point(138, 356);
            this.mtxbEndTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxbEndTime.Mask = "00:00:00";
            this.mtxbEndTime.Name = "mtxbEndTime";
            this.mtxbEndTime.Size = new System.Drawing.Size(112, 27);
            this.mtxbEndTime.TabIndex = 8;
            // 
            // txbExamID
            // 
            this.txbExamID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbExamID.Location = new System.Drawing.Point(138, 40);
            this.txbExamID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbExamID.Name = "txbExamID";
            this.txbExamID.Size = new System.Drawing.Size(112, 27);
            this.txbExamID.TabIndex = 22;
            this.txbExamID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Exam ID";
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbExamID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mtxbEndTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mtxbStrTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mtxbDurationT);
            this.panel1.Controls.Add(this.txbMaxAttemps);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(45, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 611);
            this.panel1.TabIndex = 24;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1332, 734);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvExamData);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Exam";
            this.Text = "Exam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExamMaintain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMaxAttemps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvExamData;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.MaskedTextBox mtxbDurationT;
        private System.Windows.Forms.MaskedTextBox mtxbStrTime;
        private System.Windows.Forms.MaskedTextBox mtxbEndTime;
        private System.Windows.Forms.TextBox txbExamID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExaminerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamMaxDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxAllowedAttemptsPerPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

