namespace Student_University_App_Enhanced
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.initialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_PopStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_PopDepts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_popProfs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_PopCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_PopPreReqs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_popCoursesOffered = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_PopCoursesTaken = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_popStudentCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_popStudentMajors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_popProfDepts = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCoursesOfferedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEnrollmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentGradesAndGPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCoursesTakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerForACourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unregisterForACourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initialToolStripMenuItem,
            this.studentManagementToolStripMenuItem,
            this.courseManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // initialToolStripMenuItem
            // 
            this.initialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_PopStudents,
            this.menuItem_PopDepts,
            this.menuItem_popProfs,
            this.menuItem_PopCourses,
            this.menuItem_PopPreReqs,
            this.menuItem_popCoursesOffered,
            this.menuItem_PopCoursesTaken,
            this.menuItem_popStudentCourses,
            this.menuItem_popStudentMajors,
            this.menuItem_popProfDepts});
            this.initialToolStripMenuItem.Name = "initialToolStripMenuItem";
            this.initialToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.initialToolStripMenuItem.Text = "InitializeDB";
            // 
            // menuItem_PopStudents
            // 
            this.menuItem_PopStudents.Name = "menuItem_PopStudents";
            this.menuItem_PopStudents.Size = new System.Drawing.Size(241, 22);
            this.menuItem_PopStudents.Text = "Populate Students";
            this.menuItem_PopStudents.Click += new System.EventHandler(this.menuItem_PopStudents_Click);
            // 
            // menuItem_PopDepts
            // 
            this.menuItem_PopDepts.Name = "menuItem_PopDepts";
            this.menuItem_PopDepts.Size = new System.Drawing.Size(241, 22);
            this.menuItem_PopDepts.Text = "Populate Departments";
            this.menuItem_PopDepts.Click += new System.EventHandler(this.menuItem_PopDepts_Click);
            // 
            // menuItem_popProfs
            // 
            this.menuItem_popProfs.Name = "menuItem_popProfs";
            this.menuItem_popProfs.Size = new System.Drawing.Size(241, 22);
            this.menuItem_popProfs.Text = "Populate Professors";
            this.menuItem_popProfs.Click += new System.EventHandler(this.menuItem_popProfs_Click);
            // 
            // menuItem_PopCourses
            // 
            this.menuItem_PopCourses.Name = "menuItem_PopCourses";
            this.menuItem_PopCourses.Size = new System.Drawing.Size(241, 22);
            this.menuItem_PopCourses.Text = "Populate Courses";
            this.menuItem_PopCourses.Click += new System.EventHandler(this.menuItem_PopCourses_Click);
            // 
            // menuItem_PopPreReqs
            // 
            this.menuItem_PopPreReqs.Name = "menuItem_PopPreReqs";
            this.menuItem_PopPreReqs.Size = new System.Drawing.Size(241, 22);
            this.menuItem_PopPreReqs.Text = "Populate CoursePrerequisites";
            this.menuItem_PopPreReqs.Click += new System.EventHandler(this.menuItem_PopPreReqs_Click);
            // 
            // menuItem_popCoursesOffered
            // 
            this.menuItem_popCoursesOffered.Name = "menuItem_popCoursesOffered";
            this.menuItem_popCoursesOffered.Size = new System.Drawing.Size(241, 22);
            this.menuItem_popCoursesOffered.Text = "Populate CoursesOffered";
            this.menuItem_popCoursesOffered.Click += new System.EventHandler(this.menuItem_popCoursesOffered_Click);
            // 
            // menuItem_PopCoursesTaken
            // 
            this.menuItem_PopCoursesTaken.Name = "menuItem_PopCoursesTaken";
            this.menuItem_PopCoursesTaken.Size = new System.Drawing.Size(241, 22);
            this.menuItem_PopCoursesTaken.Text = "Populate CoursesTaken";
            this.menuItem_PopCoursesTaken.Click += new System.EventHandler(this.menuItem_PopCoursesTaken_Click);
            // 
            // menuItem_popStudentCourses
            // 
            this.menuItem_popStudentCourses.Name = "menuItem_popStudentCourses";
            this.menuItem_popStudentCourses.Size = new System.Drawing.Size(241, 22);
            this.menuItem_popStudentCourses.Text = "Populate StudentCourses";
            this.menuItem_popStudentCourses.Click += new System.EventHandler(this.menuItem_popStudentCourses_Click);
            // 
            // menuItem_popStudentMajors
            // 
            this.menuItem_popStudentMajors.Name = "menuItem_popStudentMajors";
            this.menuItem_popStudentMajors.Size = new System.Drawing.Size(241, 22);
            this.menuItem_popStudentMajors.Text = "Populate StudentMajors";
            this.menuItem_popStudentMajors.Click += new System.EventHandler(this.menuItem_popStudentMajors_Click);
            // 
            // menuItem_popProfDepts
            // 
            this.menuItem_popProfDepts.Name = "menuItem_popProfDepts";
            this.menuItem_popProfDepts.Size = new System.Drawing.Size(241, 22);
            this.menuItem_popProfDepts.Text = "Populate ProfessorDepartments";
            this.menuItem_popProfDepts.Click += new System.EventHandler(this.menuItem_popProfDepts_Click);
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentsToolStripMenuItem,
            this.viewStudentsGradesToolStripMenuItem,
            this.viewStudentGradesAndGPAToolStripMenuItem,
            this.viewCoursesTakenToolStripMenuItem});
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.viewStudentsToolStripMenuItem.Text = "View Students";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // viewStudentsGradesToolStripMenuItem
            // 
            this.viewStudentsGradesToolStripMenuItem.Name = "viewStudentsGradesToolStripMenuItem";
            this.viewStudentsGradesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.viewStudentsGradesToolStripMenuItem.Text = "View Students Grades";
            this.viewStudentsGradesToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsGradesToolStripMenuItem_Click);
            // 
            // courseManagementToolStripMenuItem
            // 
            this.courseManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCoursesOfferedToolStripMenuItem,
            this.viewEnrollmenToolStripMenuItem,
            this.registerForACourseToolStripMenuItem,
            this.unregisterForACourseToolStripMenuItem});
            this.courseManagementToolStripMenuItem.Name = "courseManagementToolStripMenuItem";
            this.courseManagementToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.courseManagementToolStripMenuItem.Text = "Course Management";
            // 
            // viewCoursesOfferedToolStripMenuItem
            // 
            this.viewCoursesOfferedToolStripMenuItem.Name = "viewCoursesOfferedToolStripMenuItem";
            this.viewCoursesOfferedToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewCoursesOfferedToolStripMenuItem.Text = "View Courses Offered";
            this.viewCoursesOfferedToolStripMenuItem.Click += new System.EventHandler(this.viewCoursesOfferedToolStripMenuItem_Click);
            // 
            // viewEnrollmenToolStripMenuItem
            // 
            this.viewEnrollmenToolStripMenuItem.Name = "viewEnrollmenToolStripMenuItem";
            this.viewEnrollmenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewEnrollmenToolStripMenuItem.Text = "View Enrollments";
            this.viewEnrollmenToolStripMenuItem.Click += new System.EventHandler(this.viewEnrollmenToolStripMenuItem_Click);
            // 
            // viewStudentGradesAndGPAToolStripMenuItem
            // 
            this.viewStudentGradesAndGPAToolStripMenuItem.Name = "viewStudentGradesAndGPAToolStripMenuItem";
            this.viewStudentGradesAndGPAToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.viewStudentGradesAndGPAToolStripMenuItem.Text = "View Student Grades and GPA";
            this.viewStudentGradesAndGPAToolStripMenuItem.Click += new System.EventHandler(this.viewStudentGradesAndGPAToolStripMenuItem_Click);
            // 
            // viewCoursesTakenToolStripMenuItem
            // 
            this.viewCoursesTakenToolStripMenuItem.Name = "viewCoursesTakenToolStripMenuItem";
            this.viewCoursesTakenToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.viewCoursesTakenToolStripMenuItem.Text = "View Courses Taken";
            this.viewCoursesTakenToolStripMenuItem.Click += new System.EventHandler(this.viewCoursesTakenToolStripMenuItem_Click);
            // 
            // registerForACourseToolStripMenuItem
            // 
            this.registerForACourseToolStripMenuItem.Name = "registerForACourseToolStripMenuItem";
            this.registerForACourseToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.registerForACourseToolStripMenuItem.Text = "Register for a course";
            this.registerForACourseToolStripMenuItem.Click += new System.EventHandler(this.registerForACourseToolStripMenuItem_Click);
            // 
            // unregisterForACourseToolStripMenuItem
            // 
            this.unregisterForACourseToolStripMenuItem.Name = "unregisterForACourseToolStripMenuItem";
            this.unregisterForACourseToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.unregisterForACourseToolStripMenuItem.Text = "Unregister for a course";
            this.unregisterForACourseToolStripMenuItem.Click += new System.EventHandler(this.unregisterForACourseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 261);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem initialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_PopStudents;
        private System.Windows.Forms.ToolStripMenuItem menuItem_PopDepts;
        private System.Windows.Forms.ToolStripMenuItem menuItem_popProfs;
        private System.Windows.Forms.ToolStripMenuItem menuItem_PopCourses;
        private System.Windows.Forms.ToolStripMenuItem menuItem_PopPreReqs;
        private System.Windows.Forms.ToolStripMenuItem menuItem_popCoursesOffered;
        private System.Windows.Forms.ToolStripMenuItem menuItem_PopCoursesTaken;
        private System.Windows.Forms.ToolStripMenuItem menuItem_popStudentCourses;
        private System.Windows.Forms.ToolStripMenuItem menuItem_popStudentMajors;
        private System.Windows.Forms.ToolStripMenuItem menuItem_popProfDepts;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsGradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCoursesOfferedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEnrollmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentGradesAndGPAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCoursesTakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerForACourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unregisterForACourseToolStripMenuItem;
    }
}

