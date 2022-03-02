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
    public partial class PlutusMainForm : Form
    {
        User user;

        internal User User { get => user; set => user = value; }

        public PlutusMainForm()
        {

            InitializeComponent();
            customDesign();   
        }

        private void customDesign()
        {
           // MessageBox.Show(User.Email);
            HomeForm homeForm = new HomeForm();
            homeForm.FormBorderStyle = FormBorderStyle.None;
            homeForm.TopLevel = false;
            homeForm.AutoScroll = true;
            pnlMainContaint.Controls.Add(homeForm);
            homeForm.Show();
        }

     
        private void PlutusMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PlutusMainForm_Load(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnShopByDep_Click(object sender, EventArgs e)
        //{
        //    showSubMenu(panelSubShopByDep);
        //}

        //private void hideSubMenu(Panel SubMenu)
        //{
        //    if (SubMenu.Visible == true)
        //    {
        //        SubMenu.Visible = false;
        //    }
        //}

        //private void showSubMenu(Panel subMenu)
        //{
        //    if (subMenu.Visible == false)
        //    {
        //        hideSubMenu(subMenu);
        //        subMenu.Visible = true;
        //    }
        //    else
        //    {
        //        subMenu.Visible = true;
        //    }
        //}
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelSideMenu.Width == 232)
            {
                lblShopByDep.Text = "";
                btnElectronics.Text = "";
                btnComputers.Text = "";
                btnArtCrafts.Text = "";
                btnAutomotie.Text = "";
                btnBabby.Text = "";
                btnAccount.Text = "";
                btnGiftCards.Text = "";
                lblProgramFeatures.Text = "";
                lblHelpSettings.Text = "";
                btnHome.Text = "";
                btnSeeAll.Text = "";
                pnlShopByDep.Width = 49;
                panelSideMenu.Width = 49;

            }else
            {
                btnSeeAll.Text = "See All";
                lblShopByDep.Text = "Shop By Departement";
                btnElectronics.Text = "Electronics";
                btnComputers.Text = "Computers";
                btnArtCrafts.Text = "Art and Crafts";
                btnAutomotie.Text = "Automotieve";
                btnBabby.Text = "Babby";
                btnAccount.Text = "Your Account";
                btnGiftCards.Text = "All gift Cards";
                lblProgramFeatures.Text = "Program and Features";
                lblHelpSettings.Text = "Help and Settings";
                btnHome.Text = "Home";
                pnlShopByDep.Width = 232;
                panelSideMenu.Width = 232;
            }
        }

    

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            if(panelSubShopByDep.Height == 250)
            {
                panelSubShopByDep.Height = 354;
                btnSeeAll.Dock = DockStyle.Bottom;
                btnSeeAll.Text = "Hide";
            }
            else
            {
                panelSubShopByDep.Height = 250;
                btnSeeAll.Dock = DockStyle.Top;
                btnSeeAll.Text = "See All";
            }
        }

        private void btnElectronics_Click(object sender, EventArgs e)
        {

            createSubContaint(btnElectronics);
        }
        
        private void createSubContaint(Button button)
        {

            if (pnlMainContaint != null) {
                while (pnlMainContaint.Controls.Count > 0)
                {
                    pnlMainContaint.Controls[0].Dispose();
                }
            }
            
            ContaintForm cForm = new ContaintForm(button);
            cForm.FormBorderStyle = FormBorderStyle.None;
            cForm.TopLevel = false;
            cForm.AutoScroll = true;
            pnlMainContaint.Controls.Add(cForm);
            cForm.Show();

            
        }
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            HomeForm homeForm = new HomeForm();


            if (pnlMainContaint != null)
            {
                while (pnlMainContaint.Controls.Count > 0)
                {
                    pnlMainContaint.Controls[0].Dispose();
                }
            }
            homeForm.FormBorderStyle = FormBorderStyle.None;
            homeForm.TopLevel = false;
            homeForm.AutoScroll = true;
            pnlMainContaint.Controls.Add(homeForm);
            homeForm.Show();


        }

        private void closeForm(Form form)
        {
            form.Close();
        }
        private void btnComputers_Click(object sender, EventArgs e)
        {
            createSubContaint(btnComputers);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PlutusDBLayer plutusDB = new PlutusDBLayer();
            plutusDB.endShoppingSessionBySP();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();


            if (pnlMainContaint != null)
            {
                while (pnlMainContaint.Controls.Count > 0)
                {
                    pnlMainContaint.Controls[0].Dispose();
                }
            }
            cartForm.FormBorderStyle = FormBorderStyle.None;
            cartForm.TopLevel = false;
            cartForm.AutoScroll = true;
            pnlMainContaint.Controls.Add(cartForm);
            cartForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();

            if(pnlMainContaint != null)
            {
                while(pnlMainContaint.Controls.Count > 0)
                {
                    pnlMainContaint.Controls[0].Dispose();
                }
            }
            accountForm.FormBorderStyle = FormBorderStyle.None;
            accountForm.TopLevel = false;
            accountForm.AutoScroll = true;
            pnlMainContaint.Controls.Add(accountForm);
            accountForm.Show();
        }

        private void btnSmartHome_Click(object sender, EventArgs e)
        {
            createSubContaint(btnSmartHome);
        }

        private void btnArtCrafts_Click(object sender, EventArgs e)
        {
            createSubContaint(btnArtCrafts);
        }

        private void btnAutomotie_Click(object sender, EventArgs e)
        {
            createSubContaint(btnAutomotie);
        }

        private void btnBabby_Click(object sender, EventArgs e)
        {
            createSubContaint(btnBabby);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMainContaint_Click(object sender, EventArgs e)
        {

        }
    }
}
