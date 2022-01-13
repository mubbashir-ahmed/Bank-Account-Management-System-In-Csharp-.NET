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
    public partial class CreateUserAccountForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MUBBASHIR-PC;User ID=sa;Password=sql123");
        private Random random = new Random();

        public CreateUserAccountForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminDashboardForm ADF = new AdminDashboardForm();
            this.Hide();
            ADF.Show();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (FirstNameTB.Text == "" || LastNameTB.Text == "" || AccNoTB.Text == "" ||
                AccTitleTB.Text == "" || AccTypeCB.Text == "" || GenderCB.Text == "" ||
                DOBDTP.Text == "" || NationalityCB.Text == "" || AddressTB.Text == "" ||
                PhoneNoTB.Text == "" || NICNoTB.Text == "" || EmailTB.Text == "" ||
                CompanyNameTB.Text == "" || OccupTB.Text == "" || InitDepTB.Text == "" || PinCodeTB.Text == "")
            {
                MessageBox.Show("Kindly fill all fields!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Customer VALUES('" + FirstNameTB.Text + "', '" + LastNameTB.Text + "', '"
                    + AccNoTB.Text + "', '" + AccTitleTB.Text + "', '" + AccTypeCB.Text + "', '"
                    + GenderCB.Text + "', '" + DOBDTP.Text + "', '" 
                    + AddressTB.Text + "', '" + CityTB.Text + "', '" + CountryCB.Text + "', '" 
                    + NationalityCB.Text + "', '" + PhoneNoTB.Text + "', '" + NICNoTB.Text + "', '"
                    + EmailTB.Text + "', '" + CompanyNameTB.Text + "', '" + OccupTB.Text + "', '" + InitDepTB.Text + "', 'Unblocked', '" + PinCodeTB.Text + "', '" + InitDepTB.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Account Successfully Created!", "User Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                GetNewAccNo();
            }
        }

        private void ClearFields()
        {
            FirstNameTB.Clear();
            LastNameTB.Clear();
            AccNoTB.Clear();
            AccTitleTB.Clear();
            AccTypeCB.SelectedIndex = -1;
            GenderCB.SelectedIndex = -1;
            DOBDTP.ResetText();
            NationalityCB.SelectedIndex = -1;
            CountryCB.SelectedIndex = -1;
            CityTB.Clear();
            AddressTB.Clear();
            PhoneNoTB.Clear();
            NICNoTB.Clear();
            EmailTB.Clear();
            CompanyNameTB.Clear();
            OccupTB.Clear();
            InitDepTB.Clear();
        }

        private void CreateUserAccountForm_Load(object sender, EventArgs e)
        {
            NationalityCB.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderCB.DropDownStyle = ComboBoxStyle.DropDownList;
            AccTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CountryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            GetNewAccNo();
            GeneratePinCode();
        }

        private void GetNewAccNo()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 1 Cust_AccNo FROM Customer ORDER BY Cust_AccNo DESC";
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    string lastAccNo = reader["Cust_AccNo"].ToString();
                    int length = lastAccNo.Length - 3;
                    Int32 num = Convert.ToInt32(lastAccNo.Substring(3, length));
                    num = num + 1;
                    AccNoTB.Text = "ABC" + num;
                }
            }
            else if(!reader.HasRows)
            {
                AccNoTB.Text = "ABC100";
            }
            con.Close();
        }

        private void GeneratePinCode()
        {
            string num = random.Next(0000, 9999).ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Cust_PinCode FROM Customer WHERE Cust_PinCode = '" + num + "'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GeneratePinCode();
            }
            else
            {
                PinCodeTB.Text = num;
            }
            con.Close();
        }
    }
}
