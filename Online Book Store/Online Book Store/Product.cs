using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public abstract class Product
    {
        /// Attributes of class.
        /// The product class is base class for the other product objects.
        private string name;
        public static int ID = 1;
        private float price;
        private Image image;
        string description;
        /// Getter and Setter of the attributes of the class.
        /// 
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public Image Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }
        /// <Print the information of the products.>
        /// This function is for printing the information of the product.
        /// </Print the information of the products.>
        /// <returns></returns>
        protected string PrintProperties()
        {
            return "Product ID: " + ID + ", Product Name: " + Name + ", Product Price: " + Price;
        }
        public Product()
        {           
            DBConnection dBConnection = new DBConnection();
            dBConnection.Connect();
            dBConnection.Open();

            SqlCommand command = new SqlCommand("Select totalid from Table_Settings", dBConnection.Connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                ID = Convert.ToInt32(dr["totalid"].ToString());
            }
            dBConnection.Close();
        }

    }
}
