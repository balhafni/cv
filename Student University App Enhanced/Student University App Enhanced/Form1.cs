using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_University_App_Enhanced.BusinessLayer;
using System.IO;
using Student_University_App_Enhanced.Models;

namespace Student_University_App_Enhanced
{

    public partial class Form1 : Form
    {
        IBusinessStudent _ibusinessStudents = null;
        IBusinessDepartment _ibusinessDepartments = null;
        IBusinessProfessor _ibusinessProfessors = null;
        IBusinessStudentCourse _ibusinessStudentCourse = null;
        IBusinessStudentMajor _ibusinessStudentMajor = null;
        IBusinessCourseTaken _ibusinessCoursesTaken = null;
        IBusinessProfessorDepartment _ibusinessProfessorDepartmenets = null;
        IBusinessCoursesPrerequisite _ibusinessCoursesPrerequisites = null;
        IBusinessCourseOffered _ibusinessCoursesOffered = null;
        IBusinessCourse _ibusinessCourses = null;



        public Form1()
        {
            InitializeComponent();
            _ibusinessStudents = new Business() as IBusinessStudent;
            _ibusinessCourses = new Business() as IBusinessCourse;
            _ibusinessCoursesOffered = new Business() as IBusinessCourseOffered;
            _ibusinessCoursesTaken = new Business() as IBusinessCourseTaken;
            _ibusinessCoursesPrerequisites = new Business() as IBusinessCoursesPrerequisite;
            _ibusinessDepartments = new Business() as IBusinessDepartment;
            _ibusinessProfessorDepartmenets = new Business() as IBusinessProfessorDepartment;
            _ibusinessProfessors = new Business() as IBusinessProfessor;
            _ibusinessStudentCourse = new Business() as IBusinessStudentCourse;
            _ibusinessStudentMajor = new Business() as IBusinessStudentMajor;

        }
        public List<string[]> Read()
        {
            OpenFileDialog fileDialog;
            string fileName;
            FileInfo finfo;
            Stream stream;
            StreamReader reader = null;
            char[] sep = { ',' };
            List<string[]> InfoList = new List<string[]>();
            string[] info = null;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    finfo = new FileInfo(fileName);
                    stream = finfo.Open(FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream);
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (line == null)
                        {
                            break;
                        }
                        info = line.Split(sep);
                        InfoList.Add(info);
                        line = reader.ReadLine();
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return InfoList;
        }

        private void menuItem_PopStudents_Click(object sender, EventArgs e)
        {
            List<Student> SList = new List<Student>();
            try
            {
                SList = _ibusinessStudents.ReadStudents(Read());
                int rows = 0;
                foreach (Student st in SList)
                {
                    rows += _ibusinessStudents.AddStudent(st);

                }
                MessageBox.Show(rows + " were added to the student table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void menuItem_PopDepts_Click(object sender, EventArgs e)
        {
            List<Department> DList = new List<Department>();
            try
            {
                DList = _ibusinessDepartments.ReadDepartments(Read());
                int rows = 0;
                foreach (Department dt in DList)
                {
                    rows += _ibusinessDepartments.AddDepartment(dt);
                }
                MessageBox.Show(rows + " were added to the department table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItem_popProfs_Click(object sender, EventArgs e)
        {
            List<Professor> PList = new List<Professor>();
            try
            {
                PList = _ibusinessProfessors.ReadProfessors(Read());
                int rows = 0;
                foreach (Professor p in PList)
                {
                    rows += _ibusinessProfessors.AddProfessor(p);
                }
                MessageBox.Show(rows + " were added to the professors table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItem_PopCourses_Click(object sender, EventArgs e)
        {
            List<Course> CList = new List<Course>();
            try
            {
                CList = _ibusinessCourses.ReadCourses(Read());
                int rows = 0;
                foreach (Course c in CList)
                {
                    rows += _ibusinessCourses.AddCourse(c);
                }
                MessageBox.Show(rows + " were added to the Courses table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItem_PopPreReqs_Click(object sender, EventArgs e)
        {
            List<CoursePrerequisite> CPList = new List<CoursePrerequisite>();
            try
            {
                CPList = _ibusinessCoursesPrerequisites.ReadCoursePrerequisites(Read());
                int rows = 0;
                foreach (CoursePrerequisite cp in CPList)
                {
                    rows += _ibusinessCoursesPrerequisites.AddCoursePrequisite(cp);
                }
                MessageBox.Show(rows + " were added to the CoursePrerequisites table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItem_popCoursesOffered_Click(object sender, EventArgs e)
        {
            List<CoursesOffered> COList = new List<CoursesOffered>();
            try
            {
                COList = _ibusinessCoursesOffered.ReadCourseOffered(Read());
                int rows = 0;
                foreach (CoursesOffered co in COList)
                {
                    rows += _ibusinessCoursesOffered.AddCourseOffered(co);
                }
                MessageBox.Show(rows + " were added to the CoursesOffered table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItem_PopCoursesTaken_Click(object sender, EventArgs e)
        {
            List<CoursesTaken> CTList = new List<CoursesTaken>();
            try
            {
                CTList = _ibusinessCoursesTaken.ReadCourseTaken(Read());
                int rows = 0;
                foreach (CoursesTaken ct in CTList)
                {
                    rows += _ibusinessCoursesTaken.AddCourseTaken(ct);
                }
                MessageBox.Show(rows + " were added to the CoursesTaken table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItem_popStudentCourses_Click(object sender, EventArgs e)
        {
            List<StudentCourse> SCList = new List<StudentCourse>();
            try
            {
                SCList = _ibusinessStudentCourse.ReadStudentCourses(Read());
                int rows = 0;
                foreach (StudentCourse sc in SCList)
                {
                    rows += _ibusinessStudentCourse.AddStudentCourse(sc);
                }
                if(rows <= 0)
                {
                    MessageBox.Show( " no new rows were added to the StudentCourses table");
                }
                else
                {
                    MessageBox.Show(rows + " rows were added to the StudentCourses table");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItem_popStudentMajors_Click(object sender, EventArgs e)
        {
            List<StudentMajor> SMList = new List<StudentMajor>();
            try
            {
                SMList = _ibusinessStudentMajor.ReadStudentMajor(Read());
                int rows = 0;
                foreach (StudentMajor sc in SMList)
                {
                    rows += _ibusinessStudentMajor.AddStudentMajor(sc);
                }
                MessageBox.Show(rows + " were added to the StudentMajors table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItem_popProfDepts_Click(object sender, EventArgs e)
        {
            List<ProfessorDepartment> PDList = new List<ProfessorDepartment>();
            try
            {
                PDList = _ibusinessProfessorDepartmenets.ReadProfessorDepartment(Read());
                int rows = 0;
                foreach (ProfessorDepartment pd in PDList)
                {
                    rows += _ibusinessProfessorDepartmenets.AddProfessorDepartment(pd);
                }
                MessageBox.Show(rows + " were added to the ProfessorDepartments table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudents form = new ViewStudents();
            form.ShowDialog();
        }

        private void viewStudentsGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewGrades form = new ViewGrades();
            form.ShowDialog();
        }

        private void viewCoursesOfferedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCoursesOffered form = new ViewCoursesOffered();
            form.ShowDialog();
        }

        private void viewEnrollmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEnrollements form = new ViewEnrollements();
            form.ShowDialog();
        }

        private void viewStudentGradesAndGPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentGradesAndGPA form = new ViewStudentGradesAndGPA();
            form.ShowDialog();
        }

        private void viewCoursesTakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCoursesTaken form = new ViewCoursesTaken();
            form.ShowDialog();
        }

        private void registerForACourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();

        }

        private void unregisterForACourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnregisterForACourseForm form = new UnregisterForACourseForm();
            form.ShowDialog();
        }
    }
}

