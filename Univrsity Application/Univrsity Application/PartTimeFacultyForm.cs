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
    public partial class PartTimeFacultyForm : Form
    {
        public PartTimeFacultyForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartTimeFacultyForm_Load(object sender, EventArgs e)
        {

        }

        private void display_btn_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (isEmptyTextBox())
            {
                msg = "Please make sure that all the fields are provided";
            }
            else
            {
                PartTimeFaculty faculty = new PartTimeFaculty(fname_txt.Text, lname_txt.Text, ssn_txt.Text, dpt_txt.Text,
                               strt_txt.Text, city_txt.Text, phone_txt.Text);
                if (!faculty.CheckTelephone())
                {
                    msg = "Please input 10 digits for phone number!";
                }
                else
                    msg = faculty.ToString();
            }

            MessageBox.Show(msg);
        }

        public bool isEmptyTextBox()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox box = (TextBox)control;
                    if (string.IsNullOrEmpty(box.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
