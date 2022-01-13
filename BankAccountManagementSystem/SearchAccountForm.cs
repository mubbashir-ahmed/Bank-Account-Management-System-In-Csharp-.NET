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
    public partial class SearchAccountForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MUBBASHIR-PC;User ID=sa;Password=sql123");

        public SearchAccountForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminDashboardForm ADF = new AdminDashboardForm();
            this.Hide();
            ADF.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchOptCB.Text == "Name")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Cust_FirstName AS [First Name], Cust_LastName AS [Last Name], Cust_AccNo AS [Account Number], Cust_AccTitle AS [Account Title], Cust_AccType AS [Account Type], Cust_Gender AS [Gender], Cust_DOB AS [Date Of Birth], Cust_Address AS [Address], Cust_City AS [City], Cust_Country AS [Country], Cust_Nationality AS [Nationality], Cust_PhoneNo AS [Phone Number], Cust_NICNo AS [NIC Number], Cust_Email AS [Email], Cust_CompanyName AS [Company Name], Cust_Occupation AS [Occupation], Cust_InitialDeposit AS [Initial Deposit] FROM Customer WHERE Cust_FirstName LIKE '" + SearchValueTB.Text + "' OR Cust_LastName LIKE '" + SearchValueTB.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                ClearFields();
            }
            else if (SearchOptCB.Text == "NIC No.")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Cust_FirstName AS [First Name], Cust_LastName AS [Last Name], Cust_AccNo AS [Account Number], Cust_AccTitle AS [Account Title], Cust_AccType AS [Account Type], Cust_Gender AS [Gender], Cust_DOB AS [Date Of Birth], Cust_Address AS [Address], Cust_City AS [City], Cust_Country AS [Country], Cust_Nationality AS [Nationality], Cust_PhoneNo AS [Phone Number], Cust_NICNo AS [NIC Number], Cust_Email AS [Email], Cust_CompanyName AS [Company Name], Cust_Occupation AS [Occupation], Cust_InitialDeposit AS [Initial Deposit] FROM Customer WHERE Cust_NICNo = '" + SearchValueTB.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                ClearFields();
            }
            else if (SearchOptCB.Text == "Account No.")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Cust_FirstName AS [First Name], Cust_LastName AS [Last Name], Cust_AccNo AS [Account Number], Cust_AccTitle AS [Account Title], Cust_AccType AS [Account Type], Cust_Gender AS [Gender], Cust_DOB AS [Date Of Birth], Cust_Address AS [Address], Cust_City AS [City], Cust_Country AS [Country], Cust_Nationality AS [Nationality], Cust_PhoneNo AS [Phone Number], Cust_NICNo AS [NIC Number], Cust_Email AS [Email], Cust_CompanyName AS [Company Name], Cust_Occupation AS [Occupation], Cust_InitialDeposit AS [Initial Deposit] FROM Customer WHERE Cust_AccNo = '" + SearchValueTB.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                ClearFields();
            }
            else if (SearchOptCB.Text == "Account Title")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Cust_FirstName AS [First Name], Cust_LastName AS [Last Name], Cust_AccNo AS [Account Number], Cust_AccTitle AS [Account Title], Cust_AccType AS [Account Type], Cust_Gender AS [Gender], Cust_DOB AS [Date Of Birth], Cust_Address AS [Address], Cust_City AS [City], Cust_Country AS [Country], Cust_Nationality AS [Nationality], Cust_PhoneNo AS [Phone Number], Cust_NICNo AS [NIC Number], Cust_Email AS [Email], Cust_CompanyName AS [Company Name], Cust_Occupation AS [Occupation], Cust_InitialDeposit AS [Initial Deposit] FROM Customer WHERE Cust_AccTitle = '" + SearchValueTB.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                ClearFields();
            }
            else if (SearchOptCB.Text == "Account Type")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Cust_FirstName AS [First Name], Cust_LastName AS [Last Name], Cust_AccNo AS [Account Number], Cust_AccTitle AS [Account Title], Cust_AccType AS [Account Type], Cust_Gender AS [Gender], Cust_DOB AS [Date Of Birth], Cust_Address AS [Address], Cust_City AS [City], Cust_Country AS [Country], Cust_Nationality AS [Nationality], Cust_PhoneNo AS [Phone Number], Cust_NICNo AS [NIC Number], Cust_Email AS [Email], Cust_CompanyName AS [Company Name], Cust_Occupation AS [Occupation], Cust_InitialDeposit AS [Initial Deposit] FROM Customer WHERE Cust_AccType = '" + SearchValueTB.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                ClearFields();
            }
            else if (SearchOptCB.Text == "Status")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Cust_FirstName AS [First Name], Cust_LastName AS [Last Name], Cust_AccNo AS [Account Number], Cust_AccTitle AS [Account Title], Cust_AccType AS [Account Type], Cust_Gender AS [Gender], Cust_DOB AS [Date Of Birth], Cust_Address AS [Address], Cust_City AS [City], Cust_Country AS [Country], Cust_Nationality AS [Nationality], Cust_PhoneNo AS [Phone Number], Cust_NICNo AS [NIC Number], Cust_Email AS [Email], Cust_CompanyName AS [Company Name], Cust_Occupation AS [Occupation], Cust_InitialDeposit AS [Initial Deposit] FROM Customer WHERE Cust_Status = '" + SearchValueTB.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Kindly fill the fields to search user accounts", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Cust_FirstName AS [First Name], Cust_LastName AS [Last Name], Cust_AccNo AS [Account Number], Cust_AccTitle AS [Account Title], Cust_AccType AS [Account Type], Cust_Gender AS [Gender], Cust_DOB AS [Date Of Birth], Cust_Address AS [Address], Cust_City AS [City], Cust_Country AS [Country], Cust_Nationality AS [Nationality], Cust_PhoneNo AS [Phone Number], Cust_NICNo AS [NIC Number], Cust_Email AS [Email], Cust_CompanyName AS [Company Name], Cust_Occupation AS [Occupation], Cust_InitialDeposit AS [Initial Deposit] FROM Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void SearchAccountForm_Load(object sender, EventArgs e)
        {
            SearchOptCB.DropDownStyle = ComboBoxStyle.DropDownList;
            DisplayData();
        }

        private void ClearFields()
        {
            SearchValueTB.Clear();
            SearchOptCB.SelectedIndex = -1;
        }
    }
}
