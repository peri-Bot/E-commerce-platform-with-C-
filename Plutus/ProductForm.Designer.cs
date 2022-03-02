
using System.Windows.Forms;

namespace Plutus
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblAvaliablity = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblS = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(267, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 437);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblProductName.Location = new System.Drawing.Point(766, 155);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(70, 26);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "label1";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblVendor.Location = new System.Drawing.Point(767, 199);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(60, 24);
            this.lblVendor.TabIndex = 2;
            this.lblVendor.Text = "label1";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblDesc.Location = new System.Drawing.Point(767, 268);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 24);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "label1";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblCat.Location = new System.Drawing.Point(767, 365);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(94, 24);
            this.lblCat.TabIndex = 4;
            this.lblCat.Text = "Catagory: ";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblCatagory.Location = new System.Drawing.Point(867, 365);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(60, 24);
            this.lblCatagory.TabIndex = 5;
            this.lblCatagory.Text = "label1";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblA.Location = new System.Drawing.Point(767, 406);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(92, 24);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "Avaliblity: ";
            // 
            // lblAvaliablity
            // 
            this.lblAvaliablity.AutoSize = true;
            this.lblAvaliablity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliablity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblAvaliablity.Location = new System.Drawing.Point(867, 406);
            this.lblAvaliablity.Name = "lblAvaliablity";
            this.lblAvaliablity.Size = new System.Drawing.Size(60, 24);
            this.lblAvaliablity.TabIndex = 5;
            this.lblAvaliablity.Text = "label1";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblP.Location = new System.Drawing.Point(767, 524);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(63, 24);
            this.lblP.TabIndex = 4;
            this.lblP.Text = "Price: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblPrice.Location = new System.Drawing.Point(867, 524);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(60, 24);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "label1";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddToCart.Location = new System.Drawing.Point(1145, 728);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddToCart.Size = new System.Drawing.Size(120, 34);
            this.btnAddToCart.TabIndex = 12;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblS.Location = new System.Drawing.Point(767, 446);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(66, 24);
            this.lblS.TabIndex = 4;
            this.lblS.Text = "Stock: ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.lblStock.Location = new System.Drawing.Point(867, 446);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(60, 24);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "label1";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1546, 800);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblAvaliablity);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblProductName;
        private Label lblVendor;
        private Label lblDesc;
        private Label lblCat;
        private Label lblCatagory;
        private Label lblA;
        private Label lblAvaliablity;
        private Label lblP;
        private Label lblPrice;
        private Button btnAddToCart;
        private Label lblS;
        private Label lblStock;

        public Label LblVendor { get => lblVendor; set => lblVendor = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public Label LblProductName { get => lblProductName; set => lblProductName = value; }
        public Label LblVendor1 { get => lblVendor; set => lblVendor = value; }
        public Label LblDesc { get => lblDesc; set => lblDesc = value; }
        public Label LblCat { get => lblCat; set => lblCat = value; }
        public Label LblCatagory { get => lblCatagory; set => lblCatagory = value; }
        public Label LblA { get => lblA; set => lblA = value; }
        public Label LblAvaliablity { get => lblAvaliablity; set => lblAvaliablity = value; }
        public Label LblP { get => lblP; set => lblP = value; }
        public Label LblPrice { get => lblPrice; set => lblPrice = value; }
        public Button BtnAddToCart { get => btnAddToCart; set => btnAddToCart = value; }
        public Label LblS { get => lblS; set => lblS = value; }
        public Label LblStock { get => lblStock; set => lblStock = value; }
    }
}