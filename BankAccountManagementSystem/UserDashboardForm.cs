using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountManagementSystem
{
    public partial class UserDashboardForm : Form
    {
        public UserDashboardForm()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            UserLoginForm ULF = new UserLoginForm();
            this.Hide();
            ULF.Show();
        }

        private void ComplaintBtn_Click(object sender, EventArgs e)
        {
            ComplaintForm CF = new ComplaintForm();
            this.Hide();
            CF.Show();
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            UserDetailsForm UDF = new UserDetailsForm();
            this.Hide();
            UDF.Show();
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            DepositMoneyForm DMF = new DepositMoneyForm();
            this.Hide();
            DMF.Show();
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            WithdrawMoneyForm WMF = new WithdrawMoneyForm();
            this.Hide();
            WMF.Show();
        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            TransferMoneyForm TMF = new TransferMoneyForm();
            this.Hide();
            TMF.Show();
        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            UtilityBillsForm UBF = new UtilityBillsForm();
            this.Hide();
            UBF.Show();
        }

        private void TransactionBtn_Click(object sender, EventArgs e)
        {
            TransactionDetailsForm TDF = new TransactionDetailsForm();
            this.Hide();
            TDF.Show();
        }
    }
}
