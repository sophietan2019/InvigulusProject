using BLL;
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
    public partial class Examinee : Form
    {
        public Examinee()
        {
            InitializeComponent();
        }

        private void populateData()
        {
            var examinees = ExamineeManager.GetAll();
            dgvExaminee.DataSource = examinees;
            dgvExaminee.Refresh();
        }
        private void Examinee_Load(object sender, EventArgs e)
        {
            populateData();
        }
    }
}
