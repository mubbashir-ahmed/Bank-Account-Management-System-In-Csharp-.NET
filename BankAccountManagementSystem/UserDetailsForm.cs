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
    public partial class UserDetailsForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MUBBASHIR-PC;User ID=sa;Password=sql123");
        private string Acc, Pin;

        public UserDetailsForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserDashboardForm UDF = new UserDashboardForm();
            this.Hide();
            UDF.Show();
        }

        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
            Acc = UserLoginForm.AccNoText;
            Pin = UserLoginForm.PinCodeText;
            GetUserData();
        }

        private void GetUserData()
        {
            con.Open();
            SqlDataReader reader;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Customer WHERE Cust_AccNo = '" + Acc + "' AND Cust_PinCode = '" + Pin + "'";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FNameLbl.Text = (reader["Cust_FirstName"].ToString());
                LNameLbl.Text = (reader["Cust_LastName"].ToString());
                GenderLbl.Text = (reader["Cust_Gender"].ToString());
                DOBLbl.Text = (reader["Cust_DOB"].ToString());
                AddressLbl.Text = (reader["Cust_Address"].ToString());
                CityLbl.Text = (reader["Cust_City"].ToString());
                CountryLbl.Text = (reader["Cust_Country"].ToString());
                NationalityLbl.Text = (reader["Cust_Nationality"].ToString());
                NICNoLbl.Text = (reader["Cust_FirstName"].ToString());
                PhoneNoLbl.Text = (reader["Cust_PhoneNo"].ToString());
                EmailLbl.Text = (reader["Cust_Email"].ToString());
                AccNoLbl.Text = (reader["Cust_AccNo"].ToString());
                AccTitleLbl.Text = (reader["Cust_AccTitle"].ToString());
                AccTypeLbl.Text = (reader["Cust_AccType"].ToString());
                CompanyNameLbl.Text = (reader["Cust_CompanyName"].ToString());
                OccupLbl.Text = (reader["Cust_Occupation"].ToString());
                CurrentBalanceLbl.Text = (reader["Cust_CurrentBalance"].ToString());
            }
            con.Close();
        }
    }
}
