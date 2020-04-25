using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCab
{
    class Customer
    {
        string username { get; set; }
        string password { get; set; }
        string mobile { get; set; }
        string address { get; set;}

        public void register(string uname,string pwd,string mob,string ad)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "insert into Customer(username,password,contact_no,address) values (@uname , @pwd , @mob , @ad)";
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@mob", mob);
            cmd.Parameters.AddWithValue("@ad", ad);

            int result = cmd.ExecuteNonQuery();
            return;


        }
    }
}
