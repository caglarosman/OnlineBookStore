using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
*  @author  : Serdar Demirtaş
*  @number  : 152120181011
*  @mail    : serdardemirtas25@gmail.com
*  @date    : 02.06.2021
*  @brief   : The purpose of this form is showing informations about selected products to the customer and purchasing operation with payment methods.
*             Also customer cancel the purchasing in this page.
*/

namespace Online_Book_Store
{
    public partial class MyCartForm : Form
    {
        private User user;

        /// <summary>
        /// This code block exists for showing product in ListView for products' properties.
        /// </summary>
        public MyCartForm(User user)
        {
            InitializeComponent();

            labelName.Text = user.FullName;
            labelUsername.Text = user.UserName;
            timer.Start();
            grpCart.Visible = false;
            this.user = user;

            listViewProducts.View = View.Details;
            listViewProducts.GridLines = true;
            listViewProducts.FullRowSelect = true;

            listViewProducts.Columns.Add("Product Type", 120);
            listViewProducts.Columns.Add("Name", 200);
            listViewProducts.Columns.Add("Amount", 90);
            listViewProducts.Columns.Add("Price", 90);

            UpdateListView();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pctLogout_Click(object sender, EventArgs e)
        {
            Application.OpenForms["LoginForm"].Show();
            this.Close();
        }

        /// <summary>
        /// This code block exists for showing time and date for user.
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

            UpdateTotalPrice();
        }

        /// <summary>
        /// This code block exists for cancelling order.
        /// </summary>
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Do you want to delete all items?", "Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(dg == DialogResult.Yes)
            {
                ShoppingCart shoppingCart = ShoppingCart.Instance;
                shoppingCart.CancelOrder();

                UpdateListView();
            }
            
        }

        /// <summary>
        /// This code block exists for updateting refreshing the shopping cart for every database operation. 
        /// </summary>
        private void UpdateListView()
        {
            listViewProducts.Items.Clear();

            ShoppingCart shoppingCart = ShoppingCart.Instance;
            List<Product> itemsToPurchase = shoppingCart.GetItemsToProducts();
            List<int> amountsOfPurchase = shoppingCart.GetAmountsOfProducts();

            foreach (var item in itemsToPurchase)
            {
                if (item is Book)
                {
                    int index = itemsToPurchase.IndexOf(item);
                    string[] row = { "BOOK", item.Name, amountsOfPurchase[index].ToString(), "$" + item.Price.ToString() };

                    ListViewItem myRow = new ListViewItem(row);
                    listViewProducts.Items.Add(myRow);
                }
                else if (item is Magazine)
                {
                    int index = itemsToPurchase.IndexOf(item);
                    string[] row = { "MAGAZINE", item.Name, amountsOfPurchase[index].ToString(), "$" + item.Price.ToString() };

                    ListViewItem myRow = new ListViewItem(row);
                    listViewProducts.Items.Add(myRow);
                }
                else if (item is MusicCD)
                {
                    int index = itemsToPurchase.IndexOf(item);
                    string[] row = { "MUSIC/CD", item.Name, amountsOfPurchase[index].ToString(), "$" + item.Price.ToString() };

                    ListViewItem myRow = new ListViewItem(row);
                    listViewProducts.Items.Add(myRow);
                }

            }
        }

        private void MyCartForm_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        /// <summary>
        /// This code block exists for removing items only for items.
        /// </summary>
        private void listViewProducts_DoubleClick(object sender, EventArgs e)
        {
            ShoppingCart shoppingCart = ShoppingCart.Instance;
            List<Product> itemsToPurchase = shoppingCart.GetItemsToProducts();
            int index = listViewProducts.FocusedItem.Index;

            shoppingCart.RemoveProduct(itemsToPurchase[index]);

            UpdateListView();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
            this.Close();
        }

        /// <summary>
        /// This code block exists for calculating total price for every operations which are performed by users.
        /// </summary>
        private void UpdateTotalPrice()
        {
            ShoppingCart shoppingCart = ShoppingCart.Instance;
            List<int> amountsOfProducts = shoppingCart.GetAmountsOfProducts();
            List<Product> itemsToProducts = shoppingCart.GetItemsToProducts();

            float totalPrice = 0;
            foreach (var item in itemsToProducts)
            {
                totalPrice += item.Price * amountsOfProducts[itemsToProducts.IndexOf(item)];
            }

            labelTotalPrice.Text = totalPrice.ToString();
        }

        /// <summary>
        /// This code block exists for sending bill to the user over e-mail.
        /// </summary>
        public bool SendToMail()
        {
            
            if(listViewProducts.Items.Count <= 0)
            {
                MessageBox.Show("You have to have at least 1 item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                string msg="Thank you for choosing us. Here is the details of your purchases:\n\n";
                string temp = "";
                if (rdoBtnCart.Checked == true)
                    temp = "Credit Cart";
                else if (rdoBtnCash.Checked == true)
                    temp = "Cash";

                if(listViewProducts.Items.Count > 0)
                {
                    for (int i = 0; i < listViewProducts.Items.Count; i++)
                    {
                        msg += listViewProducts.Items[i].SubItems[0].Text + " - " + listViewProducts.Items[i].SubItems[1].Text + " - " +
                            listViewProducts.Items[i].SubItems[2].Text + "x - " + listViewProducts.Items[i].SubItems[3].Text + "\n";
                    }
                    msg += "\n\nTotal Price: $" + labelTotalPrice.Text + " (" + temp + ")";

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("cengbookstore@gmail.com");
                    mail.To.Add(user.EMail);
                    mail.Subject = "CENG Book Store Invoice";
                    mail.Body = msg;
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("cengbookstore@gmail.com", "d4m14Y4_601");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("You have successfully purchased!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(SendToMail() == true)
            {
                Application.Exit();
            }
            
        }

        private void rdoBtnCash_CheckedChanged(object sender, EventArgs e)
        {
            grpCart.Visible = false;
        }
        private void rdoBtnCart_CheckedChanged(object sender, EventArgs e)
        {
            grpCart.Visible = true;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

    }
}
