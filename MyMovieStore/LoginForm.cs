using MyMovieStore.Common;
using MyMovieStore.DBAction;
using MyMovieStore.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMovieStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// login to Movie Rental with valid username and password
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
        try
        {       // initialize variables
                string userName, Pswd;
                userName = txtUserName.Text.Trim();
                Pswd = txtPswd.Text.Trim();

                //check empty fields
                if (Checks.EmptyField(userName))
                {
                    MessageBox.Show("User name is required", "Alert!");
                }
                else if (Checks.EmptyField(Pswd))
                {
                    MessageBox.Show("Password is required", "Alert!");
                }
                else
                {
                    LoginData data = new LoginData();
                    data.userName = userName;
                    data.password = Pswd;

                    DataTable dt = new LoginAction().LoginForm(data);
                    if (dt.Rows.Count >0 )
                    {
                        this.Hide();
                        Form1 f = new Form1();
                        f.Show(); // show Next Form
                    }
                    else
                    {
                        MessageBox.Show("Login failed! Invalid username / password.","Alert!");
                    }
                }
        }
        catch (Exception ex)
        {
                MessageBox.Show(ex.Message);
        }
        }

        // Form Closing when click on [X] button
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
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
    }
}
