namespace Univrsity_Application
{
    partial class PhDStudentForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.test2_txt = new System.Windows.Forms.TextBox();
            this.test1_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.strt_txt = new System.Windows.Forms.TextBox();
            this.cmptGrade_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.advisor_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "PhD Advisor";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Street Address";
            // 
            // test2_txt
            // 
            this.test2_txt.Location = new System.Drawing.Point(143, 348);
            this.test2_txt.Name = "test2_txt";
            this.test2_txt.Size = new System.Drawing.Size(100, 20);
            this.test2_txt.TabIndex = 61;
            this.test2_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.test2_txt_KeyPress);
            // 
            // test1_txt
            // 
            this.test1_txt.Location = new System.Drawing.Point(143, 309);
            this.test1_txt.Name = "test1_txt";
            this.test1_txt.Size = new System.Drawing.Size(100, 20);
            this.test1_txt.TabIndex = 60;
            this.test1_txt.TextChanged += new System.EventHandler(this.test1_txt_TextChanged);
            this.test1_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.test1_txt_KeyPress);
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(143, 274);
            this.phone_txt.MaxLength = 10;
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(100, 20);
            this.phone_txt.TabIndex = 59;
            this.phone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_txt_KeyPress);
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(143, 233);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(100, 20);
            this.city_txt.TabIndex = 58;
            // 
            // fname_txt
            // 
            this.fname_txt.Location = new System.Drawing.Point(143, 40);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(100, 20);
            this.fname_txt.TabIndex = 57;
            // 
            // lname_txt
            // 
            this.lname_txt.Location = new System.Drawing.Point(143, 82);
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(100, 20);
            this.lname_txt.TabIndex = 56;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(143, 120);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 55;
            // 
            // strt_txt
            // 
            this.strt_txt.Location = new System.Drawing.Point(143, 191);
            this.strt_txt.Name = "strt_txt";
            this.strt_txt.Size = new System.Drawing.Size(100, 20);
            this.strt_txt.TabIndex = 54;
            // 
            // cmptGrade_btn
            // 
            this.cmptGrade_btn.Location = new System.Drawing.Point(85, 394);
            this.cmptGrade_btn.Name = "cmptGrade_btn";
            this.cmptGrade_btn.Size = new System.Drawing.Size(139, 23);
            this.cmptGrade_btn.TabIndex = 53;
            this.cmptGrade_btn.Text = "Compute Grade";
            this.cmptGrade_btn.UseVisualStyleBackColor = true;
            this.cmptGrade_btn.Click += new System.EventHandler(this.cmptGrade_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Test 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Test 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "First Name";
            // 
            // advisor_txt
            // 
            this.advisor_txt.Location = new System.Drawing.Point(143, 160);
            this.advisor_txt.Name = "advisor_txt";
            this.advisor_txt.Size = new System.Drawing.Size(100, 20);
            this.advisor_txt.TabIndex = 65;
            // 
            // PhDStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 457);
            this.Controls.Add(this.advisor_txt);
            this.Controls.Add(this.label9);
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
            this.Name = "PhDStudentForm";
            this.Text = "PhDStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox test2_txt;
        private System.Windows.Forms.TextBox test1_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox strt_txt;
        private System.Windows.Forms.Button cmptGrade_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox advisor_txt;
    }
}