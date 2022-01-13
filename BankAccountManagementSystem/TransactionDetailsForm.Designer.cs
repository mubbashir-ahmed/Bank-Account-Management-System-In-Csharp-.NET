namespace BankAccountManagementSystem
{
    partial class TransactionDetailsForm
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
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewAllUsersAccountDataSet = new BankAccountManagementSystem.ViewAllUsersAccountDataSet();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomerTableAdapter = new BankAccountManagementSystem.ViewAllUsersAccountDataSetTableAdapters.CustomerTableAdapter();
            this.TransactionDetailsDataSet = new BankAccountManagementSystem.TransactionDetailsDataSet();
            this.Customer_Transactions1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Customer_Transactions1TableAdapter = new BankAccountManagementSystem.TransactionDetailsDataSetTableAdapters.Customer_Transactions1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllUsersAccountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_Transactions1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataMember = "Customer";
            this.CustomerBindingSource.DataSource = this.ViewAllUsersAccountDataSet;
            // 
            // ViewAllUsersAccountDataSet
            // 
            this.ViewAllUsersAccountDataSet.DataSetName = "ViewAllUsersAccountDataSet";
            this.ViewAllUsersAccountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(12, 446);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 43;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 44);
            this.label1.TabIndex = 42;
            this.label1.Text = "Transaction Details";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TDDataSet";
            reportDataSource1.Value = this.Customer_Transactions1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BankAccountManagementSystem.TransactionDetailsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(680, 381);
            this.reportViewer1.TabIndex = 41;
            // 
            // CustomerTableAdapter
            // 
            this.CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // TransactionDetailsDataSet
            // 
            this.TransactionDetailsDataSet.DataSetName = "TransactionDetailsDataSet";
            this.TransactionDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Customer_Transactions1BindingSource
            // 
            this.Customer_Transactions1BindingSource.DataMember = "Customer Transactions1";
            this.Customer_Transactions1BindingSource.DataSource = this.TransactionDetailsDataSet;
            // 
            // Customer_Transactions1TableAdapter
            // 
            this.Customer_Transactions1TableAdapter.ClearBeforeFill = true;
            // 
            // TransactionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TransactionDetailsForm";
            this.Text = "TransactionDetailsForm";
            this.Load += new System.EventHandler(this.TransactionDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllUsersAccountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_Transactions1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private ViewAllUsersAccountDataSet ViewAllUsersAccountDataSet;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ViewAllUsersAccountDataSetTableAdapters.CustomerTableAdapter CustomerTableAdapter;
        private System.Windows.Forms.BindingSource Customer_Transactions1BindingSource;
        private TransactionDetailsDataSet TransactionDetailsDataSet;
        private TransactionDetailsDataSetTableAdapters.Customer_Transactions1TableAdapter Customer_Transactions1TableAdapter;
    }
}