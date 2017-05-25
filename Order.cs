// Chris Lund Schober

namespace Business_under_control
{
    /*
     * Order - Contains the data of an order
     */
    class Order
    {
        private string id;
        private string supplier;
        private string date;

        public Order(string id, string supplier, string date)
        {
            this.id = id;
            this.supplier = supplier;
            this.date = date;
        }

        public string Id { get { return id; } set { id = value; } }
        public string Supplier { get { return supplier; } set { supplier = value; } }
        public string Date { get { return date; } set { id = value; } }
    }
}
