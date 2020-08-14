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
    public class RentalMovieAction
    {
        // Add Movie
        public bool RentMovie(RentalData data)
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            cmd.CommandText = "prcRentMovie"; // stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MovieID", data.MovieId);
            cmd.Parameters.AddWithValue("@CustID", data.CustId);
            cmd.Parameters.AddWithValue("@RentDate", data.OnRentDate);
            cmd.Parameters.AddWithValue("@ReturnDate", data.ReturnDate);
            cmd.Parameters.AddWithValue("@TotalRent", data.TotalRentAmount);
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }

        // Get All RentedData
        public DataTable GetAllRentedData()
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            // stored procedure to show all rented movies order by isuue date descending
            cmd.CommandText = "ShowRentedData"; 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }

        // Return Movie
        public bool ReturnMovie(int MovieID, int CustId)
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            cmd.CommandText = "prcReturnMovie"; // stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@movieID", MovieID);
            cmd.Parameters.AddWithValue("@CustID", CustId);

            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }


        //Customers who borrows most movies
        public DataTable CustomersWhoBorrowMostMovies()
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            cmd.CommandText = "prcCustWhoBorrowMostMovies"; // store procedure
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }

        //Most popular movies
        public DataTable MostPopularMovies()
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            cmd.CommandText = "prcMostPopularMovies"; // store procedure
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }
        

        // Get All RentedMovie for DDL
        public DataTable GetRentedMoviesDDL()
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            
            cmd.CommandText = "select rm.MovieID, Title from RentedMovies rm join movies mv on rm.movieid= mv.movieid where onrentDate is not null group by Title, rm.MovieID";
            cmd.CommandType = CommandType.StoredProcedure;
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }

        // Get RentedMovie By customer
        public DataTable GetRentedMoviesDDL(int custId)
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();

            cmd.CommandText = "procGetRentedMovieByCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@custID", custId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }








    }
}
