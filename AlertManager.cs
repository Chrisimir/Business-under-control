// Chris Lund Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    class AlertManager
    {
        List<Alert> alertList;

        public AlertManager()
        {
            alertList = new List<Alert>();
            ManageNewAlerts();
        }

        void ManageNewAlerts()
        {
            // TODO: Check for alerts in data
            // TODO: Send alerts
        }

        void UpdateAlerts()
        {
            // TODO: Send alerts to screen
            // Have in mind the alert of "no connection" if it's not capable of the sync
        }
    }
}
