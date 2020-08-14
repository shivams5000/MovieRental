using MyMovieStore.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieStore.DBAction
{
    public class CustomerAction
    {
        // Add customer
        public bool AddCustomer(CustomerData data)
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            cmd.CommandText = "procInsertCustomer"; // stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name",data.Name);
            cmd.Parameters.AddWithValue("@Address", data.Address);
            cmd.Parameters.AddWithValue("@Phone", data.Phone);
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }


        // Get My Customers
        public DataTable GetAllCustomers()
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();

            cmd.CommandText = "SELECT * FROM customer";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }


        // Get CustomersInfo from selected Customer Id
        public CustomerData GetCustomersInfo(int custId)
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM customer where custId = @custId";
            cmd.Parameters.AddWithValue("@custId", custId);
            SqlDataReader reader = cmd.ExecuteReader();
            CustomerData data = null;
            if (reader.Read())
            {
                data = new CustomerData();
                data.Name = reader["name"].ToString();
                data.Address = reader["address"].ToString();
                data.Phone = long.Parse(reader["phone"].ToString());
            }
            reader.Dispose();
            cmd.Dispose();
            return data;
        }

        // Delete customer
        public bool DeleteCustomer(string CustID)
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            cmd.CommandText = "prcDelCust"; // stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@custId", CustID);
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }


        // Update customer
        public bool UpdateCustomer(CustomerData data)
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            cmd.CommandText = "update customer set name=@name, address=@address, phone=@phone where custId=@custId";
            cmd.Parameters.AddWithValue("@custId", data.CustId);
            cmd.Parameters.AddWithValue("@name", data.Name);
            cmd.Parameters.AddWithValue("@address", data.Address);
            cmd.Parameters.AddWithValue("@phone", data.Phone);
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }

    }
}
