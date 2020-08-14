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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // after the timer's tick, launch the Login frame
                this.Hide();
                LoginForm obj = new LoginForm();
                obj.Show();
                timer1.Stop();
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            // timer start
            timer1.Start();
        }
    }
}
