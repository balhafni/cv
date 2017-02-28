using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapack;
namespace Test
{
    class Program
    {

        static int[,] fourGrid = new int[4, 4];


        static double[][] fixedArray1 = new double[4][];
        static Matrix fixed1, fixed2, coefficient, c1, c2;
        static double[][] check1, check2;
        static double[,] largerImage;
        static Random rand = new Random();
        static void Main(string[] args)
        {


            int[,] image = new int[8, 8];
            image[0, 0] = 52; image[0, 1] = 55; image[0, 2] = 61;
            image[0, 3] = 66; image[0, 4] = 70; image[0, 5] = 61;
            image[0, 6] = 66; image[0, 7] = 70; image[1, 0] = 62; image[1, 1] = 60;
            image[1, 2] = 54; image[1, 3] = 90; image[1, 4] = 108; image[1, 5] = 85;
            image[1, 6] = 67; image[1, 7] = 71; image[2, 0] = 63; image[2, 1] = 65;
            image[2, 2] = 66; image[2, 3] = 110; image[2, 4] = 140; image[2, 5] = 104;
            image[2, 6] = 63; image[2, 7] = 72; image[3, 0] = 64; image[3, 1] = 70;
            image[3, 2] = 70; image[3, 3] = 120; image[3, 4] = 152; image[3, 5] = 106;
            image[3, 6] = 71; image[3, 7] = 69; image[4, 0] = 67; image[4, 1] = 75; image[4, 2] = 68;
            image[4, 3] = 106; image[4, 4] = 124; image[4, 5] = 88; image[4, 6] = 68; image[4, 7] = 68;
            image[5, 0] = 68; image[5, 1] = 80; image[5, 2] = 60; image[5, 3] = 72; image[5, 4] = 77;
            image[5, 5] = 66; image[5, 6] = 58; image[5, 7] = 75;
            image[6, 0] = 69; image[6, 1] = 85; image[6, 2] = 64; image[6, 3] = 58; image[6, 4] = 55; image[6, 5] = 62;
            image[6, 6] = 65; image[6, 7] = 83; image[7, 0] = 70;
            image[7, 1] = 90; image[7, 2] = 69; image[7, 3] = 68; image[7, 4] = 65;
            image[7, 5] = 72; image[7, 6] = 78; image[7, 7] = 90;
            //InitFixed();
            //int a = 1;
            //for (int i = 0; i < image.GetLength(0); i++)
            //{
            //   for (int j = 0; j < image.GetLength(1); j++)
            //{
            //        image[i, j] = rand.Next(1, 255); ;

            //    }
            //}
        
            SortedDictionary<int, int> freq_dic = new SortedDictionary<int, int>();
            SortedDictionary<int, int> cdf_dic = new SortedDictionary<int, int>();
            SortedDictionary<int, int> equalized_dic = new SortedDictionary<int, int>();
            for (int i = 0; i < 255; i++)
            {
                freq_dic.Add(i, 0);
                cdf_dic.Add(i, 0);
                equalized_dic.Add(i, 0);
            }
            int[] cdf = new int[256];
            int[] equalized = new int[256];
            int min = 0;
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {

                    freq_dic[image[i, j]]++;

                }

            }
            printArray(image);
            Console.WriteLine("");

            

            //deleting elements with values of zeros

            List<int> keysToRemove = freq_dic.Where(pair => pair.Value == 0)
                  .Select(pair => pair.Key).ToList<int>();
            foreach (int key in keysToRemove)
            {
                freq_dic.Remove(key);
            }
            // var min_pixel = freq_dic.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            int prev_key = 0;
            foreach (KeyValuePair<int, int> pair in freq_dic)
            {


                if (pair.Key == freq_dic.First().Key)
                {
                    cdf_dic[pair.Key] = freq_dic[pair.Key];

                }
                else
                {

                    cdf_dic[pair.Key] = freq_dic[pair.Key] + cdf_dic[prev_key];

                }
                prev_key = pair.Key;
            }


            //deleting elements with values of zeros

            List<int> keysToRemove_cdf = cdf_dic.Where(pair => pair.Value == 0)
                  .Select(pair => pair.Key).ToList<int>();
            foreach (int key in keysToRemove_cdf)
            {
                cdf_dic.Remove(key);
            }

            //equalizing the pixels
            min = cdf_dic.First().Value;
            foreach(KeyValuePair<int,int> pair in cdf_dic)
            {
                double top = pair.Value - min;
                double bottom = (image.GetLength(0) * image.GetLength(1)) - 1;
                double res = (top / bottom) * 255;
                equalized_dic[pair.Key] = (int)Math.Floor(res);
            }
    
            foreach (KeyValuePair<int,int> pair in cdf_dic)
            {
                Console.WriteLine("Pixel: " + pair.Key +" Was Repeated : "+freq_dic[pair.Key]+" CDF: " + pair.Value+ " Equalized: "+equalized_dic[pair.Key]);
            }
           //int gridCount = 0;

            //int row_index = 0;
            //int col_index = 0;
            //int new_row = 0;
            //int new_col = 0;
            //bool start_new_row = false;
            //bool sec_iteration_new_row = false;
            //int[,] doubled_image = new int[600, 600];
            //while (row_index + fourGrid.GetLength(0) <= image.GetLength(0))
            //{
            //    while (col_index + fourGrid.GetLength(1) <= image.GetLength(1))
            //    {
            //        for (int i = 0; i < fourGrid.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < fourGrid.GetLength(1); j++)
            //            {
            //                fourGrid[i, j] = image[i + row_index, j + col_index];
            //            }
            //        }
            //        gridCount++;
            //        Console.WriteLine("Grid " + gridCount + " :");
            //        printArray(fourGrid);
            //        Console.WriteLine("");
            //        double[][] complex = constrCoeffMatrix(fourGrid);
            //        Matrix comp = new Matrix(complex);
            //        coefficient = Matrix.Multiply(fixed1, comp);
            //        coefficient = Matrix.Multiply(coefficient, fixed2);

            //        Console.WriteLine("Fixed 1:\n " + fixed1.ToString());
            //        Console.WriteLine("Complex : \n" + comp.ToString());
            //        Console.WriteLine("Fixed 2: \n" + fixed2.ToString());//;                       coefficient.ToString());
            //        Console.WriteLine("Coefficients:\n " + coefficient.ToString());
            //        if (new_row >= 39 || new_col >= 39)
            //        {
            //            break;
            //        }
            //        if (sec_iteration_new_row && start_new_row)
            //        {

            //            doubled_image[new_row, new_col] = (int)Math.Ceiling(FindPoints(0.5, 0.5, coefficient));
            //            doubled_image[new_row + 1, new_col] = (int)Math.Ceiling(FindPoints(0.5, 1, coefficient));
            //            doubled_image[new_row, new_col + 1] = (int)Math.Ceiling(FindPoints(1, 0.5, coefficient));
            //            doubled_image[new_row + 1, new_col + 1] = fourGrid[2, 2];
            //            new_col += 2;

            //        }
            //        else if ((new_row == 0 && new_col == 0) || start_new_row)
            //        {
            //            if (start_new_row)
            //            {
            //                doubled_image[new_row, new_col] = (int)Math.Ceiling(FindPoints(0, 0.5, coefficient));
            //                doubled_image[new_row + 1, new_col] = fourGrid[2, 1];
            //                doubled_image[new_row, new_col + 1] = (int)Math.Ceiling(FindPoints(0.5, 0.5, coefficient));
            //                doubled_image[new_row + 1, new_col + 1] = (int)Math.Ceiling(FindPoints(0.5, 1, coefficient));
            //                doubled_image[new_row, new_col + 2] = (int)Math.Ceiling(FindPoints(1, 0.5, coefficient));
            //                doubled_image[new_row + 1, new_col + 2] = fourGrid[2, 2];
            //                new_col += 3;
            //                sec_iteration_new_row = true;
            //            }
            //            else
            //            {
            //                doubled_image[new_row, new_col] = fourGrid[1, 1];
            //                doubled_image[new_row + 1, new_col] = (int)Math.Ceiling(FindPoints(0, 0.5, coefficient));
            //                doubled_image[new_row + 2, new_col] = fourGrid[2, 1];
            //                doubled_image[new_row, new_col + 1] = (int)Math.Ceiling(FindPoints(0.5, 0, coefficient));
            //                doubled_image[new_row + 1, new_col + 1] = (int)Math.Ceiling(FindPoints(0.5, 0.5, coefficient));
            //                doubled_image[new_row + 2, new_col + 1] = (int)Math.Ceiling(FindPoints(0.5, 1, coefficient));
            //                doubled_image[new_row, new_col + 2] = fourGrid[1, 2];
            //                doubled_image[new_row + 1, new_col + 2] = (int)Math.Ceiling(FindPoints(1, 0.5, coefficient));
            //                doubled_image[new_row + 2, new_col + 2] = fourGrid[2, 2];
            //                new_col += 3;
            //            }

            //            start_new_row = false;
            //        }
            //        else
            //        {
            //            doubled_image[new_row, new_col] = (int)Math.Ceiling(FindPoints(0.5, 0, coefficient));
            //            doubled_image[new_row + 1, new_col] = (int)Math.Ceiling(FindPoints(0.5, 0.5, coefficient));
            //            doubled_image[new_row + 2, new_col] = (int)Math.Ceiling(FindPoints(0.5, 1, coefficient));
            //            doubled_image[new_row, new_col + 1] = fourGrid[1, 2];
            //            doubled_image[new_row + 1, new_col + 1] = (int)Math.Ceiling(FindPoints(1, 0.5, coefficient));
            //            doubled_image[new_row + 2, new_col + 1] = fourGrid[2, 2];
            //            new_col += 2;
            //        }

            //        col_index++;

            //    }
            //    row_index++;
            //    if (start_new_row)
            //    {
            //        new_row += 2;
            //    }
            //    else
            //    {
            //        new_row += 3;
            //    }

            //    start_new_row = true;
            //    sec_iteration_new_row = false;
            //    col_index = 0;
            //    new_col = 0;
            //}


            //printArray(doubled_image);





        }
        public static void InitFixed()
        {

            fixedArray1[0] = new double[] { 1, 0, 0, 0 };
            fixedArray1[1] = new double[] { 0, 0, 1, 0 };
            fixedArray1[2] = new double[] { -3, 3, -2, -1 };
            fixedArray1[3] = new double[] { 2, -2, 1, 1 };



            fixed1 = new Matrix(fixedArray1);
            fixed2 = fixed1.Transpose();
            coefficient = new Matrix(4, 4);
            largerImage = new double[18, 16];





        }


        static void printArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }


        static double[][] constrCoeffMatrix(int[,] grid)
        {
            double[][] complex = new double[4][];
            for (int i = 0; i < 4; i++)
            {
                complex[i] = new double[4];
            }
            complex[0][0] = grid[1, 1]; //f(0,0)
            complex[0][1] = grid[2, 1]; //f(0,1)
            complex[1][0] = grid[1, 2]; //f(1,0)
            complex[1][1] = grid[2, 2];//f(1,1)
            complex[2][0] = (grid[1, 2] - grid[1, 0]) / 2; //fx(0,0)
            complex[3][0] = (grid[1, 3] - grid[1, 1]) / 2; //fx(1,0)
            complex[2][1] = (grid[2, 2] - grid[2, 0]) / 2; //fx(0,1)
            complex[3][1] = (grid[2, 3] - grid[2, 1]) / 2; //fx(1,1)
            complex[0][2] = (grid[0, 1] - grid[2, 1]) / 2; //fy(0,0)
            complex[1][2] = (grid[0, 2] - grid[2, 2]) / 2; //fy(1,0)
            complex[0][3] = (grid[1, 1] - grid[3, 1]) / 2; //fy(0,1)
            complex[1][3] = (grid[1, 2] - grid[3, 2]) / 2; //fy(1,1)
            complex[2][2] = (grid[0, 2] - grid[0, 0] - grid[2, 2] + grid[2, 0]) / 4; //fxy(0,0)
            complex[2][3] = (grid[0, 3] - grid[0, 1] - grid[2, 3] + grid[2, 1]) / 4; // fxy(0,1)
            complex[3][2] = (grid[1, 3] - grid[1, 0] - grid[3, 2] + grid[3, 0]) / 4; //fxy(1,0)
            complex[3][3] = (grid[1, 3] - grid[1, 1] - grid[3, 3] + grid[3, 1]) / 4; //fxy(1,1)

            return complex;
        }

        public static double FindPoints(double x, double y, Matrix coef)
        {

            double p = 0;
            double[][] xArray = new double[1][];
            for (int i = 0; i < xArray.Length; i++)
            {
                xArray[i] = new double[4];
            }
            xArray[0][0] = 1;
            xArray[0][1] = x;
            xArray[0][2] = Math.Pow(x, 2);
            xArray[0][3] = Math.Pow(x, 3);

            double[][] yArray = new double[4][];
            for (int i = 0; i < yArray.Length; i++)
            {
                yArray[i] = new double[1];
            }
            yArray[0][0] = 1;
            yArray[1][0] = y;
            yArray[2][0] = Math.Pow(y, 2);
            yArray[3][0] = Math.Pow(y, 3);


            Matrix xMatrix = new Matrix(xArray);
            Matrix yMatrix = new Matrix(yArray);

            Matrix res = Matrix.Multiply(xMatrix, coef);
            res = Matrix.Multiply(res, yMatrix);
            p = res.Determinant;
            return p;
        }

        public static void costructDoubledImage(Matrix complex)
        {

        }
    }
}