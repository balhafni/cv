using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_University_App_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudents form = new ViewStudents();
            form.ShowDialog();
        }

        private void viewStudentsGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentGrades form = new ViewStudentGrades();
            form.ShowDialog();

        }
    }
}
