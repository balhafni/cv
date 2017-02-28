using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_University_Application
{
    public partial class Main : Form
    {
        OpenFileDialog fileDialog;
        string fileName;
        FileInfo finfo;
        Stream stream;
        StreamReader reader;
        char[] sep = { ',' };
        string sql;
        int rowsModified;
        public Main()
        {
            InitializeComponent();
        }
        //Students
        private void menuItem_PopStudents_Click(object sender, EventArgs e)
        {
            rowsModified = 0;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                   
                    if(!fileName.Contains("Students"))
                    {
                        MessageBox.Show("Please select the Students file!!");
                        return;
                    }
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
                        string[] info = line.Split(sep);
                        try
                        {
                            sql = "select count(*) from students where studentid like '" + info[0] + "'";
                            if (DataAccess.CheckExistence(sql) == 0)
                            {
                                //insert to students table
                                sql = "insert into Students Values ('" + info[0] + "','" + info[1] + "','" + info[2] + "','" + info[3]
                                    + "','" + info[4] + "','" + info[5] + "','" + info[6] + "')";
                            }
                            else
                            {
                                sql = "update students set firstname = '" + info[1] + "'" +
                                    ", lastname = '" + info[2] + "'" + ", streetaddress = '" + info[3] + "'" + ",city = '" + info[4] + "'" +
                                    ", state = '" + info[5] + "'" + ", telephone = '" + info[6] + "' where studentid = '" + info[0] + "'";
                            }

                            rowsModified += DataAccess.InsertUpdateDelete(sql);
                            line = reader.ReadLine();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Please select the Students file!!");
                            break;
                        }
                        
                    }
                    reader.Close();
                    
                    MessageBox.Show(rowsModified.ToString() + " Rows were added to the Students table");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        //Departments
        private void menuItem_PopDepts_Click(object sender, EventArgs e)
        {
            rowsModified = 0;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    if(!fileName.Contains("Departments"))
                    {
                        MessageBox.Show("Please select the Departments file!!");
                        return;
                    }
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
                        string[] info = line.Split(sep);
                      
                            sql = "select count(*) from Departments where DepartmentId like '" + int.Parse(info[0]) + "'";
                            if (DataAccess.CheckExistence(sql) == 0)
                            {

                                sql = "insert into Departments Values ('" + int.Parse(info[0]) + "','" + info[1] + "')";
                            }
                            else
                            {
                                sql = "update Departments set DepartmentName = '" + info[1] + "' where DepartmentId = '" + int.Parse(info[0]) + "'";
                            }

                            rowsModified += DataAccess.InsertUpdateDelete(sql);
                            line = reader.ReadLine();
                       
                    }
                    reader.Close();
                    MessageBox.Show(rowsModified.ToString() + " Rows were added to the Departments table");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Professors
        private void menuItem_popProfs_Click(object sender, EventArgs e)
        {
            rowsModified = 0;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    if (!fileName.Contains( "Professors"))
                    {
                        MessageBox.Show("Please Select the Professors file!!");
                        return;
                    }
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
                        string[] info = line.Split(sep);
                        
                            sql = "select count(*) from Professors where ProfessorID like '" + info[0] + "'";
                            if (DataAccess.CheckExistence(sql) == 0)
                            {

                                sql = "insert into Professors Values ('" + info[0] + "','" + info[1] + "','" + info[2] + "','" + info[3]
                                + "','" + info[4] + "','" + info[5] + "','" + info[6] + "')";
                            }
                            else
                            {
                                sql = "update professors set firstname = '" + info[1] + "'" +
                                    ", lastname = '" + info[2] + "'" + ", streetaddress = '" + info[3] + "'" + ",city = '" + info[4] + "'" +
                                    ", state = '" + info[5] + "'" + ", telephone = '" + info[6] + "' where professorid = '" + info[0] + "'";
                            }

                            rowsModified += DataAccess.InsertUpdateDelete(sql);
                            line = reader.ReadLine();
                        }
                        
                    }
                    reader.Close();
                    MessageBox.Show(rowsModified.ToString() + " Rows were added to the Professors table");

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Courses
        private void menuItem_PopCourses_Click(object sender, EventArgs e)
        {
            rowsModified = 0;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    if(!fileName.Contains( "Courses"))
                    {
                        MessageBox.Show("Please select the Courses File!");
                            return;
                    }
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
                        string[] info = line.Split(sep);
                       
                            sql = "select count(*) from Courses where courseNum like '" + info[0] + "'";
                            if (DataAccess.CheckExistence(sql) == 0)
                            {
                                sql = "insert into Courses Values ('" + info[0] + "','" + info[1] + "','" + int.Parse(info[2]) + "','" + info[3]
                             + "','" + int.Parse(info[4]) + "')";

                            }
                            else
                            {
                                sql = "update courses set coursename = '" + info[1] + "'" +
                                    ", CreditHours = '" + int.Parse(info[2]) + "'" + ", description = '" + info[3] + "'" + ",departmentid = '" + int.Parse(info[4]) + "'" +
                                     " where courseNum = '" + info[0] + "'";
                            }
                            rowsModified += DataAccess.InsertUpdateDelete(sql);
                        line = reader.ReadLine();
                        
                    }
                    reader.Close();
                    MessageBox.Show(rowsModified.ToString() + " Rows were added to the Courses table");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        //Courses Prereq
        
        private void menuItem_PopPreReqs_Click(object sender, EventArgs e)
        {
            rowsModified = 0;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    if(!fileName.Contains( "CoursePrerequisites"))
                    {
                        MessageBox.Show("Please select the Course Prerequisites file!");
                        return;
                    }
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
                        string[] info = line.Split(sep);
                        
                            sql = "select count(*) from CoursePrerequisites where courseNum like '" + info[0] +
                            "' And prereqcoursenum like '" + info[1] + "'";
                            if (DataAccess.CheckExistence(sql) == 0)
                            {
                                sql = "insert into CoursePrerequisites Values ('" + info[0] + "','" + info[1] + "')";

                            }

                            rowsModified += DataAccess.InsertUpdateDelete(sql);
                            line = reader.ReadLine();

                      
                        
                    }
                    reader.Close();
                    if(rowsModified>0)
                        MessageBox.Show(rowsModified.ToString() + " Rows were added to the CoursePrerequisites table");
                    else
                        MessageBox.Show(" No new rows were added to the CoursePrerequisites table");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Courses Offered
        private void menuItem_popCoursesOffered_Click(object sender, EventArgs e)
        {
            rowsModified = 0;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    if(!fileName.Contains( "CoursesOffered"))
                    {
                        MessageBox.Show("Please select the CoursesOffered file!");
                        return;
                    }
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
                        string[] info = line.Split(sep);
                      
                            sql = "select count(*) from CoursesOffered where courseNum like '" + info[0] + 
                                "' And semester like '"+info[1]+"'";
                            if (DataAccess.CheckExistence(sql) == 0)
                            {
                                sql = "insert into CoursesOffered Values ('" + info[0] + "','" + info[1] + "','" + int.Parse(info[2]) + "','" +
                                int.Parse(info[3]) + "','" + info[4] + "','" + int.Parse(info[5]) + "')";

                            }
                            else
                            {
                                sql = "update coursesoffered set maxenrollment = '" + int.Parse(info[2]) + "', enrolledcount = '" + int.Parse(info[3]) + "', roomnumber = '" +
                                    info[4] + "', professorid = '" + info[5] + "' where courseNum = '" + info[0] +
                                    "' and semester = '" + info[1] + "'";

                            }

                            rowsModified += DataAccess.InsertUpdateDelete(sql);
                            line = reader.ReadLine();
                      
                     
                      
                    }
                    reader.Close();
                    MessageBox.Show(rowsModified.ToString() + " Rows were added to the CoursesOffered table");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Courses Taken
        private void menuItem_PopCoursesTaken_Click(object sender, EventArgs e)
        {
            rowsModified = 0;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    if(!fileName.Contains( "CoursesTaken"))
                    {
                        MessageBox.Show("Please select the CoursesTaken file!!");
                        return;
                    }
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
                        string[] info = line.Split(sep);
                        

                            sql = "select count(*) from CoursesTaken where studentid like '" + info[0] + 
                                "' AND coursenum like '"+info[1]+"' AND Semester like '"+info[2]+"'" ;
                            if (DataAccess.CheckExistence(sql) == 0)
                            {
                                sql = "insert into CoursesTaken Values ('" + info[0] + "','" + info[1] + "','" + info[2] + "','" +
                                 info[3] + "')";

                            }
                            else
                            {
                                sql = "update CoursesTaken set  grade = '" + info[3]
                                    + "' where studentid = '" + info[0] + "' And coursenum = '" + info[1] + "'" +
                                    " And semester = '" + info[2] + "'";

                            }

                            rowsModified += DataAccess.InsertUpdateDelete(sql);
                            line = reader.ReadLine();
                      
                     
                       
                    }
                    reader.Close();
                    MessageBox.Show(rowsModified.ToString() + " Rows were added to the CoursesTaken table");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Student Courses
        private void menuItem_popStudentCourses_Click(object sender, EventArgs e)
        {
            rowsModified = 0;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    if(!fileName.Contains("StudentCourses"))
                    {
                        MessageBox.Show("Please select the StudentCourses file!");
                        return;
                    }
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
                        string[] info = line.Split(sep);
                        
                                sql = "select count(*) from StudentCourses where studentid like '" + info[0] + 
                                    "'And CourseNum like '"+info[1]+"' And Semester like '"+info[2]+"'";
                            if (DataAccess.CheckExistence(sql) == 0)
                            {
                                sql = "insert into StudentCourses Values ('" + info[0] + "','" + info[1] + "','" + info[2] + "')";

                            }

                            rowsModified += DataAccess.InsertUpdateDelete(sql);
                            line = reader.ReadLine();

                    }
                    reader.Close();
                    if(rowsModified > 0)
                        MessageBox.Show(rowsModified.ToString() + " Rows were added to the StudentCourses table");
                    else
                        MessageBox.Show(" No new rows were added to the StudentCourses table");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Student Majors
        private void menuItem_popStudentMajors_Click(object sender, EventArgs e)
        {
            rowsModified = 0;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    if(!fileName.Contains("StudentMajors"))
                    {
                        MessageBox.Show("Please select the Student Majors file!");
                        return;
                    }
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
                        string[] info = line.Split(sep);
                      
                       
                            sql = "select count(*) from StudentMajors   where studentid like '" + info[0] +
                                "' And departmentid like '" + int.Parse(info[1]) +"'";
                            if (DataAccess.CheckExistence(sql) == 0)
                            {
                                sql = "insert into StudentMajors Values ('" + info[0] + "','" + int.Parse(info[1]) + "')";

                            }
                          

                            rowsModified += DataAccess.InsertUpdateDelete(sql);
                            line = reader.ReadLine();
                      
                        
                      
                    }
                    reader.Close();
                    if(rowsModified>0)
                        MessageBox.Show(rowsModified.ToString() + " Rows were added to the StudentMajors table");
                    else
                        MessageBox.Show(" No new rows were added to the StudentMajors table");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Professors Departments
        private void menuItem_popProfDepts_Click(object sender, EventArgs e)
        {
            rowsModified = 0;
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    if(!fileName.Contains( "ProfessorDepartments"))
                    {
                        MessageBox.Show("Please select the ProfessorDepartments");
                        return;
                    }
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
                        string[] info = line.Split(sep);

                        
                            sql = "select count(*) from ProfessorDepartments   where professorid like '" + int.Parse(info[0]) +
                                "' And DepartmentId like '" + int.Parse(info[1]) +"'";
                            if (DataAccess.CheckExistence(sql) == 0)
                            {
                                sql = "insert into ProfessorDepartments Values ('" + int.Parse(info[0]) + "','" + int.Parse(info[1]) + "')";
                            }

                            rowsModified += DataAccess.InsertUpdateDelete(sql);
                            line = reader.ReadLine();    
                     
                    }
                    reader.Close();
                    if(rowsModified >0)
                        MessageBox.Show(rowsModified.ToString() + " Rows were added to the ProfessorDepartments table");
                    else
                        MessageBox.Show(" No New Rows were added to the ProfessorDepartments table");
                }
            }
            catch (FileNotFoundException ex)
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
            CoursesOffered form = new CoursesOffered();
            form.ShowDialog();
        }

        private void viewEnrollmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEnrollement form = new ViewEnrollement();
            form.ShowDialog();
        }
    }
}
