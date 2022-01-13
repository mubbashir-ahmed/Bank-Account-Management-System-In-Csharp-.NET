namespace BankAccountManagementSystem
{
    partial class ViewAllUsersAccountForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ViewAllUsersAccountDataSet = new BankAccountManagementSystem.ViewAllUsersAccountDataSet();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerTableAdapter = new BankAccountManagementSystem.ViewAllUsersAccountDataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllUsersAccountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ViewAllUsersAccountDataSet";
            reportDataSource1.Value = this.CustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BankAccountManagementSystem.ViewAllUsersAccountReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(680, 381);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "View All Users Accounts";
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(12, 446);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 40;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ViewAllUsersAccountDataSet
            // 
            this.ViewAllUsersAccountDataSet.DataSetName = "ViewAllUsersAccountDataSet";
            this.ViewAllUsersAccountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataMember = "Customer";
            this.CustomerBindingSource.DataSource = this.ViewAllUsersAccountDataSet;
            // 
            // CustomerTableAdapter
            // 
            this.CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // ViewAllUsersAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewAllUsersAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Users Accounts";
            this.Load += new System.EventHandler(this.ViewAllUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllUsersAccountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private ViewAllUsersAccountDataSet ViewAllUsersAccountDataSet;
        private ViewAllUsersAccountDataSetTableAdapters.CustomerTableAdapter CustomerTableAdapter;
    }
}