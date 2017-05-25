// Chris Lund Schober

using System;
using System.Net.Mail;

namespace Business_under_control
{
    /*
     * Mail - Controls the mail connections.
     */
    class Mail : Connection
    {
        private string mail;
        public Mail(string direction, string mail, short port, DateTime date) :
            base(direction, port, date)
        {
            this.mail = mail;
        }

        public void Send(string mailTo, string subject, string body, ref bool noError)
        {
            // Loads password from a txt so it isn't visible in the code
            string password = base.GetPassword("mailpass");

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(direction);

                mail.From = new MailAddress(this.mail);
                mail.To.Add(mailTo);
                mail.Subject = subject;
                mail.Body = body;

                SmtpServer.Port = port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(this.mail, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                noError = true;
                throw ex;
            }
        }
        void Read()
        {
            // TODO: Read message 
        }
    }
}
