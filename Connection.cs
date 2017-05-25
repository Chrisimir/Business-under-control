// Chris Lund Schober
using System;
using System.IO;

namespace Business_under_control
{
    /*
     * Conections - Father class to the Conection classes,
     *  contains general functions that are used in subclasses
     */
    class Connection
    {
        protected string direction;
        protected short port;
        protected DateTime date;

        protected Connection(string direction, short port, DateTime date)
        {
            this.direction = direction;
            this.port = port;
            this.date = date;
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
