using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    class Order
    {
        private string id;
        private string supplier;
        private string date;

        Order(string id, string supplier, string date)
        {
            this.id = id;
            this.supplier = supplier;
            this.date = date;
        }

        public string Id { get; set; }
        public string Supplier { get; set; }
        public string Date { get; set; }
    }
}
