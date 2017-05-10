// Chris Lund Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    class DataFunction
    {
        protected string name;
        protected DateTime timeNow = DateTime.Now;

        virtual protected void log()
        {
            // TODO: Log information about function
        }
    }
}
