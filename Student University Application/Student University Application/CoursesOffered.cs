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
    public partial class CoursesOffered : Form
    {
        public CoursesOffered()
        {
            InitializeComponent();
            string sql = "select * from CoursesOffered";

            
            DataTable dt = DataAccess.GetManyRowsCols(sql);
            List<string> list = dt.AsEnumerable()
                           .Select(r => r.Field<string>("Semester"))
                           .Distinct().ToList();

            semesterDropDown.DataSource = list;
        }

        private void btnOfferedCourses_Click(object sender, EventArgs e)
        {
            string sql = "select CourseNum, Semester, RoomNumber from CoursesOffered where Semester = '"+
                semesterDropDown.SelectedItem.ToString()+"'";

            DataTable dt = DataAccess.GetManyRowsCols(sql);
            dataGrid.DataSource = dt;
            dataGrid.Refresh();
        }
    }
}
