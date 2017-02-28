namespace Univrsity_Application
{
    partial class StudentForm
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
            this.UGStd_btn = new System.Windows.Forms.Button();
            this.GStd_btn = new System.Windows.Forms.Button();
            this.PhD_Student = new System.Windows.Forms.Button();
            this.partStd_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UGStd_btn
            // 
            this.UGStd_btn.Location = new System.Drawing.Point(98, 42);
            this.UGStd_btn.Name = "UGStd_btn";
            this.UGStd_btn.Size = new System.Drawing.Size(119, 23);
            this.UGStd_btn.TabIndex = 0;
            this.UGStd_btn.Text = "UG Student";
            this.UGStd_btn.UseVisualStyleBackColor = true;
            this.UGStd_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // GStd_btn
            // 
            this.GStd_btn.Location = new System.Drawing.Point(98, 86);
            this.GStd_btn.Name = "GStd_btn";
            this.GStd_btn.Size = new System.Drawing.Size(119, 23);
            this.GStd_btn.TabIndex = 1;
            this.GStd_btn.Text = "G Student";
            this.GStd_btn.UseVisualStyleBackColor = true;
            this.GStd_btn.Click += new System.EventHandler(this.GStd_btn_Click);
            // 
            // PhD_Student
            // 
            this.PhD_Student.Location = new System.Drawing.Point(98, 129);
            this.PhD_Student.Name = "PhD_Student";
            this.PhD_Student.Size = new System.Drawing.Size(119, 23);
            this.PhD_Student.TabIndex = 2;
            this.PhD_Student.Text = "PhD Student";
            this.PhD_Student.UseVisualStyleBackColor = true;
            this.PhD_Student.Click += new System.EventHandler(this.PhD_Student_Click);
            // 
            // partStd_btn
            // 
            this.partStd_btn.Location = new System.Drawing.Point(98, 173);
            this.partStd_btn.Name = "partStd_btn";
            this.partStd_btn.Size = new System.Drawing.Size(119, 23);
            this.partStd_btn.TabIndex = 3;
            this.partStd_btn.Text = "Part Time Student";
            this.partStd_btn.UseVisualStyleBackColor = true;
            this.partStd_btn.Click += new System.EventHandler(this.partStd_btn_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.partStd_btn);
            this.Controls.Add(this.PhD_Student);
            this.Controls.Add(this.GStd_btn);
            this.Controls.Add(this.UGStd_btn);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UGStd_btn;
        private System.Windows.Forms.Button GStd_btn;
        private System.Windows.Forms.Button PhD_Student;
        private System.Windows.Forms.Button partStd_btn;
    }
}