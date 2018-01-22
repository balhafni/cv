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
    public partial class HistogramEqualisationFrom : Form
    {
        public HistogramEqualisationFrom()
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


        private void histoEqualBtn_Click(object sender, EventArgs e)
        {
            Bitmap org = new Bitmap(orgPicBox.Image);
            HistogramEqualizer equalizer = new HistogramEqualizer(org);
            ImageProcessor processor = new ImageProcessor();
            modifiedPicBox.Image = equalizer.EqualizedImage(org);
        }
    }
}
