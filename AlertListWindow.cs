// Chris Lund Schober

using System;
using System.Windows.Forms;

namespace Business_under_control
{
    /*
     * Alert List Window - The screen that contains the list of alerts
     */
    public partial class AlertListWindow : Form
    {
        public AlertListWindow()
        {
            InitializeComponent();
        }

        private void AlertListWindow_Load(object sender, EventArgs e)
        {
            // TODO: Load the alerts in the list

            if (lstAlerts.Items.Count > 0)
            {
                lstAlerts.Visible = true;
                lblAlert.Visible = false;
            }
        }
    }
}
