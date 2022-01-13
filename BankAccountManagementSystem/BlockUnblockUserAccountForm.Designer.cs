namespace BankAccountManagementSystem
{
    partial class BlockUnblockUserAccountForm
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
            this.AccNoCB = new System.Windows.Forms.ComboBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.BlockBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UnblockBtn = new System.Windows.Forms.Button();
            this.AccTitleTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AccNoCB
            // 
            this.AccNoCB.FormattingEnabled = true;
            this.AccNoCB.Location = new System.Drawing.Point(157, 57);
            this.AccNoCB.MaxLength = 1;
            this.AccNoCB.Name = "AccNoCB";
            this.AccNoCB.Size = new System.Drawing.Size(170, 26);
            this.AccNoCB.TabIndex = 106;
            this.AccNoCB.SelectedIndexChanged += new System.EventHandler(this.AccNoCB_SelectedIndexChanged);
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(454, 97);
            this.LastNameTB.MaxLength = 20;
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(170, 26);
            this.LastNameTB.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 119;
            this.label4.Text = "Account No.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 118;
            this.label3.Text = "Last Name:";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(157, 97);
            this.FirstNameTB.MaxLength = 20;
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(170, 26);
            this.FirstNameTB.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 117;
            this.label2.Text = "First Name:";
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(24, 207);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 116;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // BlockBtn
            // 
            this.BlockBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockBtn.Location = new System.Drawing.Point(157, 181);
            this.BlockBtn.Name = "BlockBtn";
            this.BlockBtn.Size = new System.Drawing.Size(231, 49);
            this.BlockBtn.TabIndex = 115;
            this.BlockBtn.Text = "Block";
            this.BlockBtn.UseVisualStyleBackColor = true;
            this.BlockBtn.Click += new System.EventHandler(this.BlockBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 44);
            this.label1.TabIndex = 107;
            this.label1.Text = "Block/Unblock User Account";
            // 
            // UnblockBtn
            // 
            this.UnblockBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnblockBtn.Location = new System.Drawing.Point(394, 181);
            this.UnblockBtn.Name = "UnblockBtn";
            this.UnblockBtn.Size = new System.Drawing.Size(231, 49);
            this.UnblockBtn.TabIndex = 125;
            this.UnblockBtn.Text = "Unblock";
            this.UnblockBtn.UseVisualStyleBackColor = true;
            this.UnblockBtn.Click += new System.EventHandler(this.UnblockBtn_Click);
            // 
            // AccTitleTB
            // 
            this.AccTitleTB.Location = new System.Drawing.Point(454, 57);
            this.AccTitleTB.MaxLength = 40;
            this.AccTitleTB.Name = "AccTitleTB";
            this.AccTitleTB.Size = new System.Drawing.Size(170, 26);
            this.AccTitleTB.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 127;
            this.label5.Text = "Account Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 32);
            this.label6.TabIndex = 128;
            this.label6.Text = "Status:";
            // 
            // StatusTB
            // 
            this.StatusTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusTB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTB.ForeColor = System.Drawing.Color.Green;
            this.StatusTB.Location = new System.Drawing.Point(296, 135);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.ReadOnly = true;
            this.StatusTB.Size = new System.Drawing.Size(150, 32);
            this.StatusTB.TabIndex = 129;
            // 
            // BlockUnblockUserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 251);
            this.Controls.Add(this.StatusTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccTitleTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UnblockBtn);
            this.Controls.Add(this.AccNoCB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.BlockBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BlockUnblockUserAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block/Unblock User Account";
            this.Load += new System.EventHandler(this.BlockUnblockUserAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AccNoCB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button BlockBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UnblockBtn;
        private System.Windows.Forms.TextBox AccTitleTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StatusTB;
    }
}