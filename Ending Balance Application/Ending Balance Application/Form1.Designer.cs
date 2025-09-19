
namespace Ending_Balance_Application
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
            this.lblStartingBalance = new System.Windows.Forms.Label();
            this.lblNumberOfMonths = new System.Windows.Forms.Label();
            this.lblEndingLabel = new System.Windows.Forms.Label();
            this.lblendingBalance = new System.Windows.Forms.Label();
            this.txtmonths = new System.Windows.Forms.TextBox();
            this.txtstartingBal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstDetailList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStartingBalance
            // 
            this.lblStartingBalance.AutoSize = true;
            this.lblStartingBalance.Location = new System.Drawing.Point(195, 91);
            this.lblStartingBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartingBalance.Name = "lblStartingBalance";
            this.lblStartingBalance.Size = new System.Drawing.Size(126, 16);
            this.lblStartingBalance.TabIndex = 0;
            this.lblStartingBalance.Text = "Starting Balance:";
            // 
            // lblNumberOfMonths
            // 
            this.lblNumberOfMonths.AutoSize = true;
            this.lblNumberOfMonths.Location = new System.Drawing.Point(195, 154);
            this.lblNumberOfMonths.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfMonths.Name = "lblNumberOfMonths";
            this.lblNumberOfMonths.Size = new System.Drawing.Size(136, 16);
            this.lblNumberOfMonths.TabIndex = 1;
            this.lblNumberOfMonths.Text = "Number of Months:";
            // 
            // lblEndingLabel
            // 
            this.lblEndingLabel.AutoSize = true;
            this.lblEndingLabel.Location = new System.Drawing.Point(195, 415);
            this.lblEndingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndingLabel.Name = "lblEndingLabel";
            this.lblEndingLabel.Size = new System.Drawing.Size(121, 16);
            this.lblEndingLabel.TabIndex = 2;
            this.lblEndingLabel.Text = "Ending Balance:";
            // 
            // lblendingBalance
            // 
            this.lblendingBalance.AutoSize = true;
            this.lblendingBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblendingBalance.Location = new System.Drawing.Point(356, 415);
            this.lblendingBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblendingBalance.Name = "lblendingBalance";
            this.lblendingBalance.Size = new System.Drawing.Size(2, 18);
            this.lblendingBalance.TabIndex = 3;
            // 
            // txtmonths
            // 
            this.txtmonths.Location = new System.Drawing.Point(356, 150);
            this.txtmonths.Margin = new System.Windows.Forms.Padding(4);
            this.txtmonths.Name = "txtmonths";
            this.txtmonths.Size = new System.Drawing.Size(172, 22);
            this.txtmonths.TabIndex = 5;
            // 
            // txtstartingBal
            // 
            this.txtstartingBal.Location = new System.Drawing.Point(356, 91);
            this.txtstartingBal.Margin = new System.Windows.Forms.Padding(4);
            this.txtstartingBal.Name = "txtstartingBal";
            this.txtstartingBal.Size = new System.Drawing.Size(172, 22);
            this.txtstartingBal.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(144, 471);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 28);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(344, 471);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(568, 471);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstDetailList
            // 
            this.lstDetailList.FormattingEnabled = true;
            this.lstDetailList.ItemHeight = 16;
            this.lstDetailList.Location = new System.Drawing.Point(198, 214);
            this.lstDetailList.Name = "lstDetailList";
            this.lstDetailList.Size = new System.Drawing.Size(403, 164);
            this.lstDetailList.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(788, 554);
            this.Controls.Add(this.lstDetailList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtstartingBal);
            this.Controls.Add(this.txtmonths);
            this.Controls.Add(this.lblendingBalance);
            this.Controls.Add(this.lblEndingLabel);
            this.Controls.Add(this.lblNumberOfMonths);
            this.Controls.Add(this.lblStartingBalance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Ending Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartingBalance;
        private System.Windows.Forms.Label lblNumberOfMonths;
        private System.Windows.Forms.Label lblEndingLabel;
        private System.Windows.Forms.Label lblendingBalance;
        private System.Windows.Forms.TextBox txtmonths;
        private System.Windows.Forms.TextBox txtstartingBal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstDetailList;
    }
}

