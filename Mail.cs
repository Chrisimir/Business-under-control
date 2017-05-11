using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    class Mail : Conections
    {
        private string mail;
        Mail(string direction, string mail, short port, DateTime date) :
            base(direction, port, date)
        {
            this.mail = mail;
        }

        protected override void Connect()
        {
            // TODO: Addapt connection type
            base.Connect();
        }

        void Send()
        {
            // TODO: Send message
        }
        void Read()
        {
            // TODO: Read message 
        }
    }
}
