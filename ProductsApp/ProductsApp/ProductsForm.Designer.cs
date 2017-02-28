namespace ProductsApp
{
    partial class ProductsForm
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
            this.btnViewProds = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewProds
            // 
            this.btnViewProds.Location = new System.Drawing.Point(120, 83);
            this.btnViewProds.Name = "btnViewProds";
            this.btnViewProds.Size = new System.Drawing.Size(106, 23);
            this.btnViewProds.TabIndex = 0;
            this.btnViewProds.Text = "View Products";
            this.btnViewProds.UseVisualStyleBackColor = true;
            this.btnViewProds.Click += new System.EventHandler(this.btnViewProds_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(120, 148);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(106, 23);
            this.btnAddProd.TabIndex = 1;
            this.btnAddProd.Text = "Add a Product";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 306);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.btnViewProds);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewProds;
        private System.Windows.Forms.Button btnAddProd;
    }
}