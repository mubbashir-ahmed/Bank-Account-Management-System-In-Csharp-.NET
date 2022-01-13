using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountManagementSystem
{
    public partial class ComplaintForm : Form
    {
        public ComplaintForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserDashboardForm UDF = new UserDashboardForm();
            this.Hide();
            UDF.Show();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show(this, "If you have any complaint, kindly fill the fields.", "Empty Fields!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, "Sorry for your inconvenience. Your complaint is submitted. We will try to solve it as soon as possible.", "Complaint Submitted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                richTextBox1.Clear();
                UserDashboardForm UDF = new UserDashboardForm();
                this.Hide();
                UDF.Show();
            }
        }

        private void ComplaintForm_Load(object sender, EventArgs e)
        {

        }
    }
}
