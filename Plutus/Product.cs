using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plutus
{
    class Product:PlutusDBLayer
    {
        string productName;
        string productDesc;
        string productVendor;
        string productCatagoryName;
        string productAvaliblity;
        int prouctQuantity;
        int productInvintory;
        double price;
        Image productImage;

        public Product()
        {

        }
        public Product(string productName, string productDesc, string productVendor, double price)
        {
            this.productName = productName;
            this.productDesc = productDesc;
            this.productVendor = "by "+ productVendor;
            this.price = price;
            this.productImage = productImage;
            this.productCatagoryName = productCatagoryName;
            this.productAvaliblity = productAvaliblity;
            this.productInvintory = productInvintory;
        }
         
        
        public string ProductName { get => productName; set => productName = value; }
        public string ProductDesc { get => productDesc; set => productDesc = value; }
        public string ProductVendor { get => productVendor; set => productVendor = value; }
     
        public Image ProductImage { get => productImage; set => productImage = value; }
        public double Price { get => price; set => price = value; }
        public string ProductCatagoryName { get => productCatagoryName; set => productCatagoryName = value; }
        public string ProductAvaliblity { get => productAvaliblity; set => productAvaliblity = value; }
        public int ProductInvintory { get => productInvintory; set => productInvintory = value; }

        public int getNumOfProducts(Button button)
        {
            
            return getNumberOfProducts(button);
        }
        
        public Product[] getProducts(Button button)
        {
            
            return retriveProductBySp(button);
        }

        public void getProduct(Button button)
        {
            Product product = getProductBySp(productName);
            this.productName = product.ProductName;
            this.productDesc = product.ProductDesc;
            this.productVendor = product.ProductVendor;
            this.price = product.Price;
            this.productImage = product.ProductImage;
        }

        public double calcTotal()
        {
            return prouctQuantity * price;
        }
    }
}
