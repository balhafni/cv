using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;
namespace Student_University_App_EntityFramework.BusinessLayer
{
    interface IBusinessStudentCourse
    {
        int AddStudentCourse(StudentCours student_course);
        bool DoesStudentCourseExist(string studentId, string courseNum, string semester);

        List<StudentCours> ReadStudentCourses(List<string[]> info);

        int RegisterForACourse(string courseNum, string studentId);

        List<StudentCours> GetAllStudentCourses(string id);
        int UnregisterForCourse(string courseNum);
    }
}
