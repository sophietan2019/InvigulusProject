using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var email = txbEmail.Text;
            var admin = ExamAdministratorManager.GetByEmail(email);
            if (admin != null)
            {
                MessageBox.Show("Successfully loged in");
                Home home = new Home();
                home.UserID = admin.ExaminerID;
                home.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Please enter Correct Email Address!");
                txbEmail.Clear();

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    } 
}
