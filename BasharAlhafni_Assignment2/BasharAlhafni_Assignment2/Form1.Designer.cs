namespace BasharAlhafni_Assignment2
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
            this.btnSwapDoubles = new System.Windows.Forms.Button();
            this.btn_SwapStrings = new System.Windows.Forms.Button();
            this.btn_SwapStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwapDoubles
            // 
            this.btnSwapDoubles.Location = new System.Drawing.Point(105, 69);
            this.btnSwapDoubles.Name = "btnSwapDoubles";
            this.btnSwapDoubles.Size = new System.Drawing.Size(91, 23);
            this.btnSwapDoubles.TabIndex = 0;
            this.btnSwapDoubles.Text = "Swap doubles";
            this.btnSwapDoubles.UseVisualStyleBackColor = true;
            this.btnSwapDoubles.Click += new System.EventHandler(this.btnSwapDoubles_Click);
            // 
            // btn_SwapStrings
            // 
            this.btn_SwapStrings.Location = new System.Drawing.Point(105, 120);
            this.btn_SwapStrings.Name = "btn_SwapStrings";
            this.btn_SwapStrings.Size = new System.Drawing.Size(91, 23);
            this.btn_SwapStrings.TabIndex = 1;
            this.btn_SwapStrings.Text = "Swap Strings";
            this.btn_SwapStrings.UseVisualStyleBackColor = true;
            this.btn_SwapStrings.Click += new System.EventHandler(this.btn_SwapStrings_Click);
            // 
            // btn_SwapStudents
            // 
            this.btn_SwapStudents.Location = new System.Drawing.Point(105, 173);
            this.btn_SwapStudents.Name = "btn_SwapStudents";
            this.btn_SwapStudents.Size = new System.Drawing.Size(91, 23);
            this.btn_SwapStudents.TabIndex = 2;
            this.btn_SwapStudents.Text = "Swap Students";
            this.btn_SwapStudents.UseVisualStyleBackColor = true;
            this.btn_SwapStudents.Click += new System.EventHandler(this.btn_SwapStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 274);
            this.Controls.Add(this.btn_SwapStudents);
            this.Controls.Add(this.btn_SwapStrings);
            this.Controls.Add(this.btnSwapDoubles);
            this.Name = "Form1";
            this.Text = "Swaper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwapDoubles;
        private System.Windows.Forms.Button btn_SwapStrings;
        private System.Windows.Forms.Button btn_SwapStudents;
    }
}

