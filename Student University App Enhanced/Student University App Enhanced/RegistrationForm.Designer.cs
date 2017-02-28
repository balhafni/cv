namespace Student_University_App_Enhanced
{
    partial class RegistrationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.courses_dropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.semester_dropDown = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstudentID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Courses Offered";
            // 
            // courses_dropDown
            // 
            this.courses_dropDown.FormattingEnabled = true;
            this.courses_dropDown.Location = new System.Drawing.Point(123, 109);
            this.courses_dropDown.Name = "courses_dropDown";
            this.courses_dropDown.Size = new System.Drawing.Size(149, 21);
            this.courses_dropDown.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Semester";
            // 
            // semester_dropDown
            // 
            this.semester_dropDown.FormattingEnabled = true;
            this.semester_dropDown.Location = new System.Drawing.Point(123, 33);
            this.semester_dropDown.Name = "semester_dropDown";
            this.semester_dropDown.Size = new System.Drawing.Size(149, 21);
            this.semester_dropDown.TabIndex = 10;
            this.semester_dropDown.SelectionChangeCommitted += new System.EventHandler(this.semester_dropDown_SelectionChangeCommitted);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(123, 201);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(119, 23);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register For Course";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Student ID";
            // 
            // txtstudentID
            // 
            this.txtstudentID.Location = new System.Drawing.Point(123, 159);
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.Size = new System.Drawing.Size(100, 20);
            this.txtstudentID.TabIndex = 16;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this.txtstudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courses_dropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.semester_dropDown);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox courses_dropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox semester_dropDown;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstudentID;
    }
}