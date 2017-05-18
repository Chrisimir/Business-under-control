// Chris Lund Schober
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    public static class Establishment
    {
        static private string name;
        static private ContactInfo contactInfo;

        // Saves new data
        public static void Save(string newName, string imageLocation,
            string website, string phone, string mail)
        {
            if (!string.IsNullOrWhiteSpace(mail))
                contactInfo.email = mail;
            if (!string.IsNullOrWhiteSpace(phone))
                contactInfo.telephone = phone;
            if (!string.IsNullOrWhiteSpace(website))
                contactInfo.website = website;
            if (!string.IsNullOrWhiteSpace(newName))
                name = newName;
            if (!string.IsNullOrWhiteSpace(imageLocation))
                contactInfo.imageLocation = imageLocation;
        }
        public static string GetName()
        {
            return name;
        }
        public static string GetMail()
        {
            return contactInfo.email;
        }
        public static string GetTelephone()
        {
            return contactInfo.telephone;
        }
        public static string GetWebsite()
        {
            return contactInfo.website;
        }
        public static string GetImageLocation()
        {
            return contactInfo.imageLocation;
        }
    }
}
