using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;
namespace Student_University_App_EntityFramework.BusinessLayer
{
    interface IBusinessCoursesPrerequisite
    {
        int AddCoursePrequisite(CoursePrerequisite cp);

        bool DoesCoursePrerequisiteExist(string courseNum, string preRequisiteCourseNum);

        List<CoursePrerequisite> ReadCoursePrerequisites(List<string[]> info);
    }
}
