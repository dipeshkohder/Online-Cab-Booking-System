using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCab
{
    class Cabs
    {
        public SqlDataReader findCabs(string src,string des)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from Driver where current_location = @src and isFree = @isF";
            cmd.Parameters.AddWithValue("@src", src);
            cmd.Parameters.AddWithValue("@isF", 0);

            SqlDataReader srdr = cmd.ExecuteReader();
            if (srdr.Read())
            {
                MessageBox.Show("Data Retrieved");
                return srdr;
            }

            return null;
        }

        public void bookCabs(string src, string des, int driverid, int distance,int amount,int customerid)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Insert into driver_customer_request(source,destination,driverid,distance,fairamount,customerid) values (@src,@des,@driverid,@distance,@amount,@customerid)";
            cmd.Parameters.AddWithValue("@src", src);
            cmd.Parameters.AddWithValue("@des",des);
            cmd.Parameters.AddWithValue("@driverid",driverid);
            cmd.Parameters.AddWithValue("@distance",distance);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@customerid", customerid);


            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Requset is sent to the Driver!");
            }

            return;


        }

        public DataTable showCabRequest(int driverid)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select Id,source,destination,distance,fairamount from driver_customer_request where driverid = @driverid and isRequestAccepted = @isRequestAccepted";
            cmd.Parameters.AddWithValue("@driverid", driverid);
            cmd.Parameters.AddWithValue("@isRequestAccepted", 0);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public DataTable AllacceptedCabRequests(int driverid)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select Id,source,destination,distance,fairamount from driver_customer_request where driverid = @driverid and isRequestAccepted = @isRequestAccepted and isFairDone = @isFairDone";
            cmd.Parameters.AddWithValue("@driverid", driverid);
            cmd.Parameters.AddWithValue("@isRequestAccepted", 1);
            cmd.Parameters.AddWithValue("@isFairDone", 0);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public string acceptCabRequest(int id)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "update driver_customer_request set isRequestAccepted = @isRequestAccepted where Id = @id";
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@isRequestAccepted", 1);

            int r = cmd.ExecuteNonQuery();
            if (r >= 1)
            {
                return "Request Accepted Successfully!";
            }
            else
            {
                return "There is some problem!";
            }

        }

        public string cancleCabRequest(int id)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "update driver_customer_request set isRequestAccepted = @isRequestAccepted where Id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@isRequestAccepted", -1);

            int r = cmd.ExecuteNonQuery();
            if (r >= 1)
            {
                return "Request Rejected Successfully!";
            }
            else
            {
                return "There is some problem!";
            }
        }

        public string FairDone(int driverid)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "update driver_customer_request set isFairDone = @isFairDone where Id = @id";
            cmd.Parameters.AddWithValue("@id", driverid);
            cmd.Parameters.AddWithValue("@isFairDone", 1);

            int r = cmd.ExecuteNonQuery();
            if (r >= 1)
            {
                return "Request Rejected Successfully!";
            }
            else
            {
                return "There is some problem!";
            }
        }


        public DataTable showAllAcceptedRequestForCustomer(int customerid)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select source,destination,distance,fairamount from driver_customer_request where customerid = @customerid and isRequestAccepted = @isRequestAccepted and isFairDone = @isFairDone";
            cmd.Parameters.AddWithValue("@customerid", customerid);
            cmd.Parameters.AddWithValue("@isRequestAccepted", 1);
            cmd.Parameters.AddWithValue("@isFairDone", 0);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }


        public DataTable showAllRejectedRequestForCustomer(int customerid)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select source,destination,distance,fairamount from driver_customer_request where customerid = @customerid and isRequestAccepted = @isRequestAccepted and isFairDone = @isFairDone";
            cmd.Parameters.AddWithValue("@customerid", customerid);
            cmd.Parameters.AddWithValue("@isRequestAccepted", -1);
            cmd.Parameters.AddWithValue("@isFairDone", 0);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public DataTable showAllPandingRequestForCustomer(int customerid)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineCab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select source,destination,distance,fairamount from driver_customer_request where customerid = @customerid and isRequestAccepted = @isRequestAccepted and isFairDone = @isFairDone";
            cmd.Parameters.AddWithValue("@customerid", customerid);
            cmd.Parameters.AddWithValue("@isRequestAccepted", 0);
            cmd.Parameters.AddWithValue("@isFairDone", 0);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }






    }
}
