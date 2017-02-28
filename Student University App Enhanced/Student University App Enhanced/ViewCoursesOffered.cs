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
    public partial class ViewCoursesOffered : Form
    {
        IBusinessCourseOffered _ibusinessCoursesOffered = null;
        
        public ViewCoursesOffered()
        {
            InitializeComponent();
            _ibusinessCoursesOffered = new Business() as IBusinessCourseOffered;
        }

        private void btnOfferedCourses_Click(object sender, EventArgs e)
        {
            List<CoursesOffered> COList = null;
            try
            {
                COList = _ibusinessCoursesOffered.GetCoursesOfferedBySemester(semesterDropDown.SelectedValue.ToString());
                dataGrid.DataSource = COList;
                dataGrid.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewCoursesOffered_Load(object sender, EventArgs e)
        {
            List<CoursesOffered> COList = null;
            try
            {
                COList = _ibusinessCoursesOffered.GetAllCoursesOffered();
                
                semesterDropDown.DataSource = COList.Select(o => o.Semester).Distinct().ToList();//to remove duplicates
                semesterDropDown.Refresh();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
