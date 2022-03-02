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
    public partial class NewUserRegistrationForm : Form
    {
        public NewUserRegistrationForm()
        {
            InitializeComponent();
            
        }

        private void txtFistName_Enter(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
        }

        private void txtLasttName_Enter(object sender, EventArgs e)
        {
            txtLastName.Text = "";

        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtUserNmae_Enter(object sender, EventArgs e)
        {
            txtUserName.Text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassw.Text = "";
        }

        private void txtConfirPassw_Enter(object sender, EventArgs e)
        {
            txtConfirmPassw.Text = "";

        }

        private void txtConfirmPassw_Leave(object sender, EventArgs e)
        {
            if (!txtPassw.Text.Equals(txtConfirmPassw.Text))
            {
                MessageBox.Show("The password doesn't match.");
            }
        }

        private void NewUserRegistrationForm_Load(object sender, EventArgs e)
        {

        }

       

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            string l = txtLastName.Text;
            if (txtUserName.Text.Equals("")|| txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") || txtPassw.Text.Equals("") || txtEmail.Text.Equals("") || txtPhone.Text.Equals(""))
            {
                MessageBox.Show("The Feilds can't be empty.");
            }
            else
            {
                pnlCreateAccount.Hide();
                pnlAddress.Visible = true;
                pnlAddress.Location = new Point(25, 94);
                pnlAddress.Size = new Size(303, 490);
                txtLastName.Text = l;
            }

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
           
            if (txtAddressBox.Text.Equals("") || cmbCity.Text.Equals("") || txtPostalCode.Text.Equals("") || txtZipCode.Text.Equals("")|| txtUserName.Text.Equals("") || txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") || txtPassw.Text.Equals("") || txtEmail.Text.Equals("") || txtPhone.Text.Equals(""))
            {
                MessageBox.Show("The feilds can't be empty" + txtUserName.Text + txtFirstName.Text + txtLastName.Text + txtPassw.Text + txtEmail.Text + txtPhone.Text + txtAddressBox.Text + cmbCity.Text + txtPostalCode.Text + txtZipCode.Text);
            }
            else
            {
                User user = new User(txtUserName.Text, txtFirstName.Text, txtLastName.Text, txtPassw.Text, txtEmail.Text, txtPhone.Text, txtAddressBox.Text, cmbCity.Text, txtPostalCode.Text, txtZipCode.Text);
                PlutusDBLayer plutusDB = new PlutusDBLayer();
                
                plutusDB.saveUserBySP(user);
                plutusDB.saveAddressBySp(user);

                this.Close();
            }
        }

        private void txtZipCode_Validating(object sender, CancelEventArgs e)
        {
            






        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlAddress.Hide();
            pnlCreateAccount.Show();
        }
    }
}
