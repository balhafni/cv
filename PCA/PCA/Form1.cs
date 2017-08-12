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
using System.Threading;

namespace PCA
{
    public partial class Form1 : Form
    {
        List<Matrix> vectors;
        List<Bitmap> images, testImages;
        Bitmap choosenImage;
        List<Matrix> meanAdjustableMatrix;
        Matrix covarianceMatrix;
        Matrix eigenVectors;
        Matrix eigenFaces;
        List<Matrix> coefficients;
        string choosenImageName;
        string matchedImageName;
        PCA pca = new PCA();

        int i = 0;
        List<string> testImagesPaths = new List<string>();
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


            //loading the test images 

            testImages = new List<Bitmap>();
            for (int i = 1; i < 41; i++)
            {
                for (int j = 6; j < 11; j++)
                {
                    String path = "c:\\users\\bashar.alhafni\\desktop\\ATTFaceDataSet\\Testing\\S" + i + "_" + j;
                    testImagesPaths.Add("S" + i);
                    testImages.Add(new Bitmap(path + ".jpg"));

                }
            }

            MessageBox.Show("Finished training...");
        }

        private void matchImage_Btn_Click(object sender, EventArgs e)
        {

            //int matchPosition = pca.MatchImage(choosenImage, vectors, eigenFaces, coefficients);
            //matchedImagePicBox.Image = images[matchPosition];

            //MessageBox.Show("The mean Adjustable Matrix is  " + meanAdjustableMatrix[0].Rows + " By " + meanAdjustableMatrix.Count);
            //MessageBox.Show("The covariance matrix is " + covarianceMatrix.Rows + " By " + covarianceMatrix.Columns);
            //MessageBox.Show("The eigen vectors matrix is " + eigenVectors.Rows + " By " + eigenVectors.Columns);
            //MessageBox.Show("The eigen faces matrix is " + eigenFaces.Rows + " By " + eigenFaces.Columns);
            //MessageBox.Show(coefficients.Count + " coefficients were found and each has " + coefficients[0].Columns + " numbers");

            //MessageBox.Show("The matched image is " + pca.getPaths()[matchPosition]);
            //MessageBox.Show("The loaded image is " + choosenImageName);
            //if (pca.getPaths()[matchPosition] == choosenImageName)
            //{
            //    MessageBox.Show("Correct Match");
            //}
            //else
            //{
            //    MessageBox.Show("False Match");
            //}
           
            int correctImages = 0;
            // System.IO.StreamWriter file = new System.IO.StreamWriter("test.txt");

            choosenPicBox.Image = testImages[i];
            int matchPosition = pca.MatchImage(testImages[i], vectors, eigenFaces, coefficients);
            matchedImagePicBox.Image = images[matchPosition];



            i++;
        }

        private void accuracyBtn_Click(object sender, EventArgs e)
        {
            double correctMatches = 0;
            
           for(int i = 0; i < testImages.Count; i++)
            {
                int matchPosition = pca.MatchImage(testImages[i], vectors, eigenFaces, coefficients);
                if(pca.getPaths()[matchPosition] == testImagesPaths[i])
                {
                    correctMatches++;
                }
            }
            MessageBox.Show("The accuracy percentage is " + correctMatches / 200.0 + "%");
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
                        choosenImageName = "S" + fileDialog.FileName[fileDialog.FileName.IndexOf("\\S") + 2];
                        if (fileDialog.FileName[fileDialog.FileName.IndexOf("\\S") + 3] != '_')
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
