// Chris Lund Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    class OrderFunctionality : DataFunction
    {
        OrderFunctionality(string name) : base(name)
        {
        }
        List<object> CompareSuppliers()
        {
            return new List<object>();
        }
        List<object> EstimateFutureOrders()
        {
            return new List<object>();
        }
        List<object> SeeOrders()
        {
            return new List<object>();
        }
        string OrderToString()
        {
            return "";
        }
    }
}
