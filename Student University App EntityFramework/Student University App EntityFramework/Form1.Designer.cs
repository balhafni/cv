namespace Student_University_App_EntityFramework
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
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCoursesOfferedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEnrollmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentManagementToolStripMenuItem,
            this.courseManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentsToolStripMenuItem,
            this.viewStudentsGradesToolStripMenuItem});
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewStudentsToolStripMenuItem.Text = "View Students";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // viewStudentsGradesToolStripMenuItem
            // 
            this.viewStudentsGradesToolStripMenuItem.Name = "viewStudentsGradesToolStripMenuItem";
            this.viewStudentsGradesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewStudentsGradesToolStripMenuItem.Text = "View Students Grades";
            this.viewStudentsGradesToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsGradesToolStripMenuItem_Click);
            // 
            // courseManagementToolStripMenuItem
            // 
            this.courseManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCoursesOfferedToolStripMenuItem,
            this.viewEnrollmenToolStripMenuItem});
            this.courseManagementToolStripMenuItem.Name = "courseManagementToolStripMenuItem";
            this.courseManagementToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.courseManagementToolStripMenuItem.Text = "Course Management";
            // 
            // viewCoursesOfferedToolStripMenuItem
            // 
            this.viewCoursesOfferedToolStripMenuItem.Name = "viewCoursesOfferedToolStripMenuItem";
            this.viewCoursesOfferedToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewCoursesOfferedToolStripMenuItem.Text = "View Courses Offered";
            // 
            // viewEnrollmenToolStripMenuItem
            // 
            this.viewEnrollmenToolStripMenuItem.Name = "viewEnrollmenToolStripMenuItem";
            this.viewEnrollmenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewEnrollmenToolStripMenuItem.Text = "View Enrollments";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 261);
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
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsGradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCoursesOfferedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEnrollmenToolStripMenuItem;
    }
}

