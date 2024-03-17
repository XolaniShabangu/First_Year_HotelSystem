using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Group10_HotelSystem
{
    public partial class CheckBooking : Form
    {
        public CheckBooking()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();

        }

        private void CheckBooking_Load(object sender, EventArgs e)
        {
            try
            {
                string lineRec = "";
                lstBooking.Items.Add("");
                StreamReader read = new StreamReader(@"C:\Users\xolan\OneDrive\Desktop" + "\\Booking\\" + BookingData.propData + ".txt");
                using (read)
                {
                lineRec = read.ReadLine();
                while (lineRec != null)
                {
                    lstBooking.Items.Add(lineRec);
                    lineRec = read.ReadLine();
                }
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Booking Not Found","Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\xolan\OneDrive\Desktop" + "\\Booking\\" + BookingData.propData + ".txt");
            MessageBox.Show("Your Booking has been Cancelled.","Success!!");

            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
