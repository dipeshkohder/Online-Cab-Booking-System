using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCab
{
    public partial class SignupCustomer : Form
    {

        Customer cust;
        public SignupCustomer()
        {
            cust = new Customer();
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
           
            string uname = username.Text;
            string pwd = password.Text;
            string mob = mobile.Text;
            string ad = address.Text;

            cust.register(uname,pwd,mob,ad);
            this.Hide();
            Form1 login = new Form1();
            login.Show();

        }
    }
}
