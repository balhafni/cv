namespace GradeProcessing
{
    partial class AddStudent
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_test1 = new System.Windows.Forms.TextBox();
            this.txt_test2 = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.box_majors = new System.Windows.Forms.ComboBox();
            this.btn_addStudent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(169, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 0;
            // 
            // txt_test1
            // 
            this.txt_test1.Location = new System.Drawing.Point(170, 176);
            this.txt_test1.Name = "txt_test1";
            this.txt_test1.Size = new System.Drawing.Size(100, 20);
            this.txt_test1.TabIndex = 1;
            this.txt_test1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_test1_KeyPress);
            // 
            // txt_test2
            // 
            this.txt_test2.Location = new System.Drawing.Point(169, 230);
            this.txt_test2.Name = "txt_test2";
            this.txt_test2.Size = new System.Drawing.Size(100, 20);
            this.txt_test2.TabIndex = 2;
            this.txt_test2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_test2_KeyPress);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(169, 125);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(100, 20);
            this.txt_lname.TabIndex = 3;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(170, 76);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(100, 20);
            this.txt_fname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Test 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Test 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Major";
            // 
            // box_majors
            // 
            this.box_majors.FormattingEnabled = true;
            this.box_majors.Location = new System.Drawing.Point(169, 269);
            this.box_majors.Name = "box_majors";
            this.box_majors.Size = new System.Drawing.Size(121, 21);
            this.box_majors.TabIndex = 11;
            // 
            // btn_addStudent
            // 
            this.btn_addStudent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_addStudent.Location = new System.Drawing.Point(51, 369);
            this.btn_addStudent.Name = "btn_addStudent";
            this.btn_addStudent.Size = new System.Drawing.Size(97, 23);
            this.btn_addStudent.TabIndex = 14;
            this.btn_addStudent.Text = "Add a Student";
            this.btn_addStudent.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(179, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButton2);
            this.groupBox.Controls.Add(this.radioButton1);
            this.groupBox.Location = new System.Drawing.Point(51, 309);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(203, 38);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(118, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "GRAD";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "UG";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 481);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_addStudent);
            this.Controls.Add(this.box_majors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_test2);
            this.Controls.Add(this.txt_test1);
            this.Controls.Add(this.txt_id);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_test1;
        private System.Windows.Forms.TextBox txt_test2;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox box_majors;
        private System.Windows.Forms.Button btn_addStudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}