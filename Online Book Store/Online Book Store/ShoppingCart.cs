using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

/**
*  @author  : Serdar Demirtaş
*  @number  : 152120181011
*  @mail    : serdardemirtas25@gmail.com
*  @date    : 02.06.2021
*  @brief   : The purpose of this class is that removing, adding, cancelling order operations.
*/

namespace Online_Book_Store
{
    class ShoppingCart
    {
        private static List<Product> itemsToPurchase;
        private static List<int> amountToPurchase;
        private static ShoppingCart instance = null;

        private ShoppingCart() { itemsToPurchase = new List<Product>(); amountToPurchase = new List<int>(); }

        /// <summary>
        /// The purpose of this function is using singleton.
        /// </summary>
        public static ShoppingCart Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShoppingCart();
                }
                return instance;
            }
        }

        /// <summary>
        /// The purpose of this function is adding product. 
        /// </summary>
        public void AddProduct(Product product, int amount)
        {
            if (itemsToPurchase.IndexOf(product) > -1)
            {
                amountToPurchase[itemsToPurchase.IndexOf(product)] += amount;
            }
            else
            {
                itemsToPurchase.Add(product);
                amountToPurchase.Add(amount);
            }

        }

        /// <summary>
        /// The purpose of this function is removing product. 
        /// </summary>
        public bool RemoveProduct(Product product)
        {
            int index = itemsToPurchase.IndexOf(product);

            if (itemsToPurchase.Remove(product))
            {
                amountToPurchase.RemoveAt(index);
                return true;

            }
            else 
                return false;
        }

        /// <summary>
        /// The purpose of this function is cancelling order. 
        /// </summary>
        public void CancelOrder()
        {
            itemsToPurchase.Clear();
        }

        /// <summary>
        /// The purposes of this functions are showing informations abaout products. 
        /// </summary>
        public List<Product> GetItemsToProducts()
        {
            return itemsToPurchase;
        }
        public List<int> GetAmountsOfProducts()
        {
            return amountToPurchase;
        }

        
    }
}
