using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mapack;

namespace Image_Transformation
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void leastSquareError_btn_Click(object sender, EventArgs e)
        {
            Least_Square_Error_Form form = new Least_Square_Error_Form();
            form.ShowDialog();
        }

        private void ransac_btn_Click(object sender, EventArgs e)
        {
            RANSAC_Form form = new RANSAC_Form();
            form.ShowDialog();
        }
    }
}
