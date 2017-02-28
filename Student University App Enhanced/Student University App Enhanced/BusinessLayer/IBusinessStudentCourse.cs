using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_Enhanced.Models;
namespace Student_University_App_Enhanced.BusinessLayer
{
    public interface IBusinessStudentCourse
    {
        int AddStudentCourse(StudentCourse student_course);
        bool DoesStudentCourseExist(string studentId, string courseNum, string semester);

        List<StudentCourse> ReadStudentCourses(List<string[]> info);

        int RegisterForACourse(string courseNum, string studentId);

        List<StudentCourse> GetAllStudentCourses(string id);
         int UnregisterForCourse(string courseNum);
    }
}
