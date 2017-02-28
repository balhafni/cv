using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Student_University_App_Enhanced.Models;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace Student_University_App_Enhanced.DataLayer
{
    class Repository : IRepositoryStudent, IRepositoryProfessor, IRepositoryDepartment, IRepositoryCourse, IRepositoryCourseOffered,
        IRepositoryCoursePrerequisites, IRepositoryStudentMajor, IRepositoryStudentCourse, IRepositoryProfessorDepartment,
        IRepositoryCourseTaken

    {
        IDataAccess _idac = null;
        public Repository()
        {
            string CONNSTR = ConfigurationManager.ConnectionStrings["Student_University_App_Enhanced.Properties.Settings.UBDBConnectionString"].ConnectionString;
            _idac = new DataAccess(CONNSTR);
        }
        public Repository(IDataAccess idac)
        {
            _idac = idac;
        }
        public List<Student> ReadStudents(List<string[]> info)
        {
            List<Student> SList = null;
            try
            {
                SList = ReadData.CreateObject<Student>(info);
            }
            catch (Exception)
            {
                throw;
            }
            return SList;
        }
        public int AddStudent(Student st)
        {
            int rows = 0;
            string sql = "";
            try
            {
                if (DoesStudentExist(st.StudentId) == false)
                {
                    sql = "insert into Students Values ('" + st.StudentId + "','" + st.FirstName + "','" + st.LastName + "','" + st.StreetAddress
                                     + "','" + st.City + "','" + st.State + "','" + st.Telephone + "')";
                }
                else
                {
                    sql = "update students set firstname = '" + st.FirstName + "'" +
                                   ", lastname = '" + st.LastName + "'" + ", streetaddress = '" + st.StreetAddress + "'" + ",city = '" + st.City + "'" +
                                   ", state = '" + st.State + "'" + ", telephone = '" + st.Telephone + "' where studentid = '" + st.StudentId + "'";
                }
                rows = _idac.InsertUpdateDelete(sql, null);
            }
            catch (Exception)
            {
                throw;
            }
            return rows;

        }

        public bool DoesStudentExist(string studentId)
        {
            try
            {
                string sql = " select count(*) from students where studentid like @StudentId";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar);
                p1.Value = studentId;
                ParamList.Add(p1);

                int rows = _idac.CheckExistence(sql, ParamList);
                if (rows <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AddCourseTaken(CoursesTaken ct)
        {
            int rows = 0;
            string sql = "";
            try
            {
                if (DoesCourseTakenExist(ct.StudentId, ct.CourseNum, ct.Semester) == false)
                {
                    sql = "insert into CoursesTaken Values ('" + ct.StudentId + "','" + ct.CourseNum + "','" + ct.Semester + "','" + ct.Grade + "')";
                }
                else
                {
                    sql = "update CoursesTaken set  grade = '" + ct.Grade
                                    + "' where studentid = '" + ct.StudentId + "' And coursenum = '" + ct.CourseNum + "'" +
                                    " And semester = '" + ct.Semester + "'";

                }
                rows = _idac.InsertUpdateDelete(sql, null);
            }
            catch (Exception)
            {
                throw;
            }
            return rows;
        }

        public bool DoesCourseTakenExist(string studentId, string courseNum, string semester)
        {
            try
            {

                string sql = "select count(*) from CoursesTaken where studentid like @studentId AND coursenum like @courseNum  AND Semester like @Semester";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@courseNum", SqlDbType.VarChar);
                SqlParameter p3 = new SqlParameter("@Semester", SqlDbType.VarChar);
                p1.Value = studentId;
                p2.Value = courseNum;
                p3.Value = semester;
                ParamList.Add(p1);
                ParamList.Add(p2);
                ParamList.Add(p3);

                int rows = _idac.CheckExistence(sql, ParamList);
                if (rows <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<CoursesTaken> ReadCourseTaken(List<string[]> info)
        {
            List<CoursesTaken> CTList = null;
            try
            {
                CTList = ReadData.CreateObject<CoursesTaken>(info);
            }
            catch (Exception)
            {
                throw;
            }
            return CTList;
        }

        public int AddStudentMajor(StudentMajor sm)
        {
            int rows = 0;
            string sql = "";
            try
            {
                if (DoesStudentMajorExist(sm.StudentId, sm.DepartmentId) == false)
                {
                    sql = "insert into StudentMajors Values ('" + sm.StudentId + "','" + sm.DepartmentId + "')";
                    rows = _idac.InsertUpdateDelete(sql, null);
                }


            }
            catch (Exception)
            {
                throw;
            }
            return rows;
        }

        public bool DoesStudentMajorExist(string studentId, int departmentId)
        {
            try
            {
                string sql = "select count(*) from StudentMajors where studentid like @studentId And departmentid like @departmentId";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@departmentId", SqlDbType.Int);
                p1.Value = studentId;
                p2.Value = departmentId;
                ParamList.Add(p1);
                ParamList.Add(p2);

                int rows = _idac.CheckExistence(sql, ParamList);
                if (rows <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<StudentMajor> ReadStudentMajors(List<string[]> info)
        {
            List<StudentMajor> SMList = null;
            try
            {
                SMList = ReadData.CreateObject<StudentMajor>(info);
            }
            catch (Exception)
            {
                throw;
            }
            return SMList;
        }

        public int AddCoursePrequisite(CoursePrerequisite cp)
        {
            int rows = 0;
            string sql = "";
            try
            {
                if (DoesCoursePrerequisiteExist(cp.CourseNum, cp.PrereqCourseNum) == false)
                {
                    sql = "insert into CoursePrerequisites Values ('" + cp.CourseNum + "','" + cp.PrereqCourseNum + "')";
                    rows = _idac.InsertUpdateDelete(sql, null);
                }


            }
            catch (Exception)
            {
                throw;
            }
            return rows;
        }

        public bool DoesCoursePrerequisiteExist(string courseNum, string preRequisiteCourseNum)
        {
            try
            {
                string sql = "select count(*) from CoursePrerequisites where courseNum like @courseNum And prereqcoursenum like @preRequisiteCourseNum";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@courseNum", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@preRequisiteCourseNum", SqlDbType.VarChar);
                p1.Value = courseNum;
                p2.Value = preRequisiteCourseNum;
                ParamList.Add(p1);
                ParamList.Add(p2);
                int rows = _idac.CheckExistence(sql, ParamList);
                if (rows <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CoursePrerequisite> ReadCoursePrerequisites(List<string[]> info)
        {
            List<CoursePrerequisite> CPList = null;
            try
            {
                CPList = ReadData.CreateObject<CoursePrerequisite>(info);
            }
            catch (Exception)
            {
                throw;
            }
            return CPList;
        }

        public int AddStudentCourse(StudentCourse student_course)
        {
            int rows = 0;
            string sql = "";
            try
            {
                if (DoesStudentCourseExist(student_course.StudentId, student_course.CourseNum, student_course.Semester) == false)
                {
                    sql = "insert into StudentCourses Values ('" + student_course.StudentId + "','" + student_course.StudentId +
                        "','" + student_course.Semester + "')";
                    rows = _idac.InsertUpdateDelete(sql, null);
                }


            }
            catch (Exception)
            {
                throw;
            }
            return rows;
        }

        public bool DoesStudentCourseExist(string studentId, string courseNum, string semester)
        {

            try
            {
                string sql = "select count(*) from StudentCourses where studentid like @studentId And CourseNum like @courseNum And Semester like @semester";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@studentid", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@courseNum", SqlDbType.VarChar);
                SqlParameter p3 = new SqlParameter("@semester", SqlDbType.VarChar);
                p1.Value = studentId;
                p2.Value = courseNum;
                p3.Value = semester;
                ParamList.Add(p1);
                ParamList.Add(p2);
                ParamList.Add(p3);

                int rows = _idac.CheckExistence(sql, ParamList);
                if (rows <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<StudentCourse> ReadStudentCourses(List<string[]> info)
        {
            List<StudentCourse> PSCList = null;
            try
            {
                PSCList = ReadData.CreateObject<StudentCourse>(info);
            }
            catch (Exception)
            {
                throw;
            }
            return PSCList;
        }

        public int AddProfessorDepartment(ProfessorDepartment pd)
        {
            int rows = 0;
            string sql = "";
            try
            {
                if (DoesProfessorDepartmentExist(pd.ProfessorId, pd.DepartmentId) == false)
                {
                    sql = "insert into Students Values ('" + pd.ProfessorId + "','" + pd.DepartmentId + "')";
                    rows = _idac.InsertUpdateDelete(sql, null);
                }


            }
            catch (Exception)
            {
                throw;
            }
            return rows;
        }

        public bool DoesProfessorDepartmentExist(int professorId, int departmentId)
        {


            try
            {
                string sql = sql = "select count(*) from ProfessorDepartments where professorid like @ProfessorId  And DepartmentId like @DepartmentId";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@ProfessorId", SqlDbType.Int);
                SqlParameter p2 = new SqlParameter("@DepartmentId", SqlDbType.Int);
                p1.Value = professorId;
                p2.Value = departmentId;
                ParamList.Add(p1);
                ParamList.Add(p2);
                int rows = _idac.CheckExistence(sql, ParamList);
                if (rows <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ProfessorDepartment> ReadProfessorDepartment(List<string[]> info)
        {
            List<ProfessorDepartment> PDList = null;
            try
            {
                PDList = ReadData.CreateObject<ProfessorDepartment>(info);
            }
            catch (Exception)
            {
                throw;
            }
            return PDList;
        }

        public int AddProfessor(Professor prof)
        {
            int rows = 0;
            string sql = "";
            try
            {
                if (DoesProfessorExist(prof.ProfessorId) == false)
                {
                    sql = "insert into Students Values ('" + prof.ProfessorId + "','" + prof.FirstName + "','" + prof.LastName +
                        "','" + prof.StreetAddress + "','" + prof.City + "','" + prof.State + "','" + prof.Telephone + "')";
                }
                else
                {
                    sql = "update professors set firstname = '" + prof.FirstName + "'" +
                          ", lastname = '" + prof.LastName + "'" + ", streetaddress = '" + prof.StreetAddress + "'" +
                          ",city = '" + prof.City + "'" + ", state = '" + prof.State + "'" + ", telephone = '" +
                          prof.Telephone + "' where professorid = '" + prof.ProfessorId + "'";
                }
                rows = _idac.InsertUpdateDelete(sql, null);
            }
            catch (Exception)
            {
                throw;
            }
            return rows;
        }

        public bool DoesProfessorExist(string professorId)
        {
            try
            {
                string sql = " select count(*) from professors where professorid like @professorId";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@professorId", SqlDbType.VarChar);
                p1.Value = professorId;
                ParamList.Add(p1);

                int rows = _idac.CheckExistence(sql, ParamList);
                if (rows <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Professor> ReadProfessors(List<string[]> info)
        {
            List<Professor> PList = null;
            try
            {
                PList = ReadData.CreateObject<Professor>(info);
            }
            catch (Exception)
            {
                throw;
            }
            return PList;
        }

        public int AddDepartment(Department dt)
        {
            int rows = 0;
            string sql = "";
            try
            {
                if (DoesDepartmentExist(dt.DepartmentId) == false)
                {
                    sql = "insert into departments Values ('" + dt.DepartmentId + "','" + dt.DepartmentName + "')";
                }
                else
                {
                    sql = "update Departments set DepartmentName = '" + dt.DepartmentName + "' where DepartmentId = '" +
                       dt.DepartmentId + "'";
                }
                rows = _idac.InsertUpdateDelete(sql, null);
            }
            catch (Exception)
            {
                throw;
            }
            return rows;
        }

        public bool DoesDepartmentExist(int departmentId)
        {
            try
            {
                string sql = " select count(*) from departments where departmentid like @departmentid";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@departmentid", SqlDbType.Int);
                p1.Value = departmentId;
                ParamList.Add(p1);

                int rows = _idac.CheckExistence(sql, ParamList);
                if (rows <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Department> ReadDepartments(List<string[]> info)
        {
            List<Department> DList = null;
            try
            {
                DList = ReadData.CreateObject<Department>(info);
            }
            catch (Exception)
            {
                throw;
            }
            return DList;
        }

        public int AddCourse(Course course)
        {
            int rows = 0;
            string sql = "";
            int? c = course.CreditHours;
            try
            {
                if (DoesCourseExist(course.CourseNum) == false)
                {
                    sql = "insert into Courses Values ('" + course.CourseNum + "','" + course.CourseName + "','" +
                       course.CreditHours + "','" + course.Description + "','" + course.DepartmentId + "')";
                }
                else
                {

                    sql = "update courses set coursename = '" + course.CourseName + "'" +
                        ", CreditHours = '" + course.CreditHours + "'" + ", description = '" + course.Description + "'" +
                        ",departmentid = '" + course.DepartmentId + "'" + " where courseNum = '" + course.CourseNum + "'";
                }
                rows = _idac.InsertUpdateDelete(sql, null);
            }
            catch (Exception)
            {
                throw;
            }
            return rows;
        }

        public bool DoesCourseExist(string courseNum)
        {
            try
            {
                string sql = " select count(*) from Courses where courseNum like @courseNum";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@courseNum", SqlDbType.VarChar);
                p1.Value = courseNum;
                ParamList.Add(p1);

                int rows = _idac.CheckExistence(sql, ParamList);
                if (rows <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Course> ReadCourses(List<string[]> info)
        {
            List<Course> CList = null;
            try
            {
                CList = ReadData.CreateObject<Course>(info);
            }
            catch (Exception)
            {
                throw;
            }
            return CList;
        }

        public int AddCourseOffered(CoursesOffered ct)
        {
            int rows = 0;
            string sql = "";
            try
            {
                if (DoesCourseOfferedExist(ct.CourseNum, ct.Semester) == false)
                {
                    sql = "insert into CoursesOffered Values ('" + ct.CourseNum + "','" + ct.Semester + "','" +
                       ct.MaxEnrollment + "','" + ct.EnrolledCount + "','" + ct.RoomNumber + "','" + ct.ProfessorId + "')";
                }
                else
                {
                    sql = "update coursesoffered set maxenrollment = '" + ct.MaxEnrollment + "',enrolledcount = '" +
                        ct.EnrolledCount + "', roomnumber = '" + ct.RoomNumber + "', professorid = '" + ct.ProfessorId +
                        "' where courseNum = '" + ct.CourseNum + "' and semester = '" + ct.Semester + "'";
                }
                rows = _idac.InsertUpdateDelete(sql, null);
            }
            catch (Exception)
            {
                throw;
            }
            return rows;
        }

        public bool DoesCourseOfferedExist(string courseNum, string semester)
        {

            try
            {

                string sql = "select count(*) from CoursesOffered where courseNum like @courseNum And semester like @semester";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@coursenum", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@semester", SqlDbType.VarChar);

                p1.Value = courseNum;
                p2.Value = semester;
                ParamList.Add(p1);
                ParamList.Add(p2);

                int rows = _idac.CheckExistence(sql, ParamList);
                if (rows <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<CoursesOffered> ReadCourseOffered(List<string[]> info)
        {
            List<CoursesOffered> COLIST = null;
            try
            {
                COLIST = ReadData.CreateObject<CoursesOffered>(info);
            }
            catch (Exception)
            {
                throw;
            }
            return COLIST;
        }

        public List<Department> GetAllDepartments()
        {
            List<Department> DList = null;
            try
            {
                string sql = "select * from Departments";
                DataTable dt = _idac.GetManyRowsCols(sql, null);
                DList = DBList.ToList<Department>(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return DList;
        }
        public List<StudentCourse> GetAllStudentCourses(string studentId)
        {
            List<StudentCourse> SCList = null;
            try
            {
                string sql = "select * from StudentCourses where studentId = @studentId";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@studentId", SqlDbType.VarChar);
                p1.Value = studentId;
                ParamList.Add(p1);

                DataTable dt = _idac.GetManyRowsCols(sql, ParamList);
                SCList = DBList.ToList<StudentCourse>(dt);

            }
            catch (Exception)
            {
                throw;
            }
            return SCList;
        }
        public List<Student> GetStudetnByDepartmentName(string dptName)
        {
            List<Student> SList = null;
            try
            {
                string sql = "select s.StudentId, s.FirstName, s.LastName, s.StreetAddress,"
              + "s.City, s.State, s.Telephone from Students s" + "\n" +
              "inner join StudentMajors sm on sm.StudentId = s.StudentId" + "\n" +
              "inner join Departments d on sm.DepartmentId = d.DepartmentId" + "\n" +
              "where d.DepartmentName = @DepartmentName";

                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@DepartmentName", SqlDbType.VarChar);
                p1.Value = dptName;
                ParamList.Add(p1);
                DataTable dt = _idac.GetManyRowsCols(sql, ParamList);
                SList = DBList.ToList<Student>(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return SList;
        }

        public List<CoursesTaken> GetGradeByStudentId(string id)
        {
            List<CoursesTaken> cList = null;
            try
            {
                string sql = "select c.studentid, c.CourseNum, c.Semester, c.Grade from CoursesTaken c " +
              "where c.StudentId = @StudentId";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar);
                p1.Value = id;
                ParamList.Add(p1);
                DataTable dt = _idac.GetManyRowsCols(sql, ParamList);
                cList = DBList.ToList<CoursesTaken>(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return cList;
        }
        public List<CoursesOffered> GetAllCoursesOffered()

        {
            List<CoursesOffered> COList = null;
            try
            {
                string sql = "select * from CoursesOffered";
                DataTable dt = _idac.GetManyRowsCols(sql, null);
                COList = DBList.ToList<CoursesOffered>(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return COList;
        }

        public List<CoursesOffered> GetCoursesOfferedBySemester(string semester)
        {
            List<CoursesOffered> COList = null;
            try
            {
                string sql = "select * from CoursesOffered where Semester = @Semester";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@Semester", SqlDbType.VarChar);
                p1.Value = semester;
                ParamList.Add(p1);
                DataTable dt = _idac.GetManyRowsCols(sql, ParamList);
                COList = DBList.ToList<CoursesOffered>(dt);

            }
            catch (Exception)
            {
                throw;
            }
            return COList;
        }
        public List<CoursesOffered> GetEnrollement(string courseNum, string semester)
        {
            List<CoursesOffered> COList = null;
            try
            {
                string sql = "select * from CoursesOffered where Semester =@Semester and CourseNum = @CourseNum";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@Semester", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@CourseNum", SqlDbType.VarChar);
                p1.Value = semester;
                p2.Value = courseNum;
                ParamList.Add(p1); ParamList.Add(p2);
                DataTable dt = _idac.GetManyRowsCols(sql, ParamList);
                COList = DBList.ToList<CoursesOffered>(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return COList;

        }

        public List<CoursesTaken> GetCoursesTaken(string id)
        {
            List<CoursesTaken> CTList = null;
            try
            {
                string sql = "select coursenum, semester, grade from coursesTaken where studentid = @studentid";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@studentid", SqlDbType.VarChar);
                p1.Value = id;
                ParamList.Add(p1);
                DataTable dt = _idac.GetManyRowsCols(sql, ParamList);
                CTList = DBList.ToList<CoursesTaken>(dt);
                return CTList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetGradesAndHrs(string id)
        {
            DataTable dt = null;
            try
            {
                string sql = "select ct.grade, c.credithours from coursestaken ct\n" +
                    "inner join courses c on c.courseNum = ct.courseNum where ct.studentid = @StudentId";

                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar);
                p1.Value = id;
                ParamList.Add(p1);
                dt = _idac.GetManyRowsCols(sql, ParamList);
                //DTList = DBList.ToList(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
        public double CalculateGPA(DataTable grades)
        {

            double GPA = 0;
            int creditHours = 0;
            try
            {

                foreach (DataRow dr in grades.Rows)
                {
                    if (dr["grade"].ToString() == "A")
                    {
                        GPA += 4.0 * double.Parse(dr["credithours"].ToString());
                        creditHours += int.Parse(dr["credithours"].ToString());
                    }
                    else if (dr["grade"].ToString() == "A-")
                    {
                        GPA += 3.7 * double.Parse(dr["credithours"].ToString());
                        creditHours += int.Parse(dr["credithours"].ToString());
                    }
                    else if (dr["grade"].ToString() == "B")
                    {
                        GPA += 3 * double.Parse(dr["credithours"].ToString());
                        creditHours += int.Parse(dr["credithours"].ToString());
                    }
                    else if (dr["grade"].ToString() == "B-")
                    {
                        GPA += 2.7 * double.Parse(dr["credithours"].ToString());
                        creditHours += int.Parse(dr["credithours"].ToString());
                    }
                    else if (dr["grade"].ToString() == "B+")
                    {
                        GPA += 3.3 * double.Parse(dr["credithours"].ToString());
                        creditHours += int.Parse(dr["credithours"].ToString());
                    }
                    else if (dr["grade"].ToString() == "C")
                    {
                        GPA += 2.0 * double.Parse(dr["credithours"].ToString());
                        creditHours += int.Parse(dr["credithours"].ToString());
                    }
                    else if (dr["grade"].ToString() == "C-")
                    {
                        GPA += 1.7 * double.Parse(dr["credithours"].ToString());
                        creditHours += int.Parse(dr["credithours"].ToString());
                    }
                    else if (dr["grade"].ToString() == "C+")
                    {
                        GPA += 2.3 * double.Parse(dr["credithours"].ToString());
                        creditHours += int.Parse(dr["credithours"].ToString());
                    }

                }
                GPA = GPA / creditHours;
            }
            catch (Exception)
            {
                throw;
            }
            return GPA;
        }
        public bool IsClassFull(CoursesOffered courseOffered)
        {

            try
            {
                if (courseOffered.MaxEnrollment > courseOffered.EnrolledCount)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CoursePrerequisite> GetCoursesPrereqs(string courseNum)
        {
            List<CoursePrerequisite> CPLISt = null;
            try
            {
                string sql = "select * from courseprerequisites where courseNum = @courseNum";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@courseNum", SqlDbType.VarChar);
                p1.Value = courseNum;
                ParamList.Add(p1);
                DataTable dt = _idac.GetManyRowsCols(sql, ParamList);
                CPLISt = DBList.ToList<CoursePrerequisite>(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return CPLISt;
        }
        public bool IsPrereqsTaken(List<CoursePrerequisite> CPLISt, string id)
        {
            List<CoursesTaken> CTList = GetCoursesTaken(id);
            List<bool> check = new List<bool>();
      
            foreach(CoursesTaken cT in CTList)
            {
                foreach(CoursePrerequisite cp in CPLISt)
                {
                    if(cT.CourseNum == cp.PrereqCourseNum)
                    {
                        check.Add(true);
                    }
                }
            }
            if (!DidStudentPass(CTList))
            {
                return false;
            }

            if(check.Count() == CPLISt.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DidStudentPass(List<CoursesTaken> sc)
        {
            foreach(CoursesTaken c in sc)
            {
                if(c.Grade != "C-" && c.Grade != "D" && c.Grade != "D-" && c.Grade!= "F")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public CoursesOffered GetCourseOffered(string courseNum)
        {
            List<CoursesOffered> coursesOffered = null;
            CoursesOffered course = null;
            try
            {
                string sql = "select * from coursesOffered where courseNum = @courseNum";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@CourseNum", SqlDbType.VarChar);
                p1.Value = courseNum;
                ParamList.Add(p1);
                DataTable dt = _idac.GetManyRowsCols(sql, ParamList);
                coursesOffered = DBList.ToList<CoursesOffered>(dt);
                course = coursesOffered[0];
                //course = (CoursesOffered)_idac.GetSingleAnswer(sql, ParamList);
            }
            catch (Exception)
            {
                throw;
            }
            return course;
        }


        public int RegisterForACourse(string courseNum, string studentId)
        {
            int rows = 0;
            try
            {
                CoursesOffered courseOffered = GetCourseOffered(courseNum);
                List<CoursePrerequisite> CPList = GetCoursesPrereqs(courseNum);
                if (DoesStudentExist(studentId) == false)
                {
                    throw new Exception("Student doesn't exist!");
                }
                if (IsClassFull(courseOffered))
                {
                    throw new Exception("Class is full!");
                }
                if (IsCourseTaken(courseOffered, studentId))
                {
                    throw new Exception("The student has already been registered to the course");
                }
                if (!IsPrereqsTaken(CPList, studentId))
                {
                    throw new Exception("You haven't taken all the prerequisites courses to register for this course "+"or you did not pass any of the pre reqs");
                }
                
                else
                {
                    string sql = "insert into studentcourses values(@studentId, @courseNum,@Semester)";
                    List<DbParameter> ParamList = new List<DbParameter>();
                    SqlParameter p1 = new SqlParameter("@studentId", SqlDbType.VarChar);
                    SqlParameter p2 = new SqlParameter("@courseNum", SqlDbType.VarChar);
                    SqlParameter p3 = new SqlParameter("@Semester", SqlDbType.VarChar);
                    p1.Value = studentId;
                    p2.Value = courseNum;
                    p3.Value = courseOffered.Semester;
                    ParamList.Add(p1); ParamList.Add(p2); ParamList.Add(p3);
                    rows += _idac.InsertUpdateDelete(sql, ParamList);
                    IncrementEnrolledCount(courseNum);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return rows;

        }

        public bool IsCourseTaken(CoursesOffered courseoffered,string studentid)
        {
            List<StudentCourse> CTList = GetAllStudentCourses(studentid);
            foreach(StudentCourse sc in CTList)
            {
                if(sc.CourseNum == courseoffered.CourseNum)
                {
                    return true;
                }
            }
            return false;
        }
        public void IncrementEnrolledCount(string courseNum)
        {
            int rows = 0;
            try
            {
               string  sql = "update coursesoffered set enrolledcount = enrolledcount + 1 where courseNum = @courseNum";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@courseNum", SqlDbType.VarChar);
               
                p1.Value = courseNum;
                
                ParamList.Add(p1); 
                rows += _idac.InsertUpdateDelete(sql, ParamList);

            }
            catch(Exception)
            {
                throw;
            }
        }

        public int UnregisterForCourse(string courseNum)
        {
            int rows = 0;
            try
            {
                string sql = "Delete From StudentCourses where courseNum = @courseNum";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@courseNum", SqlDbType.VarChar);
                p1.Value = courseNum;
                ParamList.Add(p1);
                rows = _idac.InsertUpdateDelete(sql, ParamList);
                DecrementEnrolledCount(courseNum);
            }
            catch (Exception)
            {
                throw;
            }
            return rows;
        }
        public void DecrementEnrolledCount(string courseNum)
        {
            int rows = 0;
            try
            {
                string sql = "update coursesoffered set enrolledcount = enrolledcount - 1 where courseNum = @courseNum";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@courseNum", SqlDbType.VarChar);

                p1.Value = courseNum;

                ParamList.Add(p1);
                rows = _idac.InsertUpdateDelete(sql, ParamList);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
