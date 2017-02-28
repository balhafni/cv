namespace BasharAlhafni_Assignment2
{
    partial class Form3
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
            this.btn_swap = new System.Windows.Forms.Button();
            this.text_firstString = new System.Windows.Forms.TextBox();
            this.text_secondString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_swap
            // 
            this.btn_swap.Location = new System.Drawing.Point(96, 159);
            this.btn_swap.Name = "btn_swap";
            this.btn_swap.Size = new System.Drawing.Size(75, 23);
            this.btn_swap.TabIndex = 0;
            this.btn_swap.Text = "Swap";
            this.btn_swap.UseVisualStyleBackColor = true;
            this.btn_swap.Click += new System.EventHandler(this.btn_swap_Click);
            // 
            // text_firstString
            // 
            this.text_firstString.Location = new System.Drawing.Point(135, 47);
            this.text_firstString.Name = "text_firstString";
            this.text_firstString.Size = new System.Drawing.Size(100, 20);
            this.text_firstString.TabIndex = 1;
            // 
            // text_secondString
            // 
            this.text_secondString.Location = new System.Drawing.Point(135, 117);
            this.text_secondString.Name = "text_secondString";
            this.text_secondString.Size = new System.Drawing.Size(100, 20);
            this.text_secondString.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Second String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second String";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_secondString);
            this.Controls.Add(this.text_firstString);
            this.Controls.Add(this.btn_swap);
            this.Name = "Form3";
            this.Text = "String Swap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_swap;
        private System.Windows.Forms.TextBox text_firstString;
        private System.Windows.Forms.TextBox text_secondString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}