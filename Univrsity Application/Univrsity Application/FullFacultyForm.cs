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
    public partial class FullFacultyForm : Form
    {
        public FullFacultyForm()
        {
            InitializeComponent();
            cb_menu.DataSource = Enum.GetNames(typeof(Rank));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                FullTimeFaculty fullTimeFaculty = new FullTimeFaculty(fname_txt.Text, lname_txt.Text, empID_txt.Text, dpt_txt.Text,
                                cb_menu.Text, strt_txt.Text, city_txt.Text, phone_txt.Text);
                if (!fullTimeFaculty.CheckTelephone())
                {
       
                    msg = "Please input 10 digits for the phone number!";
                }
                else
                    msg = fullTimeFaculty.ToString();
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
