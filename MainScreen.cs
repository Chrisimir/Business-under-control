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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        // Event dependent functions
        AlertListWindow alertWindow = new AlertListWindow();
        private void openAlertWindow()
        {
            if (!alertWindow.Visible)
            {
                alertWindow = new AlertListWindow();
                alertWindow.Show();
            }
        }

        // Event handlers
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paneAlert_Click(object sender, EventArgs e)
        {
            openAlertWindow();
        }

        private void alertImage_Click(object sender, EventArgs e)
        {
            openAlertWindow();
        }

        private void lblAlert_Click(object sender, EventArgs e)
        {
            openAlertWindow();
        }

        private void lblAlertNum_Click(object sender, EventArgs e)
        {
            openAlertWindow();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // TODO: Open new screen and close(destroy) this one
            /*AboutScreen aboutScreen = new AboutScreen();
            this.Close();
            aboutScreen.Show();
            this.Visible = false;*/
        }
    }
}
