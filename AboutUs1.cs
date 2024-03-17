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
    public partial class AboutUs1 : Form
    {
        public AboutUs1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcomePage welcomePage = new frmWelcomePage();
            welcomePage.Show();
            this.Hide();
        }
    }
}
