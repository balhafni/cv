using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeProcessing
{
    public partial class AddStudent : Form
    {

        Student st = null;
        public AddStudent()
        {
            InitializeComponent();
            box_majors.DataSource = Enum.GetValues(typeof(Major));

        }
        public Student Student_Info
        {

            get
            {
                bool check = true;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        if (ctrl.Text == "")
                        {
                            MessageBox.Show("Please make sure that all the fields are provided!");
                            check = false;
                            break;
                        }
                    }
                }

                if (check)
                {
                    st = new Student();
                    st.Id = int.Parse(txt_id.Text);
                    st.FirstName = txt_fname.Text;
                    st.LastName = txt_lname.Text;
                    st.Test1 = double.Parse(txt_test1.Text);
                    st.Test2 = double.Parse(txt_test2.Text);
                    st.Student_Major = (Major)box_majors.SelectedItem;
                    foreach (RadioButton btn in groupBox.Controls)
                    {
                        if (btn.Checked)
                        {
                            st.Student_Level = (Level)Enum.Parse(typeof(Level), btn.Text, true);
                        }
                    }
                }
                return st;
            }
        }

        private void txt_test1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 46 & txt_test1.Text.IndexOf('.') != -1) // checking if the user's input has a decimal point
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_test2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 46 & txt_test2.Text.IndexOf('.') != -1) // checking if the user's input has a decimal point
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }
    }
}
