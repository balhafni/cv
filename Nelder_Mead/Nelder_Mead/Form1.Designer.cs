namespace Nelder_Mead
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
            this.transformedImg_PicBox = new System.Windows.Forms.PictureBox();
            this.referenceImg_picBox = new System.Windows.Forms.PictureBox();
            this.registerationBtn = new System.Windows.Forms.Button();
            this.referenceImage_loadbtn = new System.Windows.Forms.Button();
            this.transformedImg_loadbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transformedImg_PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceImg_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transformed Image";
            // 
            // transformedImg_PicBox
            // 
            this.transformedImg_PicBox.Location = new System.Drawing.Point(611, 66);
            this.transformedImg_PicBox.Name = "transformedImg_PicBox";
            this.transformedImg_PicBox.Size = new System.Drawing.Size(421, 292);
            this.transformedImg_PicBox.TabIndex = 3;
            this.transformedImg_PicBox.TabStop = false;
            // 
            // referenceImg_picBox
            // 
            this.referenceImg_picBox.Location = new System.Drawing.Point(27, 66);
            this.referenceImg_picBox.Name = "referenceImg_picBox";
            this.referenceImg_picBox.Size = new System.Drawing.Size(421, 292);
            this.referenceImg_picBox.TabIndex = 5;
            this.referenceImg_picBox.TabStop = false;
            // 
            // registerationBtn
            // 
            this.registerationBtn.Location = new System.Drawing.Point(487, 400);
            this.registerationBtn.Name = "registerationBtn";
            this.registerationBtn.Size = new System.Drawing.Size(112, 23);
            this.registerationBtn.TabIndex = 6;
            this.registerationBtn.Text = "Register Images";
            this.registerationBtn.UseVisualStyleBackColor = true;
            this.registerationBtn.Click += new System.EventHandler(this.registerationBtn_Click);
            // 
            // referenceImage_loadbtn
            // 
            this.referenceImage_loadbtn.Location = new System.Drawing.Point(154, 385);
            this.referenceImage_loadbtn.Name = "referenceImage_loadbtn";
            this.referenceImage_loadbtn.Size = new System.Drawing.Size(112, 23);
            this.referenceImage_loadbtn.TabIndex = 7;
            this.referenceImage_loadbtn.Text = "Load";
            this.referenceImage_loadbtn.UseVisualStyleBackColor = true;
            this.referenceImage_loadbtn.Click += new System.EventHandler(this.referenceImage_loadbtn_Click);
            // 
            // transformedImg_loadbtn
            // 
            this.transformedImg_loadbtn.Location = new System.Drawing.Point(776, 385);
            this.transformedImg_loadbtn.Name = "transformedImg_loadbtn";
            this.transformedImg_loadbtn.Size = new System.Drawing.Size(112, 23);
            this.transformedImg_loadbtn.TabIndex = 8;
            this.transformedImg_loadbtn.Text = "Load";
            this.transformedImg_loadbtn.UseVisualStyleBackColor = true;
            this.transformedImg_loadbtn.Click += new System.EventHandler(this.transformedImg_loadbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 513);
            this.Controls.Add(this.transformedImg_loadbtn);
            this.Controls.Add(this.referenceImage_loadbtn);
            this.Controls.Add(this.registerationBtn);
            this.Controls.Add(this.referenceImg_picBox);
            this.Controls.Add(this.transformedImg_PicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.transformedImg_PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceImg_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox transformedImg_PicBox;
        private System.Windows.Forms.PictureBox referenceImg_picBox;
        private System.Windows.Forms.Button registerationBtn;
        private System.Windows.Forms.Button referenceImage_loadbtn;
        private System.Windows.Forms.Button transformedImg_loadbtn;
    }
}

