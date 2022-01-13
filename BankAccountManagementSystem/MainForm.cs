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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ALBtn_Click(object sender, EventArgs e)
        {
            AdminLoginForm ALF = new AdminLoginForm();
            this.Hide();
            ALF.Show();
        }

        private void ULBtn_Click(object sender, EventArgs e)
        {
            UserLoginForm ULF = new UserLoginForm();
            this.Hide();
            ULF.Show();
        }
    }
}
