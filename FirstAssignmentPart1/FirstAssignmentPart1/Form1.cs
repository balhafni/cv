using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAssignmentPart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FirstName = textFirstName.Text;
            student.LastName = textLastName.Text;
            student.Id = int.Parse(textID.Text);
            student.Test1 = int.Parse(textTest1.Text);
            student.Test2 = int.Parse(textTest2.Text);

            string msg = "First Name: " + student.FirstName+"\nLast Name: "+student.LastName+"\nID: "+student.Id +"\nGrade: "+student.ComputeGrade();

            MessageBox.Show(msg);
        }
    }
}
