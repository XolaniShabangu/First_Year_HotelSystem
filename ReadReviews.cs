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
    public partial class ReadReviews : Form
    {
        public ReadReviews()
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

        private void lstReviews_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReadReviews_Load(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader(@"C:\Users\xolan\OneDrive\Desktop\CodeReviews\Reviews.txt");

            using (read)
            {
                string Reviews = read.ReadLine();
                while (Reviews != null)
                {
                    lstReviews.Items.Add(Reviews);
                    Reviews = read.ReadLine();
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
