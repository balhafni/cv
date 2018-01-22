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
namespace PCA
{
    public partial class Form1 : Form
    {
        List<Matrix> vectors;
        List<Bitmap> images;
        Bitmap choosenImage;
        List<Matrix> meanAdjustableMatrix;
        Matrix covarianceMatrix;
        Matrix eigenVectors;
        Matrix eigenFaces;
        List<Matrix> coefficients;
        string choosenImageName;
        string matchedImageName;
        PCA pca = new PCA();
        public Form1()
        {
            InitializeComponent();
        }



        private void read_btn_Click(object sender, EventArgs e)
        {
            images = pca.readImages();
            vectors = pca.convertImagesToVectors(images);
            meanAdjustableMatrix = pca.GetMeanAdjustedMatrix(vectors);
            covarianceMatrix = pca.GetCovarianceMatrix(meanAdjustableMatrix);
            eigenVectors = pca.GetEigenVectorsMatrix(covarianceMatrix);
            eigenFaces = pca.GetEigenFacesMatrix(meanAdjustableMatrix, eigenVectors);
            coefficients = pca.GetCoefficients(meanAdjustableMatrix, eigenFaces);
            MessageBox.Show("Finished training...");
        }

        private void matchImage_Btn_Click(object sender, EventArgs e)
        {

            int matchPosition = pca.MatchImage(choosenImage, vectors, eigenFaces, coefficients);
            matchedImagePicBox.Image = images[matchPosition];

            //MessageBox.Show("The mean Adjustable Matrix is  " + meanAdjustableMatrix[0].Rows + " By " + meanAdjustableMatrix.Count);
            //MessageBox.Show("The covariance matrix is " + covarianceMatrix.Rows + " By " + covarianceMatrix.Columns);
            //MessageBox.Show("The eigen vectors matrix is " + eigenVectors.Rows + " By " + eigenVectors.Columns);
            //MessageBox.Show("The eigen faces matrix is " + eigenFaces.Rows + " By " + eigenFaces.Columns);
            //MessageBox.Show(coefficients.Count + " coefficients were found and each has " + coefficients[0].Columns + " numbers");

            //MessageBox.Show("The matched image is " + pca.getPaths()[matchPosition]);
            //MessageBox.Show("The loaded image is " + choosenImageName);
            if(pca.getPaths()[matchPosition] == choosenImageName)
            {
                MessageBox.Show("Correct Match");
            }
            else
            {
                MessageBox.Show("False Match");
            }

        }

        private void loadImage_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "c:\\users";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    choosenImage = new Bitmap(fileDialog.FileName);

                    if (fileDialog.FileName.Contains("\\S"))
                    {
                        choosenImageName = "S"+fileDialog.FileName[fileDialog.FileName.IndexOf("\\S")+2];
                        if(fileDialog.FileName[fileDialog.FileName.IndexOf("\\S") + 3]!='_')
                        {
                            choosenImageName = choosenImageName + fileDialog.FileName[fileDialog.FileName.IndexOf("\\S") + 3];
                        }
                    }
                    choosenPicBox.Image = choosenImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
