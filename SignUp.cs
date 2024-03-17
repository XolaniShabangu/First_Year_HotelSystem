using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Group10_HotelSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare Variables
            string Name = "", Surname = "", Password = "", ConfPassword = "", Email = "";
            string Phone = "";
            string ID = "";

            //Input
            Name = txtName.Text;
            Surname = txtSurname.Text;
            Email = txtEmail.Text;
            Password = txtPswd.Text;
            ConfPassword = txtConfirmPswd.Text;
            Phone = txtPhone.Text;
            ID = txtID.Text;




            //Validating 
       
                if (txtPswd.Text != txtConfirmPswd.Text)
                {
                    MessageBox.Show("Passwords don't match");
                }
                else
                {
                    //open confirm form
                    this.Hide();
                    Confirm_details CF = new Confirm_details();
                    CF.Name1 = Name;
                    CF.Surname = Surname;
                    CF.Password = Password;
                    CF.Phone = Phone;
                    CF.ID = ID;
                    CF.Email1 = Email;
                    CF.Show();
                }
            
        }
        
        private void btnEyCl_Click(object sender, EventArgs e)
        {
            if (txtPswd.PasswordChar == '\0')
            {
                btnEyOp.BringToFront();
                txtPswd.PasswordChar = '*';
            }
        }

        private void btnEyOp_Click(object sender, EventArgs e)
        {
            if (txtPswd.PasswordChar == '*')
            {
                btnEyCl.BringToFront();
                txtPswd.PasswordChar = '\0';
            }
        }

        private void btnEyOpen_Click(object sender, EventArgs e)
        {
            if (txtConfirmPswd.PasswordChar == '*')
            {
                btnEyClosed.BringToFront();
                txtConfirmPswd.PasswordChar = '\0';
            }
        }

        private void btnEyClosed_Click(object sender, EventArgs e)
        {
            if (txtConfirmPswd.PasswordChar == '\0')
            {
                btnEyOpen.BringToFront();
                txtConfirmPswd.PasswordChar = '*';
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcomePage welc = new frmWelcomePage();
            welc.Show();
            this.Hide();
        }

        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, pattern) == false)
            {
                txtEmail.Focus();
                errorProvider5.SetError(this.txtEmail, "Invalid email address");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text)== true)
            {
                txtName.Focus();
                errorProvider1.SetError(this.txtName, "Do not leave empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSurname.Text) == true)
            {
                txtSurname.Focus();
                errorProvider2.SetError(this.txtSurname, "Do not leave empty");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text) == true)
            {
                txtPhone.Focus();
                errorProvider3.SetError(this.txtPhone, "Do not leave empty");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) == true)
            {
                txtID.Focus();
                errorProvider4.SetError(this.txtID, "Do not leave empty");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txtPswd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPswd.Text) == true)
            {
                txtPswd.Focus();
                errorProvider6.SetError(this.txtPswd, "Do not leave empty");
            }
            else
            {
                errorProvider6.Clear();
            }
            if (txtPswd.TextLength < 6)
            {
                txtPswd.Focus();
                errorProvider9.SetError(this.txtPswd, "Password must be more than 6 characters.");
            }
        }

        private void txtConfirmPswd_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
