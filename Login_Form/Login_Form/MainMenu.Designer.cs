namespace Login_Form
{
    partial class MainMenu
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
            this.IssuecardLbl = new System.Windows.Forms.Label();
            this.ExitLbl = new System.Windows.Forms.Label();
            this.openAccountLbl = new System.Windows.Forms.Label();
            this.depositLbl = new System.Windows.Forms.Label();
            this.transferFundsLbl = new System.Windows.Forms.Label();
            this.withdrawLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IssuecardLbl
            // 
            this.IssuecardLbl.AutoSize = true;
            this.IssuecardLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuecardLbl.Location = new System.Drawing.Point(212, 71);
            this.IssuecardLbl.Name = "IssuecardLbl";
            this.IssuecardLbl.Size = new System.Drawing.Size(156, 22);
            this.IssuecardLbl.TabIndex = 34;
            this.IssuecardLbl.Text = "Cheque Services";
            // 
            // ExitLbl
            // 
            this.ExitLbl.AutoSize = true;
            this.ExitLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLbl.Location = new System.Drawing.Point(257, 297);
            this.ExitLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(41, 22);
            this.ExitLbl.TabIndex = 32;
            this.ExitLbl.Text = "Exit";
            // 
            // openAccountLbl
            // 
            this.openAccountLbl.AutoSize = true;
            this.openAccountLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAccountLbl.Location = new System.Drawing.Point(257, 212);
            this.openAccountLbl.Name = "openAccountLbl";
            this.openAccountLbl.Size = new System.Drawing.Size(45, 22);
            this.openAccountLbl.TabIndex = 27;
            this.openAccountLbl.Text = "Bills";
            // 
            // depositLbl
            // 
            this.depositLbl.AutoSize = true;
            this.depositLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLbl.Location = new System.Drawing.Point(257, 253);
            this.depositLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depositLbl.Name = "depositLbl";
            this.depositLbl.Size = new System.Drawing.Size(54, 22);
            this.depositLbl.TabIndex = 30;
            this.depositLbl.Text = "Utility";
            // 
            // transferFundsLbl
            // 
            this.transferFundsLbl.AutoSize = true;
            this.transferFundsLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferFundsLbl.Location = new System.Drawing.Point(212, 168);
            this.transferFundsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.transferFundsLbl.Name = "transferFundsLbl";
            this.transferFundsLbl.Size = new System.Drawing.Size(138, 22);
            this.transferFundsLbl.TabIndex = 28;
            this.transferFundsLbl.Text = "Transfer Funds";
            // 
            // withdrawLbl
            // 
            this.withdrawLbl.AutoSize = true;
            this.withdrawLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawLbl.Location = new System.Drawing.Point(226, 120);
            this.withdrawLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.withdrawLbl.Name = "withdrawLbl";
            this.withdrawLbl.Size = new System.Drawing.Size(124, 22);
            this.withdrawLbl.TabIndex = 29;
            this.withdrawLbl.Text = "View Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 44);
            this.label6.TabIndex = 33;
            this.label6.Text = "Services";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.IssuecardLbl);
            this.Controls.Add(this.ExitLbl);
            this.Controls.Add(this.openAccountLbl);
            this.Controls.Add(this.depositLbl);
            this.Controls.Add(this.transferFundsLbl);
            this.Controls.Add(this.withdrawLbl);
            this.Controls.Add(this.label6);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IssuecardLbl;
        private System.Windows.Forms.Label ExitLbl;
        private System.Windows.Forms.Label openAccountLbl;
        private System.Windows.Forms.Label depositLbl;
        private System.Windows.Forms.Label transferFundsLbl;
        private System.Windows.Forms.Label withdrawLbl;
        private System.Windows.Forms.Label label6;
    }
}