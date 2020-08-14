using MyMovieStore.Common;
using MyMovieStore.DBAction;
using MyMovieStore.Operation;
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

namespace MyMovieStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // add new customer implementation
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // add customer only works when selected tab = customer
                if (TabControl.SelectedTab == TabControl.TabPages["Customers"])
                {
                    string name, address, phone;
                    name = txtName.Text.Trim();
                    address = txtAddress.Text.Trim();
                    phone = txtPhone.Text.Trim();

                    if (Checks.EmptyField(name))
                    {
                        MessageBox.Show("Customer name is required!");
                        txtName.Focus();
                    }
                    else if (Checks.EmptyField(address))
                    {
                        MessageBox.Show("Customer address is required!");
                        txtAddress.Focus();
                    }
                    else if (Checks.EmptyField(phone))
                    {
                        MessageBox.Show("Customer phone number is required!");
                        txtPhone.Focus();
                    }
                    else if (!Checks.checkPhoneNumber(phone))
                    {
                        MessageBox.Show("please provide a valid phone number!");
                        txtPhone.Focus();
                    }
                    else
                    {
                        CustomerData data = new CustomerData();
                        data.Name = name;
                        data.Address = address;
                        data.Phone = long.Parse(phone);
                        if (new CustomerAction().AddCustomer(data))
                        {

                            BindDdlCustomer(); // method calling to Bind comboBox Customer
                            BindGridCustomer(); // method calling to Bind GridView Customer
                            MessageBox.Show("New customer added!");

                            txtAddress.Clear();
                            txtName.Clear();
                            txtPhone.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Unable to add this customer!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select CUSTOMERS tab first!");
                }

            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
                   DataConnection.CloseConnection(); // close connection with database when error occured
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDdlCustomer(); // bind dropdownlist for customers
            BindGridCustomer(); // method calling to bind customer grid
            BindDdlMovie(); // method calling to Bind ComboBox Movies
        }


        

        //bind movies grid
        private void BindGridMovies()
        {
            DataTable ds = new MovieAction().GetAllMovies();
            gvMovies.DataSource = ds;
            gvMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //Bind Customer Grid to show data
        private void BindGridCustomer()
        {
            DataTable ds = new CustomerAction().GetAllCustomers();
            CustomersDataGridView.DataSource = ds;
            CustomersDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // Bind rented movies grid
        private void BindGridRentedMovies()
        {
            DataTable ds = new RentalMovieAction().GetAllRentedData();
            gvRental.DataSource = ds;
            gvRental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //Bind dropdownlist of All Customer to show data 
        private void BindDdlCustomer()
        {
            DataTable ds = new CustomerAction().GetAllCustomers();

            DataRow row = ds.NewRow();
            row[0] = 0;
            row[1] = "--Please select--";
            ds.Rows.InsertAt(row, 0); // add item at INDEX = 0;

            ddlCustomer.DisplayMember = "Name";
            ddlCustomer.ValueMember = "CustId";
            ddlCustomer.DataSource = ds; // Bind customer in Customer section

            ddlSelectCustomer.DisplayMember = "Name";
            ddlSelectCustomer.ValueMember = "CustId";
            ddlSelectCustomer.DataSource = ds; // Bind customer in Movie Rent Panel

            // Bind customer in Movie Return section **********************************
            ddlAllCust.DisplayMember = "Name";
            ddlAllCust.ValueMember = "CustId";
            ddlAllCust.DataSource = ds;
        }

        
        

         // Bind ddl movies Available for rent *********************************
        private void BindDdlMovie()
        {
            DataTable dsMovie = new MovieAction().GetMoviesForDDL();

            DataRow row = dsMovie.NewRow();
            row[0] = 0;
            row[1] = "--Please select--";
            dsMovie.Rows.InsertAt(row, 0);

            ddlMovie.DisplayMember = "Title";
            ddlMovie.ValueMember = "MovieID";
            ddlMovie.DataSource = dsMovie;

            // Bind Movie in Movie Rent Panel
            ddlSelectMovie.DisplayMember = "Title";
            ddlSelectMovie.ValueMember = "MovieID";
            ddlSelectMovie.DataSource = dsMovie;
        }

       
        // to delete a customer
        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string custId = ddlCustomer.SelectedValue.ToString();
                
                    DialogResult result = MessageBox.Show("Are you sure to delete this customer?", "Alert", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (new CustomerAction().DeleteCustomer(custId))
                        {
                            BindDdlCustomer(); // method calling to Bind comboBox Customer
                            BindGridCustomer(); // method calling to Bind GridView Customer
                        txtName.Clear();
                        txtAddress.Clear();
                        txtPhone.Clear();
                        ddlCustomer.SelectedIndex = 0;
                            MessageBox.Show("Customer Deleted!");
                        }
                        else
                        {
                            MessageBox.Show("Unable to delete this customer");
                        }
                    }
                    else
                    {
                        // Not deleted
                    }

            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("Can not delete this customer as this customer rented a movie!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                    DataConnection.CloseConnection(); // close connection with database when error occured
                }
            }
        }

        //Update customer info
        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string custId = ddlCustomer.SelectedValue.ToString();
                string name, address, phone;
                name = txtName.Text.Trim();
                address = txtAddress.Text.Trim();
                phone = txtPhone.Text.Trim();

                if (Checks.EmptyField(name))
                {
                    MessageBox.Show("Customer name is required!");
                    txtName.Focus();
                }
                else if (Checks.EmptyField(address))
                {
                    MessageBox.Show("Customer address is required!");
                    txtAddress.Focus();
                }
                else if (Checks.EmptyField(phone))
                {
                    MessageBox.Show("Customer phone number is required!");
                    txtPhone.Focus();
                }
                else if (!Checks.checkPhoneNumber(phone))
                {
                    MessageBox.Show("please provide a valid phone number!");
                    txtPhone.Focus();
                }
                else
                {
                    CustomerData data = new CustomerData();
                    data.Name = name;
                    data.Address = address;
                    data.Phone = long.Parse(phone);
                    data.CustId = int.Parse(custId);
                    if (new CustomerAction().UpdateCustomer(data))
                    {
                        
                        BindDdlCustomer(); // method calling to Bind comboBox Customer
                        BindGridCustomer(); // method calling to Bind GridView Customer
                        MessageBox.Show("Customer updated!");
                        txtName.Clear();
                        txtAddress.Clear();
                        txtPhone.Clear();
                        ddlCustomer.SelectedIndex = 0;

                    }
                    else
                    {
                        MessageBox.Show("Unable to update this customer!");
                    }
                }

            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
                DataConnection.CloseConnection(); // close connection with database when error occured
            }
        }

        // Add movies 
        private void btnAddMOvie_Click(object sender, EventArgs e)
        {
            try
            {
                if (TabControl.SelectedTab == TabControl.TabPages["Movies"])
                {
                    string Title, RentCost, Year, Rating, Genre;
                    Title = txtTitle.Text.Trim();
                    RentCost = txtRentedCost.Text.Trim();
                    Rating = txtRating.Text.Trim();
                    Year = txtYear.Text.Trim();
                    Genre = txtGenre.Text.Trim();

                    if (Checks.EmptyField(Title))
                    {
                        MessageBox.Show("Movie title is required!");
                    }
                    else if (Checks.EmptyField(Year))
                    {
                        MessageBox.Show("Movie released year is required!");
                    }
                    else if (!Checks.checkNumber(Year))
                    {
                        MessageBox.Show("Please enter a valid year!");
                    }
                    else if (Checks.EmptyField(Genre))
                    {
                        MessageBox.Show("Movie genre is required!");
                    }
                    else if (Checks.EmptyField(RentCost))
                    {
                        MessageBox.Show("Movie rent cost is required!");
                    }
                    else if (!Checks.checkNumber(RentCost))
                    {
                        MessageBox.Show("Please enter a valid cost!");
                    }
                    else if (Checks.EmptyField(Rating))
                    {
                        MessageBox.Show("Movie rating is required!");
                    }
                    else if (!Checks.checkNumber(Rating))
                    {
                        MessageBox.Show("Please enter a valid rating!");
                    }
                    else
                    {
                        MovieData data = new MovieData();
                        data.Title = Title;
                        data.Year = Year;
                        data.Rating = int.Parse(Rating);
                        data.Genre = Genre;
                        data.RentCost = int.Parse(RentCost);
                        if (new MovieAction().AddMovie(data))
                        {

                            BindGridMovies(); // method calling to Bind Grid Movies
                            BindDdlMovie(); // method calling to Bind ComboBox Movies
                            MessageBox.Show("Movie Inseted!");

                            txtTitle.Clear();
                            txtYear.Clear();
                            txtRating.Clear();
                            txtGenre.Clear();
                            txtRentedCost.Clear();
                           
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select the MOVIES tab first!");
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
                   DataConnection.CloseConnection();
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //your specific tabname
                if (TabControl.SelectedTab == TabControl.TabPages["Movies"])
                {
                    BindGridMovies(); // method calling to Bind Grid Movies
                    

                }
                else if (TabControl.SelectedTab == TabControl.TabPages["Customers"])
                {
                    

                    BindGridCustomer(); // method calling to Bind Grid Customer
                }
                else if (TabControl.SelectedTab == TabControl.TabPages["RentedMovies"])
                {
                    BindGridRentedMovies(); //method calling to Bind Grid for all rental movies
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataConnection.CloseConnection(); // close connection with database when error occured
            }
        }

        // To delete any movie
        private void btnDelMOvie_Click(object sender, EventArgs e)
        {
            try
            {
                string MovieId = ddlMovie.SelectedValue.ToString();

                DialogResult result = MessageBox.Show("Are you sure to delete this movie?", "Alert", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (new MovieAction().DeleteMovie(MovieId))
                    {
                        BindDdlMovie(); // method calling to Bind comboBox movie
                        BindGridMovies(); // method calling to Bind GridView movie
                        MessageBox.Show("Movie Deleted!");

                        txtTitle.Clear();
                        txtYear.Clear();
                        txtRating.Clear();
                        txtGenre.Clear();
                        txtRentedCost.Clear();

                        ddlMovie.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete this movie");
                    }
                }
                else
                {
                    // Nothing happen
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("Can not delete this movie as it is rented by a customer!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                    DataConnection.CloseConnection(); // close connection with database when error occured
                }
            }
        }

        //Update Movies Info
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MovieId = ddlMovie.SelectedValue.ToString();

                string Title, RentCost, Year, Rating, Genre;
                Title = txtTitle.Text.Trim();
                RentCost = txtRentedCost.Text.Trim();
                Rating = txtRating.Text.Trim();
                Year = txtYear.Text.Trim();
                Genre = txtGenre.Text.Trim();

                if (Checks.EmptyField(Title))
                {
                    MessageBox.Show("Movie title is required!");
                }
                else if (Checks.EmptyField(Year))
                {
                    MessageBox.Show("Movie released year is required!");
                }
                else if (!Checks.checkNumber(Year))
                {
                    MessageBox.Show("Please enter a valid year!");
                }
                else if (Checks.EmptyField(Genre))
                {
                    MessageBox.Show("Movie genre is required!");
                }
                else if (Checks.EmptyField(RentCost))
                {
                    MessageBox.Show("Movie rent cost is required!");
                }
                else if (!Checks.checkNumber(RentCost))
                {
                    MessageBox.Show("Please enter a valid cost!");
                }
                else if (Checks.EmptyField(Rating))
                {
                    MessageBox.Show("Movie rating is required!");
                }
                else if (!Checks.checkNumber(Rating))
                {
                    MessageBox.Show("Please enter a valid rating!");
                }
                else
                {
                    MovieData data = new MovieData();
                    data.Title = Title;
                    data.Year = Year;
                    data.Rating = int.Parse(Rating);
                    data.Genre = Genre;
                    data.RentCost = int.Parse(RentCost);
                    data.MovieId = int.Parse(MovieId);
                    if (new MovieAction().UpdateMovie(data))
                    {

                        BindGridMovies(); // method calling to Bind Grid Movies
                        BindDdlMovie(); // method calling to Bind ComboBox Movies
                        MessageBox.Show("Movie Updated!");
                        btnAddMOvie.Enabled = true; // enable Add movie button
                        txtTitle.Clear();
                        txtYear.Clear();
                        txtRating.Clear();
                        txtGenre.Clear();
                        txtRentedCost.Clear();
                        ddlMovie.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Unable to update this movie!");

                    }
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
                    DataConnection.CloseConnection(); // close connection with database when error occured
            }
        }

        // Get Movie Cost 
        public int GetMovieCost( int MovieID)
        {
            SqlCommand cmd = DataConnection.GetConnection().CreateCommand();
            cmd.CommandText = " select RentCost from movies where MovieID=@MovieID"; // stored procedure
            
            cmd.Parameters.AddWithValue("@MovieID", MovieID);
            int RentCost = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                RentCost = int.Parse(reader["RentCost"].ToString());
            }
            reader.Close();
            cmd.Dispose();
            return RentCost;
        }

        // Issue  movie to customer
        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string CustId, MovieId, rentDate, ReturnDate;
                int Days;
                CustId = ddlSelectCustomer.SelectedValue.ToString();
                MovieId = ddlSelectMovie.SelectedValue.ToString();
                rentDate = dtIsuue.Value.ToShortDateString();
                ReturnDate = dtReturn.Value.ToShortDateString();
                if (rentDate == ReturnDate)
                {
                    Days = 1;
                }
                else
                {
                    Days = Convert.ToInt32((DateTime.Parse(ReturnDate) - DateTime.Parse(rentDate)).TotalDays);
                }
                int RentalCost = GetMovieCost(int.Parse(MovieId)); // Getting rental cost for that movie

                int TotalRent = Days * RentalCost; // Calculated the TotalRent

                if (DateTime.Parse(rentDate) > DateTime.Parse(ReturnDate))
                {
                    MessageBox.Show("Issue date can not b greater than retun date");
                }
                else
                {
                    RentalData data = new RentalData();
                    data.CustId = int.Parse(CustId);
                    data.MovieId = int.Parse(MovieId);
                    data.OnRentDate = DateTime.Parse(rentDate);
                    data.ReturnDate = DateTime.Parse(ReturnDate);
                    data.TotalRentAmount = TotalRent;

                    if (new RentalMovieAction().RentMovie(data))
                    {
                       
                            BindGridRentedMovies(); //method calling to Bind Grid for all rental movies
                            
                            MessageBox.Show("Movie rented successfully!");
                        
                    }
                    else
                    {
                        MessageBox.Show("Failed to rent this movie");
                    }
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
            
        }

        //Customer returns movie and available it for rent again **************
        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            try
            {
                int MoviID = int.Parse(ddlRentedMovies.SelectedValue.ToString());
                int CustId = int.Parse(ddlCustomer.SelectedValue.ToString());
                if (new RentalMovieAction().ReturnMovie(MoviID, CustId))
                {
                    
                    BindGridRentedMovies(); //method calling to Bind Grid for all rental movies

                    MessageBox.Show("Movie Returned Successfully!");
                    ddlAllCust.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Unable to return this movie!");
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        // Show all rented movies
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab == TabControl.TabPages["RentedMovies"])
            {
                try
                {   //method calling to Bind Grid for all rental movies
                    BindGridRentedMovies();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select RENTED MOVIES tab first!");
            }
        }

        // show customers who bought most movies
        private void btnCustMostMovie_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab == TabControl.TabPages["RentedMovies"])
            {
                try
                {
                    DataTable dt = new RentalMovieAction().CustomersWhoBorrowMostMovies();
                    gvRental.DataSource = dt;
                    gvRental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select RENTED MOVIES tab first!");
            }
        }

        // show most popular movies
        private void btnMostPopulrMovies_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab == TabControl.TabPages["RentedMovies"])
            {
                try
                {
                    DataTable dt = new RentalMovieAction().MostPopularMovies();
                    gvRental.DataSource = dt;
                    gvRental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select RENTED MOVIES tab first!");
            }
        }

        //Form closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Do you really want to exit?", "Alert", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Connection to Database closed on form closing
                        DataConnection.CloseConnection();
                        Application.ExitThread();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bind Customer details on selection changed
            try
            {
                int CustId = int.Parse(ddlCustomer.SelectedValue.ToString());
                if (CustId > 0 )
                {
                    CustomerData data = new CustomerData();
                    data = new CustomerAction().GetCustomersInfo(CustId);
                    if (data != null)
                    {
                        txtName.Text = data.Name;
                        txtAddress.Text = data.Address;
                        txtPhone.Text = data.Phone.ToString();
                    }

                }
                else
                {
                    //MessageBox.Show("Test");
                }
            }
        catch (Exception ex)
        {
                MessageBox.Show(ex.Message);
        }
        }

        //Bind movie details on selection changed
        private void ddlMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                // get "movie id" here
                int MovieId = int.Parse(ddlMovie.SelectedValue.ToString());
                if (MovieId > 0)
                {
                    MovieData data = new MovieData();
                    data = new MovieAction().GetMoviesInfo(MovieId);
                    if (data != null)
                    {
                        txtGenre.Text = data.Genre;
                        txtRating.Text = data.Rating.ToString();
                        txtTitle.Text = data.Title;
                        txtRentedCost.Text = data.RentCost.ToString();
                        txtYear.Text = data.Year;
                        btnAddMOvie.Enabled = false; // disable Add movie button

                    }

                }
                else
                {
                    //MessageBox.Show("Test");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                // Closes the connection with database and Exit the App.
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Alert", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Connection to Database closed on form closing
                    DataConnection.CloseConnection();
                    Application.ExitThread();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = true;
            gbCustomer.Visible = false;
            gbMovie.Visible = false;
            gbReturnMovie.Visible = false;
            gbRentMovie.Visible = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            gbCustomer.Visible = true;
            gbMovie.Visible = false;
            gbReturnMovie.Visible = false;
            gbRentMovie.Visible = false;
            TabControl.SelectedTab = TabControl.TabPages["Customers"];
            
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            gbCustomer.Visible = false;
            gbMovie.Visible = true;
            gbReturnMovie.Visible = false;
            gbRentMovie.Visible = false;
            TabControl.SelectedTab = TabControl.TabPages["Movies"];
            txtRentedCost.ReadOnly = true; // rent cost textbox will be read only as its value will be computed
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            gbCustomer.Visible = false;
            gbMovie.Visible = false;
            gbReturnMovie.Visible = true;
            gbRentMovie.Visible = false;
            TabControl.SelectedTab =TabControl.TabPages["RentedMovies"];
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            gbCustomer.Visible = false;
            gbMovie.Visible = false;
            gbReturnMovie.Visible = false;
            gbRentMovie.Visible = true;
            TabControl.SelectedTab = TabControl.TabPages["RentedMovies"];
            
        }

        //Compute the Rent Cost of Movie
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string movieReleaseyear = txtYear.Text.Trim();
                string currentYear = DateTime.Now.Year.ToString();
                if (Checks.EmptyField(movieReleaseyear))
                {
                    txtRentedCost.Text = "";
                }
                
                else
                {
                    int older = int.Parse(currentYear) - int.Parse(movieReleaseyear);
                    //if videos are older than 5 years (Release Date) then they cost $2 otherwise they cost $5
                    if (older > 5)
                    {
                        txtRentedCost.Text = "2";
                    }
                    else
                    {
                        txtRentedCost.Text = "5";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// Bind the ddl Rented movie by customer
        /// </summary>
        private void ddlAllCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int customerID = int.Parse(ddlAllCust.SelectedValue.ToString());
                if (customerID > 0)
                {
                    ddlRentedMovies.Enabled = true;
                    DataTable dsRented = new RentalMovieAction().GetRentedMoviesDDL(customerID);
                   
                    if (dsRented.Rows.Count>0)
                    {
                        DataRow row = dsRented.NewRow();
                        row[0] = 0;
                        row[1] = "--Please select--";
                        dsRented.Rows.InsertAt(row, 0); // add item at INDEX = 0;

                        ddlRentedMovies.DisplayMember = "Title";
                        ddlRentedMovies.ValueMember = "MovieID";
                        ddlRentedMovies.DataSource = dsRented;
                    }
                    else
                    {
                        ddlRentedMovies.Enabled = false;
                    }
                }
                else
                {
                    ddlRentedMovies.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        }
}
