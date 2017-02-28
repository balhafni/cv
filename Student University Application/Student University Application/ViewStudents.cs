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
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();
           
            string sql = "select * from departments";
            DataTable dt = DataAccess.GetManyRowsCols(sql);
            List<string> list = dt.AsEnumerable()
                           .Select(r => r.Field<string>("DepartmentName"))
                           .Distinct().ToList();

            dropDown_majors.DataSource = list;
        }


        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            
            string sql = "select s.StudentId, s.FirstName, s.LastName, s.StreetAddress,"
                +"s.City, s.State, s.Telephone from Students s" +"\n"+
                "inner join StudentMajors sm on sm.StudentId = s.StudentId" +"\n"+
                "inner join Departments d on sm.DepartmentId = d.DepartmentId" +"\n"+
                "where d.DepartmentName = '" + dropDown_majors.SelectedItem.ToString() + "'";

            DataTable dt = DataAccess.GetManyRowsCols(sql);
            dataGridStudents.DataSource = dt;
            dataGridStudents.Refresh();
                             
        }
        
    }
}
