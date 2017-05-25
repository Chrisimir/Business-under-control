// Chris Lund Schober

namespace Business_under_control
{
    /*
     * Product - Contains the data of the products.
     */
    class Product
    {
        private string name;
        private float salePrice;

        public Product(string name, float salePrice)
        {
            this.name = name;
            this.salePrice = salePrice;
        }

        public string Name { get { return name; } set { name = value; } }
        public float SalePrice { get { return salePrice; } set { salePrice = value; } }
    }
}
