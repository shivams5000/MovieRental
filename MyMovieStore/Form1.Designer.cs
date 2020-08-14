namespace MyMovieStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtRentedCost = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.gvRental = new System.Windows.Forms.DataGridView();
            this.RentedMovies = new System.Windows.Forms.TabPage();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnMostPopulrMovies = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbReturnMovie = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ddlAllCust = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlRentedMovies = new System.Windows.Forms.ComboBox();
            this.btnCustMostMovie = new System.Windows.Forms.Button();
            this.gbMovie = new System.Windows.Forms.GroupBox();
            this.btnDelMOvie = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ddlMovie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddMOvie = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gvMovies = new System.Windows.Forms.DataGridView();
            this.Movies = new System.Windows.Forms.TabPage();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.Customers = new System.Windows.Forms.TabPage();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.label13 = new System.Windows.Forms.Label();
            this.ddlCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtIsuue = new System.Windows.Forms.DateTimePicker();
            this.dtReturn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.gbRentMovie = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ddlSelectCustomer = new System.Windows.Forms.ComboBox();
            this.ddlSelectMovie = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvRental)).BeginInit();
            this.RentedMovies.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.gbReturnMovie.SuspendLayout();
            this.gbMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovies)).BeginInit();
            this.Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.Customers.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.gbRentMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRentedCost
            // 
            this.txtRentedCost.Location = new System.Drawing.Point(141, 295);
            this.txtRentedCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentedCost.Name = "txtRentedCost";
            this.txtRentedCost.Size = new System.Drawing.Size(237, 26);
            this.txtRentedCost.TabIndex = 40;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(141, 130);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(237, 26);
            this.txtYear.TabIndex = 39;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(141, 75);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(237, 26);
            this.txtTitle.TabIndex = 38;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(125, 112);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(213, 26);
            this.txtPhone.TabIndex = 32;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(125, 162);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 72);
            this.txtAddress.TabIndex = 31;
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturnMovie.Location = new System.Drawing.Point(36, 185);
            this.btnReturnMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(276, 45);
            this.btnReturnMovie.TabIndex = 28;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteCustomer.Location = new System.Drawing.Point(782, 116);
            this.DeleteCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(157, 33);
            this.DeleteCustomer.TabIndex = 26;
            this.DeleteCustomer.Text = "Delete";
            this.DeleteCustomer.UseVisualStyleBackColor = false;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.BackColor = System.Drawing.Color.SeaGreen;
            this.UpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateCustomer.Location = new System.Drawing.Point(628, 116);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(146, 33);
            this.UpdateCustomer.TabIndex = 25;
            this.UpdateCustomer.Text = "Update";
            this.UpdateCustomer.UseVisualStyleBackColor = false;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // gvRental
            // 
            this.gvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRental.Location = new System.Drawing.Point(4, 4);
            this.gvRental.Margin = new System.Windows.Forms.Padding(4);
            this.gvRental.Name = "gvRental";
            this.gvRental.Size = new System.Drawing.Size(1468, 292);
            this.gvRental.TabIndex = 0;
            // 
            // RentedMovies
            // 
            this.RentedMovies.BackColor = System.Drawing.Color.Transparent;
            this.RentedMovies.Controls.Add(this.gvRental);
            this.RentedMovies.Location = new System.Drawing.Point(4, 29);
            this.RentedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.RentedMovies.Name = "RentedMovies";
            this.RentedMovies.Size = new System.Drawing.Size(1476, 298);
            this.RentedMovies.TabIndex = 2;
            this.RentedMovies.Text = "Rented Movies";
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.Khaki;
            this.pnlHome.Controls.Add(this.btnMostPopulrMovies);
            this.pnlHome.Controls.Add(this.btnShow);
            this.pnlHome.Controls.Add(this.btnCustMostMovie);
            this.pnlHome.Location = new System.Drawing.Point(376, 375);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1465, 432);
            this.pnlHome.TabIndex = 66;
            // 
            // btnMostPopulrMovies
            // 
            this.btnMostPopulrMovies.BackColor = System.Drawing.Color.Crimson;
            this.btnMostPopulrMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostPopulrMovies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostPopulrMovies.Location = new System.Drawing.Point(48, 55);
            this.btnMostPopulrMovies.Name = "btnMostPopulrMovies";
            this.btnMostPopulrMovies.Size = new System.Drawing.Size(328, 42);
            this.btnMostPopulrMovies.TabIndex = 56;
            this.btnMostPopulrMovies.Text = "Show Most Popular Movies";
            this.btnMostPopulrMovies.UseVisualStyleBackColor = false;
            this.btnMostPopulrMovies.Click += new System.EventHandler(this.btnMostPopulrMovies_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Crimson;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.Location = new System.Drawing.Point(467, 55);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(328, 42);
            this.btnShow.TabIndex = 57;
            this.btnShow.Text = "Show All Rented Movies";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gbReturnMovie
            // 
            this.gbReturnMovie.BackColor = System.Drawing.Color.Khaki;
            this.gbReturnMovie.Controls.Add(this.label12);
            this.gbReturnMovie.Controls.Add(this.ddlAllCust);
            this.gbReturnMovie.Controls.Add(this.btnReturnMovie);
            this.gbReturnMovie.Controls.Add(this.label11);
            this.gbReturnMovie.Controls.Add(this.ddlRentedMovies);
            this.gbReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReturnMovie.Location = new System.Drawing.Point(376, 375);
            this.gbReturnMovie.Name = "gbReturnMovie";
            this.gbReturnMovie.Size = new System.Drawing.Size(904, 460);
            this.gbReturnMovie.TabIndex = 60;
            this.gbReturnMovie.TabStop = false;
            this.gbReturnMovie.Text = "Movie Return Panel";
            this.gbReturnMovie.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "Select Customer:";
            // 
            // ddlAllCust
            // 
            this.ddlAllCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAllCust.FormattingEnabled = true;
            this.ddlAllCust.Location = new System.Drawing.Point(223, 43);
            this.ddlAllCust.Name = "ddlAllCust";
            this.ddlAllCust.Size = new System.Drawing.Size(213, 28);
            this.ddlAllCust.TabIndex = 55;
            this.ddlAllCust.SelectedIndexChanged += new System.EventHandler(this.ddlAllCust_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Select Rented Movie:";
            // 
            // ddlRentedMovies
            // 
            this.ddlRentedMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRentedMovies.FormattingEnabled = true;
            this.ddlRentedMovies.Location = new System.Drawing.Point(223, 101);
            this.ddlRentedMovies.Name = "ddlRentedMovies";
            this.ddlRentedMovies.Size = new System.Drawing.Size(213, 28);
            this.ddlRentedMovies.TabIndex = 53;
            // 
            // btnCustMostMovie
            // 
            this.btnCustMostMovie.BackColor = System.Drawing.Color.Crimson;
            this.btnCustMostMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustMostMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustMostMovie.Location = new System.Drawing.Point(879, 55);
            this.btnCustMostMovie.Name = "btnCustMostMovie";
            this.btnCustMostMovie.Size = new System.Drawing.Size(523, 42);
            this.btnCustMostMovie.TabIndex = 55;
            this.btnCustMostMovie.Text = "Customers Who Borrows Most Movies ";
            this.btnCustMostMovie.UseVisualStyleBackColor = false;
            this.btnCustMostMovie.Click += new System.EventHandler(this.btnCustMostMovie_Click);
            // 
            // gbMovie
            // 
            this.gbMovie.BackColor = System.Drawing.Color.Khaki;
            this.gbMovie.Controls.Add(this.btnDelMOvie);
            this.gbMovie.Controls.Add(this.btnUpdate);
            this.gbMovie.Controls.Add(this.ddlMovie);
            this.gbMovie.Controls.Add(this.label4);
            this.gbMovie.Controls.Add(this.txtTitle);
            this.gbMovie.Controls.Add(this.label5);
            this.gbMovie.Controls.Add(this.txtYear);
            this.gbMovie.Controls.Add(this.btnAddMOvie);
            this.gbMovie.Controls.Add(this.label6);
            this.gbMovie.Controls.Add(this.txtRentedCost);
            this.gbMovie.Controls.Add(this.label8);
            this.gbMovie.Controls.Add(this.txtGenre);
            this.gbMovie.Controls.Add(this.txtRating);
            this.gbMovie.Controls.Add(this.label7);
            this.gbMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovie.Location = new System.Drawing.Point(376, 375);
            this.gbMovie.Name = "gbMovie";
            this.gbMovie.Size = new System.Drawing.Size(1020, 475);
            this.gbMovie.TabIndex = 59;
            this.gbMovie.TabStop = false;
            this.gbMovie.Text = "Movie Panel";
            this.gbMovie.Visible = false;
            // 
            // btnDelMOvie
            // 
            this.btnDelMOvie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelMOvie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelMOvie.Location = new System.Drawing.Point(614, 229);
            this.btnDelMOvie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelMOvie.Name = "btnDelMOvie";
            this.btnDelMOvie.Size = new System.Drawing.Size(203, 33);
            this.btnDelMOvie.TabIndex = 53;
            this.btnDelMOvie.Text = "Delete Movie";
            this.btnDelMOvie.UseVisualStyleBackColor = false;
            this.btnDelMOvie.Click += new System.EventHandler(this.btnDelMOvie_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(614, 162);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 33);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update Movie";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ddlMovie
            // 
            this.ddlMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMovie.FormattingEnabled = true;
            this.ddlMovie.Location = new System.Drawing.Point(614, 89);
            this.ddlMovie.Name = "ddlMovie";
            this.ddlMovie.Size = new System.Drawing.Size(231, 28);
            this.ddlMovie.TabIndex = 55;
            this.ddlMovie.SelectedIndexChanged += new System.EventHandler(this.ddlMovie_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Year:";
            // 
            // btnAddMOvie
            // 
            this.btnAddMOvie.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddMOvie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddMOvie.Location = new System.Drawing.Point(141, 369);
            this.btnAddMOvie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMOvie.Name = "btnAddMOvie";
            this.btnAddMOvie.Size = new System.Drawing.Size(203, 45);
            this.btnAddMOvie.TabIndex = 52;
            this.btnAddMOvie.Text = "Add Movie";
            this.btnAddMOvie.UseVisualStyleBackColor = false;
            this.btnAddMOvie.Click += new System.EventHandler(this.btnAddMOvie_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Genre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Rent cost($):";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(141, 185);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(237, 26);
            this.txtGenre.TabIndex = 46;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(141, 240);
            this.txtRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(237, 26);
            this.txtRating.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Rating (*/10):";
            // 
            // gvMovies
            // 
            this.gvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMovies.Location = new System.Drawing.Point(6, 7);
            this.gvMovies.Margin = new System.Windows.Forms.Padding(4);
            this.gvMovies.Name = "gvMovies";
            this.gvMovies.Size = new System.Drawing.Size(1462, 288);
            this.gvMovies.TabIndex = 0;
            // 
            // Movies
            // 
            this.Movies.Controls.Add(this.gvMovies);
            this.Movies.Location = new System.Drawing.Point(4, 29);
            this.Movies.Margin = new System.Windows.Forms.Padding(4);
            this.Movies.Name = "Movies";
            this.Movies.Padding = new System.Windows.Forms.Padding(4);
            this.Movies.Size = new System.Drawing.Size(1476, 298);
            this.Movies.TabIndex = 1;
            this.Movies.Text = "Movies";
            this.Movies.UseVisualStyleBackColor = true;
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(8, 7);
            this.CustomersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.Size = new System.Drawing.Size(1460, 288);
            this.CustomersDataGridView.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.CustomersDataGridView);
            this.Customers.Location = new System.Drawing.Point(4, 29);
            this.Customers.Margin = new System.Windows.Forms.Padding(4);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(4);
            this.Customers.Size = new System.Drawing.Size(1476, 298);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIssueMovie.Location = new System.Drawing.Point(137, 308);
            this.btnIssueMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(276, 45);
            this.btnIssueMovie.TabIndex = 27;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Customers);
            this.TabControl.Controls.Add(this.Movies);
            this.TabControl.Controls.Add(this.RentedMovies);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(376, 19);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1484, 331);
            this.TabControl.TabIndex = 21;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(552, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Select Customer:";
            // 
            // ddlCustomer
            // 
            this.ddlCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCustomer.FormattingEnabled = true;
            this.ddlCustomer.Location = new System.Drawing.Point(714, 51);
            this.ddlCustomer.Name = "ddlCustomer";
            this.ddlCustomer.Size = new System.Drawing.Size(227, 28);
            this.ddlCustomer.TabIndex = 51;
            this.ddlCustomer.SelectedIndexChanged += new System.EventHandler(this.ddlCustomer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(125, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 26);
            this.txtName.TabIndex = 44;
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.ForestGreen;
            this.AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddCustomer.Location = new System.Drawing.Point(39, 283);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(203, 41);
            this.AddCustomer.TabIndex = 43;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(123, -67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 52;
            this.label14.Text = "Select Movie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Issue Date:";
            // 
            // dtIsuue
            // 
            this.dtIsuue.Location = new System.Drawing.Point(182, 170);
            this.dtIsuue.Name = "dtIsuue";
            this.dtIsuue.Size = new System.Drawing.Size(230, 26);
            this.dtIsuue.TabIndex = 50;
            // 
            // dtReturn
            // 
            this.dtReturn.Location = new System.Drawing.Point(182, 222);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(231, 26);
            this.dtReturn.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Return Date:";
            // 
            // gbRentMovie
            // 
            this.gbRentMovie.BackColor = System.Drawing.Color.Khaki;
            this.gbRentMovie.Controls.Add(this.label16);
            this.gbRentMovie.Controls.Add(this.ddlSelectCustomer);
            this.gbRentMovie.Controls.Add(this.ddlSelectMovie);
            this.gbRentMovie.Controls.Add(this.label15);
            this.gbRentMovie.Controls.Add(this.label9);
            this.gbRentMovie.Controls.Add(this.dtReturn);
            this.gbRentMovie.Controls.Add(this.label10);
            this.gbRentMovie.Controls.Add(this.label14);
            this.gbRentMovie.Controls.Add(this.dtIsuue);
            this.gbRentMovie.Controls.Add(this.btnIssueMovie);
            this.gbRentMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRentMovie.Location = new System.Drawing.Point(376, 375);
            this.gbRentMovie.Name = "gbRentMovie";
            this.gbRentMovie.Size = new System.Drawing.Size(904, 475);
            this.gbRentMovie.TabIndex = 53;
            this.gbRentMovie.TabStop = false;
            this.gbRentMovie.Text = "Movie Rent Panel";
            this.gbRentMovie.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 20);
            this.label16.TabIndex = 69;
            this.label16.Text = "Select Customer:";
            // 
            // ddlSelectCustomer
            // 
            this.ddlSelectCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSelectCustomer.FormattingEnabled = true;
            this.ddlSelectCustomer.Location = new System.Drawing.Point(181, 71);
            this.ddlSelectCustomer.Name = "ddlSelectCustomer";
            this.ddlSelectCustomer.Size = new System.Drawing.Size(231, 28);
            this.ddlSelectCustomer.TabIndex = 68;
            // 
            // ddlSelectMovie
            // 
            this.ddlSelectMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSelectMovie.FormattingEnabled = true;
            this.ddlSelectMovie.Location = new System.Drawing.Point(181, 118);
            this.ddlSelectMovie.Name = "ddlSelectMovie";
            this.ddlSelectMovie.Size = new System.Drawing.Size(231, 28);
            this.ddlSelectMovie.TabIndex = 67;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(54, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 56;
            this.label15.Text = "Select Movie:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(33, 749);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRent);
            this.groupBox5.Controls.Add(this.btnReturn);
            this.groupBox5.Controls.Add(this.btnMovie);
            this.groupBox5.Controls.Add(this.btnCustomer);
            this.groupBox5.Controls.Add(this.btnHome);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(298, 433);
            this.groupBox5.TabIndex = 65;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control Panel";
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.Gold;
            this.btnRent.Location = new System.Drawing.Point(17, 280);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(215, 50);
            this.btnRent.TabIndex = 69;
            this.btnRent.Text = "RENT MOVIE";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Gold;
            this.btnReturn.Location = new System.Drawing.Point(17, 356);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(215, 50);
            this.btnReturn.TabIndex = 68;
            this.btnReturn.Text = "RETURN MOVIE";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnMovie
            // 
            this.btnMovie.BackColor = System.Drawing.Color.Gold;
            this.btnMovie.Location = new System.Drawing.Point(21, 208);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(215, 50);
            this.btnMovie.TabIndex = 67;
            this.btnMovie.Text = "MOVIE";
            this.btnMovie.UseVisualStyleBackColor = false;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Gold;
            this.btnCustomer.Location = new System.Drawing.Point(21, 140);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(215, 50);
            this.btnCustomer.TabIndex = 66;
            this.btnCustomer.Text = "CUSTOMER";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gold;
            this.btnHome.Location = new System.Drawing.Point(21, 59);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(215, 50);
            this.btnHome.TabIndex = 65;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // gbCustomer
            // 
            this.gbCustomer.BackColor = System.Drawing.Color.Khaki;
            this.gbCustomer.Controls.Add(this.DeleteCustomer);
            this.gbCustomer.Controls.Add(this.label13);
            this.gbCustomer.Controls.Add(this.UpdateCustomer);
            this.gbCustomer.Controls.Add(this.ddlCustomer);
            this.gbCustomer.Controls.Add(this.label1);
            this.gbCustomer.Controls.Add(this.txtName);
            this.gbCustomer.Controls.Add(this.AddCustomer);
            this.gbCustomer.Controls.Add(this.label3);
            this.gbCustomer.Controls.Add(this.txtPhone);
            this.gbCustomer.Controls.Add(this.label2);
            this.gbCustomer.Controls.Add(this.txtAddress);
            this.gbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.Location = new System.Drawing.Point(376, 375);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(1020, 432);
            this.gbCustomer.TabIndex = 58;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer Panel";
            this.gbCustomer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1866, 907);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.gbMovie);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbReturnMovie);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbRentMovie);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Rental Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRental)).EndInit();
            this.RentedMovies.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.gbReturnMovie.ResumeLayout(false);
            this.gbReturnMovie.PerformLayout();
            this.gbMovie.ResumeLayout(false);
            this.gbMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovies)).EndInit();
            this.Movies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.Customers.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.gbRentMovie.ResumeLayout(false);
            this.gbRentMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRentedCost;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.DataGridView gvRental;
        private System.Windows.Forms.TabPage RentedMovies;
        private System.Windows.Forms.DataGridView gvMovies;
        private System.Windows.Forms.TabPage Movies;
        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlMovie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelMOvie;
        private System.Windows.Forms.Button btnAddMOvie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtIsuue;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbRentMovie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddlRentedMovies;
        private System.Windows.Forms.Button btnCustMostMovie;
        private System.Windows.Forms.Button btnMostPopulrMovies;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddlAllCust;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbReturnMovie;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.GroupBox gbMovie;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ddlSelectCustomer;
        private System.Windows.Forms.ComboBox ddlSelectMovie;
        private System.Windows.Forms.Label label15;
    }
}

