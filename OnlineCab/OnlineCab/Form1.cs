using OnlineCab;
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
    public partial class Form1 : Form
    {

        public static string uname = "";
        public static string pwd = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void SigninClick(object sender, EventArgs e)
        {
             uname = textBox1.Text;
             pwd = textBox2.Text; 

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            if (customer.Checked)
            {

                cmd.CommandText = "Select * from Customer where username = @uname1 and password = @pwd1";
                cmd.Parameters.AddWithValue("@uname1", uname);
                cmd.Parameters.AddWithValue("@pwd1", pwd);

                SqlDataReader srdr = cmd.ExecuteReader();

                if (!srdr.Read())
                {
                    MessageBox.Show("Incorrect Username or Password!");
                }
                else
                {

                    CustomerHomePage customerHomePage = new CustomerHomePage(srdr["ID"].ToString(),srdr["username"].ToString());
                    customerHomePage.Show();
                    this.Hide();
                    string name = srdr["username"].ToString();
                    MessageBox.Show("Welcome " + name);
                }
            }
            else if (driver.Checked)
            {
                cmd.CommandText = "Select * from Driver where username = @uname1 and password = @pwd1";
                cmd.Parameters.AddWithValue("@uname1", uname);
                cmd.Parameters.AddWithValue("@pwd1", pwd);

                SqlDataReader srdr = cmd.ExecuteReader();

                if (!srdr.Read())
                {
                    MessageBox.Show("Incorrect Username or Password!");
                }
                else
                {
                    DriveHomePage driverHomePage = new DriveHomePage(uname,pwd,Int32.Parse(srdr["ID"].ToString()));
                    driverHomePage.Show();
                    this.Hide();
                    string name = srdr["username"].ToString();
                    MessageBox.Show("Welcome " + name);
                }

            }
            else if (admin.Checked)
            {
                cmd.CommandText = "Select * from Admin where username = @uname1 and password = @pwd1";
                cmd.Parameters.AddWithValue("@uname1", uname);
                cmd.Parameters.AddWithValue("@pwd1", pwd);

                SqlDataReader srdr = cmd.ExecuteReader();

                if (!srdr.Read())
                {
                    MessageBox.Show("Incorrect Username or Password!");
                }
                else
                {
                    string name = srdr["username"].ToString();
                    MessageBox.Show("Welcome " + name);
                }
            }
            else {

                MessageBox.Show("Please select type of user");
            }
         }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

            SignupDriver sd = new SignupDriver();
            sd.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupCustomer sc = new SignupCustomer();
            sc.Show();
            this.Hide();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
