namespace FirstAssignment_Part2
{
    partial class Form1
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
            this.textHrsWorked = new System.Windows.Forms.TextBox();
            this.textPayRate = new System.Windows.Forms.TextBox();
            this.btnComputePay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours Worked";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pay Rate";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(125, 42);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 5;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(125, 81);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 6;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(125, 118);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 7;
            // 
            // textHrsWorked
            // 
            this.textHrsWorked.Location = new System.Drawing.Point(125, 157);
            this.textHrsWorked.Name = "textHrsWorked";
            this.textHrsWorked.Size = new System.Drawing.Size(100, 20);
            this.textHrsWorked.TabIndex = 8;
            this.textHrsWorked.TextChanged += new System.EventHandler(this.textHrsWorked_TextChanged);
            this.textHrsWorked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHrsWorked_KeyPress);
            // 
            // textPayRate
            // 
            this.textPayRate.Location = new System.Drawing.Point(125, 192);
            this.textPayRate.Name = "textPayRate";
            this.textPayRate.Size = new System.Drawing.Size(100, 20);
            this.textPayRate.TabIndex = 9;
            this.textPayRate.TextChanged += new System.EventHandler(this.textPayRate_TextChanged);
            this.textPayRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPayRate_KeyPress);
            // 
            // btnComputePay
            // 
            this.btnComputePay.Location = new System.Drawing.Point(77, 234);
            this.btnComputePay.Name = "btnComputePay";
            this.btnComputePay.Size = new System.Drawing.Size(92, 23);
            this.btnComputePay.TabIndex = 10;
            this.btnComputePay.Text = "Compute Pay";
            this.btnComputePay.UseVisualStyleBackColor = true;
            this.btnComputePay.Click += new System.EventHandler(this.btnComputePay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 287);
            this.Controls.Add(this.btnComputePay);
            this.Controls.Add(this.textPayRate);
            this.Controls.Add(this.textHrsWorked);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employees Hours";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox textHrsWorked;
        private System.Windows.Forms.TextBox textPayRate;
        private System.Windows.Forms.Button btnComputePay;
    }
}

