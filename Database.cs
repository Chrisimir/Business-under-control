using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    class Database : Conections
    {
        private int timer;
        Database(string direction, short port, DateTime date) :
            base(direction, port, date)
        {
            this.timer = 300;
        }

        protected override void Connect()
        {
            // TODO: Addapt connection type
            base.Connect();
        }

        void Sync()
        {
            // TODO: Sync with DB
        }
        void Fetch()
        {
            // TODO: Fetch from DB
        }
        void Push()
        {
            // TODO: Push to DB
        }
    }
}
