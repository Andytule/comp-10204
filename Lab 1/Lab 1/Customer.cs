/*
 * Andy Le
 * 000805099
 * Implementation of the customer class
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    /// <summary>
    /// Implementation of a class called Customer which stores the information for one single customer
    /// </summary>    
    class Customer
    {
        private string name;
        private int id;
        private string productName;
        private decimal productSalePrice;
        private int quantity;
        private decimal salesTotal;
        /// <summary>
        /// Constructor method for Customer class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="productName"></param>
        /// <param name="productSalePrice"></param>
        /// <param name="quantity"></param>        
        public Customer(string name, int id, string productName, decimal productSalePrice, int quantity)
        {
            this.name = name;
            this.id = id;
            this.productName = productName;
            this.productSalePrice = productSalePrice;
            this.quantity = quantity;
            if (250 <= quantity)
            {
                this.salesTotal = quantity * productSalePrice * 0.875M;
            }
            else if (100 <= quantity)
            {
                this.salesTotal = quantity * productSalePrice * 0.95M;
            }
            else
            {
                this.salesTotal = quantity * productSalePrice;
            }

        }
        /// <summary>
        /// Method that retrieves the customer name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.name;
        }
        /// <summary>
        /// Method that retrieves the customer Id
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return this.id;
        }
        /// <summary>
        /// Method that retrieves the customer product name
        /// </summary>
        /// <returns></returns>
        public string GetProductName()
        {
            return this.productName;
        }
        /// <summary>
        /// Method that retrieves the customer product sales price
        /// </summary>
        /// <returns></returns>
        public decimal GetProductSalesPrice()
        {
            return this.productSalePrice;
        }
        /// <summary>
        /// Method that retrieves customer quantity
        /// </summary>
        /// <returns></returns>
        public int GetQuantity()
        {
            return this.quantity;
        }
        /// <summary>
        /// Method that retrieves the customer sales total
        /// </summary>
        /// <returns></returns>
        public decimal GetSalesTotal()
        {
            return this.salesTotal;
        }
        /// <summary>
        /// Returns string representation of customer instance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.name, -22}{this.id, -9}{this.productName, -36}{this.productSalePrice, -13:C}{this.quantity, 8}  {this.salesTotal:C}";
        }
        /// <summary>
        /// Method that sets the customer name
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Method that sets the customer Id
        /// </summary>
        /// <param name="id"></param>
        public void SetId(int id)
        {
            this.id = id;
        }
        /// <summary>
        /// Method that sets the customer product name
        /// </summary>
        /// <param name="productName"></param>
        public void SetProductName(string productName)
        {
            this.productName = productName;
        }
        /// <summary>
        /// Method that sets the customer product sale price
        /// </summary>
        /// <param name="unitSalePrice"></param>
        public void SetProductSalePrice(decimal unitSalePrice)
        {
            this.productSalePrice = unitSalePrice;
        }
        /// <summary>
        /// Method that sets the customer quantity
        /// </summary>
        /// <param name="quantity"></param>
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
