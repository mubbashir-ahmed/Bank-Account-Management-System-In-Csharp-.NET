using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankAccountManagementSystem
{
    public partial class UserLoginForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MUBBASHIR-PC;User ID=sa;Password=sql123");
        public static string AccNoText, PinCodeText;

        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Cust_AccNo, Cust_PinCode FROM Customer WHERE Cust_AccNo = '" + AccNoTB.Text + "' AND Cust_PinCode = '" + PinTB.Text + "' AND Cust_Status = 'Unblocked'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                AccNoText = AccNoTB.Text;
                PinCodeText = PinTB.Text;
                ClearFields();
                MessageBox.Show("Login Successful! Welcome to your Dashboard.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserDashboardForm UDF = new UserDashboardForm();
                this.Hide();
                UDF.Show();
            }
            else
            {
                ClearFields();
                MessageBox.Show("Login Failed! Invalid Username or Password or Account Blocked", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            AccNoTB.Clear();
            PinTB.Clear();
        }
    }
}
