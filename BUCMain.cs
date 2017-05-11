// Chris Lund Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_under_control
{
    static class BUCMain
    {
        [STAThread]
        static void Main()
        {
            // Load establishment data
            Utilities.LoadSavedEstablishment();
            //TODO: Load rest of data

            UI.StartGUI();
        }

        static void CheckRefreshTime()
        {

        }
        static void CheckAlert()
        {

        }
        static void SendAlert()
        {

        }
        static void SaveData()
        {

        }
        static void SendData()
        {

        }
    }
    public struct ContactInfo
    {
        public string telephone;
        public string website;
        public string email;
    }
}
