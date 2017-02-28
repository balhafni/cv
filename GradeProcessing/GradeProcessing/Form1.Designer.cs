namespace GradeProcessing
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_itemRead = new System.Windows.Forms.ToolStripMenuItem();
            this.readStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid_students = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.dispalyGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_students)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_itemRead});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_itemRead
            // 
            this.menu_itemRead.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readStudentsToolStripMenuItem,
            this.processAndSaveToolStripMenuItem,
            this.addToolStripMenuItem,
            this.dispalyGradesToolStripMenuItem});
            this.menu_itemRead.Name = "menu_itemRead";
            this.menu_itemRead.Size = new System.Drawing.Size(61, 20);
            this.menu_itemRead.Text = "Options";
            // 
            // readStudentsToolStripMenuItem
            // 
            this.readStudentsToolStripMenuItem.Name = "readStudentsToolStripMenuItem";
            this.readStudentsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.readStudentsToolStripMenuItem.Text = "Read Students";
            this.readStudentsToolStripMenuItem.Click += new System.EventHandler(this.readStudentsToolStripMenuItem_Click);
            // 
            // processAndSaveToolStripMenuItem
            // 
            this.processAndSaveToolStripMenuItem.Name = "processAndSaveToolStripMenuItem";
            this.processAndSaveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.processAndSaveToolStripMenuItem.Text = "Process and Save";
            this.processAndSaveToolStripMenuItem.Click += new System.EventHandler(this.processAndSaveToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addToolStripMenuItem.Text = "Add Student";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // dataGrid_students
            // 
            this.dataGrid_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_students.Location = new System.Drawing.Point(83, 27);
            this.dataGrid_students.Name = "dataGrid_students";
            this.dataGrid_students.Size = new System.Drawing.Size(734, 127);
            this.dataGrid_students.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(27, 41);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(50, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Students";
            // 
            // dispalyGradesToolStripMenuItem
            // 
            this.dispalyGradesToolStripMenuItem.Name = "dispalyGradesToolStripMenuItem";
            this.dispalyGradesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dispalyGradesToolStripMenuItem.Text = "Dispaly Grades";
            this.dispalyGradesToolStripMenuItem.Click += new System.EventHandler(this.dispalyGradesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 314);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dataGrid_students);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_itemRead;
        private System.Windows.Forms.ToolStripMenuItem readStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processAndSaveToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid_students;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispalyGradesToolStripMenuItem;
    }
}

