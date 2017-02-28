namespace Student_University_App_Enhanced
{
    partial class UnregisterForACourseForm
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.cbclasses = new System.Windows.Forms.ComboBox();
            this.btnuniregister = new System.Windows.Forms.Button();
            this.btnGetRegisteredClasses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(99, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 0;
            // 
            // cbclasses
            // 
            this.cbclasses.FormattingEnabled = true;
            this.cbclasses.Location = new System.Drawing.Point(99, 89);
            this.cbclasses.Name = "cbclasses";
            this.cbclasses.Size = new System.Drawing.Size(121, 21);
            this.cbclasses.TabIndex = 1;
            // 
            // btnuniregister
            // 
            this.btnuniregister.Location = new System.Drawing.Point(210, 144);
            this.btnuniregister.Name = "btnuniregister";
            this.btnuniregister.Size = new System.Drawing.Size(127, 23);
            this.btnuniregister.TabIndex = 2;
            this.btnuniregister.Text = "Unregsiter for Class";
            this.btnuniregister.UseVisualStyleBackColor = true;
            this.btnuniregister.Click += new System.EventHandler(this.btnuniregister_Click);
            // 
            // btnGetRegisteredClasses
            // 
            this.btnGetRegisteredClasses.Location = new System.Drawing.Point(75, 144);
            this.btnGetRegisteredClasses.Name = "btnGetRegisteredClasses";
            this.btnGetRegisteredClasses.Size = new System.Drawing.Size(106, 23);
            this.btnGetRegisteredClasses.TabIndex = 3;
            this.btnGetRegisteredClasses.Text = "Classes Registered";
            this.btnGetRegisteredClasses.UseVisualStyleBackColor = true;
            this.btnGetRegisteredClasses.Click += new System.EventHandler(this.btnGetRegisteredClasses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student ID";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(6, 97);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(87, 13);
            this.lable2.TabIndex = 5;
            this.lable2.Text = "Class Registered";
            // 
            // UnregisterForACourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 261);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetRegisteredClasses);
            this.Controls.Add(this.btnuniregister);
            this.Controls.Add(this.cbclasses);
            this.Controls.Add(this.txtid);
            this.Name = "UnregisterForACourseForm";
            this.Text = "UnregisterForACourseView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cbclasses;
        private System.Windows.Forms.Button btnuniregister;
        private System.Windows.Forms.Button btnGetRegisteredClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable2;
    }
}