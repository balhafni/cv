using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Student_University_App_EntityFramework.DataLayer
{
    public class RepositoryEF : IRepositoryCourse, IRepositoryCourseOffered, IRepositoryCoursePrerequisites, IRepositoryCourseTaken,
         IRepositoryDepartment, IRepositoryProfessor, IRepositoryProfessorDepartment, IRepositoryStudent, IRepositoryStudentCourse,
         IRepositoryStudentMajor
    {
        UBDBEntities _dbcontext = null;

        public RepositoryEF()
        {
            _dbcontext = new UBDBEntities();

        }
        public RepositoryEF(DbContext dbcontext)
        {
            _dbcontext = dbcontext as UBDBEntities;
        }

        public int AddCourse(Cours course)
        {
            throw new NotImplementedException();
        }

        public int AddCourseOffered(CoursesOffered st)
        {
            throw new NotImplementedException();
        }

        public int AddCoursePrequisite(CoursePrerequisite cp)
        {
            throw new NotImplementedException();
        }

        public int AddCourseTaken(CoursesTaken ct)
        {
            throw new NotImplementedException();
        }

        public int AddDepartment(Department st)
        {
            throw new NotImplementedException();
        }

        public int AddProfessor(Professor st)
        {
            throw new NotImplementedException();
        }

        public int AddProfessorDepartment(ProfessorDepartment pd)
        {
            throw new NotImplementedException();
        }

        public int AddStudent(Student st)
        {
            throw new NotImplementedException();
        }

        public int AddStudentCourse(StudentCours student_course)
        {
            throw new NotImplementedException();
        }

        public int AddStudentMajor(StudentMajor sm)
        {
            throw new NotImplementedException();
        }

        public double CalculateGPA(DataTable grades)
        {
            throw new NotImplementedException();
        }



        public void DecrementEnrolledCount(string courseNum)
        {
            throw new NotImplementedException();
        }

        public bool DoesCourseExist(string courseNum)
        {
            try
            {
                var res = (from c in _dbcontext.Courses
                           where c.CourseNum == courseNum
                           select c).FirstOrDefault<Cours>();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DoesCourseOfferedExist(string courseNum, string semester)
        {
            try
            {
                var res = (from co in _dbcontext.CoursesOffereds
                           where co.CourseNum == courseNum && co.Semester == semester
                           select co).FirstOrDefault<CoursesOffered>();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DoesCoursePrerequisiteExist(string courseNum, string preRequisiteCourseNum)
        {
            try
            {
                var res = (from cp in _dbcontext.CoursePrerequisites
                           where cp.CourseNum == courseNum && cp.PrereqCourseNum == preRequisiteCourseNum
                           select cp).FirstOrDefault<CoursePrerequisite>();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DoesCourseTakenExist(string studentId, string courseNum, string semester)
        {
            try
            {
                var res = (from ct in _dbcontext.CoursesTakens
                           where ct.StudentId == studentId && ct.CourseNum == courseNum && ct.Semester == semester
                           select ct).FirstOrDefault<CoursesTaken>();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DoesDepartmentExist(int departmentId)
        {
            try
            {
                var res = (from dpt in _dbcontext.Departments
                           where dpt.DepartmentId == departmentId
                           select dpt).FirstOrDefault<Department>();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DoesProfessorDepartmentExist(int professorId, int departmentId)
        {
            try
            {
                var res = (from pd in _dbcontext.ProfessorDepartments
                           where pd.ProfessorId == professorId && pd.DepartmentId == departmentId
                           select pd).FirstOrDefault<ProfessorDepartment>();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DoesProfessorExist(string professorId)
        {
            try
            {
                var res = (from p in _dbcontext.Professors
                           where p.ProfessorId == professorId
                           select p).FirstOrDefault<Professor>();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DoesStudentCourseExist(string studentId, string courseNum, string semester)
        {
            try
            {
                var res = (from sc in _dbcontext.StudentCourses
                           where sc.StudentId == studentId && sc.CourseNum == courseNum && sc.Semester == semester
                           select sc).FirstOrDefault<StudentCours>();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DoesStudentExist(string studentId)
        {
            try
            {
                var res = (from s in _dbcontext.Students
                           where s.StudentId == studentId
                           select s).FirstOrDefault<Student>();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DoesStudentMajorExist(string studentId, int departmentId)
        {
            try
            {
                var res = (from sm in _dbcontext.StudentMajors
                           where sm.StudentId == studentId && sm.DepartmentId == departmentId
                           select sm).FirstOrDefault<StudentMajor>();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CoursesOffered> GetAllCoursesOffered()
        {
            try
            {
                return _dbcontext.CoursesOffereds.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Department> GetAllDepartments()
        {
            try
            {
                return _dbcontext.Departments.ToList<Department>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<StudentCours> GetAllStudentCourses(string id)
        {
            try
            {
                var res = (_dbcontext.StudentCourses.Where(scourse => scourse.StudentId == id)).ToList<StudentCours>();
                if (res.Count() == 0)
                    throw new Exception("invalid id");
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CoursesOffered GetCourseOffered(string courseNum)
        {
            try
            {
                var res = (from co in _dbcontext.CoursesOffereds
                           where co.CourseNum == courseNum
                           select co).FirstOrDefault<CoursesOffered>();
                if (res == null)
                    throw new Exception("Invalid course num");
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CoursesOffered> GetCoursesOfferedBySemester(string semester)
        {
            try
            {
                var res = (_dbcontext.CoursesOffereds.Where(coffered => coffered.Semester == semester)).ToList<CoursesOffered>();

                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CoursePrerequisite> GetCoursesPrereqs(string courseNum)
        {
            try
            {
                var res = (_dbcontext.CoursePrerequisites.Where(cpreq => cpreq.CourseNum == courseNum)).ToList<CoursePrerequisite>();

                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CoursesTaken> GetCoursesTaken(string id)
        {
            try
            {
                var res = (_dbcontext.CoursesTakens.Where(ctaken => ctaken.StudentId == id)).ToList<CoursesTaken>();

                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CoursesOffered> GetEnrollement(string courseNum, string semester)
        {
            try
            {
                var res = (_dbcontext.CoursesOffereds.Where(coffered => coffered.Semester == semester && coffered.CourseNum == courseNum
                )).ToList<CoursesOffered>();

                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CoursesTaken> GetGradeByStudentId(string id)
        {
            
            var res = _dbcontext.CoursesTakens.Where(ct => ct.StudentId == id).ToList<CoursesTaken>();
            if (res.Count() == 0)
                throw new Exception("invalid id");
            return res;
        }

        public DataTable GetGradesAndHrs(string id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudetnByDepartmentName(string dptName)
        {
            try
            {
                var res = (from s in _dbcontext.Students
                           join sm in _dbcontext.StudentMajors
                           on s.StudentId equals sm.StudentId
                           join d in _dbcontext.Departments
                           on sm.DepartmentId equals d.DepartmentId
                           where d.DepartmentName == dptName
                           select s).ToList<Student>();

               
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void IncrementEnrolledCount(string courseNum)
        {
            throw new NotImplementedException();
        }

        public bool IsClassFull(CoursesOffered courseOffered)
        {
            throw new NotImplementedException();
        }

        public bool IsCourseTaken(CoursesOffered courseoffered, string studentid)
        {
            throw new NotImplementedException();
        }

        public bool IsPrereqsTaken(List<CoursePrerequisite> CPLISt, string studentid)
        {
            throw new NotImplementedException();
        }

        public List<CoursesOffered> ReadCourseOffered(List<string[]> info)
        {
            throw new NotImplementedException();
        }

        public List<CoursePrerequisite> ReadCoursePrerequisites(List<string[]> info)
        {
            throw new NotImplementedException();
        }

        public List<Cours> ReadCourses(List<string[]> info)
        {
            throw new NotImplementedException();
        }

        public List<CoursesTaken> ReadCourseTaken(List<string[]> info)
        {
            throw new NotImplementedException();
        }

        public List<Department> ReadDepartments(List<string[]> info)
        {
            throw new NotImplementedException();
        }

        public List<ProfessorDepartment> ReadProfessorDepartment(List<string[]> info)
        {
            throw new NotImplementedException();
        }

        public List<Professor> ReadProfessors(List<string[]> info)
        {
            throw new NotImplementedException();
        }

        public List<StudentCours> ReadStudentCourses(List<string[]> info)
        {
            throw new NotImplementedException();
        }

        public List<StudentMajor> ReadStudentMajors(List<string[]> info)
        {
            throw new NotImplementedException();
        }

        public List<Student> ReadStudents(List<string[]> info)
        {
            throw new NotImplementedException();
        }

        public int RegisterForACourse(string courseNum, string studentId)
        {
            throw new NotImplementedException();
        }

        public int UnregisterForCourse(string courseNum)
        {
            throw new NotImplementedException();
        }


    }
}
