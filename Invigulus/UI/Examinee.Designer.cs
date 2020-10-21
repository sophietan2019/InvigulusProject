namespace UI
{
    partial class Examinee
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
            this.dgvExaminee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExaminee
            // 
            this.dgvExaminee.AllowUserToAddRows = false;
            this.dgvExaminee.AllowUserToDeleteRows = false;
            this.dgvExaminee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExaminee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExaminee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.dgvExaminee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExaminee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExaminee.Location = new System.Drawing.Point(0, 0);
            this.dgvExaminee.Name = "dgvExaminee";
            this.dgvExaminee.ReadOnly = true;
            this.dgvExaminee.RowHeadersWidth = 51;
            this.dgvExaminee.RowTemplate.Height = 24;
            this.dgvExaminee.Size = new System.Drawing.Size(900, 534);
            this.dgvExaminee.TabIndex = 0;
            // 
            // Examinee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.dgvExaminee);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Examinee";
            this.Text = "Examinee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Examinee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExaminee;
    }
}