using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group10_HotelSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Log objLogIn = new Log();
            objLogIn.propEmail = txtEmail.Text;
            objLogIn.propPassword = txtPassword.Text;


            

            if (objLogIn.LogOn().Contains("Access Granted"))
            {
                MessageBox.Show(objLogIn.LogOn());
                HomePage home = new HomePage(); 
                home.Show();
                this.Hide();

                BookingData.propData = txtEmail.Text;
            }
            else
            {
                MessageBox.Show("Try Again","Error");
            }

            
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void EyOpen_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnEyClosed.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnEyClosed_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnEyOpen.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcomePage frmWelcomePage = new frmWelcomePage();
            frmWelcomePage.Show();
            this.Hide();
        }
    }
}
