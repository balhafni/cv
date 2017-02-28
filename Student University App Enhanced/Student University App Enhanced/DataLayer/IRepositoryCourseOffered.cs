using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_Enhanced.Models;

namespace Student_University_App_Enhanced.DataLayer
{
    public interface IRepositoryCourseOffered
    {
        int AddCourseOffered(CoursesOffered st);
        bool DoesCourseOfferedExist(string courseNum, string semester);

        List<CoursesOffered> ReadCourseOffered(List<string[]> info);

        List<CoursesOffered> GetAllCoursesOffered();
        List<CoursesOffered> GetCoursesOfferedBySemester(string semester);

        List<CoursesOffered> GetEnrollement(string courseNum, string semester);

        CoursesOffered GetCourseOffered(string courseNum);

        void IncrementEnrolledCount(string courseNum);
        void DecrementEnrolledCount(string courseNum);
    }
}
