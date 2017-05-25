// Chris Lund Schober
using System;
using System.Threading;

namespace Business_under_control
{
    /*
     * Business under control Main - Main class of the program
     */
    static class BUCMain
    {
        [STAThread]
        static void Main()
        {
            // Starts connection with database
            Database database = new Database();
            database.Sync();

            // Load establishment data
            Utilities.LoadSavedEstablishment();
            //TODO: Load rest of data

            new UI().StartGUI();
        }

        static void SendAlert()
        {

        }
    }
}
