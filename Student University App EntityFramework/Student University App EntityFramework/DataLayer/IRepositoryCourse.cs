using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;

namespace Student_University_App_EntityFramework.DataLayer
{
    public interface IRepositoryCourse
    {

        int AddCourse(Cours course);
        bool DoesCourseExist(string courseNum);

        List<Cours> ReadCourses(List<string[]> info);
        


    }
}
