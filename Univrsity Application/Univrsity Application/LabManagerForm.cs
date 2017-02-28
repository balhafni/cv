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
    public partial class LabManagerForm : Form
    {
        public LabManagerForm()
        {
            InitializeComponent();
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
                LabManager labManager = new LabManager(fname_txt.Text, lname_txt.Text, empID_txt.Text, dpt_txt.Text,
                               strt_txt.Text, city_txt.Text, phone_txt.Text);
                if (!labManager.CheckTelephone())
                {
                    msg = "Please input 10 digits phone number!";
                }
                else
                    msg = labManager.ToString();
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

        private void phone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }


}
