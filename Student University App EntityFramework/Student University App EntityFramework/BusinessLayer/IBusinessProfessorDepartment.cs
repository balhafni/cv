using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;
namespace Student_University_App_EntityFramework.BusinessLayer
{
    interface IBusinessProfessorDepartment
    {
        int AddProfessorDepartment(ProfessorDepartment pd);
        bool DoesProfessorDepartmentExist(int professorId, int departmentId);

        List<ProfessorDepartment> ReadProfessorDepartment(List<string[]> info);
    }
}
