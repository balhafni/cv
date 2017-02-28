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
    public partial class RegistrationForm : Form
    {
        IBusinessCourseOffered _ibussinessCoursesOffered = null;
        IBusinessStudentCourse _ibusinessStudentCourse = null;
        public RegistrationForm()
        {
            _ibussinessCoursesOffered = new Business() as IBusinessCourseOffered;
            _ibusinessStudentCourse = new Business() as IBusinessStudentCourse;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int rows = 0;
            try
            {
                rows = _ibusinessStudentCourse.RegisterForACourse(courses_dropDown.SelectedValue.ToString(), txtstudentID.Text);
                MessageBox.Show(rows + " Course was added successfully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            List<CoursesOffered> COList = null;
            try
            {
                COList = _ibussinessCoursesOffered.GetAllCoursesOffered();
                semester_dropDown.DataSource = COList.Select(s => s.Semester).Distinct().ToList();

                semester_dropDown.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void semester_dropDown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<CoursesOffered> CoList = null;
            try
            {
                CoList = _ibussinessCoursesOffered.GetCoursesOfferedBySemester(semester_dropDown.SelectedValue.ToString());
                courses_dropDown.DataSource = CoList;
                courses_dropDown.DisplayMember = "CourseNum";
                courses_dropDown.ValueMember = "CourseNum";
                courses_dropDown.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
