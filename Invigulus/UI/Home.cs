using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using FontAwesome.Sharp;

namespace UI
{
    public partial class Home : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public int UserID { get; set; }
        ExamAdministrator examAdmin = new ExamAdministrator();

        public Home()
        {

            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon Current Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            examAdmin = ExamAdministratorManager.GetByID(UserID);
            lblWelcom.Text = "Welcome, " + "\n" + "\n" + examAdmin.FirstName.ToString() + 
                " " + examAdmin.LastName.ToString();
        }

        private void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                //open only a form at a time
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDeskTop.Controls.Add(childform);
            panelDeskTop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            /*lblTitleChildForm.Text = childform.Text;*/

        }

        private void iconBtnExams_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);           
            Exam exam = new Exam();
            exam.UserID = UserID;
            OpenChildForm(exam);

        }

        private void iconBtnExaminee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            Examinee  examinee = new Examinee();       
            OpenChildForm(examinee);
        }

        private void iconBtnExamTaken_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            ExamTaken examTaken = new ExamTaken();
            examTaken.UserID = UserID;
            OpenChildForm(examTaken);
        }

        private void iconBtnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            Setting setting = new Setting();
            setting.UserID = UserID;
            OpenChildForm(setting);
        }

        private void iconBtnSignOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void ptBoxHome_Click(object sender, EventArgs e)
        {
            Reset();
            
        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(128, 128, 255);
            lblTitleChildForm.Text = "Home";
            currentChildForm.Close();
            examAdmin = ExamAdministratorManager.GetByID(UserID);
            lblWelcom.Text = "Welcome, " + "\n" + "\n" + examAdmin.FirstName.ToString() +
                " " + examAdmin.LastName.ToString();
        }

     

        ////Drag Form
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();

        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112,0xf012, 0);
        //}

    }
}
