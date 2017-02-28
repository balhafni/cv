using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;
using System.Data;
namespace Student_University_App_EntityFramework.DataLayer
{
    public interface IRepositoryStudent
    {
        
            int AddStudent(Student st);
            bool DoesStudentExist(string studentId);

            List<Student> ReadStudents(List<string[]> info);

            List<Student> GetStudetnByDepartmentName(string dptName);

            List<CoursesTaken> GetCoursesTaken(string id);

            List<CoursesTaken> GetGradeByStudentId(string id);

            DataTable GetGradesAndHrs(string id);

            double CalculateGPA(DataTable grades);


        
    }
}
