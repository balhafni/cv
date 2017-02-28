using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAssignment_Part1
{
    public partial class GradesCalculator : Form
    {
        public GradesCalculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnComputeGrade_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (isEmptyTextBox())
            {
                msg = "Please make sure that all the fields are provided";
            }
            else
            {
                Student student = new Student();
                student.FirstName = textFirstName.Text;
                student.LastName = textLastName.Text;
                student.Id = textID.Text;
                student.Test1 = double.Parse(textTest1.Text);
                student.Test2 = double.Parse(textTest2.Text);
                msg = "First Name: " + student.FirstName + "\nLast Name: " + student.LastName + "\nID: " + student.Id + "\nGrade: " + student.computeGrade();
                if (!student.correct())
                {
                    msg = "Please enter reasonable grades!";
                }
            }
            MessageBox.Show(msg);
        }


        public bool isEmptyTextBox()
        {
            if (string.IsNullOrWhiteSpace(textFirstName.Text) || string.IsNullOrWhiteSpace(textLastName.Text) || string.IsNullOrWhiteSpace(textID.Text) ||
                string.IsNullOrWhiteSpace(textTest1.Text) || string.IsNullOrWhiteSpace(textTest2.Text))
            {
                return true;
            }
            return false;
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTest1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTest1_KeyPress(object sender, KeyPressEventArgs e) // allowing the user only to input numbers for grades
        {
            char c = e.KeyChar;
            if (c == 46 & textTest1.Text.IndexOf('.') != -1) // checking if the user's input has a decimal point
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46) 
            {
                e.Handled = true;
            }
        }

        private void textTest2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 46 & textTest1.Text.IndexOf('.') != -1)
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
