// Chris Lund Schober

using System;
using System.Collections.Generic;

namespace Business_under_control
{
    /*
     * Supplier - Contains the information of a Supplier.
     */
    class Supplier
    {
        private string CIF;
        private string name;
        private TimeSpan deliveryTime;
        private ContactInfo contactInfo;
        private SortedList<Product, decimal> productPriceList;

        public void addProduct(Product product, decimal price)
        {
            productPriceList.Add(product, price);
        }
        public SortedList<Product, decimal> GetProductPriceList()
        {
            return productPriceList;
        }
    }
}
