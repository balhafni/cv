using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapack;
using System.Drawing;

namespace Image_Transformation
{
    class Transformation
    {

        public Transformation()
        {

        }
        double a;
        public double A
        {
            set { a = value; }
            get { return a; }
        }
        double b;
        public double B
        {
            set { b = value; }
            get { return b; }
        }
        double t1;
        public double T1
        {
            set { t1 = value; }
            get { return t1; }
        }
        double t2;
        public double T2
        {
            set { t2 = value; }
            get { return t2; }
        }
        public static void DisplayShape(List<Point> Shp, Pen pen, Graphics g)
        {
            Point? prevPoint = null; // nullable
            foreach (Point pt in Shp)
            {
                g.DrawEllipse(pen, new Rectangle(pt.X - 2, pt.Y - 2, 4, 4));
                if (prevPoint != null)
                    g.DrawLine(pen, (Point)prevPoint, pt);
                prevPoint = pt;
            }
            g.DrawLine(pen, Shp[0], Shp[Shp.Count - 1]);
        }

        public Matrix ConstructMatrix_A(List<Point> shape2)
        {
            
            Matrix mat_A = new Matrix(4, 4);
            Matrix A = new Matrix(4, 4);
            for (int i = 0; i < shape2.Count; i++)
            {
                A[0, 0] = (2 * Math.Pow(shape2[i].X, 2) + 2 * Math.Pow(shape2[i].Y, 2));
                A[0, 1] = 0;
                A[0, 2] = (2 * shape2[i].X);
                A[0, 3] = (2 * shape2[i].Y);
                A[1, 0] = 0;
                A[1, 1] = (2 * Math.Pow(shape2[i].X, 2) + 2 * Math.Pow(shape2[i].Y, 2));
                A[1, 2] = (2 * shape2[i].Y);
                A[1, 3] = (-2 * shape2[i].X);
                A[2, 0] = (2 * shape2[i].X);
                A[2, 1] = (2 * shape2[i].Y);
                A[2, 2] = 2;
                A[2, 3] = 0;
                A[3, 0] = (2 * shape2[i].Y);
                A[3, 1] = (-2 * shape2[i].X);
                A[3, 2] = 0;
                A[3, 3] = 2;
                //Matrix temp = new Matrix(A);

                mat_A = mat_A + A;
            }
            return mat_A;
        }
      
        public Matrix ConstructMatrix_B(List<Point> shape1, List<Point> shape2)
        {
            Matrix temp = new Matrix(4, 1);
            Matrix B = new Matrix(4, 1);
            for (int i = 0; i < shape1.Count; i++)
            {
                temp[0, 0] = ((2 * shape1[i].X * shape2[i].X) + (2 * shape1[i].Y * shape2[i].Y));
                temp[1, 0] = ((2 * shape1[i].X * shape2[i].Y) - (2 * shape1[i].Y * shape2[i].X));
                temp[2, 0] = (2 * shape1[i].X);
                temp[3, 0] = (2 * shape1[i].Y);
                B = B + temp;

            }

            return B;
        }

       
        public Matrix FindTransformation(List<Point> shape1, List<Point> shape2)
        {
            Matrix A = ConstructMatrix_A(shape2);
            Matrix B = ConstructMatrix_B(shape1, shape2);
            Matrix A_inverse = A.Inverse;
            Matrix U = A_inverse * B;
            return U;
        }


        public List<Point> ApplyTransformation(Transformation T, List<Point> shape1)
        {
           
            Matrix rotation_matrix = new Matrix(2,2);
            
            rotation_matrix[0,0] = A;
            rotation_matrix[0,1] = B;
            rotation_matrix[1,0] = -B;
            rotation_matrix[1,1] = A;
           

            List<Point> new_shape = new List<Point>();
            Matrix old_points = new Matrix(2,1);
            Matrix translation_matix = new Matrix(2,1);
            translation_matix[0,0] = T1;
            translation_matix[1,0] = T2;
            
            for (int i = 0; i < shape1.Count; i++)
            {
                old_points[0,0] = shape1[i].X;
                old_points[1,0] = shape1[i].Y;
               
                Matrix temp = rotation_matrix * old_points;
                Matrix res = temp + translation_matix;
                new_shape.Add(new Point((int)res[0, 0], (int)res[1, 0]));
            }
            return new_shape;
        }

        public double error(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
        public List<Point> RandomizeList(List<Point> list, int size)
        {
            Random rand = new Random();
            List<Point> randomized_list = new List<Point>();
            for(int i = 0; i < size; i++)
            {
                int index = rand.Next(0, list.Count);
                randomized_list.Add(list[index]);
            }
            return randomized_list;
        }
        //CompareShapes get the sum of all minimum distances for each point in shape1
        public double CompareShapes(List<Point> shape1, List<Point> shape2)
        {
            double total_error = 0;
            double minimum_error = 0;//same value as best error
            foreach (Point p1 in shape1)
            {
                minimum_error = 1000000;
                foreach (Point p2 in shape2) {
                    if(minimum_error > error(p1, p2))
                    {
                        minimum_error = error(p1, p2);
                    }
                }
                total_error += minimum_error;
            }
            return total_error;
        }

        public List<Point> PreservingOrder(List<Point> data, List<Point> model)
        {
            List<Point> final_shape = new List<Point>(model.Count);
            foreach(Point p1 in data)
            {
                if (model.Contains(p1))
                {

                    final_shape.Add(p1);
                }
            }
            return final_shape;
        }
        public List<Point> Ransac(List<Point> data, List<Point> model)
        {
            int k = 1000;
            int d = 3; //thershold for number of points in data
            int t = 50; //the distatnce treshold between two points
            int n = 3; //the minimum number of data that required to fit in the model
            double best_error = 1000000;
            double current_error = 0;
            int iterations = 0;
            List<Point> consensus_set = new List<Point>();
            List<Point> best_model = new List<Point>();
            List<Point> best_consensus_set = new List<Point>();
            List<Point> maybe_inliers = new List<Point>();
            List<Point> maybe_model = new List<Point>();
            List<Point> better_model = new List<Point>();
            // List<Point> best_model = new List<Point>();
            Random rand = new Random();

            while(iterations < k)
            {
                maybe_inliers = data.OrderBy(x => rand.Next()).Take(n).ToList();
                maybe_model = model;
                consensus_set = maybe_inliers;
                foreach(Point point in data)
                {
                    if (!maybe_inliers.Contains(point))
                    {
                        foreach(Point maybe_point in maybe_model)
                        {
                            if (error(point, maybe_point) < t)
                                consensus_set.Add(point);
                        }
                    }
                }
                if(consensus_set.Count > d)
                {
                    better_model = consensus_set;
                    current_error = CompareShapes(better_model, maybe_model);
                    if (current_error < best_error)
                    {

                        best_model = better_model;
                        best_consensus_set = consensus_set;
                        best_error = current_error;
                    }

                }
                iterations++;

            }
           best_model = PreservingOrder(data, best_model);
            return best_model;
        }

    }
}
