using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_University_Application
{
    public partial class ViewEnrollement : Form
    {
        public ViewEnrollement()
        {
            InitializeComponent();
            string sql = "select * from CoursesOffered";


            DataTable dt = DataAccess.GetManyRowsCols(sql);
            List<string> list = dt.AsEnumerable()
                           .Select(r => r.Field<string>("Semester"))
                           .Distinct().ToList();

            semester_dropDown.DataSource = list;

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            string sql = "select MaxEnrollment, EnrolledCount from CoursesOffered where Semester = '" + semester_dropDown.SelectedItem +
                "' and CourseNum = '" + courses_dropDown.SelectedItem + "'";
            DataTable dt = DataAccess.GetManyRowsCols(sql);
            dataGrid.DataSource = dt;
            dataGrid.Refresh();
        }

        private void semester_dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select coursenum from coursesoffered where semester = '" + semester_dropDown.SelectedItem.ToString() + "'";
            DataTable dt = new DataTable();
            dt = DataAccess.GetManyRowsCols(sql);
            List<string> list = dt.AsEnumerable().Select(r => r.Field<string>("CourseNum")).Distinct().ToList();
            courses_dropDown.DataSource = list;
            

        }
    }
}
