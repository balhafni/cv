namespace Student_University_App_Enhanced
{
    partial class ViewCoursesOffered
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
            this.btnOfferedCourses = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.semesterDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOfferedCourses
            // 
            this.btnOfferedCourses.Location = new System.Drawing.Point(87, 86);
            this.btnOfferedCourses.Name = "btnOfferedCourses";
            this.btnOfferedCourses.Size = new System.Drawing.Size(124, 23);
            this.btnOfferedCourses.TabIndex = 7;
            this.btnOfferedCourses.Text = "View Offered Courses";
            this.btnOfferedCourses.UseVisualStyleBackColor = true;
            this.btnOfferedCourses.Click += new System.EventHandler(this.btnOfferedCourses_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(289, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(400, 124);
            this.dataGrid.TabIndex = 6;
            // 
            // semesterDropDown
            // 
            this.semesterDropDown.FormattingEnabled = true;
            this.semesterDropDown.Location = new System.Drawing.Point(87, 32);
            this.semesterDropDown.Name = "semesterDropDown";
            this.semesterDropDown.Size = new System.Drawing.Size(144, 21);
            this.semesterDropDown.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Semester";
            // 
            // ViewCoursesOffered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 261);
            this.Controls.Add(this.btnOfferedCourses);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.semesterDropDown);
            this.Controls.Add(this.label1);
            this.Name = "ViewCoursesOffered";
            this.Text = "ViewCoursesOffered";
            this.Load += new System.EventHandler(this.ViewCoursesOffered_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOfferedCourses;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ComboBox semesterDropDown;
        private System.Windows.Forms.Label label1;
    }
}