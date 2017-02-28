namespace Student_University_App_EntityFramework
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.dropDown_majors = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Department";
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(13, 93);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(85, 23);
            this.btnViewStudents.TabIndex = 11;
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(230, 21);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.Size = new System.Drawing.Size(596, 150);
            this.dataGridStudents.TabIndex = 10;
            // 
            // dropDown_majors
            // 
            this.dropDown_majors.FormattingEnabled = true;
            this.dropDown_majors.Location = new System.Drawing.Point(80, 43);
            this.dropDown_majors.Name = "dropDown_majors";
            this.dropDown_majors.Size = new System.Drawing.Size(121, 21);
            this.dropDown_majors.TabIndex = 9;
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.dropDown_majors);
            this.Name = "ViewStudents";
            this.Text = "ViewStudents";
            this.Load += new System.EventHandler(this.ViewStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.ComboBox dropDown_majors;
    }
}