using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    class Conections
    {
        protected string direction;
        protected short port;
        protected DateTime date;

        protected Conections(string direction, short port, DateTime date)
        {
            this.direction = direction;
            this.port = port;
            this.date = date;
        }

        virtual protected void Connect()
        {
        }

        virtual protected string GetPassword(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        return sr.ReadLine();
                    }
                }
                catch (Exception)
                {
                    return "error";
                }
            }
            return "";
        }
    }
}
