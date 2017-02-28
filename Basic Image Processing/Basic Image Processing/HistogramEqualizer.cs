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

namespace Basic_Image_Processing
{
    class HistogramEqualizer
    {
        int[,] redArray;
        int[,] greenArray;
        int[,] blueArray;
        int[,] grayValues;
        int max;
        public HistogramEqualizer(Bitmap bmp)
        {
            redArray = new int[bmp.Width, bmp.Height];
            greenArray = new int[bmp.Width, bmp.Height];
            blueArray = new int[bmp.Width, bmp.Height];
            grayValues = new int[bmp.Width, bmp.Height];
            max = 0;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    redArray[i, j] = bmp.GetPixel(i, j).R;
                    greenArray[i, j] = bmp.GetPixel(i, j).G;
                    blueArray[i, j] = bmp.GetPixel(i, j).B;
                    grayValues[i, j] = (int)(0.299 * bmp.GetPixel(i, j).R + 0.587 * bmp.GetPixel(i, j).G + 0.114 * bmp.GetPixel(i, j).B);
                    if (grayValues[i, j] > max)
                    {
                        max = grayValues[i, j];
                    }
                }
            }


        }
        public Bitmap EqualizedImage(Bitmap bmp)
        {
            Bitmap result = new Bitmap(bmp.Width, bmp.Height);
            
            int[] equalizedGray = BuildHistogramForImage(grayValues);
            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    result.SetPixel(i, j, Color.FromArgb(equalizedGray[grayValues[i, j]], equalizedGray[grayValues[i, j]], equalizedGray[grayValues[i, j]]));
                }
            }
            return result;
        }
        public int[] BuildHistogramForImage(int[,] pixelArray)
        {
            SortedDictionary<int, int> freq_dic = new SortedDictionary<int, int>();
            SortedDictionary<int, int> cdf_dic = new SortedDictionary<int, int>();
            SortedDictionary<int, int> equalized_dic = new SortedDictionary<int, int>();
            int[] equalized = new int[256];
            //initializing dictionaries
            for (int i = 0; i <= 255; i++)
            {
                freq_dic.Add(i, 0);
                cdf_dic.Add(i, 0);
                equalized_dic.Add(i, 0);
            }
            //counting pixels
            for (int i = 0; i < pixelArray.GetLength(0); i++)
            {
                for (int j = 0; j < pixelArray.GetLength(1); j++)
                {

                    freq_dic[pixelArray[i, j]]++;

                }

            }

            //deleting pixels that are not in the image
            List<int> keysToRemove = freq_dic.Where(pair => pair.Value == 0)
                  .Select(pair => pair.Key).ToList<int>();
            foreach (int key in keysToRemove)
            {
                freq_dic.Remove(key);
            }

            //building the cdf
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


            //deleting pixels that are not in the image
            List<int> keysToRemove_cdf = cdf_dic.Where(pair => pair.Value == 0)
                  .Select(pair => pair.Key).ToList<int>();
            foreach (int key in keysToRemove_cdf)
            {
                cdf_dic.Remove(key);
            }

            int min = cdf_dic.First().Value;
            foreach (KeyValuePair<int, int> pair in cdf_dic)
            {
                double top = pair.Value - min;
                double bottom = (pixelArray.GetLength(0) * pixelArray.GetLength(1)) - 1;
                double res = (top / bottom) * 255;
                equalized_dic[pair.Key] = (int)Math.Floor(res);

            }

            foreach (KeyValuePair<int, int> pair in equalized_dic)
            {
                equalized[pair.Key] = pair.Value;
            }
            return equalized;
        }
    }
}
