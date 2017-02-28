namespace Univrsity_Application
{
    partial class EmpsForm
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
            this.fullTimeFaculty_btn = new System.Windows.Forms.Button();
            this.PartTime_Faculty = new System.Windows.Forms.Button();
            this.LabMgr_btn = new System.Windows.Forms.Button();
            this.Secretary_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullTimeFaculty_btn
            // 
            this.fullTimeFaculty_btn.Location = new System.Drawing.Point(136, 70);
            this.fullTimeFaculty_btn.Name = "fullTimeFaculty_btn";
            this.fullTimeFaculty_btn.Size = new System.Drawing.Size(107, 23);
            this.fullTimeFaculty_btn.TabIndex = 0;
            this.fullTimeFaculty_btn.Text = "Full Time Faculty";
            this.fullTimeFaculty_btn.UseVisualStyleBackColor = true;
            this.fullTimeFaculty_btn.Click += new System.EventHandler(this.fullTimeFaculty_btn_Click);
            // 
            // PartTime_Faculty
            // 
            this.PartTime_Faculty.Location = new System.Drawing.Point(136, 115);
            this.PartTime_Faculty.Name = "PartTime_Faculty";
            this.PartTime_Faculty.Size = new System.Drawing.Size(107, 23);
            this.PartTime_Faculty.TabIndex = 1;
            this.PartTime_Faculty.Text = "Part Time Faculty";
            this.PartTime_Faculty.UseVisualStyleBackColor = true;
            this.PartTime_Faculty.Click += new System.EventHandler(this.PartTime_Faculty_Click);
            // 
            // LabMgr_btn
            // 
            this.LabMgr_btn.Location = new System.Drawing.Point(136, 158);
            this.LabMgr_btn.Name = "LabMgr_btn";
            this.LabMgr_btn.Size = new System.Drawing.Size(107, 23);
            this.LabMgr_btn.TabIndex = 2;
            this.LabMgr_btn.Text = "Lab Manager";
            this.LabMgr_btn.UseVisualStyleBackColor = true;
            this.LabMgr_btn.Click += new System.EventHandler(this.LabMgr_btn_Click);
            // 
            // Secretary_btn
            // 
            this.Secretary_btn.Location = new System.Drawing.Point(136, 202);
            this.Secretary_btn.Name = "Secretary_btn";
            this.Secretary_btn.Size = new System.Drawing.Size(107, 23);
            this.Secretary_btn.TabIndex = 3;
            this.Secretary_btn.Text = "Secretary";
            this.Secretary_btn.UseVisualStyleBackColor = true;
            this.Secretary_btn.Click += new System.EventHandler(this.Secretary_btn_Click);
            // 
            // EmpsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 366);
            this.Controls.Add(this.Secretary_btn);
            this.Controls.Add(this.LabMgr_btn);
            this.Controls.Add(this.PartTime_Faculty);
            this.Controls.Add(this.fullTimeFaculty_btn);
            this.Name = "EmpsForm";
            this.Text = "EmpsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fullTimeFaculty_btn;
        private System.Windows.Forms.Button PartTime_Faculty;
        private System.Windows.Forms.Button LabMgr_btn;
        private System.Windows.Forms.Button Secretary_btn;
    }
}