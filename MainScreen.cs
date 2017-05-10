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

        // Event handlers
        //      Display alert window - Click wherever in "Alert" zone
        AlertListWindow alertWindow = new AlertListWindow();
        private void openAlertWindow(object sender, EventArgs e)
        {
            if (!alertWindow.Visible)
            {
                alertWindow = new AlertListWindow();
                alertWindow.Show();
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        AboutScreen aboutScreen = new AboutScreen();
        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (!aboutScreen.Visible)
            {
                aboutScreen = new AboutScreen();
                aboutScreen.Show();
            }
        }

        private void lblEditFirm_MouseEnter(object sender, EventArgs e)
        {
            lblEditFirm.Font = new Font(lblEditFirm.Font.Name, lblEditFirm.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lblEditFirm_MouseLeave(object sender, EventArgs e)
        {
            lblEditFirm.Font = new Font(lblEditFirm.Font.Name, lblEditFirm.Font.SizeInPoints, FontStyle.Regular);
        }

        FirmEditScreen firmEditScreen = new FirmEditScreen();
        private void lblEditFirm_Click(object sender, EventArgs e)
        {
            if (!firmEditScreen.Visible)
            {
                firmEditScreen = new FirmEditScreen();
                firmEditScreen.Show();
            }
        }
    }
}
