using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;

namespace Student_University_App_EntityFramework.DataLayer
{
  public  interface IRepositoryStudentMajor
    {
        int AddStudentMajor(StudentMajor sm);
        bool DoesStudentMajorExist(string studentId, int departmentId);

        List<StudentMajor> ReadStudentMajors(List<string[]> info);
    }
}
