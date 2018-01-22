namespace Basic_Image_Processing
{
    partial class HistogramEqualisationFrom
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
            this.save_btn = new System.Windows.Forms.Button();
            this.histoEqualBtn = new System.Windows.Forms.Button();
            this.modifiedPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orgPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orgPicBox
            // 
            this.orgPicBox.Location = new System.Drawing.Point(198, 39);
            this.orgPicBox.Name = "orgPicBox";
            this.orgPicBox.Size = new System.Drawing.Size(287, 303);
            this.orgPicBox.TabIndex = 7;
            this.orgPicBox.TabStop = false;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(22, 122);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(127, 23);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save Image";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // histoEqualBtn
            // 
            this.histoEqualBtn.Location = new System.Drawing.Point(22, 47);
            this.histoEqualBtn.Name = "histoEqualBtn";
            this.histoEqualBtn.Size = new System.Drawing.Size(127, 23);
            this.histoEqualBtn.TabIndex = 9;
            this.histoEqualBtn.Text = "Histogram Equalisation";
            this.histoEqualBtn.UseVisualStyleBackColor = true;
            this.histoEqualBtn.Click += new System.EventHandler(this.histoEqualBtn_Click);
            // 
            // modifiedPicBox
            // 
            this.modifiedPicBox.Location = new System.Drawing.Point(198, 402);
            this.modifiedPicBox.Name = "modifiedPicBox";
            this.modifiedPicBox.Size = new System.Drawing.Size(287, 314);
            this.modifiedPicBox.TabIndex = 10;
            this.modifiedPicBox.TabStop = false;
            // 
            // HistogramEqualisationFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 747);
            this.Controls.Add(this.modifiedPicBox);
            this.Controls.Add(this.histoEqualBtn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.orgPicBox);
            this.Name = "HistogramEqualisationFrom";
            this.Text = "Histogram Equalisation Form";
            ((System.ComponentModel.ISupportInitialize)(this.orgPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox orgPicBox;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button histoEqualBtn;
        private System.Windows.Forms.PictureBox modifiedPicBox;
    }
}