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
    public partial class ContaintForm : Form
    {
        int idx;
        Product[] products;
        public ContaintForm() { }
        public ContaintForm(Button button)
        {
            InitializeComponent();
            createControls(button);
        }

        public void createControls(Button button)
        {
            lblCatagoryName.Text = button.Text;

            Product product = new Product();
            int numOfProducts = product.getNumOfProducts(button);

            if (numOfProducts < 0)
            {
                lblC.Enabled = false;
                txtC.Enabled = false;
                btnGO.Enabled = false;
            }
            products = new Product[numOfProducts];
            products = product.getProducts(button);

        

            Panel[] panels = new Panel[numOfProducts];
            


            for (int i = 0; i < panels.Length; i++)
            {
                panels[i] = new Panel();
                panels[i].Size = new System.Drawing.Size(514, 288);
                panels[i].TabIndex = 0;
                panels[i].Visible = true;

                string num = "                Product Number: " + i.ToString();

                Label lblV = new Label();
                lblV.Text = products[i].ProductVendor+num;
                lblV.BackColor = System.Drawing.Color.Transparent;
                lblV.Dock = System.Windows.Forms.DockStyle.Top;
                lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
                lblV.Location = new System.Drawing.Point(0, 265);
                lblV.Size = new System.Drawing.Size(101, 20);
                lblV.TabIndex = 3;
                lblV.Click += product_Click;
                lblV.Cursor = Cursors.Hand;


                lblProName = new Label();
                lblProName.Text = products[i].ProductName;
                lblProName.BackColor = System.Drawing.Color.Transparent;
                lblProName.Dock = System.Windows.Forms.DockStyle.Top;
                lblProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblProName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
                lblProName.Location = new System.Drawing.Point(0, 240);
                lblProName.Size = new System.Drawing.Size(70, 25);
                lblProName.TabIndex = 2;
                lblProName.Click += product_Click;
                lblProName.Cursor = Cursors.Hand;

                PictureBox pbProPic = new PictureBox();
                pbProPic.Image = products[i].ProductImage;
                pbProPic.Dock = System.Windows.Forms.DockStyle.Top;
                pbProPic.Size = new System.Drawing.Size(589, 240);
                pbProPic.TabIndex = 0;
                pbProPic.TabStop = false;
                pbProPic.Click += product_Click;
                pbProPic.Cursor = Cursors.Hand;


                panels[i].Controls.Add(lblV);
                panels[i].Controls.Add(lblProName);
                panels[i].Controls.Add(pbProPic);
                flowLayoutPanel1.Controls.Add(panels[i]);              
            }



        }

        private void product_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lable_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            Panel panelProduct = this.Parent as Panel;
           

            Product product = products[int.Parse(txtC.Text)];
            ProductForm productForm = new ProductForm();

            productForm.LblProductName.Text = product.ProductName;
            productForm.LblVendor.Text = product.ProductVendor;
            productForm.LblDesc.Text = product.ProductDesc;
            productForm.LblCatagory.Text = product.ProductCatagoryName;
            productForm.LblPrice.Text = product.Price.ToString();
            productForm.LblAvaliablity.Text = product.ProductAvaliblity;
            productForm.LblStock.Text =  product.ProductInvintory.ToString();


            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.TopLevel = false;
            productForm.AutoScroll = true;
            panelProduct.Controls.Add(productForm);
            productForm.Show();
            this.Close();
        }
    }
}
