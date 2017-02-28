using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAssignment_Part2
{
    public partial class Form1 : Form
    {
        Employee emp;
        public Form1()
        {
            InitializeComponent();
            emp = new Employee();
        }

        private void btnComputePay_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (isEmptyTextBox())
            {
                msg = "Please provide all the information";
            }
            else {
                emp.FirstName = textFirstName.Text;
                emp.LastName = textLastName.Text;
                emp.EmpId = textID.Text;
                emp.HoursWorked = double.Parse(textHrsWorked.Text);
                emp.PayRate = double.Parse(textPayRate.Text);
                msg = "First Name: " + emp.FirstName + "\nLast Name: " + emp.LastName + "\nID: " + emp.EmpId + "\nPay: " + emp.computePay() + "\nOvertime: " + emp.computeOvertimePay();
            }
            MessageBox.Show(msg);
        }

        public bool isEmptyTextBox()
        {
            if (string.IsNullOrWhiteSpace(textFirstName.Text) || string.IsNullOrWhiteSpace(textLastName.Text) || string.IsNullOrWhiteSpace(textID.Text) ||
                string.IsNullOrWhiteSpace(textHrsWorked.Text) || string.IsNullOrWhiteSpace(textPayRate.Text))
            {
                return true;
            }
            return false;
        }

        private void textHrsWorked_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPayRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textHrsWorked_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 46 & textHrsWorked.Text.IndexOf('.') != -1) // checking if the user's input has a decimal point
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void textPayRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 46 & textPayRate.Text.IndexOf('.') != -1) // checking if the user's input has a decimal point
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
