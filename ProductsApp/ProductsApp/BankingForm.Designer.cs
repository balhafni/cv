namespace ProductsApp
{
    partial class BankingForm
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
            this.txtSavingNum = new System.Windows.Forms.TextBox();
            this.txtCheckingNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCheckingBalance = new System.Windows.Forms.Label();
            this.lblSavingBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetBalances = new System.Windows.Forms.Button();
            this.btnTransferChecking = new System.Windows.Forms.Button();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSavingNum
            // 
            this.txtSavingNum.Location = new System.Drawing.Point(184, 88);
            this.txtSavingNum.Name = "txtSavingNum";
            this.txtSavingNum.Size = new System.Drawing.Size(100, 20);
            this.txtSavingNum.TabIndex = 0;
            // 
            // txtCheckingNum
            // 
            this.txtCheckingNum.Location = new System.Drawing.Point(184, 35);
            this.txtCheckingNum.Name = "txtCheckingNum";
            this.txtCheckingNum.Size = new System.Drawing.Size(100, 20);
            this.txtCheckingNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saving Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Checking Account";
            // 
            // lblCheckingBalance
            // 
            this.lblCheckingBalance.AutoSize = true;
            this.lblCheckingBalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCheckingBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCheckingBalance.Location = new System.Drawing.Point(447, 40);
            this.lblCheckingBalance.Name = "lblCheckingBalance";
            this.lblCheckingBalance.Size = new System.Drawing.Size(2, 15);
            this.lblCheckingBalance.TabIndex = 14;
            // 
            // lblSavingBalance
            // 
            this.lblSavingBalance.AutoSize = true;
            this.lblSavingBalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSavingBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSavingBalance.Location = new System.Drawing.Point(447, 95);
            this.lblSavingBalance.Name = "lblSavingBalance";
            this.lblSavingBalance.Size = new System.Drawing.Size(2, 15);
            this.lblSavingBalance.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Saving Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Checking Balance";
            // 
            // btnGetBalances
            // 
            this.btnGetBalances.Location = new System.Drawing.Point(184, 152);
            this.btnGetBalances.Name = "btnGetBalances";
            this.btnGetBalances.Size = new System.Drawing.Size(118, 23);
            this.btnGetBalances.TabIndex = 15;
            this.btnGetBalances.Text = "Get Balances";
            this.btnGetBalances.UseVisualStyleBackColor = true;
            this.btnGetBalances.Click += new System.EventHandler(this.btnGetBalances_Click);
            // 
            // btnTransferChecking
            // 
            this.btnTransferChecking.Location = new System.Drawing.Point(560, 152);
            this.btnTransferChecking.Name = "btnTransferChecking";
            this.btnTransferChecking.Size = new System.Drawing.Size(178, 23);
            this.btnTransferChecking.TabIndex = 18;
            this.btnTransferChecking.Text = "Transfer Checking To Savings";
            this.btnTransferChecking.UseVisualStyleBackColor = true;
            this.btnTransferChecking.Click += new System.EventHandler(this.btnTransferChecking_Click);
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(404, 154);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Amount";
            // 
            // BankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 252);
            this.Controls.Add(this.btnTransferChecking);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetBalances);
            this.Controls.Add(this.lblCheckingBalance);
            this.Controls.Add(this.lblSavingBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCheckingNum);
            this.Controls.Add(this.txtSavingNum);
            this.Name = "BankingForm";
            this.Text = "BankingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSavingNum;
        private System.Windows.Forms.TextBox txtCheckingNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCheckingBalance;
        private System.Windows.Forms.Label lblSavingBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetBalances;
        private System.Windows.Forms.Button btnTransferChecking;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label5;
    }
}