using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;

namespace Student_University_App_EntityFramework.DataLayer
{
    public interface IRepositoryProfessor
    {
        int AddProfessor(Professor st);
        bool DoesProfessorExist(string professorId);
        List<Professor> ReadProfessors(List<string[]> info);
    }
}
