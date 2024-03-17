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
    public partial class Reviews : Form
    {
        public Reviews()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRev_Click(object sender, EventArgs e)
        {
            
            if (txtReview.Text == null)
            {
               MessageBox.Show("Cannot leave empty", "Error!");
            }
            else
            {
                StreamWriter Write = new StreamWriter(@"C:\Users\xolan\OneDrive\Desktop\CodeReviews\Reviews.txt", true);

                using (Write)
                {
                    Write.WriteLine(">>" + txtReview.Text + "\n");

                }
                MessageBox.Show("Review added!", "Notification");
                txtReview.Clear();
            }
        }

        private void btnSeeRev_Click(object sender, EventArgs e)
        {
            ReadReviews read = new ReadReviews();
            read.Show();
            this.Hide();
        }
    }
}
