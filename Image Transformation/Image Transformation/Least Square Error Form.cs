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

namespace Image_Transformation
{
    public partial class Least_Square_Error_Form : Form
    {
        List<Point> Shape1 = new List<Point>();
        List<Point> Shape2 = new List<Point>();
        public Least_Square_Error_Form()
        {
            InitializeComponent();
        }

        private void init_btn_Click(object sender, EventArgs e)
        {
            Shape1.Clear();
            Shape2.Clear();
            Point p1a = new Point(20, 30);
            Point p2a = new Point(120, 50);
            Point p3a = new Point(160, 80);
            Point p4a = new Point(180, 300);
            Point p5a = new Point(100, 220);
            Point p6a = new Point(50, 280);
            Point p7a = new Point(20, 140);
            Shape1.Add(p1a);
            Shape1.Add(p2a);
            Shape1.Add(p3a);
            Shape1.Add(p4a);
            Shape1.Add(p5a);
            Shape1.Add(p6a);
            Shape1.Add(p7a);


            Transformation T2 = new Transformation();
            T2.A = 1.05; T2.B = 0.05; T2.T1 = 15; T2.T2 = 22;
            Shape2 = T2.ApplyTransformation(T2, Shape1);
            Shape2[2] = new Point(Shape2[2].X + 10, Shape2[2].Y + 3);// change one point
            Pen pBlue = new Pen(Brushes.Blue, 1);
            Pen pRed = new Pen(Brushes.Red, 1);
            Graphics g = panel_shape1.CreateGraphics();
            Transformation.DisplayShape(Shape1, pBlue, g);
            Transformation.DisplayShape(Shape2, pRed, g);
        }


        private void transformation_btn_Click(object sender, EventArgs e)
        {
            Transformation T = new Transformation();
            Matrix align = T.FindTransformation(Shape1, Shape2);
            T.A = align[0, 0]; T.B = align[1, 0]; T.T1 = align[2, 0]; T.T2 = align[3, 0];
            Shape2 = T.ApplyTransformation(T, Shape2);
            Pen pBlue = new Pen(Brushes.Blue, 1);
            Pen pRed = new Pen(Brushes.Red, 1);
            Graphics g = alignment_panel.CreateGraphics();
            Transformation.DisplayShape(Shape1, pBlue, g);
            Transformation.DisplayShape(Shape2, pRed, g);
        }
    }
}
