using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCab
{
    class Driver
    {
        private const string V = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        string username { get; set; }
        string password { get; set; }
        string mobileno { get; set; }
        string licenceno { get; set; }

        public void register(string uname,string pwd,string mob, string licence)
        {
            
            string connectionString = V;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "insert into Driver(username,password,contact_no,licence_no) values (@uname , @pwd , @mob , @licence)";
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@mob", mob);
            cmd.Parameters.AddWithValue("@licence", licence);

            int result = cmd.ExecuteNonQuery();
            return;

        }


        public void AddCurrentLocation(string uname, string pwd, string location)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "update Driver set current_location = @location where username = @uname and password = @pwd";
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@location",location);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Current Location is successfully added!");
            }

            return;



        }

    }
}
