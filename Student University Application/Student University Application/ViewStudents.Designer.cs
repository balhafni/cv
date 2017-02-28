namespace Student_University_Application
{
    partial class ViewStudents
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
            this.dropDown_majors = new System.Windows.Forms.ComboBox();
            this.Major = new System.Windows.Forms.Label();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.btnViewStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dropDown_majors
            // 
            this.dropDown_majors.FormattingEnabled = true;
            this.dropDown_majors.Location = new System.Drawing.Point(79, 44);
            this.dropDown_majors.Name = "dropDown_majors";
            this.dropDown_majors.Size = new System.Drawing.Size(121, 21);
            this.dropDown_majors.TabIndex = 0;
            // 
            // Major
            // 
            this.Major.AutoSize = true;
            this.Major.Location = new System.Drawing.Point(9, 47);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(64, 13);
            this.Major.TabIndex = 1;
            this.Major.Text = "Department";
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(229, 22);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.Size = new System.Drawing.Size(596, 150);
            this.dataGridStudents.TabIndex = 2;
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(12, 94);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(85, 23);
            this.btnViewStudents.TabIndex = 3;
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 201);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.Major);
            this.Controls.Add(this.dropDown_majors);
            this.Name = "ViewStudents";
            this.Text = "ViewStudents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropDown_majors;
        private System.Windows.Forms.Label Major;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.Button btnViewStudents;
    }
}