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
    public partial class ViewGrades : Form
    {
        public ViewGrades()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql = "select c.studentid, c.CourseNum, c.Semester, c.Grade from CoursesTaken c\n" +
                "where c.StudentId = '" + txtId.Text + "'";
            DataTable dt = DataAccess.GetManyRowsCols(sql);
            if (dt.Rows.Count > 0)
            {
                dataGrid.DataSource = dt;
                dataGrid.Refresh();
            }
            else
            {
                MessageBox.Show("Invalid student id");
            }
            

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
