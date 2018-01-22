using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapack;
using System.Drawing;

namespace LBP
{
    public class LPB
    {

        List<Dictionary<string, int>> allHistograms = new List<Dictionary<string, int>>();
        List<Bitmap> allImages = new List<Bitmap>();

        public void trainImages()
        {
            for (int i = 1; i < 41; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    String path = "c:\\users\\bashar.alhafni\\desktop\\ATTFaceDataSet\\Training\\S" + i + "_" + j;
                    Bitmap image = new Bitmap(path + ".jpg");
                    allImages.Add(image);
                    allHistograms.Add(GetImageBinaryPatterns(image));
                }

            }
            Console.WriteLine(allHistograms.Count);
            
        }
        public List<Bitmap> GetAllImages()
        {
            return allImages;
        }
        public List<Dictionary<string, int>> GetHistogramsOfImages()
        {
            return allHistograms;
        }

        public Dictionary<string,int> GetImageBinaryPatterns(Bitmap image)
        {
            double[,] grayScaledImage = ConvertToGray(image);

            //dividing the image into 5x5 blocks

            double[,] block = new double[grayScaledImage.GetLength(0) / 5, grayScaledImage.GetLength(1) / 5];
            int row_index = 0;
            int col_index = 0;
            int block_num = 0;
            List<Dictionary<string, int>> blocks_histograms = new List<Dictionary<string, int>>();
            while (row_index + block.GetLength(0) <= grayScaledImage.GetLength(0))
            {
                while (col_index + block.GetLength(1) <= grayScaledImage.GetLength(1))
                {
                    for (int i = 0; i < block.GetLength(0); i++)
                    {
                        for (int j = 0; j < block.GetLength(1); j++)
                        {
                            block[i, j] = grayScaledImage[i + row_index, j + col_index];
                        }
                    }
                    //getting the unifrom binary pattern histogram for each block and adding it to a list of histograms
                    blocks_histograms.Add(GetBlockBinaryPatterns(block));
                    block_num++;

                    col_index += grayScaledImage.GetLength(1) / 5;
                }

                row_index += grayScaledImage.GetLength(0) / 5;
                col_index = 0;
            }
            //constructing one histogram for all the blocks
            Dictionary<string, int> imageHistogram = GetFinalBinaryPatterns(blocks_histograms);
            return imageHistogram;
        


        }
        public Dictionary<string, int> GetFinalBinaryPatterns(List<Dictionary<string, int>> blocks_histograms)
        {
            Dictionary<string, int> image_histogram = new Dictionary<string, int>();
            //putting the histogram for the blocks in one histogram that represents the image
            for (int i = 0; i < blocks_histograms.Count; i++)
            {
                foreach (KeyValuePair<string, int> histogram in blocks_histograms[i])
                {
                    if (!image_histogram.ContainsKey(histogram.Key))
                    {
                        image_histogram.Add(histogram.Key, 1);
                    }
                    else
                    {
                        image_histogram[histogram.Key]++;
                    }
                }
            }

            Console.WriteLine("We have " + image_histogram.Count + " Patterns");
            foreach (KeyValuePair<string, int> pattern in image_histogram)
            {
                Console.WriteLine(pattern.Key + " was repeated " + pattern.Value + " times");
            }

            return image_histogram;
        }
        public Dictionary<string, int> GetBlockBinaryPatterns(double[,] block)

        {
            int row_index = 0;
            int col_index = 0;

            //dividing the block into 3x3 grids
            double[][] threeBythree = new double[3][];

            Dictionary<string, int> uniformPatternHistogram = new Dictionary<string, int>();

            List<string> uniformPatterns_list = new List<string>();
            List<string> nonuniformPatterns_list = new List<string>();

            for (int i = 0; i < threeBythree.GetLength(0); i++)
            {
                threeBythree[i] = new double[3];
            }
            while (row_index + threeBythree.GetLength(0) <= block.GetLength(0))
            {
                while (col_index + threeBythree[0].Length <= block.GetLength(1))
                {

                    for (int i = 0; i < threeBythree.GetLength(0); i++)
                    {
                        for (int j = 0; j < threeBythree[0].Length; j++)
                        {
                            threeBythree[i][j] = block[i + row_index, j + col_index];
                        }
                    }
                    col_index++;

                    //getting the unifrom pattern of the 3x3 grid

                    Matrix m = new Matrix(threeBythree);
                    String pattern = GetUniformPattern(m);

                    //if the pattern is uniform
                    if (IsUniform(pattern))
                    {
                        if (!uniformPatternHistogram.ContainsKey(pattern)) //if it's not in the histogram
                        {
                            uniformPatternHistogram.Add(pattern, 1); //add it to the histogram
                            uniformPatterns_list.Add(pattern); //add it to a list of uniform patterns
                        }
                        else //if the pattern is in the histogram
                        {
                            uniformPatternHistogram[pattern]++; //increment the occurence of the pattern
                        }

                    }
                    //if the pattern is not uniform and is not in the non-uniform patterns list
                    else if (!IsUniform(pattern) && !nonuniformPatterns_list.Contains(pattern))
                    {
                        nonuniformPatterns_list.Add(pattern);
                    }
                }
                row_index++;
                col_index = 0;
            }
            //getting the closest uniform patterns to the non-uniform patterns
            foreach (string nonUniformPattern in nonuniformPatterns_list)
            {
                int index = GetClosestUniformPattern(nonUniformPattern, uniformPatterns_list);
                //Console.WriteLine(nonUniformPattern + " was matched with " + uniformPatterns_list[index]);
                uniformPatternHistogram[uniformPatterns_list[index]]++;
            }
            //Console.WriteLine("We have " + uniformPatternHistogram.Count + " Patterns");
            //foreach (KeyValuePair<string, int> pattern in uniformPatternHistogram)
            //{
            //    Console.WriteLine(pattern.Key + " was repeated " + pattern.Value + " times");
            //}
            //adding the histogram to a list of histograms (those histograms represent one image)

            //putting all of these histograms into one histogram
            return uniformPatternHistogram;

        }

        public int GetHammingDistance(string pattern1, string pattern2)
        {
            int counter = 0;

            for (int i = 0; i < pattern1.Length; i++)
            {
                if (pattern1[i] != pattern2[i])
                    counter++;
            }

            return counter;

        }

        public int GetClosestUniformPattern(string nonUnifrom, List<string> uniformPatterns)
        {
            int minDistance = GetHammingDistance(nonUnifrom, uniformPatterns[0]);
            int location = 0;
            foreach (string uniformPattern in uniformPatterns)

            {
                int hammingDistance = GetHammingDistance(nonUnifrom, uniformPattern);
                if (hammingDistance < minDistance)
                {
                    minDistance = hammingDistance;
                    location = uniformPatterns.IndexOf(uniformPattern);
                }
            }
            return location;
        }
        public double[,] ConvertToGray(Bitmap bmp)
        {
            double[,] grayValues = new double[bmp.Width, bmp.Height];
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color cp = bmp.GetPixel(i, j);
                    int grayVal = (int)(0.299 * cp.R + 0.587 * cp.G + 0.114 * cp.B);
                    grayValues[i, j] = grayVal;

                }
            }
            return grayValues;
        }
        public bool IsUniform(string pattern)
        {
            int changes = 0;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (i != pattern.Length - 1)
                {
                    if (pattern[i] != pattern[i + 1])
                    {
                        changes++;
                    }
                }
            }
            if (pattern[0] != pattern[pattern.Length - 1])
                changes++;

            if (changes > 2)
            {
                return false;
            }
            return true;
        }

        public string GetUniformPattern(Matrix M)
        {
            string pattern = "";

            int m = M.Rows; // ending row index
            int n = M.Columns;  // ending column index
            int i = 0; //iterator
            int k = 0; // starting row index
            int l = 0;//starting column index

            double center_value = M[1, 1];
            while (k < m && l < n && (k != 1 && l != 1))
            {
                //going the first row from the remaining rows
                for (i = l; i < n; ++i)
                {
                    if (M[k, i] < center_value)
                    {
                        pattern = pattern + "0";
                    }
                    else if (M[k, i] >= center_value)
                    {
                        pattern = pattern + "1";
                    }
                }
                k++;

                //going to the last column from the remaining columns
                for (i = k; i < m; ++i)
                {
                    if (M[i, n - 1] < center_value)
                    {
                        pattern = pattern + "0";
                    }
                    else if (M[i, n - 1] >= center_value)
                    {
                        pattern = pattern + "1";
                    }

                }
                n--;

                //going to the last row from the remaining rows
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        if (M[m - 1, i] < center_value)
                        {
                            pattern = pattern + "0";
                        }
                        else if (M[m - 1, i] >= center_value)
                        {
                            pattern = pattern + "1";
                        }

                    }
                    m--;
                }

                //going to  the first column from the remaining columns
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        if (M[i, l] < center_value)
                        {
                            pattern = pattern + "0";
                        }
                        else if (M[i, l] >= center_value)
                        {
                            pattern = pattern + "1";
                        }

                    }
                    l++;
                }
            }
            return pattern;
        }
    }
}
