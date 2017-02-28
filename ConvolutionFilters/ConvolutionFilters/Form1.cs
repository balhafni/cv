using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvolutionFilters
{
    public partial class Form1 : Form
    {
        TextBox[,] matrixGrid = new TextBox[3, 3];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixGrid[i, j] = new TextBox();
                    matrixGrid[i, j].Size = new Size(35, 50);
                    tableLayoutPanel.Controls.Add(matrixGrid[i, j]);
                }

            }
        }
    }
}