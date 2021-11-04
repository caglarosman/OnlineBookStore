using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <@autor>
/// Student No: 152120181097
/// Name Surname: Abdul Hannan Ayubi
/// Date: 29.05.2021
namespace Online_Book_Store
{
  
    public partial class ProductForm : Form
    {
        /// <The objects of ProductForm class.>
        /// In here we declare objects of the different classes to use inside the product form.
        /// </The objects of ProductForm class.>
        public static Book productBook;
        public static Magazine productMagazine;
        public static MusicCD productMusicCD;
        /// Using Enum for the product type.
      
        public enum ProductType { BOOK, MAGAZINE, MUSICCD }
        public static ProductType productType;
        private ShoppingCart shoppingCart;

        public ProductForm()
        {
            InitializeComponent();
             shoppingCart = ShoppingCart.Instance; /// using singleton and making a only one object of the shoppingcart

            switch (productType) /// using switch case for the different type of the objects.
            {
                case ProductType.BOOK: /// for showing the book informatin
                    {
                        this.lblAuthor.Text = productBook.Author;
                        this.lblISBN.Text = productBook.IsbnNumber;
                        this.lblPage.Text = productBook.Page.ToString() + " pages";
                        this.lblProductName.Text = productBook.Name;
                        this.lblPublisher.Text = productBook.Publisher;
                        this.lblPrice.Text = "$" + productBook.Price.ToString();
                        this.pctProduct.Image = productBook.Image;
                        this.rchDescription.Text = productBook.Description;
                        break;
                    }
                case ProductType.MAGAZINE:/// for showing the Magazine informatin
                    {
                        this.lblAuthor.Text = productMagazine.Issue;
                        this.lblISBN.Visible = false;
                        this.lblPage.Visible = false;
                        this.lblProductName.Text = productMagazine.Name;
                        this.lblPublisher.Text = productMagazine.Type.ToString();                     
                        this.lblPrice.Text = "$" + productMagazine.Price.ToString();
                        this.pctProduct.Image = productMagazine.Image;
                        this.rchDescription.Text = productMagazine.Description;
                        break;
                    }
                case ProductType.MUSICCD:/// for showing the MusicCD informatin
                    {
                        this.lblAuthor.Text = productMusicCD.Singer;
                        this.lblISBN.Visible = false;
                        this.lblPage.Visible = false;
                        this.lblProductName.Text = productMusicCD.Name;
                        this.lblPublisher.Text = productMusicCD.Type.ToString();                     
                        this.lblPrice.Text = "$" + productMusicCD.Price.ToString();
                        this.pctProduct.Image = productMusicCD.Image;
                        this.rchDescription.Text = productMusicCD.Description;
                        break;
                    }
            }
        }
        /// <Exiting from popup>
        /// With this function we exit from the pop up menu.
        /// </Exiting from popup>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <Decreament of the quentity of items.>
        ///  this function is for decreament the quentity of the items.
        /// </Decreament of the quentity of items.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecreament_Click(object sender, EventArgs e)
        {
            if(txtCount.Text == string.Empty)
            {
                return;
            }
            if (Convert.ToInt32(txtCount.Text) != 1)
            {
                int count = Convert.ToInt32(txtCount.Text);
                count--;
                txtCount.Text = count.ToString();
            }
        }
        /// <Increment of the quentity of items.>
        /// This function is for Increament the quentity of the items.
        /// /// </Increment of the quentity of items.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncrement_Click(object sender, EventArgs e)
        {
            if (txtCount.Text == string.Empty)
            {
                return;
            }
            int count = Convert.ToInt32(txtCount.Text);
            count++;
            txtCount.Text = count.ToString();
        }
        /// <Adding to the shoppingCart>
        /// This function is adding items to the shopping cart...
        /// </Adding to the shoppingCart>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCount.Text == string.Empty)
            {
                return;
            }
            switch (productType) /// using switch case for the different type of the items.
            {
                case ProductType.BOOK:
                    {
                        shoppingCart.AddProduct(productBook, Convert.ToInt32(txtCount.Text));
                        break;
                    }
                case ProductType.MAGAZINE:
                    {
                        shoppingCart.AddProduct(productMagazine, Convert.ToInt32(txtCount.Text));
                        break;
                    }
                case ProductType.MUSICCD:
                    {
                        shoppingCart.AddProduct(productMusicCD, Convert.ToInt32(txtCount.Text));
                        break;
                    }

            }
            this.Close();
        }
        /// <Count function for the items>
        /// this function is not let to write the alphabet inside the textbox.
        /// </Count function for the items>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        /// <Not let to write ZERO>
        /// This function is not Let to write zero inside the textbox.
        /// </Not let to write ZERO>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if(txtCount.Text == "0")
            {
                txtCount.Text = "1";
            }
        }
    }
}
