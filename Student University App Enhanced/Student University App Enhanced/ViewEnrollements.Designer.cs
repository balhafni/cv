namespace Student_University_App_Enhanced
{
    partial class ViewEnrollements
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.courses_dropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.semester_dropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(305, 27);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(447, 150);
            this.dataGrid.TabIndex = 11;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(37, 195);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(115, 23);
            this.btnEnroll.TabIndex = 10;
            this.btnEnroll.Text = "View Enrollments";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Courses Offered";
            // 
            // courses_dropDown
            // 
            this.courses_dropDown.FormattingEnabled = true;
            this.courses_dropDown.Location = new System.Drawing.Point(127, 103);
            this.courses_dropDown.Name = "courses_dropDown";
            this.courses_dropDown.Size = new System.Drawing.Size(149, 21);
            this.courses_dropDown.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Semester";
            // 
            // semester_dropDown
            // 
            this.semester_dropDown.FormattingEnabled = true;
            this.semester_dropDown.Location = new System.Drawing.Point(127, 27);
            this.semester_dropDown.Name = "semester_dropDown";
            this.semester_dropDown.Size = new System.Drawing.Size(149, 21);
            this.semester_dropDown.TabIndex = 6;
            this.semester_dropDown.SelectionChangeCommitted += new System.EventHandler(this.semester_dropDown_SelectionChangeCommitted);
            // 
            // ViewEnrollements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 261);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courses_dropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.semester_dropDown);
            this.Name = "ViewEnrollements";
            this.Text = "ViewEnrollements";
            this.Load += new System.EventHandler(this.ViewEnrollements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox courses_dropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox semester_dropDown;
    }
}