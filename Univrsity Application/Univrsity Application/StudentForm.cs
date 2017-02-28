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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void std_btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UGStudentForm form = new UGStudentForm();
            form.Show();
        }

        private void GStd_btn_Click(object sender, EventArgs e)
        {
            GStudentForm form = new  GStudentForm();
            form.Show();
        }

        private void PhD_Student_Click(object sender, EventArgs e)
        {
            PhDStudentForm form = new PhDStudentForm();
            form.Show();
        }

        private void partStd_btn_Click(object sender, EventArgs e)
        {
            PartTimeStudentForm form = new PartTimeStudentForm();
            form.Show();
        }
    }
}
