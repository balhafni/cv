using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasharAlhafni_Assignment2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            Swapper swap = new Swapper();
            double firstNumber = Double.Parse(text_firstDouble.Text);
            double secondNumber = Double.Parse(text_secondDouble.Text);
            swap.SwapDoubles(ref firstNumber, ref secondNumber);
            string msg = "First number: " + firstNumber + "\nSecond number: " + secondNumber;
            MessageBox.Show(msg);
        }

        private void btn_swap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void text_firstDouble_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 46 & text_firstDouble.Text.IndexOf('.') != -1) // checking if the user's input has a decimal point
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void text_secondDouble_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 46 & text_secondDouble.Text.IndexOf('.') != -1) // checking if the user's input has a decimal point
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

