using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;
namespace Student_University_App_EntityFramework.DataLayer
{
    public interface IRepositoryStudentCourse
    {
        int AddStudentCourse(StudentCours student_course);
        bool DoesStudentCourseExist(string studentId, string courseNum, string semester);

        List<StudentCours> ReadStudentCourses(List<string[]> info);

        int RegisterForACourse(string courseNum, string studentId);

        bool IsPrereqsTaken(List<CoursePrerequisite> CPLISt, string studentid);

        bool IsClassFull(CoursesOffered courseOffered);

        List<CoursePrerequisite> GetCoursesPrereqs(string courseNum);

        bool IsCourseTaken(CoursesOffered courseoffered, string studentid);

        List<StudentCours> GetAllStudentCourses(string id);

        int UnregisterForCourse(string courseNum);
    }
}
