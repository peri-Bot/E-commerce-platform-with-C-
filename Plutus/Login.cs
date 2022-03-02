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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRigister_Click(object sender, EventArgs e)
        {

            NewUserRegistrationForm newUserRegistrationForm = new NewUserRegistrationForm();
            newUserRegistrationForm.ShowDialog();
        }

        //private void txtEmail_Enter(object sender, EventArgs e)
        //{
        //    this.e.Text = "";
        //}

        //private void txtPassw_Enter(object sender, EventArgs e)
        //{
        //    t.Text = "";
        //}

        private void LogIn_Click(object sender, EventArgs e)
        {
            User user = new User(txtEmail.Text, txtPassw.Text);
            
            PlutusDBLayer plutusDB = new PlutusDBLayer();
            if (!plutusDB.Login_AuthenticateBySp(user))
            {
                MessageBox.Show("Username and/or password is incorrect.");
            }
            else
            {
                plutusDB.startShoppingSessionBySp(user);
                PlutusMainForm plutusMainForm = new PlutusMainForm();
                
                plutusMainForm.User = user;
                plutusMainForm.Show();
                this.Hide();
            }
            
        }

        //private void seePassw_Click(object sender, EventArgs e)
        //{

        //    Image eyeXImage = Image.FromFile("C:\\Users\\Blac\\source\\repos\\Plutus\\Plutus\\Resources\\eyeX.png");
        //    Image eyeImage = Image.FromFile("C:\\Users\\Blac\\source\\repos\\Plutus\\Plutus\\Resources\\eye.png");
        //    t.PasswordChar = default;

            

        //    if (eyePicBox.Image.Equals(eyeImage))
        //    {
        //        eyePicBox.Image = eyeXImage;
        //    }
        //    else
        //    {
        //        eyePicBox.Image = eyeImage;
        //    }
        //}

        private void picClose_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
