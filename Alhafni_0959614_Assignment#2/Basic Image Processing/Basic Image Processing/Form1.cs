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
    public partial class Form1 : Form
    {

        Bitmap mainImage;
        public Form1()
        {
            InitializeComponent();

        }

        private void loadImage_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "c:\\users";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    mainImage = new Bitmap(fileDialog.FileName);
                    orgPicBox.Image = mainImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void grayImg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(orgPicBox.Image);
                modifiedPicBox.Image = ImageProcessor.ConvertToGray(bmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void brightImg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(orgPicBox.Image);
                modifiedPicBox.Image = ImageProcessor.Brighten(bmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void contrastImg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(orgPicBox.Image);

                modifiedPicBox.Image = ImageProcessor.Contrast(bmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveImg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sdialog = new SaveFileDialog();
                sdialog.InitialDirectory = "c:\\users";
                sdialog.Filter = "jpeg|*.jpg";
                if (sdialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(modifiedPicBox.Image);
                    bmp.Save(sdialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void convoluteBtn_Click(object sender, EventArgs e)
        {
            ConvolutionForm form = new ConvolutionForm();
            form.setPicBox(mainImage);
            form.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
