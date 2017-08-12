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
    public partial class Transformation_Form : Form
    {
        public Transformation_Form()
        {
            InitializeComponent();
        }
        public void setPicBox(Bitmap bmp)
        {
            orgPicBox.Image = bmp;
        }
        public void setModifiedPicBox(Bitmap bmp)
        {
            modifiedPicBox.Image = bmp;
        }

        private void transImg_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(orgPicBox.Image);
            modifiedPicBox.Image = RotateImage(bmp, -5, 20, 30);

        }
        public Bitmap RotateImage(Bitmap bmp, float angle, float x, float y)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.DrawImage(bmp, x, y); //translating the image 
                g.RotateTransform(angle); //rotate

            }

            return rotatedImage;
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
