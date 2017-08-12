using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBP
{
    public partial class Form1 : Form
    {
        Bitmap choosenImage;
        LPB obj = new LPB();
        List<Bitmap> allImages;
        List<string> testingImagesPaths;
        List<Bitmap> testingImages;
        public Form1()
        {
            InitializeComponent();
        }


        private void trainImages_Click(object sender, EventArgs e)
        {
            obj.trainImages();
            allImages = obj.GetAllImages();
            MessageBox.Show("Done training..");
        }

        private void findMatch_btn_Click(object sender, EventArgs e)
        {
            //getting the binary patterns of the unknown image
            int matchedPos = FindMatch(choosenImage);
            matchedImageBox.Image = allImages[matchedPos];
        }
        public int FindMatch(Bitmap choosenImage)
        {
            Dictionary<string, int> unknownImage = obj.GetImageBinaryPatterns(choosenImage);
            Console.WriteLine("We have " + unknownImage.Count + " Unknown Patterns");
            foreach (KeyValuePair<string, int> pattern in unknownImage)
            {
                Console.WriteLine(pattern.Key + " was repeated " + pattern.Value + " times");
            }
            //finding the matched image using L2 norm
            //finding the minimum L2 norm
            List<Dictionary<string, int>> allHistograms = obj.GetHistogramsOfImages();
            int minDistance = (int)EuclideanDistance(unknownImage, allHistograms[0]);
            int matchedPos = 0;
            for (int i = 0; i < allHistograms.Count; i++)
            {
                int distance = (int)EuclideanDistance(unknownImage, allHistograms[i]);
                if (minDistance > distance)
                {
                    minDistance = distance;
                    matchedPos = i;
                }
            }
            return matchedPos;
        }
        private void loadPic_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "c:\\users";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    choosenImage = new Bitmap(fileDialog.FileName);
                    picBox.Image = choosenImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public double EuclideanDistance(Dictionary<string, int> unknownImage, Dictionary<string, int> knownImage)
        {
            double eculideanDistance = 0;
            foreach (string key in unknownImage.Keys)
            {
                eculideanDistance = eculideanDistance + Math.Pow(unknownImage[key] - knownImage[key], 2);
            }
            eculideanDistance = Math.Sqrt(eculideanDistance);
            return eculideanDistance;
        }

        private void accuracyBtn_Click(object sender, EventArgs e)
        {
            testingImagesPaths = new List<string>();
            testingImages = new List<Bitmap>();
            for (int i = 1; i < 41; i++)
            {
                for (int j = 6; j < 11; j++)
                {
                    String path = "c:\\users\\bashar.alhafni\\desktop\\ATTFaceDataSet\\Testing\\S" + i + "_" + j;
                    Bitmap image = new Bitmap(path + ".jpg");
                    testingImagesPaths.Add("S" + i);
                    testingImages.Add(image);
                }
            }
            double correctMatches = 0;
            for (int i = 0; i < testingImages.Count; i++)
            {
                int pos = FindMatch(testingImages[i]);
                if (testingImagesPaths[i] == obj.getPaths()[pos])
                {
                    correctMatches++;
                }
            }
            MessageBox.Show("The Accuracy is " + correctMatches / testingImages.Count + "%");
        }
    }
}


