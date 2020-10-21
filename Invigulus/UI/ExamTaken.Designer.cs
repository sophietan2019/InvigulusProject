namespace UI
{
    partial class ExamTaken
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
            this.dgvExamTaken = new System.Windows.Forms.DataGridView();
            this.cmbExamID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamTaken)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExamTaken
            // 
            this.dgvExamTaken.AllowUserToAddRows = false;
            this.dgvExamTaken.AllowUserToDeleteRows = false;
            this.dgvExamTaken.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvExamTaken.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExamTaken.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvExamTaken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamTaken.Location = new System.Drawing.Point(245, 49);
            this.dgvExamTaken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvExamTaken.Name = "dgvExamTaken";
            this.dgvExamTaken.ReadOnly = true;
            this.dgvExamTaken.RowHeadersWidth = 51;
            this.dgvExamTaken.RowTemplate.Height = 24;
            this.dgvExamTaken.Size = new System.Drawing.Size(1650, 1150);
            this.dgvExamTaken.TabIndex = 0;
            // 
            // cmbExamID
            // 
            this.cmbExamID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExamID.FormattingEnabled = true;
            this.cmbExamID.Location = new System.Drawing.Point(16, 105);
            this.cmbExamID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbExamID.Name = "cmbExamID";
            this.cmbExamID.Size = new System.Drawing.Size(206, 27);
            this.cmbExamID.TabIndex = 1;
            this.cmbExamID.SelectedValueChanged += new System.EventHandler(this.cmbExamID_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Exam ID";
            // 
            // ExamTaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1100, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbExamID);
            this.Controls.Add(this.dgvExamTaken);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExamTaken";
            this.Text = "ExamTaken";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExamTaken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamTaken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamTaken;
        private System.Windows.Forms.ComboBox cmbExamID;
        private System.Windows.Forms.Label label1;
    }
}