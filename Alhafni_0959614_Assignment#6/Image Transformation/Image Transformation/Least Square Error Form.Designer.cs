namespace Image_Transformation
{
    partial class Least_Square_Error_Form
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
            this.transformation_btn = new System.Windows.Forms.Button();
            this.alignment_panel = new System.Windows.Forms.Panel();
            this.panel_shape1 = new System.Windows.Forms.Panel();
            this.init_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transformation_btn
            // 
            this.transformation_btn.Location = new System.Drawing.Point(702, 396);
            this.transformation_btn.Name = "transformation_btn";
            this.transformation_btn.Size = new System.Drawing.Size(128, 23);
            this.transformation_btn.TabIndex = 8;
            this.transformation_btn.Text = "Apply Transformation";
            this.transformation_btn.UseVisualStyleBackColor = true;
            this.transformation_btn.Click += new System.EventHandler(this.transformation_btn_Click);
            // 
            // alignment_panel
            // 
            this.alignment_panel.Location = new System.Drawing.Point(635, 11);
            this.alignment_panel.Name = "alignment_panel";
            this.alignment_panel.Size = new System.Drawing.Size(281, 337);
            this.alignment_panel.TabIndex = 7;
            // 
            // panel_shape1
            // 
            this.panel_shape1.Location = new System.Drawing.Point(45, 11);
            this.panel_shape1.Name = "panel_shape1";
            this.panel_shape1.Size = new System.Drawing.Size(281, 337);
            this.panel_shape1.TabIndex = 6;
            // 
            // init_btn
            // 
            this.init_btn.Location = new System.Drawing.Point(111, 396);
            this.init_btn.Name = "init_btn";
            this.init_btn.Size = new System.Drawing.Size(128, 23);
            this.init_btn.TabIndex = 5;
            this.init_btn.Text = "Initialize Shapes";
            this.init_btn.UseVisualStyleBackColor = true;
            this.init_btn.Click += new System.EventHandler(this.init_btn_Click);
            // 
            // Least_Square_Error_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 431);
            this.Controls.Add(this.transformation_btn);
            this.Controls.Add(this.alignment_panel);
            this.Controls.Add(this.panel_shape1);
            this.Controls.Add(this.init_btn);
            this.Name = "Least_Square_Error_Form";
            this.Text = "Least_Square_Error_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button transformation_btn;
        private System.Windows.Forms.Panel alignment_panel;
        private System.Windows.Forms.Panel panel_shape1;
        private System.Windows.Forms.Button init_btn;
    }
}