namespace PCA
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
            this.matchImage_Btn = new System.Windows.Forms.Button();
            this.choosenPicBox = new System.Windows.Forms.PictureBox();
            this.read_btn = new System.Windows.Forms.Button();
            this.loadImage_Btn = new System.Windows.Forms.Button();
            this.matchedImagePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.choosenPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchedImagePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // matchImage_Btn
            // 
            this.matchImage_Btn.Location = new System.Drawing.Point(71, 160);
            this.matchImage_Btn.Name = "matchImage_Btn";
            this.matchImage_Btn.Size = new System.Drawing.Size(95, 23);
            this.matchImage_Btn.TabIndex = 0;
            this.matchImage_Btn.Text = "Find Match";
            this.matchImage_Btn.UseVisualStyleBackColor = true;
            this.matchImage_Btn.Click += new System.EventHandler(this.matchImage_Btn_Click);
            // 
            // choosenPicBox
            // 
            this.choosenPicBox.Location = new System.Drawing.Point(268, 37);
            this.choosenPicBox.Name = "choosenPicBox";
            this.choosenPicBox.Size = new System.Drawing.Size(293, 173);
            this.choosenPicBox.TabIndex = 1;
            this.choosenPicBox.TabStop = false;
            // 
            // read_btn
            // 
            this.read_btn.Location = new System.Drawing.Point(71, 37);
            this.read_btn.Name = "read_btn";
            this.read_btn.Size = new System.Drawing.Size(102, 23);
            this.read_btn.TabIndex = 2;
            this.read_btn.Text = "Train Images";
            this.read_btn.UseVisualStyleBackColor = true;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // loadImage_Btn
            // 
            this.loadImage_Btn.Location = new System.Drawing.Point(71, 98);
            this.loadImage_Btn.Name = "loadImage_Btn";
            this.loadImage_Btn.Size = new System.Drawing.Size(95, 23);
            this.loadImage_Btn.TabIndex = 3;
            this.loadImage_Btn.Text = "Load Image";
            this.loadImage_Btn.UseVisualStyleBackColor = true;
            this.loadImage_Btn.Click += new System.EventHandler(this.loadImage_Btn_Click);
            // 
            // matchedImagePicBox
            // 
            this.matchedImagePicBox.Location = new System.Drawing.Point(670, 37);
            this.matchedImagePicBox.Name = "matchedImagePicBox";
            this.matchedImagePicBox.Size = new System.Drawing.Size(293, 173);
            this.matchedImagePicBox.TabIndex = 4;
            this.matchedImagePicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 357);
            this.Controls.Add(this.matchedImagePicBox);
            this.Controls.Add(this.loadImage_Btn);
            this.Controls.Add(this.read_btn);
            this.Controls.Add(this.choosenPicBox);
            this.Controls.Add(this.matchImage_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.choosenPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchedImagePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button matchImage_Btn;
        private System.Windows.Forms.PictureBox choosenPicBox;
        private System.Windows.Forms.Button read_btn;
        private System.Windows.Forms.Button loadImage_Btn;
        private System.Windows.Forms.PictureBox matchedImagePicBox;
    }
}

