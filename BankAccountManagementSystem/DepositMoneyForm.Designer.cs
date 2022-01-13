namespace BankAccountManagementSystem
{
    partial class DepositMoneyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MediumCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChequeNoTB = new System.Windows.Forms.TextBox();
            this.PayOrderNoTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 44);
            this.label1.TabIndex = 85;
            this.label1.Text = "Deposit Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 86;
            this.label2.Text = "Medium:";
            // 
            // MediumCB
            // 
            this.MediumCB.FormattingEnabled = true;
            this.MediumCB.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Pay Order"});
            this.MediumCB.Location = new System.Drawing.Point(141, 61);
            this.MediumCB.Name = "MediumCB";
            this.MediumCB.Size = new System.Drawing.Size(250, 26);
            this.MediumCB.TabIndex = 1;
            this.MediumCB.SelectedIndexChanged += new System.EventHandler(this.MediumCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 88;
            this.label3.Text = "Amount:";
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(141, 105);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(250, 26);
            this.AmountTB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 90;
            this.label4.Text = "Cheque No.:";
            // 
            // ChequeNoTB
            // 
            this.ChequeNoTB.Location = new System.Drawing.Point(141, 149);
            this.ChequeNoTB.Name = "ChequeNoTB";
            this.ChequeNoTB.Size = new System.Drawing.Size(250, 26);
            this.ChequeNoTB.TabIndex = 3;
            // 
            // PayOrderNoTB
            // 
            this.PayOrderNoTB.Location = new System.Drawing.Point(141, 193);
            this.PayOrderNoTB.Name = "PayOrderNoTB";
            this.PayOrderNoTB.Size = new System.Drawing.Size(250, 26);
            this.PayOrderNoTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 92;
            this.label5.Text = "Pay Order No.:";
            // 
            // StatusTB
            // 
            this.StatusTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusTB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTB.ForeColor = System.Drawing.Color.Green;
            this.StatusTB.Location = new System.Drawing.Point(189, 237);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.ReadOnly = true;
            this.StatusTB.Size = new System.Drawing.Size(150, 32);
            this.StatusTB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 32);
            this.label6.TabIndex = 130;
            this.label6.Text = "Status:";
            // 
            // DepositBtn
            // 
            this.DepositBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBtn.Location = new System.Drawing.Point(98, 281);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(231, 49);
            this.DepositBtn.TabIndex = 5;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = true;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(17, 307);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DepositMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 346);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.StatusTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PayOrderNoTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChequeNoTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MediumCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepositMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit Money";
            this.Load += new System.EventHandler(this.DepositMoneyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MediumCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ChequeNoTB;
        private System.Windows.Forms.TextBox PayOrderNoTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StatusTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}