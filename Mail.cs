// Chris Lund Schober

using System;

namespace Business_under_control
{
    /*
     * Mail - Controls the mail connections.
     */
    class Mail : Connection
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
