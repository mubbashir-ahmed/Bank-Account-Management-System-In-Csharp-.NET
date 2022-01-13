namespace BankAccountManagementSystem
{
    partial class UtilityBillsForm
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
            this.PayBillBtn = new System.Windows.Forms.Button();
            this.StatusTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsumerNoTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(19, 265);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 136;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // PayBillBtn
            // 
            this.PayBillBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBillBtn.Location = new System.Drawing.Point(100, 239);
            this.PayBillBtn.Name = "PayBillBtn";
            this.PayBillBtn.Size = new System.Drawing.Size(231, 49);
            this.PayBillBtn.TabIndex = 135;
            this.PayBillBtn.Text = "Pay Bill";
            this.PayBillBtn.UseVisualStyleBackColor = true;
            this.PayBillBtn.Click += new System.EventHandler(this.PayBillBtn_Click);
            // 
            // StatusTB
            // 
            this.StatusTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusTB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTB.ForeColor = System.Drawing.Color.Green;
            this.StatusTB.Location = new System.Drawing.Point(191, 195);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.ReadOnly = true;
            this.StatusTB.Size = new System.Drawing.Size(150, 32);
            this.StatusTB.TabIndex = 137;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 32);
            this.label6.TabIndex = 143;
            this.label6.Text = "Status:";
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(144, 149);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(250, 26);
            this.AmountTB.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 141;
            this.label4.Text = "Amount:";
            // 
            // ConsumerNoTB
            // 
            this.ConsumerNoTB.Location = new System.Drawing.Point(144, 105);
            this.ConsumerNoTB.Name = "ConsumerNoTB";
            this.ConsumerNoTB.Size = new System.Drawing.Size(250, 26);
            this.ConsumerNoTB.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 140;
            this.label3.Text = "Consumer No.:";
            // 
            // BillCB
            // 
            this.BillCB.FormattingEnabled = true;
            this.BillCB.Items.AddRange(new object[] {
            "Electricity",
            "Gas",
            "Water",
            "Telephone"});
            this.BillCB.Location = new System.Drawing.Point(144, 61);
            this.BillCB.Name = "BillCB";
            this.BillCB.Size = new System.Drawing.Size(250, 26);
            this.BillCB.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 139;
            this.label2.Text = "Bill:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 44);
            this.label1.TabIndex = 138;
            this.label1.Text = "Utility Bill Payment";
            // 
            // UtilityBillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 310);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PayBillBtn);
            this.Controls.Add(this.StatusTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConsumerNoTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BillCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UtilityBillsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utility Bills";
            this.Load += new System.EventHandler(this.UtilityBillsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button PayBillBtn;
        private System.Windows.Forms.TextBox StatusTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConsumerNoTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BillCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}