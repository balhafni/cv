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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void std_btn_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            form.Show();
        }

        private void emp_btn_Click(object sender, EventArgs e)
        {
            EmpsForm form = new EmpsForm();
            form.Show();
        }
    }
}
