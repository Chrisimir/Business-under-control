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
        private string name;
        private int shippingDays;
        private string telephone;

        public Supplier(string name, int shippingDays, string telephone)
        {
            this.name = name;
            this.shippingDays = shippingDays;
            this.telephone = telephone;
        }

        public string Name { get { return name; } set { name = value; } }
        public int ShippingDays { get { return shippingDays; } set { shippingDays = value; } }
        public string Telephone { get { return telephone; } set { telephone = value; } }
    }
}
