namespace Basic_Image_Processing
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
            this.orgPicBox = new System.Windows.Forms.PictureBox();
            this.modifiedPicBox = new System.Windows.Forms.PictureBox();
            this.loadImage_btn = new System.Windows.Forms.Button();
            this.grayImg_btn = new System.Windows.Forms.Button();
            this.brightImg_btn = new System.Windows.Forms.Button();
            this.contrastImg_btn = new System.Windows.Forms.Button();
            this.saveImg_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orgPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orgPicBox
            // 
            this.orgPicBox.Location = new System.Drawing.Point(136, 41);
            this.orgPicBox.Name = "orgPicBox";
            this.orgPicBox.Size = new System.Drawing.Size(287, 303);
            this.orgPicBox.TabIndex = 0;
            this.orgPicBox.TabStop = false;
            // 
            // modifiedPicBox
            // 
            this.modifiedPicBox.Location = new System.Drawing.Point(519, 41);
            this.modifiedPicBox.Name = "modifiedPicBox";
            this.modifiedPicBox.Size = new System.Drawing.Size(314, 303);
            this.modifiedPicBox.TabIndex = 1;
            this.modifiedPicBox.TabStop = false;
            // 
            // loadImage_btn
            // 
            this.loadImage_btn.Location = new System.Drawing.Point(12, 41);
            this.loadImage_btn.Name = "loadImage_btn";
            this.loadImage_btn.Size = new System.Drawing.Size(102, 23);
            this.loadImage_btn.TabIndex = 4;
            this.loadImage_btn.Text = "Load Image";
            this.loadImage_btn.UseVisualStyleBackColor = true;
            this.loadImage_btn.Click += new System.EventHandler(this.loadImage_btn_Click);
            // 
            // grayImg_btn
            // 
            this.grayImg_btn.Location = new System.Drawing.Point(12, 87);
            this.grayImg_btn.Name = "grayImg_btn";
            this.grayImg_btn.Size = new System.Drawing.Size(102, 23);
            this.grayImg_btn.TabIndex = 5;
            this.grayImg_btn.Text = "Convert to Gray";
            this.grayImg_btn.UseVisualStyleBackColor = true;
            this.grayImg_btn.Click += new System.EventHandler(this.grayImg_btn_Click);
            // 
            // brightImg_btn
            // 
            this.brightImg_btn.Location = new System.Drawing.Point(12, 141);
            this.brightImg_btn.Name = "brightImg_btn";
            this.brightImg_btn.Size = new System.Drawing.Size(102, 23);
            this.brightImg_btn.TabIndex = 6;
            this.brightImg_btn.Text = "Brighter Image";
            this.brightImg_btn.UseVisualStyleBackColor = true;
            this.brightImg_btn.Click += new System.EventHandler(this.brightImg_btn_Click);
            // 
            // contrastImg_btn
            // 
            this.contrastImg_btn.Location = new System.Drawing.Point(12, 194);
            this.contrastImg_btn.Name = "contrastImg_btn";
            this.contrastImg_btn.Size = new System.Drawing.Size(102, 23);
            this.contrastImg_btn.TabIndex = 7;
            this.contrastImg_btn.Text = "Contrast Image";
            this.contrastImg_btn.UseVisualStyleBackColor = true;
            this.contrastImg_btn.Click += new System.EventHandler(this.contrastImg_btn_Click);
            // 
            // saveImg_btn
            // 
            this.saveImg_btn.Location = new System.Drawing.Point(12, 241);
            this.saveImg_btn.Name = "saveImg_btn";
            this.saveImg_btn.Size = new System.Drawing.Size(102, 23);
            this.saveImg_btn.TabIndex = 8;
            this.saveImg_btn.Text = "Save Image";
            this.saveImg_btn.UseVisualStyleBackColor = true;
            this.saveImg_btn.Click += new System.EventHandler(this.saveImg_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 444);
            this.Controls.Add(this.saveImg_btn);
            this.Controls.Add(this.contrastImg_btn);
            this.Controls.Add(this.brightImg_btn);
            this.Controls.Add(this.grayImg_btn);
            this.Controls.Add(this.loadImage_btn);
            this.Controls.Add(this.modifiedPicBox);
            this.Controls.Add(this.orgPicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox orgPicBox;
        private System.Windows.Forms.PictureBox modifiedPicBox;
        private System.Windows.Forms.Button loadImage_btn;
        private System.Windows.Forms.Button grayImg_btn;
        private System.Windows.Forms.Button brightImg_btn;
        private System.Windows.Forms.Button contrastImg_btn;
        private System.Windows.Forms.Button saveImg_btn;
    }
}

