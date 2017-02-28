namespace Basic_Image_Processing
{
    partial class InterpolationForm
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
            this.interpolateBtn = new System.Windows.Forms.Button();
            this.savePicBtn = new System.Windows.Forms.Button();
            this.modifiedPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orgPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orgPicBox
            // 
            this.orgPicBox.Location = new System.Drawing.Point(162, 31);
            this.orgPicBox.Name = "orgPicBox";
            this.orgPicBox.Size = new System.Drawing.Size(287, 303);
            this.orgPicBox.TabIndex = 6;
            this.orgPicBox.TabStop = false;
            // 
            // interpolateBtn
            // 
            this.interpolateBtn.Location = new System.Drawing.Point(22, 62);
            this.interpolateBtn.Name = "interpolateBtn";
            this.interpolateBtn.Size = new System.Drawing.Size(75, 23);
            this.interpolateBtn.TabIndex = 7;
            this.interpolateBtn.Text = "Interpolate";
            this.interpolateBtn.UseVisualStyleBackColor = true;
            this.interpolateBtn.Click += new System.EventHandler(this.interpolateBtn_Click);
            // 
            // savePicBtn
            // 
            this.savePicBtn.Location = new System.Drawing.Point(22, 122);
            this.savePicBtn.Name = "savePicBtn";
            this.savePicBtn.Size = new System.Drawing.Size(75, 23);
            this.savePicBtn.TabIndex = 8;
            this.savePicBtn.Text = "Save Picture";
            this.savePicBtn.UseVisualStyleBackColor = true;
            // 
            // modifiedPicBox
            // 
            this.modifiedPicBox.Location = new System.Drawing.Point(566, 50);
            this.modifiedPicBox.Name = "modifiedPicBox";
            this.modifiedPicBox.Size = new System.Drawing.Size(726, 551);
            this.modifiedPicBox.TabIndex = 9;
            this.modifiedPicBox.TabStop = false;
            // 
            // InterpolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 723);
            this.Controls.Add(this.modifiedPicBox);
            this.Controls.Add(this.savePicBtn);
            this.Controls.Add(this.interpolateBtn);
            this.Controls.Add(this.orgPicBox);
            this.Name = "InterpolationForm";
            this.Text = "InterpolationForm";
            ((System.ComponentModel.ISupportInitialize)(this.orgPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox orgPicBox;
        private System.Windows.Forms.Button interpolateBtn;
        private System.Windows.Forms.Button savePicBtn;
        private System.Windows.Forms.PictureBox modifiedPicBox;
    }
}