// Chris Lund Schober

using System.Windows.Forms;

namespace Business_under_control
{
    /*
     * UI - Handles the UI call.
     */
    class UI
    {
        public void StartGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
