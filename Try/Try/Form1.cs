using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            MyInit();
        }

        private void SayGreetings(object sender, EventArgs e)
        {
            
            MessageBox.Show("HI!!");
           
        }
        private void SayBye(object sender, EventArgs e)
        {
            MessageBox.Show("ADIOS!!!");
        }
        public T[] DoSomething<T>(int size)
              where T : new()
        {
            T[] Array = new T[size];

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = new T();
            }
            return Array;
        }
    }
}
