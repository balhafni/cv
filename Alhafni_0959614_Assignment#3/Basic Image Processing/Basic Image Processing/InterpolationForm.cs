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
            using(var graphics = Graphics.FromImage(largerImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            }
            return largerImage;
        }
        private void interpolateBtn_Click(object sender, EventArgs e)
        {
            BicubicInterpolator interpolate = new BicubicInterpolator();
            Bitmap org = new Bitmap(orgPicBox.Image);

            //modifiedPicBox.Image = MakelargerImager(org, org.Size.Width * 2, org.Size.Height * 2);
            modifiedPicBox.Image = interpolate.BitmapTo2DArrays(org);
            //Bitmap result = new Bitmap(org.Width * 2, org.Height * 2);
            //using (Graphics g = Graphics.FromImage(result))
            //{
            //    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //    g.DrawImage(org, 0, 0, org.Width * 2, org.Height * 2);

            //}

            //modifiedPicBox.Image = result;

        }
    }
}
