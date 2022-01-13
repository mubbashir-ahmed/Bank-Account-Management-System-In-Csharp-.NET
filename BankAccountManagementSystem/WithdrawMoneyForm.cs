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
    public partial class WithdrawMoneyForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MUBBASHIR-PC;User ID=sa;Password=sql123");
        private string Acc, Pin;

        public WithdrawMoneyForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserDashboardForm UDF = new UserDashboardForm();
            this.Hide();
            UDF.Show();
        }

        private void WithdrawMoneyForm_Load(object sender, EventArgs e)
        {
            ChequeNoTB.ReadOnly = true;
            PayOrderNoTB.ReadOnly = true;
            MediumCB.DropDownStyle = ComboBoxStyle.DropDownList;
            Acc = UserLoginForm.AccNoText;
            Pin = UserLoginForm.PinCodeText;
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if ((string)MediumCB.SelectedItem == "" && AmountTB.Text == "" && ChequeNoTB.Text == "" && PayOrderNoTB.Text == "")
            {
                MessageBox.Show("Kindly select deposit medium and fill respected fields!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string)MediumCB.SelectedItem == "Cheaque" && AmountTB.Text == "" && ChequeNoTB.Text == "")
            {
                MessageBox.Show("Kindly enter amount and cheque number!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string)MediumCB.SelectedItem == "Pay Order" && AmountTB.Text == "" && PayOrderNoTB.Text == "")
            {
                MessageBox.Show("Kindly enter amount and pay order number!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string)MediumCB.SelectedItem == "Cash" && AmountTB.Text == "")
            {
                MessageBox.Show("Kindly enter amount!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string details;
                    if ((string)MediumCB.SelectedItem == "Cash")
                    {
                        details = "Withdrawal - Cash";
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [Customer Transactions] VALUES('" + Acc + "', '" + MediumCB.SelectedItem + "', '" + details + "', '" + AmountTB.Text + "', '" + DateTime.Now.ToLongDateString() + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE Customer SET Cust_CurrentBalance = Cust_CurrentBalance - '" + AmountTB.Text + "' WHERE Cust_AccNo = '" + Acc + "'";
                        cmd.ExecuteNonQuery();
                    }
                    else if ((string)MediumCB.SelectedItem == "Cheque")
                    {
                        details = "Withdrawal - Cheque No.: " + ChequeNoTB.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [Customer Transactions] VALUES('" + Acc + "', '" + MediumCB.SelectedItem + "', '" + details + "', '" + AmountTB.Text + "', '" + DateTime.Now.ToLongDateString() + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE Customer SET Cust_CurrentBalance = Cust_CurrentBalance - '" + AmountTB.Text + "' WHERE Cust_AccNo = '" + Acc + "'";
                        cmd.ExecuteNonQuery();
                    }
                    else if ((string)MediumCB.SelectedItem == "Pay Order")
                    {
                        details = "Withdrawal - Pay Order No.: " + PayOrderNoTB.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [Customer Transactions] VALUES('" + Acc + "', '" + MediumCB.SelectedItem + "', '" + details + "', '" + AmountTB.Text + "', '" + DateTime.Now.ToLongDateString() + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE Customer SET Cust_CurrentBalance = Cust_CurrentBalance - '" + AmountTB.Text + "' WHERE Cust_AccNo = '" + Acc + "'";
                        cmd.ExecuteNonQuery();
                    }

                    ClearFields();
                    StatusTB.Text = "Withdrawed";
                    StatusTB.BackColor = this.BackColor;
                    StatusTB.ForeColor = Color.Green;
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

        private void MediumCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)MediumCB.SelectedItem == "Cheque")
            {
                ChequeNoTB.ReadOnly = false;
                PayOrderNoTB.ReadOnly = true;
            }
            else if ((string)MediumCB.SelectedItem == "Pay Order")
            {
                ChequeNoTB.ReadOnly = true;
                PayOrderNoTB.ReadOnly = false;
            }
            else if ((string)MediumCB.SelectedItem == "Cash")
            {
                ChequeNoTB.ReadOnly = true;
                PayOrderNoTB.ReadOnly = true;
            }
        }

        private void ClearFields()
        {
            MediumCB.SelectedIndex = -1;
            AmountTB.Clear();
            ChequeNoTB.Clear();
            PayOrderNoTB.Clear();
        }
    }
}
