using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelder_Mead
{
    class ImageRegistration
    {
        // Computes normalized image histogram (pdf) of the grayscale image
        // assumes the image has been converted to a 2-D array of pixel intensity values
        public static double[] GetImagePDF(int[,] img)
        {
            int xMax = img.GetLength(0);
            int yMax = img.GetLength(1);
            double[] nonNormalizedPDF = new double[256]; //ranges 0 to 255
            for (int x = 0; x < xMax; x++)
            {
                for (int y = 0; y < yMax; y++)
                {
                    int tempValue = img[x, y];
                    nonNormalizedPDF[tempValue]++;
                }
            }
            double normalizationFactor = xMax * yMax;
            for (int g = 0; g < 256; g++)
            {
                nonNormalizedPDF[g] = nonNormalizedPDF[g] / normalizationFactor;
            }
            return nonNormalizedPDF;
        }

        // f1 contains A,B,C,D,T1 and T2 values for a vertex
        public static double[,] GetJointPDF(int[,] aImgInt, int[,] bImgInt, FeatureVector f1)
        {
            double[,] jPDF = new double[256, 256];
            int xMax = aImgInt.GetLength(0);
            int yMax = aImgInt.GetLength(1);
            for (int x = 0; x < xMax; x++)
            {
                for (int y = 0; y < yMax; y++)
                {
                    double xPrimeC = f1.A * x + f1.B * y + f1.T1;
                    double yPrimeC = f1.C * x + f1.D * y + f1.T2;
                    int xPrime = (int)xPrimeC;
                    int yPrime = (int)yPrimeC;
                    if (((xPrime) < xMax) && ((xPrime) >= 0) && ((yPrime) < yMax) &&
                   ((yPrime) >= 0))
                    {
                        jPDF[aImgInt[x, y], bImgInt[xPrime, yPrime]] =
                       jPDF[aImgInt[x, y], bImgInt[xPrime, yPrime]] + 1;
                    }
                }
            }
            double factor = 1.0 / (xMax * yMax);
            for (int a = 0; a < 256; a++)
            {
                for (int b = 0; b < 256; b++)
                {
                    jPDF[a, b] = factor * jPDF[a, b];
                }
            }
            return jPDF;
        }

        public static double computeMI(double[] aPDF, double[] bPDF, double[,] jPDF)
        {
            double currentMI = 0;
            for (int a = 0; a < 256; a++)
            {
                for (int b = 0; b < 256; b++)
                {
                    if ((aPDF[a] != 0) && (bPDF[b] != 0) && (jPDF[a, b] != 0))
                    {
                        currentMI = currentMI + jPDF[a, b] * Math.Log(jPDF[a, b] /
                       (aPDF[a] * bPDF[b]));
                    }
                }
            }
            return currentMI;
        }

        public static int[,] convertToGrayScale(Bitmap bmp)
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
        public static List<FeatureVector> nelderMead(Bitmap bmp1, Bitmap bmp2)
        {
            int max_iterations = 100;
            int[,] image1_grayScaled = convertToGrayScale(bmp1);
            int[,] image2_grayScaled = convertToGrayScale(bmp2);

            double[] image1_pdf = GetImagePDF(image1_grayScaled);
            double[] image2_pdf = GetImagePDF(image2_grayScaled);

            //random simplex vertices
            List<FeatureVector> simplex_vertices = new List<FeatureVector>();
            //should the starting points be completely randomized?
            simplex_vertices.Add(new FeatureVector(0, 5, -5, 0, 0, 0));
            simplex_vertices.Add(new FeatureVector(0, 5, -5, 0, -15, -15));
            simplex_vertices.Add(new FeatureVector(0, 5, -5, 0, 15, 15));
            simplex_vertices.Add(new FeatureVector(5, 0, 0, 5, -15, -15));
            simplex_vertices.Add(new FeatureVector(5, 0, 0, 5, 15, 15));
       

            for (int i = 0; i < max_iterations; i++)
            {
                //computing mutual information for all the points from 0 to n+1
                foreach (FeatureVector vector in simplex_vertices)
                {
                    vector.MI = computeMI(image1_pdf, image2_pdf, GetJointPDF(image1_grayScaled, image2_grayScaled, vector));
                    Console.WriteLine(vector.MI);

                }
                //sorting the vectors according to their MI values
                simplex_vertices = simplex_vertices.OrderBy(o => o.MI).ToList();

                FeatureVector B = simplex_vertices[0];
                FeatureVector A = simplex_vertices[3];
                FeatureVector W = simplex_vertices[4];

                //computing the centroid C of vertices without considering W
                double CA = 0, CB = 0, CD = 0, CC = 0, CT1 = 0, CT2 = 0;
                for (int j = 0; j < simplex_vertices.Count - 1; j++) //count - 1 because we are not considering W
                {
                    CA += simplex_vertices[j].A;
                    CB += simplex_vertices[j].B;
                    CC += simplex_vertices[j].C;
                    CD += simplex_vertices[j].D;
                    CT1 += simplex_vertices[j].T1;
                    CT2 += simplex_vertices[j].T2;
                }
                CA = CA / 4; CB = CB / 4; CC = CC / 4; CD = CD / 4; CT1 = CT1 / 4; CT2 = CT2 / 4;
                FeatureVector C = new FeatureVector(CA, CB, CC, CD, CT1, CT2);

                //try reflection
                FeatureVector R = new FeatureVector(C.A + (C.A - W.A), C.B + (C.B - W.B), C.C + (C.C - W.C), C.D + (C.D - W.D), C.T1 + (C.T1 - W.T1), C.T2 + (C.T2 - W.T2));
                R.MI = computeMI(image1_pdf, image2_pdf, GetJointPDF(image1_grayScaled, image2_grayScaled, R));
                if (R.MI < A.MI && R.MI > B.MI) //f(R) < f(A) && f(R) > f(B)
                {
                    //replace W with R and continue with the next iteration
                    int index = simplex_vertices.IndexOf(W);
                    simplex_vertices[index] = R;
                    continue;
                }
                //try expansion
                if (R.MI < B.MI) //f(R) < f(B)
                {
                    FeatureVector E = new FeatureVector(C.A + 2 * (C.A - W.A), C.B + 2 * (C.B - W.B), C.C + 2 * (C.C - W.C), C.D + 2 * (C.D - W.D), C.T1 + 2 * (C.T1 - W.T1), C.T2 + 2 * (C.T2 - W.T2));
                    E.MI = computeMI(image1_pdf, image2_pdf, GetJointPDF(image1_grayScaled, image2_grayScaled, E));
                    if (E.MI < R.MI) //f(E) < f(R)
                    {
                        //replace W with E and continue to the next iteration
                        int index = simplex_vertices.IndexOf(W);
                        simplex_vertices[index] = E;
                        continue;
                    }
                    else
                    {
                        //replace W with R and continue to the next iteration
                        int index = simplex_vertices.IndexOf(W);
                        simplex_vertices[index] = R;
                        continue;
                    }
                }
                else if (R.MI < A.MI) //f(R) < f(A)
                {
                    //replace W with R and continue to the next iteration
                    int index = simplex_vertices.IndexOf(W);
                    simplex_vertices[index] = R;
                    continue;
                }
                else if (R.MI < W.MI)// f(R) < f(W)
                {
                    //compute contraction
                    FeatureVector contraction = new FeatureVector(C.A + (C.A - W.A) / 2, C.B + (C.B - W.B) / 2, C.C + (C.C - W.C) / 2, C.D + (C.D - W.D) / 2, C.T1 + (C.T1 - W.T1) / 2, C.T2 + (C.T2 - W.T2) / 2);
                    contraction.MI = computeMI(image1_pdf, image2_pdf, GetJointPDF(image1_grayScaled, image2_grayScaled, contraction));
                    if (contraction.MI < A.MI)//f(contraction) < f(A_
                    {
                        //replace W with contraction and continue to the next iteration
                        int index = simplex_vertices.IndexOf(W);
                        simplex_vertices[index] = contraction;
                        continue;
                    }
                    else
                    {
                        //do contraction of the entire simplex
                        foreach (FeatureVector vector in simplex_vertices)
                        {
                            //do not include best point
                            if (!vector.Equals(B))
                            {
                                vector.A = B.A + (vector.A - B.A) / 2;
                                vector.B = B.B + (vector.B - B.B) / 2;
                                vector.C = B.C + (vector.C - B.C) / 2;
                                vector.D = B.D + (vector.D - B.D) / 2;
                                vector.T1 = B.T1 + (vector.T1 - B.T1) / 2;
                                vector.T2 = B.T2 + (vector.T2 - B.T2) / 2;
                            }
                        }
                    }
                }
                else //reflected points does not improve things, contract the entire simplex
                {
                    foreach (FeatureVector vector in simplex_vertices)
                    {
                        //do not include best point
                        if (!vector.Equals(B))
                        {
                            vector.A = B.A + (vector.A - B.A) / 2;
                            vector.B = B.B + (vector.B - B.B) / 2;
                            vector.C = B.C + (vector.C - B.C) / 2;
                            vector.D = B.D + (vector.D - B.D) / 2;
                            vector.T1 = B.T1 + (vector.T1 - B.T1) / 2;
                            vector.T2 = B.T2 + (vector.T2 - B.T2) / 2;
                        }
                    }
                }
            }
            foreach(FeatureVector vector in simplex_vertices)
            {
                vector.MI = computeMI(image1_pdf, image2_pdf, GetJointPDF(image1_grayScaled, image2_grayScaled, vector));
            }
            return simplex_vertices;
        }

    }
}
