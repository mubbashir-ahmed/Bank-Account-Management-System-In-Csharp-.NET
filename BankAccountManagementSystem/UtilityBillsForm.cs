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
using System.IO;

namespace BankAccountManagementSystem
{
    public partial class UtilityBillsForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MUBBASHIR-PC;User ID=sa;Password=sql123");
        private string Acc, Pin;

        public UtilityBillsForm()
        {
            InitializeComponent();
        }

        private void UtilityBillsForm_Load(object sender, EventArgs e)
        {
            BillCB.DropDownStyle = ComboBoxStyle.DropDownList;
            Acc = UserLoginForm.AccNoText;
            Pin = UserLoginForm.PinCodeText;
        }

        private void PayBillBtn_Click(object sender, EventArgs e)
        {
            if ((string)BillCB.SelectedItem == "" && AmountTB.Text == "" && ConsumerNoTB.Text == "")
            {
                MessageBox.Show("Kindly select respected bill type and fill respected fields!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if ((string)BillCB.SelectedItem == "Electricity")
                    {
                        details = "Electricity Bill - Consumer No.: " + ConsumerNoTB.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [Customer Transactions] VALUES('" + Acc + "', '" + BillCB.SelectedItem + "', '" + details + "', '" + AmountTB.Text + "', '" + DateTime.Now.ToLongDateString() + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE Customer SET Cust_CurrentBalance = Cust_CurrentBalance - '" + AmountTB.Text + "' WHERE Cust_AccNo = '" + Acc + "'";
                        cmd.ExecuteNonQuery();
                    }
                    else if ((string)BillCB.SelectedItem == "Gas")
                    {
                        details = "Gas Bill - Consumer No.: " + ConsumerNoTB.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [Customer Transactions] VALUES('" + Acc + "', '" + BillCB.SelectedItem + "', '" + details + "', '" + AmountTB.Text + "', '" + DateTime.Now.ToLongDateString() + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE Customer SET Cust_CurrentBalance = Cust_CurrentBalance - '" + AmountTB.Text + "' WHERE Cust_AccNo = '" + Acc + "'";
                        cmd.ExecuteNonQuery();
                    }
                    else if ((string)BillCB.SelectedItem == "Water")
                    {
                        details = "Water Bill - Consumer No.: " + ConsumerNoTB.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [Customer Transactions] VALUES('" + Acc + "', '" + BillCB.SelectedItem + "', '" + details + "', '" + AmountTB.Text + "', '" + DateTime.Now.ToLongDateString() + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE Customer SET Cust_CurrentBalance = Cust_CurrentBalance - '" + AmountTB.Text + "' WHERE Cust_AccNo = '" + Acc + "'";
                        cmd.ExecuteNonQuery();
                    }
                    else if ((string)BillCB.SelectedItem == "Telephone")
                    {
                        details = "Telephone Bill - Consumer No.: " + ConsumerNoTB.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [Customer Transactions] VALUES('" + Acc + "', '" + BillCB.SelectedItem + "', '" + details + "', '" + AmountTB.Text + "', '" + DateTime.Now.ToLongDateString() + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE Customer SET Cust_CurrentBalance = Cust_CurrentBalance - '" + AmountTB.Text + "' WHERE Cust_AccNo = '" + Acc + "'";
                        cmd.ExecuteNonQuery();
                    }

                    ClearFields();
                    StatusTB.Text = "Bill Paid";
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserDashboardForm UDF = new UserDashboardForm();
            this.Hide();
            UDF.Show();
        }

        private void ClearFields()
        {
            BillCB.SelectedIndex = -1;
            ConsumerNoTB.Clear();
            AmountTB.Clear();
        }
    }
}
