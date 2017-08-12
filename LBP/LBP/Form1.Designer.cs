namespace LBP
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
            this.loadPic_btn = new System.Windows.Forms.Button();
            this.trainImages_btn = new System.Windows.Forms.Button();
            this.findMatch_btn = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.matchedImageBox = new System.Windows.Forms.PictureBox();
            this.accuracyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchedImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadPic_btn
            // 
            this.loadPic_btn.Location = new System.Drawing.Point(36, 120);
            this.loadPic_btn.Name = "loadPic_btn";
            this.loadPic_btn.Size = new System.Drawing.Size(87, 23);
            this.loadPic_btn.TabIndex = 2;
            this.loadPic_btn.Text = "Load Picture";
            this.loadPic_btn.UseVisualStyleBackColor = true;
            this.loadPic_btn.Click += new System.EventHandler(this.loadPic_btn_Click);
            // 
            // trainImages_btn
            // 
            this.trainImages_btn.Location = new System.Drawing.Point(36, 58);
            this.trainImages_btn.Name = "trainImages_btn";
            this.trainImages_btn.Size = new System.Drawing.Size(87, 23);
            this.trainImages_btn.TabIndex = 3;
            this.trainImages_btn.Text = "Train Images";
            this.trainImages_btn.UseVisualStyleBackColor = true;
            this.trainImages_btn.Click += new System.EventHandler(this.trainImages_Click);
            // 
            // findMatch_btn
            // 
            this.findMatch_btn.Location = new System.Drawing.Point(36, 181);
            this.findMatch_btn.Name = "findMatch_btn";
            this.findMatch_btn.Size = new System.Drawing.Size(87, 23);
            this.findMatch_btn.TabIndex = 4;
            this.findMatch_btn.Text = "Find Match";
            this.findMatch_btn.UseVisualStyleBackColor = true;
            this.findMatch_btn.Click += new System.EventHandler(this.findMatch_btn_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(176, 67);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(199, 125);
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            // 
            // matchedImageBox
            // 
            this.matchedImageBox.Location = new System.Drawing.Point(437, 67);
            this.matchedImageBox.Name = "matchedImageBox";
            this.matchedImageBox.Size = new System.Drawing.Size(233, 125);
            this.matchedImageBox.TabIndex = 6;
            this.matchedImageBox.TabStop = false;
            // 
            // accuracyBtn
            // 
            this.accuracyBtn.Location = new System.Drawing.Point(36, 236);
            this.accuracyBtn.Name = "accuracyBtn";
            this.accuracyBtn.Size = new System.Drawing.Size(87, 23);
            this.accuracyBtn.TabIndex = 7;
            this.accuracyBtn.Text = "Find Accuracy";
            this.accuracyBtn.UseVisualStyleBackColor = true;
            this.accuracyBtn.Click += new System.EventHandler(this.accuracyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 451);
            this.Controls.Add(this.accuracyBtn);
            this.Controls.Add(this.matchedImageBox);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.findMatch_btn);
            this.Controls.Add(this.trainImages_btn);
            this.Controls.Add(this.loadPic_btn);
            this.Name = "Form1";
            this.Text = "LBP";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchedImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loadPic_btn;
        private System.Windows.Forms.Button trainImages_btn;
        private System.Windows.Forms.Button findMatch_btn;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.PictureBox matchedImageBox;
        private System.Windows.Forms.Button accuracyBtn;
    }
}

