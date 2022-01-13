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
    public partial class TransferMoneyForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MUBBASHIR-PC;User ID=sa;Password=sql123");
        private string Acc, Pin;

        public TransferMoneyForm()
        {
            InitializeComponent();
        }

        private void TransferMoneyForm_Load(object sender, EventArgs e)
        {
            Acc = UserLoginForm.AccNoText;
            Pin = UserLoginForm.PinCodeText;
            ClearFields();
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (ReceiverAccNoTB.Text == "" && AmountTB.Text == "")
            {
                MessageBox.Show("Kindly fill all the fields!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Cust_CurrentBalance FROM Customer WHERE Cust_CurrentBalance > '" + AmountTB.Text + "' AND Cust_AccNo = '" + Acc + "'";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Cust_CurrentBalance FROM Customer WHERE Cust_AccNo = '" + ReceiverAccNoTB.Text + "'";
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    if (dt2.Rows.Count > 0)
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE Customer SET Cust_CurrentBalance = Cust_CurrentBalance + '" + AmountTB.Text + "' WHERE Cust_AccNo = '" + ReceiverAccNoTB.Text + "'";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE Customer SET Cust_CurrentBalance = Cust_CurrentBalance - '" + AmountTB.Text + "' WHERE Cust_AccNo = '" + Acc + "'";
                        cmd.ExecuteNonQuery();
                        StatusTB.Text = "Transferred";
                        StatusTB.BackColor = this.BackColor;
                        StatusTB.ForeColor = Color.Green;
                        ClearFields();
                    }
                    else
                    {
                        ClearFields();
                        StatusTB.Text = "Declined";
                        StatusTB.BackColor = this.BackColor;
                        StatusTB.ForeColor = Color.Red;
                        MessageBox.Show("Receiver account number is incorrect or the receiver do not have an account in this bank!", "Receiver Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    ClearFields();
                    StatusTB.Text = "Declined";
                    StatusTB.BackColor = this.BackColor;
                    StatusTB.ForeColor = Color.Red;
                    MessageBox.Show("Not enough balance in your account!", "Low Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserDashboardForm UDF = new UserDashboardForm();
            this.Hide();
            UDF.Show();
        }

        private void ClearFields()
        {
            ReceiverAccNoTB.Clear();
            AmountTB.Clear();
        }
    }
}
