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
    public partial class BlockUnblockUserAccountForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MUBBASHIR-PC;User ID=sa;Password=sql123");

        public BlockUnblockUserAccountForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminDashboardForm ADF = new AdminDashboardForm();
            this.Hide();
            ADF.Show();
        }

        private void BlockUnblockUserAccountForm_Load(object sender, EventArgs e)
        {
            AccNoCB.DropDownStyle = ComboBoxStyle.DropDownList;
            FillComboBox();
        }

        private void FillComboBox()
        {
            SqlDataReader reader;
            string query = "SELECT * FROM Customer";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string AccNo = reader["Cust_AccNo"].ToString();
                    AccNoCB.Items.Add(AccNo);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void ClearFields()
        {
            FirstNameTB.Clear();
            LastNameTB.Clear();
            AccNoCB.SelectedIndex = -1;
            AccTitleTB.Clear();
            StatusTB.Clear();
        }

        private void BlockBtn_Click(object sender, EventArgs e)
        {
            
            if (StatusTB.Text == "Unblocked")
            {
                UpdateUserAccStatus("Blocked");
                ClearFields();
                MessageBox.Show("Account successfully blocked!", "Account Blocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(StatusTB.Text == "Blocked")
            {
                MessageBox.Show("Account is already blocked!", "Account Already Blocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UnblockBtn_Click(object sender, EventArgs e)
        {
            if(StatusTB.Text == "Blocked")
            {
                UpdateUserAccStatus("Unblocked");
                ClearFields();
                MessageBox.Show("Account successfully unblocked!", "Account Unblocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(StatusTB.Text == "Unblocked")
            {
                MessageBox.Show("Account is already unblocked!", "Account Already Unblocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GetUserData()
        {
            SqlDataReader reader;
            string query = "SELECT * FROM Customer WHERE Cust_AccNo = '" + AccNoCB.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FirstNameTB.Text = (reader["Cust_FirstName"].ToString());
                LastNameTB.Text = (reader["Cust_LastName"].ToString());
                AccTitleTB.Text = (reader["Cust_AccTitle"].ToString());
                StatusTB.Text = (reader["Cust_Status"].ToString());
            }
            con.Close();
        }

        private void AccNoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserData();
            if (StatusTB.Text == "Blocked")
            {
                StatusTB.BackColor = this.BackColor;
                StatusTB.ForeColor = Color.Red;
            }
            else if (StatusTB.Text == "Unblocked")
            {
                StatusTB.BackColor = this.BackColor;
                StatusTB.ForeColor = Color.Green;
            }
        }

        private void UpdateUserAccStatus(string Status)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Customer SET Cust_Status = '" + Status + "' WHERE Cust_AccNo = '" + AccNoCB.SelectedItem + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
