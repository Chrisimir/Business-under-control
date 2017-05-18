using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_under_control
{
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
