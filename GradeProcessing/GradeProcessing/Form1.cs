using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeProcessing
{
    public partial class Form1 : Form
    {
        List<Student> list_students;
        string gradeFile;
        AddStudent addForm = new AddStudent();

        public Student this[int id]
        {
            get
            {
                Student stFound = null;
                foreach (Student st in list_students)
                {
                    if(st.Id == id)
                    {
                        stFound = st;
                        break;
                    }
                }
                return stFound;
            }
            
        }
        public Form1()
        {
            InitializeComponent();
            list_students = new List<Student>();
        }


        private void readStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\Users";
                fileDialog.Filter = "text files |*.txt|docx file|*.doc";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    String fileName = fileDialog.FileName;
                    FileInfo finfo = new FileInfo(fileName);
                    Stream stream = finfo.Open(FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(stream);
                    String line = reader.ReadLine();
                    char[] sep = { ',' };

                    while (line != null)
                    {
                        Student st = new Student();
                        String[] info = line.Split(sep);
                        st.Id = int.Parse(info[0]);
                        st.FirstName = info[1];
                        st.LastName = info[2];
                        st.Test1 = double.Parse(info[3]);
                        st.Test2 = double.Parse(info[4]);
                        st.Student_Major = (Major)Enum.Parse(typeof(Major), info[5], true);
                        st.Student_Level = (Level)Enum.Parse(typeof(Level), info[6], true);
                        list_students.Add(st);
                        line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }
                        if (line.Trim() == "")
                        {
                            break;
                        }
                    }

                    dataGrid_students.DataSource = list_students;
                    dataGrid_students.Refresh();
                    reader.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }




        private void processAndSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.Filter = "text files |*.txt| docx files|*.doc";
            try
            {


                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    gradeFile = dialog.FileName;
                    FileInfo finfo = new FileInfo(gradeFile);
                    Stream stream = finfo.Open(FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    foreach (Student st in list_students)
                    {
                        writer.WriteLine(st.ToString());
                    }
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Student st = addForm.Student_Info;
                if (st != null)
                {
                    if (this[st.Id] == null)
                    {
                        list_students.Add(st);
                        MessageBox.Show("The students has been added to the database");
                    }
                    else
                    {
                        MessageBox.Show("The student with the specified id already exist!!");
                    }
                }
            }
        }

        public List<Student> List_Students
        {
            get { return list_students; }
            set { list_students = value; }
        }

        private void dispalyGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(gradeFile);
                FileInfo finfo = new FileInfo(gradeFile);
                Stream str = finfo.Open(FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(str);
                String line = reader.ReadLine();
                char[] sep = { ',' };
                List<Results> grades = new List<Results>();
                while (line != null)
                {
                    Results res = new Results();
                    string[] info = line.Split(sep);
                    res.Id = int.Parse(info[0]);
                    res.LastName = info[1];
                    res.Major = (Major)Enum.Parse(typeof(Major), info[2], true);
                    res.Grade = info[3];
                    grades.Add(res);
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (line.Trim() == "")
                    {
                        break;
                    }

                }
                dataGrid_students.DataSource = grades;
                dataGrid_students.Refresh();
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
