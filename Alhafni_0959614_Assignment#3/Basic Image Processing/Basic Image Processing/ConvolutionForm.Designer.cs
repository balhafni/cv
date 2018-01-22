namespace Basic_Image_Processing
{
    partial class ConvolutionForm
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
            this.convoluteBtn = new System.Windows.Forms.Button();
            this.savePicBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.orgPicBox = new System.Windows.Forms.PictureBox();
            this.modifiedPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orgPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // convoluteBtn
            // 
            this.convoluteBtn.Location = new System.Drawing.Point(60, 88);
            this.convoluteBtn.Name = "convoluteBtn";
            this.convoluteBtn.Size = new System.Drawing.Size(97, 23);
            this.convoluteBtn.TabIndex = 0;
            this.convoluteBtn.Text = "Convolute";
            this.convoluteBtn.UseVisualStyleBackColor = true;
            this.convoluteBtn.Click += new System.EventHandler(this.convoluteBtn_Click);
            // 
            // savePicBtn
            // 
            this.savePicBtn.Location = new System.Drawing.Point(60, 153);
            this.savePicBtn.Name = "savePicBtn";
            this.savePicBtn.Size = new System.Drawing.Size(97, 23);
            this.savePicBtn.TabIndex = 1;
            this.savePicBtn.Text = "Save Picture";
            this.savePicBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(420, 419);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kernel";
            // 
            // orgPicBox
            // 
            this.orgPicBox.Location = new System.Drawing.Point(213, 52);
            this.orgPicBox.Name = "orgPicBox";
            this.orgPicBox.Size = new System.Drawing.Size(287, 303);
            this.orgPicBox.TabIndex = 5;
            this.orgPicBox.TabStop = false;
            // 
            // modifiedPicBox
            // 
            this.modifiedPicBox.Location = new System.Drawing.Point(536, 52);
            this.modifiedPicBox.Name = "modifiedPicBox";
            this.modifiedPicBox.Size = new System.Drawing.Size(314, 303);
            this.modifiedPicBox.TabIndex = 6;
            this.modifiedPicBox.TabStop = false;
            // 
            // ConvolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 586);
            this.Controls.Add(this.modifiedPicBox);
            this.Controls.Add(this.orgPicBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.savePicBtn);
            this.Controls.Add(this.convoluteBtn);
            this.Name = "ConvolutionForm";
            this.Text = "ConvolutionForm";
            this.Load += new System.EventHandler(this.ConvolutionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convoluteBtn;
        private System.Windows.Forms.Button savePicBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox orgPicBox;
        private System.Windows.Forms.PictureBox modifiedPicBox;
    }
}