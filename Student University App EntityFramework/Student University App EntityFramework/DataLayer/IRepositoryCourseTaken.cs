using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;
namespace Student_University_App_EntityFramework.DataLayer
{
    public interface IRepositoryCourseTaken
    {
        int AddCourseTaken(CoursesTaken ct);
        bool DoesCourseTakenExist(string studentId, string courseNum, string semester);

        List<CoursesTaken> ReadCourseTaken(List<string[]> info);


    }
}