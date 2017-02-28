using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasharAlhafni_Assignment2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            Swapper swaper = new Swapper();
            Student student1 = new Student();
            student1.FirstName = txt_s1FirstName.Text;
            student1.LastName = txt_s1LastName.Text;
            student1.ID = txt_s1ID.Text;

            Student student2 = new Student();
            student2.FirstName = txt_s2FirstName.Text;
            student2.LastName = txt_s2LastName.Text;
            student2.ID = txt_s2ID.Text;

            swaper.SwapStudents(ref student1, ref student2);

            String msg = "First Student" + "\n First Name: " + student1.FirstName + "\n Last Name: " + student1.LastName +
                "\n ID: " + student1.ID + "\nSecond Student: " + "\n First Name: " + student2.FirstName + "\n Last Name: " + student2.LastName + "\n ID: " + student2.ID;

            MessageBox.Show(msg);

        }
    }
}
