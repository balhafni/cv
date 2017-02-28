using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_Enhanced.Models;
namespace Student_University_App_Enhanced.BusinessLayer
{
    public interface IBusinessCourse
    {
        int AddCourse(Course course);
        bool DoesCourseExist(string courseNum);

        List<Course> ReadCourses(List<string[]> info);
    }
}
