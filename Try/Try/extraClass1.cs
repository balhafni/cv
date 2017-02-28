using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    partial  class Form1
    {
        public void MyInit()
        {
            button1.Click += new System.EventHandler(SayGreetings);
            
        }
    }
}
