using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Univrsity_Application
{
    public partial class EmpsForm : Form
    {
        public EmpsForm()
        {
            InitializeComponent();
        }

        private void fullTimeFaculty_btn_Click(object sender, EventArgs e)
        {
            FullFacultyForm form = new FullFacultyForm();
            form.Show();
        }

        private void PartTime_Faculty_Click(object sender, EventArgs e)
        {
            PartTimeFacultyForm form = new PartTimeFacultyForm();
            form.Show();
        }

        private void Secretary_btn_Click(object sender, EventArgs e)
        {
            SecretaryForm form = new SecretaryForm();
            form.Show();
        }

        private void LabMgr_btn_Click(object sender, EventArgs e)
        {
            LabManagerForm form = new LabManagerForm();
            form.Show();

        }
    }
}
