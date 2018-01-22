namespace Image_Transformation
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
            this.leastSquareError_btn = new System.Windows.Forms.Button();
            this.ransac_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leastSquareError_btn
            // 
            this.leastSquareError_btn.Location = new System.Drawing.Point(103, 147);
            this.leastSquareError_btn.Name = "leastSquareError_btn";
            this.leastSquareError_btn.Size = new System.Drawing.Size(110, 23);
            this.leastSquareError_btn.TabIndex = 0;
            this.leastSquareError_btn.Text = "Least Square Error";
            this.leastSquareError_btn.UseVisualStyleBackColor = true;
            this.leastSquareError_btn.Click += new System.EventHandler(this.leastSquareError_btn_Click);
            // 
            // ransac_btn
            // 
            this.ransac_btn.Location = new System.Drawing.Point(103, 234);
            this.ransac_btn.Name = "ransac_btn";
            this.ransac_btn.Size = new System.Drawing.Size(110, 23);
            this.ransac_btn.TabIndex = 1;
            this.ransac_btn.Text = "RANSAC Example";
            this.ransac_btn.UseVisualStyleBackColor = true;
            this.ransac_btn.Click += new System.EventHandler(this.ransac_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 458);
            this.Controls.Add(this.ransac_btn);
            this.Controls.Add(this.leastSquareError_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leastSquareError_btn;
        private System.Windows.Forms.Button ransac_btn;
    }
}

