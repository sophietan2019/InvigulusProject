namespace UI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconBtnSignOut = new FontAwesome.Sharp.IconButton();
            this.iconBtnSetting = new FontAwesome.Sharp.IconButton();
            this.iconBtnExamTaken = new FontAwesome.Sharp.IconButton();
            this.iconBtnExaminee = new FontAwesome.Sharp.IconButton();
            this.iconBtnExam = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptBoxHome = new System.Windows.Forms.PictureBox();
            this.lblWelcom = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDeskTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.panelMenu.Controls.Add(this.iconBtnSignOut);
            this.panelMenu.Controls.Add(this.iconBtnSetting);
            this.panelMenu.Controls.Add(this.iconBtnExamTaken);
            this.panelMenu.Controls.Add(this.iconBtnExaminee);
            this.panelMenu.Controls.Add(this.iconBtnExam);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(345, 617);
            this.panelMenu.TabIndex = 0;
            // 
            // iconBtnSignOut
            // 
            this.iconBtnSignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnSignOut.FlatAppearance.BorderSize = 0;
            this.iconBtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSignOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSignOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconBtnSignOut.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSignOut.IconSize = 32;
            this.iconBtnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSignOut.Location = new System.Drawing.Point(0, 524);
            this.iconBtnSignOut.Name = "iconBtnSignOut";
            this.iconBtnSignOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnSignOut.Rotation = 0D;
            this.iconBtnSignOut.Size = new System.Drawing.Size(345, 66);
            this.iconBtnSignOut.TabIndex = 5;
            this.iconBtnSignOut.Text = "Sign Out";
            this.iconBtnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSignOut.UseVisualStyleBackColor = true;
            this.iconBtnSignOut.Click += new System.EventHandler(this.iconBtnSignOut_Click);
            // 
            // iconBtnSetting
            // 
            this.iconBtnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnSetting.FlatAppearance.BorderSize = 0;
            this.iconBtnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSetting.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconBtnSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSetting.IconSize = 32;
            this.iconBtnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSetting.Location = new System.Drawing.Point(0, 458);
            this.iconBtnSetting.Name = "iconBtnSetting";
            this.iconBtnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnSetting.Rotation = 0D;
            this.iconBtnSetting.Size = new System.Drawing.Size(345, 66);
            this.iconBtnSetting.TabIndex = 4;
            this.iconBtnSetting.Text = "Setting";
            this.iconBtnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSetting.UseVisualStyleBackColor = true;
            this.iconBtnSetting.Click += new System.EventHandler(this.iconBtnSetting_Click);
            // 
            // iconBtnExamTaken
            // 
            this.iconBtnExamTaken.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnExamTaken.FlatAppearance.BorderSize = 0;
            this.iconBtnExamTaken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnExamTaken.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnExamTaken.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExamTaken.IconChar = FontAwesome.Sharp.IconChar.School;
            this.iconBtnExamTaken.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExamTaken.IconSize = 32;
            this.iconBtnExamTaken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExamTaken.Location = new System.Drawing.Point(0, 392);
            this.iconBtnExamTaken.Name = "iconBtnExamTaken";
            this.iconBtnExamTaken.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnExamTaken.Rotation = 0D;
            this.iconBtnExamTaken.Size = new System.Drawing.Size(345, 66);
            this.iconBtnExamTaken.TabIndex = 3;
            this.iconBtnExamTaken.Text = "Exam Taken";
            this.iconBtnExamTaken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExamTaken.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExamTaken.UseVisualStyleBackColor = true;
            this.iconBtnExamTaken.Click += new System.EventHandler(this.iconBtnExamTaken_Click);
            // 
            // iconBtnExaminee
            // 
            this.iconBtnExaminee.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnExaminee.FlatAppearance.BorderSize = 0;
            this.iconBtnExaminee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnExaminee.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnExaminee.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExaminee.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.iconBtnExaminee.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExaminee.IconSize = 32;
            this.iconBtnExaminee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExaminee.Location = new System.Drawing.Point(0, 326);
            this.iconBtnExaminee.Name = "iconBtnExaminee";
            this.iconBtnExaminee.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnExaminee.Rotation = 0D;
            this.iconBtnExaminee.Size = new System.Drawing.Size(345, 66);
            this.iconBtnExaminee.TabIndex = 2;
            this.iconBtnExaminee.Text = "Examinee";
            this.iconBtnExaminee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExaminee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExaminee.UseVisualStyleBackColor = true;
            this.iconBtnExaminee.Click += new System.EventHandler(this.iconBtnExaminee_Click);
            // 
            // iconBtnExam
            // 
            this.iconBtnExam.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnExam.FlatAppearance.BorderSize = 0;
            this.iconBtnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnExam.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnExam.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExam.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconBtnExam.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExam.IconSize = 32;
            this.iconBtnExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExam.Location = new System.Drawing.Point(0, 260);
            this.iconBtnExam.Name = "iconBtnExam";
            this.iconBtnExam.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnExam.Rotation = 0D;
            this.iconBtnExam.Size = new System.Drawing.Size(345, 66);
            this.iconBtnExam.TabIndex = 1;
            this.iconBtnExam.Text = "Exam";
            this.iconBtnExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExam.UseVisualStyleBackColor = true;
            this.iconBtnExam.Click += new System.EventHandler(this.iconBtnExams_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptBoxHome);
            this.panel2.Controls.Add(this.lblWelcom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 260);
            this.panel2.TabIndex = 0;
            // 
            // ptBoxHome
            // 
            this.ptBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("ptBoxHome.Image")));
            this.ptBoxHome.Location = new System.Drawing.Point(12, 43);
            this.ptBoxHome.Name = "ptBoxHome";
            this.ptBoxHome.Size = new System.Drawing.Size(225, 78);
            this.ptBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBoxHome.TabIndex = 2;
            this.ptBoxHome.TabStop = false;
            this.ptBoxHome.Click += new System.EventHandler(this.ptBoxHome_Click);
            // 
            // lblWelcom
            // 
            this.lblWelcom.AutoSize = true;
            this.lblWelcom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcom.ForeColor = System.Drawing.Color.White;
            this.lblWelcom.Location = new System.Drawing.Point(12, 137);
            this.lblWelcom.Name = "lblWelcom";
            this.lblWelcom.Size = new System.Drawing.Size(78, 19);
            this.lblWelcom.TabIndex = 1;
            this.lblWelcom.Text = "Welcome";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(61)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(345, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(722, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(61, 43);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(51, 19);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(61)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 35);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(345, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(722, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDeskTop.Controls.Add(this.label1);
            this.panelDeskTop.Controls.Add(this.pictureBox1);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(345, 89);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(722, 528);
            this.panelDeskTop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(72, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1346, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Online proctoring service aspiring examinees from anywhere";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 617);
            this.Controls.Add(this.panelDeskTop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDeskTop.ResumeLayout(false);
            this.panelDeskTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconBtnSignOut;
        private FontAwesome.Sharp.IconButton iconBtnSetting;
        private FontAwesome.Sharp.IconButton iconBtnExamTaken;
        private FontAwesome.Sharp.IconButton iconBtnExaminee;
        private FontAwesome.Sharp.IconButton iconBtnExam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblWelcom;
        private System.Windows.Forms.PictureBox ptBoxHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}