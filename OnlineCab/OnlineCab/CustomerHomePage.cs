using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCab
{
    public partial class CustomerHomePage : Form
    {
        string customerid = "";
        public CustomerHomePage(string customerid,string name)
        {
            //intro.Text = name;
            this.customerid = customerid;
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowCabs_Click(object sender, EventArgs e)
        {
            string src = source.Text;
            string des = destination.Text;
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select ID,username,contact_no,licence_no,rating from Driver where current_location = @src and isFree = @isF";
            cmd.Parameters.AddWithValue("@src", src);
            cmd.Parameters.AddWithValue("@isF", 1);


            // MessageBox.Show("Data Retrieved");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
//            driverInformation.DataSource = cmd.ExecuteReader();
            conn.Close();
            driverInformation.DataSource = dt;


        }

        private void DriverInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            driverInformation.CurrentRow.Selected = true;
            driverid.Text = (driverInformation.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
            drivername.Text = driverInformation.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cabs cabs = new Cabs();
            string src = source.Text;
            string des = destination.Text;
            int dis = Int32.Parse(distance.Text);
            int drid = Int32.Parse(driverid.Text);
            int amount = dis * 10;

            cabs.bookCabs(src,des,drid,dis,amount,Int32.Parse(customerid));
        }

        private void Show_accepted_request_Click(object sender, EventArgs e)
        {
            Cabs cabs = new Cabs();
            acceptedRejectedRequest.DataSource = cabs.showAllAcceptedRequestForCustomer(Int32.Parse(customerid));
        }

        private void Show_rejected_request_Click(object sender, EventArgs e)
        {
            Cabs cabs = new Cabs();
            acceptedRejectedRequest.DataSource = cabs.showAllRejectedRequestForCustomer(Int32.Parse(customerid));
        }

        private void Show_panding_request_Click(object sender, EventArgs e)
        {
            Cabs cabs = new Cabs();
            acceptedRejectedRequest.DataSource = cabs.showAllPandingRequestForCustomer(Int32.Parse(customerid));
        }
    }
}
