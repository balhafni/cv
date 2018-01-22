using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Image_Processing
{
    public partial class ConvolutionForm : Form

    {
        TextBox[,] kernelInput;
        double[][] kernel;
        public ConvolutionForm()
        {
            InitializeComponent();
            kernelInput = new TextBox[3, 3];
            kernel = new double[3][];
            for (int i = 0; i < 3; i++)
            {
                kernel[i] = new double[3];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    kernelInput[i, j] = new TextBox();
                    kernelInput[i, j].Size = new Size(35, 25);
                    tableLayoutPanel1.Controls.Add(kernelInput[i, j]);
                }
            }
        }

        private void convoluteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //converting strings to double
                bool isNumber = false;
                double res = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        isNumber = double.TryParse(kernelInput[i, j].Text.ToString(), out res);
                        if (isNumber)
                        {
                            kernel[i][j] = double.Parse(kernelInput[i, j].Text.ToString());
                        }

                    }
                }
                Bitmap bmp = new Bitmap(orgPicBox.Image);
                Bitmap bmpOrig = (Bitmap)bmp.Clone();

                ImageProcessor.Convolve(bmp, kernel);
                orgPicBox.Image = bmpOrig;
                modifiedPicBox.Image = bmp;
                MessageBox.Show("done..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConvolutionForm_Load(object sender, EventArgs e)
        {

        }
        public PictureBox getBox()
        {
            return orgPicBox;
        }
        public void setPicBox(Bitmap bmp)
        {
            orgPicBox.Image = bmp;
        }
        
    }
}
