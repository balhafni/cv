using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_EntityFramework.DataLayer.EFLayer;
using Student_University_App_EntityFramework.DataLayer;

namespace Student_University_App_EntityFramework.BusinessLayer
{
    public class Business : IBusinessCourse, IBusinessCourseOffered, IBusinessCoursesPrerequisite, IBusinessCourseTaken, IBusinessDepartment,
        IBusinessProfessor, IBusinessProfessorDepartment, IBusinessStudent, IBusinessStudentCourse, IBusinessStudentMajor
    {
        IRepositoryStudent _irepStudent = null;
        IRepositoryCourse _irepCourse = null;
        IRepositoryCourseOffered _irepCourseOffered = null;
        IRepositoryCoursePrerequisites _irepCoursePreq = null;
        IRepositoryCourseTaken _irepCourseTaken = null;
        IRepositoryDepartment _irepDepartment = null;
        IRepositoryProfessor _irepProfessor = null;
        IRepositoryProfessorDepartment _irepProfDept = null;
        IRepositoryStudentCourse _irepStudentCourse = null;
        IRepositoryStudentMajor _irepStudentMajor = null;
        public Business()
        {
            _irepStudent = new RepositoryEF() as IRepositoryStudent;
            _irepCourse = new RepositoryEF() as IRepositoryCourse;
            _irepCourseOffered = new RepositoryEF() as IRepositoryCourseOffered;
            _irepCoursePreq = new RepositoryEF() as IRepositoryCoursePrerequisites;
            _irepCourseTaken = new RepositoryEF() as IRepositoryCourseTaken;
            _irepDepartment = new RepositoryEF() as IRepositoryDepartment;
            _irepProfDept = new RepositoryEF() as IRepositoryProfessorDepartment;
            _irepStudentCourse = new RepositoryEF() as IRepositoryStudentCourse;
            _irepStudentMajor = new RepositoryEF() as IRepositoryStudentMajor;
            _irepProfessor = new RepositoryEF() as IRepositoryProfessor;
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

        public bool DoesCourseExist(string courseNum)
        {
           return _irepCourse.DoesCourseExist(courseNum);
        }

        public bool DoesCourseOfferedExist(string courseNum, string semester)
        {
            return _irepCourseOffered.DoesCourseOfferedExist(courseNum,semester);
        }

        public bool DoesCoursePrerequisiteExist(string courseNum, string preRequisiteCourseNum)
        {

            return _irepCoursePreq.DoesCoursePrerequisiteExist(courseNum, preRequisiteCourseNum);
        }

        public bool DoesCourseTakenExist(string studentId, string courseNum, string semester)
        {
            return _irepCourseTaken.DoesCourseTakenExist(studentId, courseNum, semester);
        }

        public bool DoesDepartmentExist(int departmentId)
        {
            return _irepDepartment.DoesDepartmentExist(departmentId);
        }

        public bool DoesProfessorDepartmentExist(int professorId, int departmentId)
        {
            return _irepProfDept.DoesProfessorDepartmentExist(professorId, departmentId);
        }

        public bool DoesProfessorExist(string professorId)
        {
            return _irepProfessor.DoesProfessorExist(professorId);
        }

        public bool DoesStudentCourseExist(string studentId, string courseNum, string semester)
        {
            return _irepStudentCourse.DoesStudentCourseExist(studentId, courseNum, semester);
        }

        public bool DoesStudentExist(string studentId)
        {
            return _irepStudent.DoesStudentExist(studentId);
        }

        public bool DoesStudentMajorExist(string studentId, int departmentId)
        {
            return _irepStudentMajor.DoesStudentMajorExist(studentId, departmentId);
        }

        public List<CoursesOffered> GetAllCoursesOffered()
        {
            return _irepCourseOffered.GetAllCoursesOffered();
        }

        public List<Department> GetAllDepartments()
        {
            return _irepDepartment.GetAllDepartments();
        }

        public List<StudentCours> GetAllStudentCourses(string id)
        {
            return _irepStudentCourse.GetAllStudentCourses(id);
        }

        public List<CoursesOffered> GetCoursesOfferedBySemester(string semester)
        {
            return _irepCourseOffered.GetCoursesOfferedBySemester(semester);
        }

        public List<CoursesTaken> GetCoursesTaken(string id)
        {
            return _irepStudent.GetCoursesTaken(id);
        }

        public List<CoursesOffered> GetEnrollement(string courseNum, string semester)
        {
            return _irepCourseOffered.GetEnrollement(courseNum, semester);
        }

        public List<CoursesTaken> GetGradeByStudentId(string studentId)
        {
            return _irepStudent.GetGradeByStudentId(studentId);
        }

        public DataTable GetGradesAndHrs(string id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentByDepartmentName(string dptName)
        {
            return _irepStudent.GetStudetnByDepartmentName(dptName);
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

        public List<StudentMajor> ReadStudentMajor(List<string[]> info)
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
