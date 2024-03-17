using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group10_HotelSystem
{
    public partial class Confirm_details : Form
    {
        public string Name1 { get; set; }
        public string Surname { get; set; }

        public string Password { get; set; }
        public string Phone { get; set; }
        public string ID { get; set; }
        public string Email1 { get; set; }

        public Confirm_details()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp SU = new SignUp();
            SU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log objSignIn = new Log();
            objSignIn.propName = Name1;
            objSignIn.propSurname = Surname;
            objSignIn.propPassword = Password;
            objSignIn.propPhone = Phone;
            objSignIn.propEmail = Email1;
            objSignIn.propID = ID;

            objSignIn.Register();

            BookingData.propData = lblEmail.Text;

            this.Hide();
            HomePage HP = new HomePage();
            HP.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Confirm_details_Load(object sender, EventArgs e)
        {
            lblName.Text = Name1;
            lblSurname.Text = Surname;
            lblID.Text = ID.ToString();
            lblPhone.Text = Phone;
            lblEmail.Text = Email1;

            


                DOB_Gender objDOBG = new DOB_Gender();
                objDOBG.propIDNo = ID.ToString();
                lblDOB.Text = objDOBG.getDOB().ToString("d");
                lblGender.Text = objDOBG.getGender();
            
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
