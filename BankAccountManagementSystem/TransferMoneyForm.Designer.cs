namespace BankAccountManagementSystem
{
    partial class TransferMoneyForm
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.StatusTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReceiverAccNoTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(21, 223);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 149;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // TransferBtn
            // 
            this.TransferBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferBtn.Location = new System.Drawing.Point(102, 197);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(231, 49);
            this.TransferBtn.TabIndex = 148;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // StatusTB
            // 
            this.StatusTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusTB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTB.ForeColor = System.Drawing.Color.Green;
            this.StatusTB.Location = new System.Drawing.Point(193, 153);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.ReadOnly = true;
            this.StatusTB.Size = new System.Drawing.Size(150, 32);
            this.StatusTB.TabIndex = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 32);
            this.label6.TabIndex = 156;
            this.label6.Text = "Status:";
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(193, 107);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(200, 26);
            this.AmountTB.TabIndex = 146;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 154;
            this.label4.Text = "Amount:";
            // 
            // ReceiverAccNoTB
            // 
            this.ReceiverAccNoTB.Location = new System.Drawing.Point(193, 63);
            this.ReceiverAccNoTB.Name = "ReceiverAccNoTB";
            this.ReceiverAccNoTB.Size = new System.Drawing.Size(200, 26);
            this.ReceiverAccNoTB.TabIndex = 145;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 153;
            this.label3.Text = "Receiver Account No.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 44);
            this.label1.TabIndex = 151;
            this.label1.Text = "Transfer Money";
            // 
            // TransferMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 267);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.StatusTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReceiverAccNoTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransferMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Money";
            this.Load += new System.EventHandler(this.TransferMoneyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.TextBox StatusTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReceiverAccNoTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}