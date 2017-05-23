// Chris Lund Schober

namespace Business_under_control
{
    /*
     * Establishment - Contains the data and the functions regarging
     *  the establishment using the software.
     */
    public class Establishment
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
