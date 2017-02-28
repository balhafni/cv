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
    public partial class ViewStudentGrades : Form
    {
        IBusinessStudent _ibusinessStudent = null;
        public ViewStudentGrades()
        {
            InitializeComponent();
            _ibusinessStudent = new Business() as IBusinessStudent;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
             dataGrid.DataSource = _ibusinessStudent.GetGradeByStudentId(txtId.Text);
            dataGrid.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
