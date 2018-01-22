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
        public Form1()
        {
            InitializeComponent();
        }

        private void loadImage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\users";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(fileDialog.FileName);
                orgPicBox.Image = bmp;
            }
        }

        private void grayImg_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(orgPicBox.Image);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color cp = bmp.GetPixel(i, j);
                    int grayVal = (int)(0.299 * cp.R + 0.587 * cp.G + 0.114 * cp.B);
                    bmp.SetPixel(i, j, Color.FromArgb(grayVal, grayVal, grayVal));
                }
            }
            modifiedPicBox.Image = bmp;
        }

        private void brightImg_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(orgPicBox.Image);
            int brightness = 30; //increase the brightness
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color cp = bmp.GetPixel(i, j);
                    int newRed = cp.R + brightness;
                    if (newRed > 255)
                        newRed = 255;
                    if (newRed < 0)
                        newRed = 0;
                    int newB = cp.B + brightness;
                    if (newB > 255)
                        newB = 255;
                    if (newB < 0)
                        newB = 0;
                    int newG = cp.G + brightness;
                    if (newG > 255)
                        newG = 255;
                    if (newG < 0)
                        newG = 0;
                    bmp.SetPixel(i, j, Color.FromArgb(newRed, newG, newB));
                }
            }
            modifiedPicBox.Image = bmp;
        }

        private void contrastImg_btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(orgPicBox.Image);
            int T = 20;
            double c = ((100 + T) / 100.0) * ((100 + T) / 100.0); //calculated contrast
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color cp = bmp.GetPixel(i, j);
                    int B = (int)(((((cp.B / 255.0) - 0.5) * c) + 0.5) * 255.0);                    int G = (int)(((((cp.G / 255.0) - 0.5) * c) + 0.5) * 255.0);                    int R = (int)(((((cp.R / 255.0) - 0.5) * c) + 0.5) * 255.0);                    if (B > 255)                        B = 255;                    if (B < 0)                        B = 0;                    if (G > 255)                        G = 255;                    if (G < 0)                        G = 0;                    if (R > 255)                        R = 255;                    if (R < 0)                        R = 0;

                    bmp.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            modifiedPicBox.Image = bmp;
        }

        private void saveImg_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdialog = new SaveFileDialog();
            sdialog.InitialDirectory = "c:\\users";
            sdialog.Filter = "jpeg|*.jpg";
            if(sdialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(modifiedPicBox.Image);
                bmp.Save(sdialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
