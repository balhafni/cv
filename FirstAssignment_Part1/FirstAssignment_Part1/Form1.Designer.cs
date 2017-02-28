namespace FirstAssignment_Part1
{
    partial class GradesCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textTest1 = new System.Windows.Forms.TextBox();
            this.textTest2 = new System.Windows.Forms.TextBox();
            this.btnComputeGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Test1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Test2";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(97, 40);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 5;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(97, 74);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 6;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(97, 109);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 7;
            // 
            // textTest1
            // 
            this.textTest1.Location = new System.Drawing.Point(97, 141);
            this.textTest1.Name = "textTest1";
            this.textTest1.Size = new System.Drawing.Size(100, 20);
            this.textTest1.TabIndex = 8;
            this.textTest1.TextChanged += new System.EventHandler(this.textTest1_TextChanged);
            this.textTest1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTest1_KeyPress);
            // 
            // textTest2
            // 
            this.textTest2.Location = new System.Drawing.Point(97, 172);
            this.textTest2.Name = "textTest2";
            this.textTest2.Size = new System.Drawing.Size(100, 20);
            this.textTest2.TabIndex = 9;
            this.textTest2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTest2_KeyPress);
            // 
            // btnComputeGrade
            // 
            this.btnComputeGrade.Location = new System.Drawing.Point(64, 212);
            this.btnComputeGrade.Name = "btnComputeGrade";
            this.btnComputeGrade.Size = new System.Drawing.Size(110, 23);
            this.btnComputeGrade.TabIndex = 11;
            this.btnComputeGrade.Text = "Compute Grade";
            this.btnComputeGrade.UseVisualStyleBackColor = true;
            this.btnComputeGrade.Click += new System.EventHandler(this.btnComputeGrade_Click);
            // 
            // GradesCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnComputeGrade);
            this.Controls.Add(this.textTest2);
            this.Controls.Add(this.textTest1);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GradesCalculator";
            this.Text = "GradesCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textTest1;
        private System.Windows.Forms.TextBox textTest2;
        private System.Windows.Forms.Button btnComputeGrade;
    }
}

