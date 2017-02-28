namespace Univrsity_Application
{
    partial class SecretaryForm
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
            this.display_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.dpt_txt = new System.Windows.Forms.TextBox();
            this.strt_txt = new System.Windows.Forms.TextBox();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.empID_txt = new System.Windows.Forms.TextBox();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // display_btn
            // 
            this.display_btn.Location = new System.Drawing.Point(83, 328);
            this.display_btn.Name = "display_btn";
            this.display_btn.Size = new System.Drawing.Size(147, 23);
            this.display_btn.TabIndex = 29;
            this.display_btn.Text = "Display Employee Info";
            this.display_btn.UseVisualStyleBackColor = true;
            this.display_btn.Click += new System.EventHandler(this.display_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Street Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name";
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(162, 280);
            this.phone_txt.MaxLength = 10;
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(100, 20);
            this.phone_txt.TabIndex = 21;
            this.phone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_txt_KeyPress);
            // 
            // dpt_txt
            // 
            this.dpt_txt.Location = new System.Drawing.Point(162, 163);
            this.dpt_txt.Name = "dpt_txt";
            this.dpt_txt.Size = new System.Drawing.Size(100, 20);
            this.dpt_txt.TabIndex = 20;
            // 
            // strt_txt
            // 
            this.strt_txt.Location = new System.Drawing.Point(162, 200);
            this.strt_txt.Name = "strt_txt";
            this.strt_txt.Size = new System.Drawing.Size(100, 20);
            this.strt_txt.TabIndex = 19;
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(162, 243);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(100, 20);
            this.city_txt.TabIndex = 18;
            // 
            // empID_txt
            // 
            this.empID_txt.Location = new System.Drawing.Point(162, 126);
            this.empID_txt.Name = "empID_txt";
            this.empID_txt.Size = new System.Drawing.Size(100, 20);
            this.empID_txt.TabIndex = 17;
            // 
            // lname_txt
            // 
            this.lname_txt.Location = new System.Drawing.Point(162, 87);
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(100, 20);
            this.lname_txt.TabIndex = 16;
            // 
            // fname_txt
            // 
            this.fname_txt.Location = new System.Drawing.Point(163, 50);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(100, 20);
            this.fname_txt.TabIndex = 15;
            // 
            // SecretaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 402);
            this.Controls.Add(this.display_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.dpt_txt);
            this.Controls.Add(this.strt_txt);
            this.Controls.Add(this.city_txt);
            this.Controls.Add(this.empID_txt);
            this.Controls.Add(this.lname_txt);
            this.Controls.Add(this.fname_txt);
            this.Name = "SecretaryForm";
            this.Text = "ScecretaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button display_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox dpt_txt;
        private System.Windows.Forms.TextBox strt_txt;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.TextBox empID_txt;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.TextBox fname_txt;
    }
}