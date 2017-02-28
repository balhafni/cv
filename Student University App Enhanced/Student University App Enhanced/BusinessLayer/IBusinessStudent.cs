using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_Enhanced.Models;
using System.Data;

namespace Student_University_App_Enhanced.BusinessLayer
{
    public interface IBusinessStudent
    {
        int AddStudent(Student st);
        bool DoesStudentExist(string studentId);

        List<Student> ReadStudents(List<string[]>info);

        List<Student> GetStudentByDepartmentName(string dptName);
        List<CoursesTaken> GetGradeByStudentId(string studentId);


        List<CoursesTaken> GetCoursesTaken(string id);

        DataTable GetGradesAndHrs(string id);

        double CalculateGPA(DataTable grades);
    }
}
