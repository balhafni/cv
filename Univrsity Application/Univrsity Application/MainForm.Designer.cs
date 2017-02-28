namespace Univrsity_Application
{
    partial class MainForm
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
            this.std_btn = new System.Windows.Forms.Button();
            this.emp_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // std_btn
            // 
            this.std_btn.Location = new System.Drawing.Point(88, 68);
            this.std_btn.Name = "std_btn";
            this.std_btn.Size = new System.Drawing.Size(101, 23);
            this.std_btn.TabIndex = 1;
            this.std_btn.Text = "Student";
            this.std_btn.UseVisualStyleBackColor = true;
            this.std_btn.Click += new System.EventHandler(this.std_btn_Click);
            // 
            // emp_btn
            // 
            this.emp_btn.Location = new System.Drawing.Point(88, 146);
            this.emp_btn.Name = "emp_btn";
            this.emp_btn.Size = new System.Drawing.Size(101, 23);
            this.emp_btn.TabIndex = 2;
            this.emp_btn.Text = "Employee";
            this.emp_btn.UseVisualStyleBackColor = true;
            this.emp_btn.Click += new System.EventHandler(this.emp_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.emp_btn);
            this.Controls.Add(this.std_btn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button std_btn;
        private System.Windows.Forms.Button emp_btn;
    }
}

