// Chris Lund Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    class Suplier
    {
        private string CIF;
        private string name;
        private TimeSpan deliveryTime;
        // TODO: Change to a class
        private string contact;
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
