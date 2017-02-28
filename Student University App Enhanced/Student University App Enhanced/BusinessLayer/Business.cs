using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_Enhanced.DataLayer;
using Student_University_App_Enhanced.Models;

namespace Student_University_App_Enhanced.BusinessLayer
{
    public class Business : IBusinessStudent, IBusinessCourse, IBusinessCourseOffered, IBusinessCoursesPrerequisite, IBusinessCourseTaken,
         IBusinessDepartment, IBusinessProfessor, IBusinessProfessorDepartment, IBusinessStudentCourse, IBusinessStudentMajor
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
            _irepStudent = new Repository() as IRepositoryStudent;
            _irepCourse = new Repository() as IRepositoryCourse;
            _irepCourseOffered = new Repository() as IRepositoryCourseOffered;
            _irepCoursePreq = new Repository() as IRepositoryCoursePrerequisites;
            _irepCourseTaken = new Repository() as IRepositoryCourseTaken;
            _irepDepartment = new Repository() as IRepositoryDepartment;
            _irepProfDept = new Repository() as IRepositoryProfessorDepartment;
            _irepStudentCourse = new Repository() as IRepositoryStudentCourse;
            _irepStudentMajor = new Repository() as IRepositoryStudentMajor;
            _irepProfessor = new Repository() as IRepositoryProfessor;
        }
        public Business(IRepositoryStudent irepStudent)
        {
            _irepStudent = irepStudent;
        }

        public int AddCourse(Course course)
        {
            return _irepCourse.AddCourse(course);
        }

        public int AddCourseOffered(CoursesOffered courseOffered)
        {
            return _irepCourseOffered.AddCourseOffered(courseOffered);
        }

        public int AddCoursePrequisite(CoursePrerequisite cp)
        {
            return _irepCoursePreq.AddCoursePrequisite(cp);
        }

        public int AddCourseTaken(CoursesTaken ct)
        {
            return _irepCourseTaken.AddCourseTaken(ct);
        }

        public int AddDepartment(Department dt)
        {
            return _irepDepartment.AddDepartment(dt);
        }

        public int AddProfessor(Professor prof)
        {
            return _irepProfessor.AddProfessor(prof);
        }

        public int AddProfessorDepartment(ProfessorDepartment pd)
        {
            return _irepProfDept.AddProfessorDepartment(pd);
        }

        public int AddStudent(Student st)
        {
            return _irepStudent.AddStudent(st);
        }

        public int AddStudentCourse(StudentCourse student_course)
        {
            return _irepStudentCourse.AddStudentCourse(student_course);
        }

        public int AddStudentMajor(StudentMajor sm)
        {
            return _irepStudentMajor.AddStudentMajor(sm);
        }

        public bool DoesCourseExist(string courseNum)
        {
            return _irepCourse.DoesCourseExist(courseNum);
        }

        public bool DoesCourseOfferedExist(string courseNum, string semester)
        {
            return _irepCourseOffered.DoesCourseOfferedExist(courseNum, semester);
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

        public List<CoursesOffered> ReadCourseOffered(List<string[]> info)
        {
            return _irepCourseOffered.ReadCourseOffered(info);
        }

        public List<CoursePrerequisite> ReadCoursePrerequisites(List<string[]> info)
        {
            return _irepCoursePreq.ReadCoursePrerequisites(info);
        }

        public List<Course> ReadCourses(List<string[]> info)
        {
            return _irepCourse.ReadCourses(info);
        }

        public List<CoursesTaken> ReadCourseTaken(List<string[]> info)
        {
            return _irepCourseTaken.ReadCourseTaken(info);
        }

        public List<Department> ReadDepartments(List<string[]> info)
        {
            return _irepDepartment.ReadDepartments(info);
        }

        public List<ProfessorDepartment> ReadProfessorDepartment(List<string[]> info)
        {
            return _irepProfDept.ReadProfessorDepartment(info);
        }

        public List<Professor> ReadProfessors(List<string[]> info)
        {
            return _irepProfessor.ReadProfessors(info);
        }

        public List<StudentCourse> ReadStudentCourses(List<string[]> info)
        {
            return _irepStudentCourse.ReadStudentCourses(info);
        }

        public List<StudentMajor> ReadStudentMajor(List<string[]> info)
        {
            return _irepStudentMajor.ReadStudentMajors(info);
        }

        public List<Student> ReadStudents(List<string[]> info)
        {
            return _irepStudent.ReadStudents(info);
        }

        public List<Department> GetAllDepartments()
        {
            return _irepDepartment.GetAllDepartments();
        }

        public List<Student> GetStudentByDepartmentName(string dptName)
        {
            return _irepStudent.GetStudetnByDepartmentName(dptName);
        }
        public List<CoursesTaken> GetGradeByStudentId(string id)
        {
            return _irepStudent.GetGradeByStudentId(id);
        }
        public List<CoursesOffered> GetAllCoursesOffered()
        {
            return _irepCourseOffered.GetAllCoursesOffered();
        }
        public List<CoursesOffered> GetCoursesOfferedBySemester(string semester)
        {
            return _irepCourseOffered.GetCoursesOfferedBySemester(semester);
        }

        public List<CoursesOffered> GetEnrollement(string courseNum, string semester)
        {
            return _irepCourseOffered.GetEnrollement(courseNum, semester);
        }
        public List<CoursesTaken> GetCoursesTaken(string id)
        {
            return _irepStudent.GetCoursesTaken(id);
        }

        public DataTable GetGradesAndHrs(string id)
        {
            return _irepStudent.GetGradesAndHrs(id);
        }

        public double CalculateGPA(DataTable grades)
        {
            return _irepStudent.CalculateGPA(grades);
        }

        public int RegisterForACourse(string courseNum, string studentId)
        {
            return _irepStudentCourse.RegisterForACourse(courseNum, studentId);
        }
        public List<StudentCourse> GetAllStudentCourses(string id)
        {
            return _irepStudentCourse.GetAllStudentCourses(id);
        }
       public int UnregisterForCourse(string courseNum)
        {
            return _irepStudentCourse.UnregisterForCourse(courseNum);
        }

    }
}

