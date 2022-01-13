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
    public partial class UpdateUserAccountInfoForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MUBBASHIR-PC;User ID=sa;Password=sql123");

        public UpdateUserAccountInfoForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminDashboardForm ADF = new AdminDashboardForm();
            this.Hide();
            ADF.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(AccNoCB.SelectedItem != null)
            {
                UpdateUserData();
            }
            else
            {
                MessageBox.Show("Kindly select \"Account No.\" to update user data.!", "Select Account No.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearFields();
        }

        private void ClearFields()
        {
            FirstNameTB.Clear();
            LastNameTB.Clear();
            AccNoCB.SelectedIndex = -1;
            AddressTB.Clear();
            PhoneNoTB.Clear();
            EmailTB.Clear();
            CompanyNameTB.Clear();
            OccupTB.Clear();
        }

        private void UpdateUserInfoForm_Load(object sender, EventArgs e)
        {
            AccNoCB.DropDownStyle = ComboBoxStyle.DropDownList;
            FillComboBox();
            ClearFields();
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
                AddressTB.Text = (reader["Cust_Address"].ToString());
                EmailTB.Text = (reader["Cust_Email"].ToString());
                PhoneNoTB.Text = (reader["Cust_PhoneNo"].ToString());
                CompanyNameTB.Text = (reader["Cust_CompanyName"].ToString());
                OccupTB.Text = (reader["Cust_Occupation"].ToString());
            }
            con.Close();
        }

        private void UpdateUserData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Customer SET Cust_FirstName = '" + FirstNameTB.Text + "', Cust_LastName = '" + LastNameTB.Text + "', Cust_Address = '"
                    + AddressTB.Text + "', Cust_PhoneNo = '" + PhoneNoTB.Text + "', Cust_Email = '"
                    + EmailTB.Text + "', Cust_CompanyName = '" + CompanyNameTB.Text + "', Cust_Occupation = '" + OccupTB.Text + "' WHERE Cust_AccNo = '" + AccNoCB.SelectedItem + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User account information successfully updated!", "User Account Info Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AccNoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserData();
        }
    }
}
