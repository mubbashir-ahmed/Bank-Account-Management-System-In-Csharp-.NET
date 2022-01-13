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
    public partial class AdminLoginForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MUBBASHIR-PC;User ID=sa;Password=sql123");

        public AdminLoginForm()
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
            cmd.CommandText = "SELECT Emp_Username, Emp_Password, Emp_Designation FROM [Admin Login] WHERE Emp_Username = '" + UsernameTB.Text + "' AND Emp_Password = '" + PasswordTB.Text + "' AND Emp_Designation = '" + PostCB.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful! Welcome to your Dashboard.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminDashboardForm ADF = new AdminDashboardForm();
                this.Hide();
                ADF.Show();
            }
            else
            {
                MessageBox.Show("Login Failed! Invalid Username or Password or Post.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            PostCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
