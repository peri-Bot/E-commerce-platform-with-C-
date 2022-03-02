using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plutus
{
    public partial class AccountForm : Form
    {
       

        public AccountForm()
        {
            InitializeComponent();
            customizeControls();
        }

       
        public void customizeControls()
        {
            User user = new User();
            User u = user.GetUser();

            txtFirstName.Text = u.FirstName;
            txtFirstName.Enabled = false;
            txtLastName.Text = u.LastName;
            txtLastName.Enabled = false;
            txtEmail.Text = u.Email;
            txtEmail.Enabled = false;
            txtUserName.Text = u.UserName;
            txtUserName.Enabled = false;
            txtPassw.Text = u.Passw;
            txtPassw.Enabled = false;
            txtAddressLine.Text = u.AddressLine;
            txtAddressLine.Enabled = false;
            txtPostalCode.Text = u.PostalCode;
            txtPostalCode.Enabled = false;
            txtCity.Text = u.City;
            txtCity.Enabled = false;
            txtZipCode.Text = u.ZipCode;
            txtZipCode.Enabled = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Enabled == false)
            {
                txtFirstName.Enabled = true;

                txtLastName.Enabled = true;

                txtEmail.Enabled = true;

                txtUserName.Enabled = true;

                txtPassw.Enabled = true;
                txtAddressLine.Enabled = true;
                txtPostalCode.Enabled = true;
                txtCity.Enabled = true;
                txtZipCode.Enabled = true;
            }
            else {
                txtFirstName.Enabled = false;

                txtLastName.Enabled = false;

                txtEmail.Enabled = false;
                
                txtUserName.Enabled = false;

                txtPassw.Enabled = false;
                txtAddressLine.Enabled = false;
                txtPostalCode.Enabled = false;
                txtCity.Enabled = false;
                txtZipCode.Enabled = false;
            }
        }
    }
}
