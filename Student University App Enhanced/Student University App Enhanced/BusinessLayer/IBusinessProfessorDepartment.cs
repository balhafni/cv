using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_Enhanced.Models;
namespace Student_University_App_Enhanced.BusinessLayer
{
    public interface IBusinessProfessorDepartment
    {
        int AddProfessorDepartment(ProfessorDepartment pd);
        bool DoesProfessorDepartmentExist(int professorId, int departmentId);

        List<ProfessorDepartment> ReadProfessorDepartment(List<string[]> info);
    }
}
