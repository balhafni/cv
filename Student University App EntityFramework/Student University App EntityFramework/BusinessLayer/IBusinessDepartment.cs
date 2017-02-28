using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;
namespace Student_University_App_EntityFramework.BusinessLayer
{
    public interface IBusinessDepartment
    {
        int AddDepartment(Department st);
        bool DoesDepartmentExist(int departmentId);
        List<Department> ReadDepartments(List<string[]> info);
        List<Department> GetAllDepartments();
    }
}