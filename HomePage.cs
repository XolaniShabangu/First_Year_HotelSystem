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
    public partial class HomePage : Form
    {
        
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmWelcomePage frmWelcomePage = new frmWelcomePage();
            frmWelcomePage.Show();
            this.Hide();
            BookingData.propData = "";
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs frmAboutUs = new AboutUs();
            frmAboutUs.Show();
            this.Hide();

        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            MakeBooking frmMakeBooking = new MakeBooking();
            frmMakeBooking.Show();
            this.Hide();

            
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            Reviews frmReviews = new Reviews();
            frmReviews.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPricing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("* A room per night costs R400"+ '\n' + "plus R250 per person." + '\n'+'\n'+"* Meals cost R100 per person per day.","Pricing");
        }

        private void btnCheckReservation_Click(object sender, EventArgs e)
        {
            CheckBooking check = new CheckBooking();
            check.Show();
            this.Hide();
        }
    }
}
