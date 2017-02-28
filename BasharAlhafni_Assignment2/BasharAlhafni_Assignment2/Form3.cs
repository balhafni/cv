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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            Swapper swaper = new Swapper();
           string s1 = text_firstString.Text;
           string s2 = text_secondString.Text;

            swaper.SwapStrings(ref s1, ref s2);
            string msg = "First String: " + s1 + "\n Second String: " + s2;
            MessageBox.Show(msg);
        }
    }
}
