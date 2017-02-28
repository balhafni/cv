using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Basic_Image_Processing
{
    public partial class InterpolationForm : Form
    {
        public InterpolationForm()
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

        public Bitmap MakelargerImager(Bitmap bmp, int width, int height)
        {
            Bitmap largerImage = new Bitmap(bmp, width, height);
            using (var graphics = Graphics.FromImage(largerImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            }
            return largerImage;
        }
        private void interpolateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BicubicInterpolator interpolate = new BicubicInterpolator();
                Bitmap org = new Bitmap(orgPicBox.Image);


                modifiedPicBox.Image = interpolate.BitmapTo2DArrays(org);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
