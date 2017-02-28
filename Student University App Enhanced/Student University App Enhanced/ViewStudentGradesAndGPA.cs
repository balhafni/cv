using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_University_App_Enhanced.Models;
using Student_University_App_Enhanced.BusinessLayer;
using System.Data;

namespace Student_University_App_Enhanced
{
    public partial class ViewStudentGradesAndGPA : Form
    {
        IBusinessStudent _ibusinessStudent = null;
        public ViewStudentGradesAndGPA()
        {
            InitializeComponent();
            _ibusinessStudent = new Business() as IBusinessStudent;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            double GPA = 0.0;
            try
            {
                dt = _ibusinessStudent.GetGradesAndHrs(txtId.Text);
                if(dt.Rows.Count == 0)
                {
                    throw new Exception("Invalid id");  
                    
                }
                dataGrid.DataSource = dt;
                dataGrid.Refresh();
                GPA = _ibusinessStudent.CalculateGPA(dt);
                MessageBox.Show("The Student GPA is "+GPA.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
