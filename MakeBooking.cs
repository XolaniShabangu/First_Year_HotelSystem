using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Group10_HotelSystem
{
    public partial class MakeBooking : Form
    {
        
        public MakeBooking()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePickerOUT_Leave(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePickerIN.Value.Date;
            DateTime date2 = dateTimePickerOUT.Value.Date;

            int dateiff = ((TimeSpan)(date2 - date1)).Days;

            lblDays.Text = dateiff.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void Dates_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            
            DateTime date1 = dateTimePickerIN.Value.Date;
            DateTime date2 = dateTimePickerOUT.Value.Date;
            int dateiff = ((TimeSpan)(date2 - date1)).Days;
            lblDays.Text = dateiff.ToString();


            
            int Rooms, People;
            int Total = 0;
            int daysTotal = 0;
            int foodTotal = 0;

            Rooms = Convert.ToInt32(nudAdults.Value);
            People = Convert.ToInt32(nudRooms.Value);
            daysTotal = (250 * Rooms) + (250 * People) + (dateiff * 150);

            

            foodTotal = dateiff * (People * 100);
                
            if (chkInclMeals.Checked)
            {
                Total = daysTotal + foodTotal;
                lblTotal.Text ="Total Price to pay is: " + Total.ToString("C");
            }
            else
            {
                Total = daysTotal;
                lblTotal.Text = "Total Price to pay is: " + Total.ToString("C");
            }
            btnPayment.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("* A room per night costs R400" + '\n' + "plus R250 per person." + '\n' + '\n' + "* Meals cost R100 per person per day.","Pricing");
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            
            StreamWriter AddBooking = new StreamWriter(@"C:\Users\xolan\OneDrive\Desktop" + "\\Booking\\" + BookingData.propData + ".txt");       
            using (AddBooking)
            {
                AddBooking.WriteLine(BookingData.propData);
                AddBooking.WriteLine("Check-In: " + dateTimePickerIN.Value.ToShortDateString());
                AddBooking.WriteLine("Check-Out: " + dateTimePickerOUT.Value.ToShortDateString());
                AddBooking.WriteLine(nudAdults.Value + " Guest(s) & " + nudRooms.Value + " Room(s)");                
                
                if (chkInclMeals.Checked)
                {
                    AddBooking.WriteLine("Meals included");
                }
                else
                {
                    AddBooking.WriteLine("No Meals included");
                }
                AddBooking.WriteLine(lblTotal.Text);
            }

            MessageBox.Show("Reservation Complete!", "Success!!");
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void MakeBooking_Load(object sender, EventArgs e)
        {
            btnPayment.Hide();
            lblEmaill.Text = BookingData.propData;
        }
    }
}
