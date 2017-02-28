using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_University_App_EntityFramework.BusinessLayer;
namespace Student_University_App_EntityFramework
{
    public partial class ViewStudents : Form
    {
        IBusinessStudent _ibusinessStudent = null;
        IBusinessDepartment _ibusinessDepartment = null;
        public ViewStudents()
        {
            InitializeComponent();
            _ibusinessStudent = new Business() as IBusinessStudent;
            _ibusinessDepartment = new Business() as IBusinessDepartment;
        }
        private void ViewStudents_Load(object sender, EventArgs e)
        {
            dropDown_majors.DataSource = _ibusinessDepartment.GetAllDepartments();
            dropDown_majors.DisplayMember = "DepartmentName";
            dropDown_majors.ValueMember = "DepartmentName";
            dropDown_majors.Refresh();
        }
        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            try
            {
                string dptName = dropDown_majors.SelectedValue.ToString();
                dataGridStudents.DataSource = _ibusinessStudent.GetStudentByDepartmentName(dptName);
                dataGridStudents.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
