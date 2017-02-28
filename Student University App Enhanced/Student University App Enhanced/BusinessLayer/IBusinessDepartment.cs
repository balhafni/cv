using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_Enhanced.Models;
namespace Student_University_App_Enhanced.BusinessLayer
{
    public interface IBusinessDepartment
    {
        int AddDepartment(Department st);
        bool DoesDepartmentExist(int departmentId);
        List<Department> ReadDepartments(List<string[]> info);
        List<Department> GetAllDepartments();
    }
}
