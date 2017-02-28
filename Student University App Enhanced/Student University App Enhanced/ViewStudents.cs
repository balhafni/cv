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
    public partial class ViewStudents : Form
    {
        IBusinessDepartment _ibusinessDepartment = null;
        IBusinessStudent _ibusinessStudent = null;
        public ViewStudents()
        {
            InitializeComponent();
            _ibusinessDepartment = new Business() as IBusinessDepartment;
            _ibusinessStudent = new Business() as IBusinessStudent;
        }


        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string dptName = dropDown_majors.SelectedValue.ToString();
                    List<Student> SList = _ibusinessStudent.GetStudentByDepartmentName(dptName);
                    dataGridStudents.DataSource = SList;
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {
            try
            {
                List<Department> DList = _ibusinessDepartment.GetAllDepartments();
                dropDown_majors.DataSource = DList;
                dropDown_majors.DisplayMember = "DepartmentName";
                dropDown_majors.ValueMember = "DepartmentName";
                dropDown_majors.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dropDown_majors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
