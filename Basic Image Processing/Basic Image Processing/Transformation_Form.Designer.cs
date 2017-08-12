namespace Basic_Image_Processing
{
    partial class Transformation_Form
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
            this.transImg_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.orgPicBox = new System.Windows.Forms.PictureBox();
            this.modifiedPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orgPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // transImg_btn
            // 
            this.transImg_btn.Location = new System.Drawing.Point(29, 63);
            this.transImg_btn.Name = "transImg_btn";
            this.transImg_btn.Size = new System.Drawing.Size(107, 23);
            this.transImg_btn.TabIndex = 0;
            this.transImg_btn.Text = "Transform Image";
            this.transImg_btn.UseVisualStyleBackColor = true;
            this.transImg_btn.Click += new System.EventHandler(this.transImg_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // orgPicBox
            // 
            this.orgPicBox.Location = new System.Drawing.Point(227, 39);
            this.orgPicBox.Name = "orgPicBox";
            this.orgPicBox.Size = new System.Drawing.Size(287, 303);
            this.orgPicBox.TabIndex = 6;
            this.orgPicBox.TabStop = false;
            // 
            // modifiedPicBox
            // 
            this.modifiedPicBox.Location = new System.Drawing.Point(598, 39);
            this.modifiedPicBox.Name = "modifiedPicBox";
            this.modifiedPicBox.Size = new System.Drawing.Size(314, 303);
            this.modifiedPicBox.TabIndex = 7;
            this.modifiedPicBox.TabStop = false;
            // 
            // Transformation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 524);
            this.Controls.Add(this.modifiedPicBox);
            this.Controls.Add(this.orgPicBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.transImg_btn);
            this.Name = "Transformation_Form";
            this.Text = "Transformation_Form";
            ((System.ComponentModel.ISupportInitialize)(this.orgPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button transImg_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox orgPicBox;
        private System.Windows.Forms.PictureBox modifiedPicBox;
    }
}