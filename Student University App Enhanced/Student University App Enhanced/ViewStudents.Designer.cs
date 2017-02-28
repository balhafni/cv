namespace Student_University_App_Enhanced
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
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.Major = new System.Windows.Forms.Label();
            this.dropDown_majors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(17, 84);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(85, 23);
            this.btnViewStudents.TabIndex = 7;
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(234, 12);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.Size = new System.Drawing.Size(596, 150);
            this.dataGridStudents.TabIndex = 6;
            this.dataGridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellContentClick);
            // 
            // Major
            // 
            this.Major.AutoSize = true;
            this.Major.Location = new System.Drawing.Point(-85, 80);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(64, 13);
            this.Major.TabIndex = 5;
            this.Major.Text = "Department";
            // 
            // dropDown_majors
            // 
            this.dropDown_majors.FormattingEnabled = true;
            this.dropDown_majors.Location = new System.Drawing.Point(84, 34);
            this.dropDown_majors.Name = "dropDown_majors";
            this.dropDown_majors.Size = new System.Drawing.Size(121, 21);
            this.dropDown_majors.TabIndex = 4;
            this.dropDown_majors.SelectedIndexChanged += new System.EventHandler(this.dropDown_majors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Department";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.Major);
            this.Controls.Add(this.dropDown_majors);
            this.Name = "ViewStudents";
            this.Text = "ViewStudents";
            this.Load += new System.EventHandler(this.ViewStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.Label Major;
        private System.Windows.Forms.ComboBox dropDown_majors;
        private System.Windows.Forms.Label label1;
    }
}