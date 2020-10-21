using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;



namespace UI
{
    public partial class Exam : Form
    {
        public int UserID { get; set; }
        DAL.Exam aExam = new DAL.Exam();




        public void Clear(Control.ControlCollection controlCollection)  // define a method to clear all text boxes 
        {
            foreach (Control ctrl in controlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = string.Empty;
                }
                else
                {
                    Clear(ctrl.Controls);
                }
            }
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;

        }

        public void PopulateData(int id)
        {
            dgvExamData.DataSource = ExamManager.GetAllByExaminerID(id);
            dgvExamData.Refresh();
        }

        public Exam()
        {
            InitializeComponent();
        }

        private void ExamMaintain_Load(object sender, EventArgs e)
        {
            aExam.ExaminerID = UserID;
            PopulateData(aExam.ExaminerID);


        }




        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                aExam.ExamMaxDuration = TimeSpan.Parse(mtxbDurationT.Text);
                aExam.MaxAllowedAttemptsPerPerson = Convert.ToInt32(txbMaxAttemps.Text);
                aExam.ExamStartDate = Convert.ToDateTime(dtpStartDate.Text);
                aExam.ExamStartTime = TimeSpan.Parse(mtxbStrTime.Text);
                aExam.ExamEndDate = Convert.ToDateTime(dtpEndDate.Text);
                aExam.ExamEndTime = TimeSpan.Parse(mtxbEndTime.Text);


                if (txbExamID.Text == "")
                {
                    ExamManager.Add(aExam);
                }
                else
                {
                    aExam.ExamID = Convert.ToInt32(txbExamID.Text);
                    ExamManager.Update(aExam);
                }

                PopulateData(aExam.ExaminerID);
                Clear(this.Controls);
                MessageBox.Show("Submit Successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error when adding the exam data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?",
                "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var id = Convert.ToInt32(txbExamID.Text);
                    ExamManager.Delete(id);
                    PopulateData(aExam.ExaminerID);
                    Clear(this.Controls);
                    MessageBox.Show("Delete Successfully!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when deleting the exam data: " + ex.Message,
                        ex.GetType().ToString());
                    //this.DialogResult = DialogResult.Retry;
                }
            }
        }







        private void txbMaxAttemps_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow number
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dgvExamData_DoubleClick(object sender, EventArgs e)
        {
            if (dgvExamData.CurrentRow.Index >= 0)
            {
                try
                {
                    var examid = Convert.ToInt32(dgvExamData.CurrentRow.Cells["ExamID"].Value);
                    var aExam = ExamManager.GetSelectedExam(examid);
                    mtxbDurationT.Text = aExam.ExamMaxDuration.ToString();
                    txbMaxAttemps.Text = aExam.MaxAllowedAttemptsPerPerson.ToString();
                    dtpStartDate.Text = aExam.ExamStartDate.ToString();
                    mtxbStrTime.Text = aExam.ExamStartTime.ToString();
                    dtpEndDate.Text = aExam.ExamEndDate.ToString();
                    mtxbEndTime.Text = aExam.ExamEndTime.ToString();
                    txbExamID.Text = aExam.ExamID.ToString();
                    btnSave.Text = "Update";
                    btnDelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error  " + ex.Message,
                        ex.GetType().ToString());
                    //this.DialogResult = DialogResult.Retry;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PopulateData(aExam.ExaminerID);
            Clear(this.Controls);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

          
        
    



