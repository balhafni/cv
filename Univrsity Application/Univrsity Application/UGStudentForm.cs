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
    public partial class UGStudentForm : Form
    {
        public UGStudentForm()
        {
            InitializeComponent();
        }

        private void UGStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void cmptGrade_btn_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (isEmptyTextBox())
            {
                msg = "Please make sure that all the fields are provided";
            }
            else
            {
                UGStudent student = new UGStudent(fname_txt.Text, lname_txt.Text, id_txt.Text, phone_txt.Text, strt_txt.Text, city_txt.Text,
                  Double.Parse(test1_txt.Text), Double.Parse(test2_txt.Text));
                if (!student.CheckGrade())
                {
                    msg = "Please input reasonable Grades!!";
                }else if (!student.CheckTelephone())
                {
                    msg = "Please input 10 digits for the phone number!";
                }
                else
                {
                    msg = student.ToString();
                }
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

        private void test1_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 46 & test1_txt.Text.IndexOf('.') != -1) // checking if the user's input has a decimal point
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void test2_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 46 & test2_txt.Text.IndexOf('.') != -1) // checking if the user's input has a decimal point
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void phone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
