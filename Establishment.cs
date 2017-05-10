// Chris Lund Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    // TODO: Change to a class
    public struct ContactInfo
    {
        public string telephone;
        public string website;
        public string email;
    }
    class Establishment
    {
        private string name;
        private string pictureLocation;
        private ContactInfo contactInfo;

        public string Name{ get; set; }
        public string PictureLocation{ get; set; }
        public void SetContact(string telephone, string website, string email)
        {
            contactInfo.telephone = telephone;
            contactInfo.website = website;
            contactInfo.email = email;
        }
    }
}
