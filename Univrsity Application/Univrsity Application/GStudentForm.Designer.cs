namespace Univrsity_Application
{
    partial class GStudentForm
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
            this.cmptGrade_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.test2_txt = new System.Windows.Forms.TextBox();
            this.test1_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.strt_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thesis_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmptGrade_btn
            // 
            this.cmptGrade_btn.Location = new System.Drawing.Point(98, 396);
            this.cmptGrade_btn.Name = "cmptGrade_btn";
            this.cmptGrade_btn.Size = new System.Drawing.Size(139, 23);
            this.cmptGrade_btn.TabIndex = 33;
            this.cmptGrade_btn.Text = "Compute Grade";
            this.cmptGrade_btn.UseVisualStyleBackColor = true;
            this.cmptGrade_btn.Click += new System.EventHandler(this.cmptGrade_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Test 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Test 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "First Name";
            // 
            // test2_txt
            // 
            this.test2_txt.Location = new System.Drawing.Point(156, 350);
            this.test2_txt.Name = "test2_txt";
            this.test2_txt.Size = new System.Drawing.Size(100, 20);
            this.test2_txt.TabIndex = 42;
            this.test2_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.test2_txt_KeyPress);
            // 
            // test1_txt
            // 
            this.test1_txt.Location = new System.Drawing.Point(156, 311);
            this.test1_txt.Name = "test1_txt";
            this.test1_txt.Size = new System.Drawing.Size(100, 20);
            this.test1_txt.TabIndex = 41;
            this.test1_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.test1_txt_KeyPress);
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(156, 276);
            this.phone_txt.MaxLength = 10;
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(100, 20);
            this.phone_txt.TabIndex = 40;
            this.phone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_txt_KeyPress);
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(156, 235);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(100, 20);
            this.city_txt.TabIndex = 39;
            // 
            // fname_txt
            // 
            this.fname_txt.Location = new System.Drawing.Point(156, 42);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(100, 20);
            this.fname_txt.TabIndex = 38;
            // 
            // lname_txt
            // 
            this.lname_txt.Location = new System.Drawing.Point(156, 84);
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(100, 20);
            this.lname_txt.TabIndex = 37;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(156, 122);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 36;
            // 
            // strt_txt
            // 
            this.strt_txt.Location = new System.Drawing.Point(156, 193);
            this.strt_txt.Name = "strt_txt";
            this.strt_txt.Size = new System.Drawing.Size(100, 20);
            this.strt_txt.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Street Address";
            // 
            // thesis_txt
            // 
            this.thesis_txt.Location = new System.Drawing.Point(156, 156);
            this.thesis_txt.Name = "thesis_txt";
            this.thesis_txt.Size = new System.Drawing.Size(100, 20);
            this.thesis_txt.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Thesis";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // GStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 431);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.thesis_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.test2_txt);
            this.Controls.Add(this.test1_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.city_txt);
            this.Controls.Add(this.fname_txt);
            this.Controls.Add(this.lname_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.strt_txt);
            this.Controls.Add(this.cmptGrade_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GStudentForm";
            this.Text = "GStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmptGrade_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox test2_txt;
        private System.Windows.Forms.TextBox test1_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox strt_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox thesis_txt;
        private System.Windows.Forms.Label label9;
    }
}