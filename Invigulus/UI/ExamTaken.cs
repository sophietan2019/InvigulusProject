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
    public partial class ExamTaken : Form
    {
        public int UserID { get; set; }
        DAL.ExamAdministrator examiner= new DAL.ExamAdministrator();
         DAL.ExamTaken examTaken = new DAL.ExamTaken();
        public ExamTaken()
        {
            InitializeComponent();
        }


        private void ExamTaken_Load(object sender, EventArgs e)
        {

            var exams = ExamManager.GetExamID(UserID);
            cmbExamID.DataSource = exams;
            
           
            
        }

        private void cmbExamID_SelectedValueChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cmbExamID.SelectedValue);
            var examtakens = ExamTakenManager.GetSelected(id);
            dgvExamTaken.DataSource = examtakens;
            dgvExamTaken.Refresh();


        }


    }
}
