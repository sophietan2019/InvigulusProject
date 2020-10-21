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
    public partial class Setting : Form
    {
        public int UserID { get; set; }
        ExamAdministrator examiner = new ExamAdministrator();
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            examiner = ExamAdministratorManager.GetByID(UserID);
            txbFirstName.Text = examiner.FirstName.ToString();
            txbLastName.Text = examiner.LastName.ToString();
            txbEmail.Text = examiner.ExaminerEmail.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                examiner.FirstName = txbFirstName.Text;
                examiner.LastName = txbLastName.Text;
                examiner.ExaminerEmail = txbEmail.Text;

                ExamAdministratorManager.Update(examiner);



                MessageBox.Show("Update Successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error when updating: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbFirstName.Text = examiner.FirstName.ToString();
            txbLastName.Text = examiner.LastName.ToString();
            txbEmail.Text = examiner.ExaminerEmail.ToString();
        }
    }
}
