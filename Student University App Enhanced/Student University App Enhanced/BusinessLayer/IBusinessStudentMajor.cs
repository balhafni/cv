using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_Enhanced.Models;
namespace Student_University_App_Enhanced.BusinessLayer
{
    public interface IBusinessStudentMajor
    {
        int AddStudentMajor(StudentMajor sm);
        bool DoesStudentMajorExist(string studentId, int departmentId);

        List<StudentMajor> ReadStudentMajor(List<string[]> info);
    }
}
