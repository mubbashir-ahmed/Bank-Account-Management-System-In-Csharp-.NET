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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            AdminLoginForm ALF = new AdminLoginForm();
            this.Hide();
            ALF.Show();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateUserAccountForm CUAF = new CreateUserAccountForm();
            this.Hide();
            CUAF.Show();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewAllUsersAccountForm VAUF = new ViewAllUsersAccountForm();
            this.Hide();
            VAUF.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateUserAccountInfoForm UUIF = new UpdateUserAccountInfoForm();
            this.Hide();
            UUIF.Show();
        }

        private void BlockBtn_Click(object sender, EventArgs e)
        {
            BlockUnblockUserAccountForm DAF = new BlockUnblockUserAccountForm();
            this.Hide();
            DAF.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchAccountForm SAF = new SearchAccountForm();
            this.Hide();
            SAF.Show();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
