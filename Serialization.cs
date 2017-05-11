using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    class Serialization : Conections
    {
        Serialization(string direction, short port, DateTime date) :
            base(direction, port, date)
        { }

        protected override void Connect()
        {
            // TODO: Addapt connection type
            base.Connect();
        }
    }
}
