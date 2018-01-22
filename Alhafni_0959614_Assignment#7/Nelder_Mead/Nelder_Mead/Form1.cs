using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nelder_Mead
{
    public partial class Form1 : Form
    {
        Bitmap referenceImage, transformedImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void transformedImg_loadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "c:\\users";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    transformedImage = new Bitmap(fileDialog.FileName);
                    transformedImg_PicBox.Image = transformedImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void registerationBtn_Click(object sender, EventArgs e)
        {
            List<FeatureVector> vectors = ImageRegistration.nelderMead(referenceImage, transformedImage);
            //getting the vector with the Minimum MI
            vectors = vectors.OrderBy(o => o.MI).ToList();
            FeatureVector transformation = vectors[0];
            //applying the transformation
            Graphics dc = Graphics.FromImage(transformedImage);
            dc.TranslateTransform(-(float)transformation.T1, -(float)transformation.T2);
            dc.RotateTransform(-(float)Math.Acos(transformation.A));
            dc.DrawImage(transformedImage, new Rectangle(0, 0, transformedImage.Width, transformedImage.Height));
            transformedImg_PicBox.Image = transformedImage;
            MessageBox.Show("Done processing...");


        }

        private void referenceImage_loadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "c:\\users";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    referenceImage = new Bitmap(fileDialog.FileName);
                    referenceImg_picBox.Image = referenceImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
