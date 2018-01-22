using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.IO;
using Mapack;

namespace Basic_Image_Processing
{
    class BicubicInterpolator
    {
        int[,] red, green, blue;

        int[,] doubled_red, doubled_green, doubled_blue;
        int[,] fourGrid = new int[4, 4];
        
        
        double[][] fixedArray = new double[4][]; // double because the MaPack.Matrix() takes only double 2d array
        Random rand = new Random();


        Mapack.Matrix fixed1, fixed2, coefficient;

        public BicubicInterpolator()
        {
            fixedArray[0] = new double[] { 1, 0, 0, 0 };
            fixedArray[1] = new double[] { 0, 0, 1, 0 };
            fixedArray[2] = new double[] { -3, 3, -2, -1 };
            fixedArray[3] = new double[] { 2, -2, 1, 1 };
            fixed1 = new Mapack.Matrix(fixedArray);
            fixed2 = fixed1.Transpose();

            coefficient = new Mapack.Matrix(4, 4);

        }
        public Bitmap BitmapTo2DArrays(Bitmap bmp)
        {

            red = new int[bmp.Width, bmp.Height];
            doubled_red = new int[2 * bmp.Width, 2 * bmp.Height];
            green = new int[bmp.Width, bmp.Height];
            doubled_green = new int[2 * bmp.Width, 2 * bmp.Height];
            blue = new int[bmp.Width, bmp.Height];
            doubled_blue = new int[2 * bmp.Width, 2 * bmp.Height];



            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    red[i, j] = pixel.R;
                    green[i, j] = pixel.G;
                    blue[i, j] = pixel.B;

                }
            }
            //setting the interpolated pixel arrays
            
            doubled_red = constructFourByFour(red);
            doubled_green = constructFourByFour(green);
            doubled_blue = constructFourByFour(blue);
            Bitmap final_image = new Bitmap(2 * bmp.Width, 2 * bmp.Height);
            for (int i = 0; i < final_image.Width; i++)
            {
                for (int j = 0; j < final_image.Height; j++)
                {
                    final_image.SetPixel(i, j, Color.FromArgb(doubled_red[i,j], doubled_green[i, j], doubled_blue[i, j]));
                }
            }
            return final_image;

        }



        public int[,] constructFourByFour(int[,] pixelArray)
        {
            bool start_new_row = false;
            bool sec_iteration_new_row = false;
            int row_index = 0;
            int col_index = 0;
            int new_row = 0;
            int new_col = 0;
            int[,] doubled_image = new int[2 * pixelArray.GetLength(0), 2 * pixelArray.GetLength(1)]; ;

            while (row_index + fourGrid.GetLength(0) <= pixelArray.GetLength(0))
            {
                while (col_index + fourGrid.GetLength(1) <= pixelArray.GetLength(1))
                {
                    for (int i = 0; i < fourGrid.GetLength(0); i++)
                    {
                        for (int j = 0; j < fourGrid.GetLength(1); j++)
                        {
                            fourGrid[i, j] = pixelArray[i + row_index, j + col_index];
                        }
                    }
                    //gridCount++;
                    //Console.WriteLine("Grid " + gridCount + " :");
                    //printArray(fourGrid);
                    //Console.WriteLine("");
                    double[][] complex = constrComplexMatrix(fourGrid);
                    Mapack.Matrix comp = new Mapack.Matrix(complex);
                    coefficient = Mapack.Matrix.Multiply(fixed1, comp);
                    coefficient = Mapack.Matrix.Multiply(coefficient, fixed2);

                    // Console.WriteLine("Fixed 1:\n " + fixed1.ToString());
                    //Console.WriteLine("Complex : \n" + comp.ToString());
                    //Console.WriteLine("Fixed 2: \n" + fixed2.ToString());//;                       coefficient.ToString());
                    //Console.WriteLine("Coefficients:\n " + coefficient.ToString());
                    //if(new_row >= 39 || new_col >= 39){
                    //    break;
                    //}
                    if (sec_iteration_new_row && start_new_row)
                    {

                        doubled_image[new_row, new_col] = check_range((int)Math.Ceiling(FindPoints(0.5, 0.5, coefficient)));
                        doubled_image[new_row + 1, new_col] = check_range((int)Math.Ceiling(FindPoints(0.5, 1, coefficient)));
                        doubled_image[new_row, new_col + 1] = check_range ((int)Math.Ceiling(FindPoints(1, 0.5, coefficient)));
                        doubled_image[new_row + 1, new_col + 1] = fourGrid[2, 2];
                        new_col += 2;

                    }
                    else if ((new_row == 0 && new_col == 0) || start_new_row)
                    {
                        if (start_new_row)
                        {
                            doubled_image[new_row, new_col] = check_range((int)Math.Ceiling(FindPoints(0, 0.5, coefficient)));
                            doubled_image[new_row + 1, new_col] = fourGrid[2, 1];
                            doubled_image[new_row, new_col + 1] = check_range((int)Math.Ceiling(FindPoints(0.5, 0.5, coefficient)));
                            doubled_image[new_row + 1, new_col + 1] = check_range((int)Math.Ceiling(FindPoints(0.5, 1, coefficient)));
                            doubled_image[new_row, new_col + 2] = check_range((int)Math.Ceiling(FindPoints(1, 0.5, coefficient)));
                            doubled_image[new_row + 1, new_col + 2] = fourGrid[2, 2];
                            new_col += 3;
                            sec_iteration_new_row = true;
                        }
                        else
                        {
                            doubled_image[new_row, new_col] = fourGrid[1, 1];
                            doubled_image[new_row + 1, new_col] = check_range((int)Math.Ceiling(FindPoints(0, 0.5, coefficient)));
                            doubled_image[new_row + 2, new_col] = fourGrid[2, 1];
                            doubled_image[new_row, new_col + 1] = check_range((int)Math.Ceiling(FindPoints(0.5, 0, coefficient)));
                            doubled_image[new_row + 1, new_col + 1] = check_range((int)Math.Ceiling(FindPoints(0.5, 0.5, coefficient)));
                            doubled_image[new_row + 2, new_col + 1] = check_range((int)Math.Ceiling(FindPoints(0.5, 1, coefficient)));
                            doubled_image[new_row, new_col + 2] = fourGrid[1, 2];
                            doubled_image[new_row + 1, new_col + 2] = check_range((int)Math.Ceiling(FindPoints(1, 0.5, coefficient)));
                            doubled_image[new_row + 2, new_col + 2] = fourGrid[2, 2];
                            new_col += 3;
                        }

                        // start_new_row = false;
                    }
                    else
                    {
                        doubled_image[new_row, new_col] = check_range((int)Math.Ceiling(FindPoints(0.5, 0, coefficient)));
                        doubled_image[new_row + 1, new_col] = check_range((int)Math.Ceiling(FindPoints(0.5, 0.5, coefficient)));
                        doubled_image[new_row + 2, new_col] = check_range((int)Math.Ceiling(FindPoints(0.5, 1, coefficient)));
                        doubled_image[new_row, new_col + 1] = fourGrid[1, 2];
                        doubled_image[new_row + 1, new_col + 1] =check_range( (int)Math.Ceiling(FindPoints(1, 0.5, coefficient)));
                        doubled_image[new_row + 2, new_col + 1] = fourGrid[2, 2];
                        new_col += 2;
                    }

                    col_index++;

                }
                row_index++;
                if (start_new_row)
                {
                    new_row += 2;
                }
                else
                {
                    new_row += 3;
                }

                start_new_row = true;
                sec_iteration_new_row = false;
                col_index = 0;
                new_col = 0;
            }
            return doubled_image;
        }
        public int check_range(int pixel)
        {
            if (pixel >= 255)
            {
                pixel = 255;
            }
            else if (pixel < 0)
            {
                pixel = 0;
            }
            else
            {
                return pixel;
            }
            return pixel;
        }
        public double[][] constrComplexMatrix(int[,] grid)
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
        public double FindPoints(double x, double y, Mapack.Matrix coef)
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


            Mapack.Matrix xMatrix = new Mapack.Matrix(xArray);
            Mapack.Matrix yMatrix = new Mapack.Matrix(yArray);

            Mapack.Matrix res = Mapack.Matrix.Multiply(xMatrix, coef);
            res = Mapack.Matrix.Multiply(res, yMatrix);
            p = res.Determinant;
            return p;
        }


    }
}
