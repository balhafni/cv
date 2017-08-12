namespace Image_Transformation
{
    partial class RANSAC_Form
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
            this.initShapes_btn = new System.Windows.Forms.Button();
            this.transformation_btn = new System.Windows.Forms.Button();
            this.ransac_btn = new System.Windows.Forms.Button();
            this.panShape3 = new System.Windows.Forms.Panel();
            this.panShape2 = new System.Windows.Forms.Panel();
            this.panShape1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // initShapes_btn
            // 
            this.initShapes_btn.Location = new System.Drawing.Point(169, 421);
            this.initShapes_btn.Name = "initShapes_btn";
            this.initShapes_btn.Size = new System.Drawing.Size(95, 23);
            this.initShapes_btn.TabIndex = 0;
            this.initShapes_btn.Text = "Initialize Shapes";
            this.initShapes_btn.UseVisualStyleBackColor = true;
            this.initShapes_btn.Click += new System.EventHandler(this.initShapes_btn_Click);
            // 
            // transformation_btn
            // 
            this.transformation_btn.Location = new System.Drawing.Point(513, 421);
            this.transformation_btn.Name = "transformation_btn";
            this.transformation_btn.Size = new System.Drawing.Size(124, 23);
            this.transformation_btn.TabIndex = 1;
            this.transformation_btn.Text = "Apply Transformation";
            this.transformation_btn.UseVisualStyleBackColor = true;
            this.transformation_btn.Click += new System.EventHandler(this.transformation_btn_Click);
            // 
            // ransac_btn
            // 
            this.ransac_btn.Location = new System.Drawing.Point(887, 421);
            this.ransac_btn.Name = "ransac_btn";
            this.ransac_btn.Size = new System.Drawing.Size(103, 23);
            this.ransac_btn.TabIndex = 2;
            this.ransac_btn.Text = "Eliminate Outliers";
            this.ransac_btn.UseVisualStyleBackColor = true;
            this.ransac_btn.Click += new System.EventHandler(this.ransac_btn_Click);
            // 
            // panShape3
            // 
            this.panShape3.Location = new System.Drawing.Point(811, 39);
            this.panShape3.Name = "panShape3";
            this.panShape3.Size = new System.Drawing.Size(272, 357);
            this.panShape3.TabIndex = 3;
            // 
            // panShape2
            // 
            this.panShape2.Location = new System.Drawing.Point(452, 39);
            this.panShape2.Name = "panShape2";
            this.panShape2.Size = new System.Drawing.Size(279, 357);
            this.panShape2.TabIndex = 0;
            // 
            // panShape1
            // 
            this.panShape1.Location = new System.Drawing.Point(91, 39);
            this.panShape1.Name = "panShape1";
            this.panShape1.Size = new System.Drawing.Size(273, 357);
            this.panShape1.TabIndex = 0;
            // 
            // RANSAC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 514);
            this.Controls.Add(this.panShape2);
            this.Controls.Add(this.panShape1);
            this.Controls.Add(this.panShape3);
            this.Controls.Add(this.ransac_btn);
            this.Controls.Add(this.transformation_btn);
            this.Controls.Add(this.initShapes_btn);
            this.Name = "RANSAC_Form";
            this.Text = "RANSAC_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button initShapes_btn;
        private System.Windows.Forms.Button transformation_btn;
        private System.Windows.Forms.Button ransac_btn;
        private System.Windows.Forms.Panel panShape3;
        private System.Windows.Forms.Panel panShape2;
        private System.Windows.Forms.Panel panShape1;
    }
}