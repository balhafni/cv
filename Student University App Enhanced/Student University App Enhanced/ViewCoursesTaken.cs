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

namespace Student_University_App_Enhanced
{
    public partial class ViewCoursesTaken : Form
    {
        IBusinessStudent _ibusinessStudent = null;

        public ViewCoursesTaken()
        {
            InitializeComponent();
            _ibusinessStudent = new Business() as IBusinessStudent;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<CoursesTaken> COTList = null;
            try
            {
                COTList = _ibusinessStudent.GetCoursesTaken(txtId.Text);
                if (COTList.Count == 0)
                {
                    MessageBox.Show("Invalid Id");
                    return;
                }
                dataGrid.DataSource = COTList.Select(c => new { CourseNum = c.CourseNum, Semester = c.Semester, Grade = c.Grade }).ToList();
                dataGrid.Refresh();

            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
