using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mapack;

namespace PCA
{
    public class PCA
    {

        Matrix EigenFacesMatrix;
        Matrix meanVector;
        List<string> trainingImagesPaths = new List<string>();

        public List<string> getPaths()
        {
            return trainingImagesPaths;
        }
        public List<Bitmap> readImages()
        {
            List<Bitmap> trainingImages = new List<Bitmap>();
            
            for (int i = 1; i < 41; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    String path = "c:\\users\\bashar.alhafni\\desktop\\ATTFaceDataSet\\Training\\S" + i + "_" + j;
                    trainingImagesPaths.Add("S"+i);
                    trainingImages.Add(new Bitmap(path + ".jpg"));
                }

            }
            return trainingImages;

        }
        public int[,] convertToGrayScale(Bitmap bmp)
        {
            int[,] gray_scaled_image = new int[bmp.Width, bmp.Height];
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color cp = bmp.GetPixel(i, j);
                    int grayVal = (int)(0.299 * cp.R + 0.587 * cp.G + 0.114 * cp.B);
                    gray_scaled_image[i, j] = grayVal;
                }
            }
            return gray_scaled_image;
        }

        public List<Matrix> convertImagesToVectors(List<Bitmap> images)
        {

            List<Matrix> vectors = new List<Matrix>();
            for (int i = 0; i < images.Count; i++)
            {


                //converting the image to gray scale 
                int[,] grayScaledImage = convertToGrayScale(images[i]);
                int rows = grayScaledImage.GetLength(0);
                int cols = grayScaledImage.GetLength(1);
                int vectorRows = rows * cols;
                Matrix vector = new Matrix(rows * cols, 1);
                //converting the gray scaled image to a vector
                for (int j = 0; j < grayScaledImage.GetLength(0); j++)
                {
                    for (int k = 0; k < grayScaledImage.GetLength(1); k++)
                    {
                        vector[j + k, 0] = grayScaledImage[j, k];
                    }
                }
                //adding the vector of each image to a list of vectors
                vectors.Add(vector);

            }


            return vectors;
        }
        public Matrix GetMeanVector(List<Matrix> vectors)
        {

            meanVector = new Matrix(vectors[0].Rows, 1);
            for (int i = 0; i < vectors.Count; i++)
            {
                meanVector = meanVector + vectors[i];
            }
            for (int i = 0; i < meanVector.Rows; i++)
            {
                meanVector[i, 0] = meanVector[i, 0] / 4;
            }
            return meanVector;
        }

        public List<Matrix> GetMeanAdjustedMatrix(List<Matrix> vectors)
        {


            //computing the mean vector
            Matrix meanVector = GetMeanVector(vectors);

            //computing the mean adjustable matrix
            List<Matrix> meanAdjustableMatrix = new List<Matrix>();
            for (int i = 0; i < vectors.Count; i++)
            {
                Matrix res = vectors[i] - meanVector;
                meanAdjustableMatrix.Add(res);
            }

            return meanAdjustableMatrix;
        }

        public Matrix GetCovarianceMatrix(List<Matrix> meanAdjustableMatrix)
        {
            Matrix covarianceMatrix = new Matrix(meanAdjustableMatrix.Count, meanAdjustableMatrix.Count); //200 x 200
            for (int i = 0; i < covarianceMatrix.Rows; i++)
            {
                for (int j = 0; j < covarianceMatrix.Columns; j++)
                {

                    covarianceMatrix[i, j] = DotProduct(meanAdjustableMatrix[i], meanAdjustableMatrix[j]);
                }
            }
            return covarianceMatrix;
        }

        public Matrix GetEigenVectorsMatrix(Matrix covarianceMatrix)
        {
            EigenvalueDecomposition obj = new EigenvalueDecomposition(covarianceMatrix);

            //getting the eigen values of the covariance matrix
            double[] eigenValues = obj.RealEigenvalues;

            double[] eigenValues_Magnitudes = new double[eigenValues.Length];

            //to save the positions of the eigenvalues
            Dictionary<int, double> lookup = new Dictionary<int, double>();

            for (int i = 0; i < eigenValues.Length; i++)
            {
                eigenValues_Magnitudes[i] = Math.Pow(eigenValues[i], 2);
                lookup.Add(i, eigenValues_Magnitudes[i]);
            }

            //sort eigen valuesby magnitude
            Array.Sort(eigenValues_Magnitudes);

            //getting the eigenvectors
            Matrix eigenVectors = obj.EigenvectorMatrix;

            //keeping the first 30 eigenvectors
            Matrix eigenVectors_Matrix = new Matrix(covarianceMatrix.Rows, 30);

            for (int j = 0; j < eigenVectors_Matrix.Columns; j++)
            {
                for (int i = 0; i < eigenVectors_Matrix.Rows; i++)
                {
                    eigenVectors_Matrix[i, j] = eigenVectors[i, lookup.FirstOrDefault(x => x.Value == eigenValues_Magnitudes[j]).Key];
                }
            }

            return eigenVectors_Matrix;
        }

        public Matrix GetEigenFacesMatrix(List<Matrix> meanAdjustableMatrix, Matrix eigenVectorsMatrix)
        {

            //convert the list to matrix 
            Matrix meanAdjustableMatrix_prime = new Matrix(meanAdjustableMatrix[0].Rows, meanAdjustableMatrix.Count);
            for (int i = 0; i < meanAdjustableMatrix.Count; i++)
            {
                for (int j = 0; j < meanAdjustableMatrix[i].Rows; j++)
                {
                    meanAdjustableMatrix_prime[j, i] = meanAdjustableMatrix[i][j, 0];
                }
            }
            EigenFacesMatrix = meanAdjustableMatrix_prime * eigenVectorsMatrix;

            return EigenFacesMatrix;
        }

        public List<Matrix> GetCoefficients(List<Matrix> meanAdjustableMatrix, Matrix EigenFacesMatrix)
        {
            List<Matrix> coefficientsList = new List<Matrix>();
            Matrix res = new Matrix(1, 30);

            for (int i = 0; i < meanAdjustableMatrix.Count; i++)    
            {
                res = meanAdjustableMatrix[i].Transpose() * EigenFacesMatrix;
                coefficientsList.Add(res);
            }
            return coefficientsList;
        }

        public Matrix GetVector(Matrix m, int column)
        {
            Matrix vector = new Matrix(m.Rows, 1);
            for (int i = 0; i < m.Rows; i++)
            {
                vector[i, 0] = m[i, column];
            }
            return vector;
        }
        public double DotProduct(Matrix A, Matrix B)
        {
            double res = 0;

            for (int i = 0; i < A.Rows; i++)
            {
                res = res + A[i, 0] * B[i, 0];
            }
            return res;
        }

        public int MatchImage(Bitmap unknownImage, List<Matrix> vectors, Matrix EigenFaces, List<Matrix> coefficients)
        {
            //converting the unknown image to a gray scale
            int[,] unknown_vector_gray_scaled = convertToGrayScale(unknownImage);

            //converting the unknown image to a vector
            Matrix unknwon_vector = new Matrix(unknown_vector_gray_scaled.GetLength(0) * unknown_vector_gray_scaled.GetLength(1), 1);
            for (int i = 0; i < unknown_vector_gray_scaled.GetLength(0); i++)
            {
                for (int j = 0; j < unknown_vector_gray_scaled.GetLength(1); j++)
                {
                    unknwon_vector[i + j, 0] = unknown_vector_gray_scaled[i, j];
                }
            }

            //subtracting the mean vector from the unknown image vector
            Matrix meanVector = GetMeanVector(vectors);
            Matrix unknown_image_prime = unknwon_vector - meanVector;

            //getting the coefficents of the unknown image
            Matrix coefficients_unknown = new Matrix(1, 30);
            coefficients_unknown = unknown_image_prime.Transpose() * EigenFaces;

            //getting the best match
            double minDistance = EuclideanDistance(coefficients_unknown, coefficients[0]);
            int matchedImagePosition = 0;
            for (int i = 1; i < coefficients.Count; i++)
            {
                double currentDistance = EuclideanDistance(coefficients_unknown, coefficients[i]);
                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                    matchedImagePosition = i;
                }
            }
            return matchedImagePosition;
        }
        public double EuclideanDistance(Matrix A, Matrix B)
        {
            double eculideanDistance = 0;

            for (int i = 0; i < A.Rows; i++)
            {
                eculideanDistance = eculideanDistance + Math.Pow(A[i, 0] - B[i, 0], 2);
            }
            eculideanDistance = Math.Sqrt(eculideanDistance);
            return eculideanDistance;
        }
    }
}
