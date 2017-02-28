using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_Enhanced.Models;

namespace Student_University_App_Enhanced.DataLayer
{
    interface IRepositoryStudentMajor
    {
        int AddStudentMajor(StudentMajor sm);
        bool DoesStudentMajorExist(string studentId, int departmentId);

        List<StudentMajor> ReadStudentMajors(List<string[]> info);
    }
}
