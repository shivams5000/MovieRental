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
    public class LoginAction
    {
        // Login
        public DataTable LoginForm(LoginData data)
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();

            cmd.CommandText = "prcLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", data.userName);
            cmd.Parameters.AddWithValue("@password", data.password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }
    }
}
