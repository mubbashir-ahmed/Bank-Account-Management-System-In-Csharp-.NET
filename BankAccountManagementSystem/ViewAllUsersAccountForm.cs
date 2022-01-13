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
    public partial class ViewAllUsersAccountForm : Form
    {
        public ViewAllUsersAccountForm()
        {
            InitializeComponent();
        }

        private void ViewAllUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ViewAllUsersAccountDataSet.Customer' table. You can move, or remove it, as needed.
            this.CustomerTableAdapter.Fill(this.ViewAllUsersAccountDataSet.Customer);
            this.reportViewer1.RefreshReport();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminDashboardForm ADF = new AdminDashboardForm();
            this.Hide();
            ADF.Show();
        }
    }
}
