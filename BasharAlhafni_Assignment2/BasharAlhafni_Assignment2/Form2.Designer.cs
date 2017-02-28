namespace BasharAlhafni_Assignment2
{
    partial class Form2
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
            this.text_firstDouble = new System.Windows.Forms.TextBox();
            this.text_secondDouble = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_swap
            // 
            this.btn_swap.Location = new System.Drawing.Point(99, 154);
            this.btn_swap.Name = "btn_swap";
            this.btn_swap.Size = new System.Drawing.Size(75, 23);
            this.btn_swap.TabIndex = 0;
            this.btn_swap.Text = "Swap";
            this.btn_swap.UseVisualStyleBackColor = true;
            this.btn_swap.Click += new System.EventHandler(this.btn_swap_Click);
            this.btn_swap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_swap_KeyPress);
            // 
            // text_firstDouble
            // 
            this.text_firstDouble.Location = new System.Drawing.Point(132, 46);
            this.text_firstDouble.Name = "text_firstDouble";
            this.text_firstDouble.Size = new System.Drawing.Size(100, 20);
            this.text_firstDouble.TabIndex = 1;
            this.text_firstDouble.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_firstDouble_KeyPress);
            // 
            // text_secondDouble
            // 
            this.text_secondDouble.Location = new System.Drawing.Point(132, 100);
            this.text_secondDouble.Name = "text_secondDouble";
            this.text_secondDouble.Size = new System.Drawing.Size(100, 20);
            this.text_secondDouble.TabIndex = 2;
            this.text_secondDouble.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.text_secondDouble.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_secondDouble_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First double";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second double";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_secondDouble);
            this.Controls.Add(this.text_firstDouble);
            this.Controls.Add(this.btn_swap);
            this.Name = "Form2";
            this.Text = "Swap Doubles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_swap;
        private System.Windows.Forms.TextBox text_firstDouble;
        private System.Windows.Forms.TextBox text_secondDouble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}