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
     
    public partial class UnregisterForACourseForm : Form
    {
        IBusinessStudentCourse _ibusinessStudentCourse = null;
        
        public UnregisterForACourseForm()
        {
            _ibusinessStudentCourse = new Business() as IBusinessStudentCourse;
            
            InitializeComponent();
        }

        private void btnGetRegisteredClasses_Click(object sender, EventArgs e)
        {
            List<StudentCourse> SCList = null;
            try
            {
                SCList = _ibusinessStudentCourse.GetAllStudentCourses(txtid.Text);
                if (SCList.Count() == 0)
                    throw new Exception("Invalid Id!!");
                cbclasses.DataSource = SCList;
                cbclasses.DisplayMember = "CourseNum";
                cbclasses.ValueMember = "CourseNum";
                cbclasses.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnuniregister_Click(object sender, EventArgs e)
        {
            int rows = 0;
            try
            {
                rows = _ibusinessStudentCourse.UnregisterForCourse(cbclasses.SelectedValue.ToString());
                MessageBox.Show("You have unregistered form " + rows + " course");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
