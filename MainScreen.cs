using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_under_control
{
    public partial class MainScreen : Form
    {
        OrdersScreen ordersScreen;
        FirmEditScreen firmEditScreen;
        AlertListWindow alertWindow;
        AboutScreen aboutScreen;
        Timer mainTimer;

        public MainScreen()
        {
            InitializeComponent();

            ordersScreen = new OrdersScreen();
            firmEditScreen = new FirmEditScreen();
            alertWindow = new AlertListWindow();
            aboutScreen = new AboutScreen();

            // Uncomment when data is there -> search *sync*
            /*/ Timer setup - Syncs local data with DB & check for new alerts
            new Database().Sync();
            mainTimer = new Timer();
            mainTimer.Interval = (5 * 60 * 1000); // 5 min
            mainTimer.Tick += new EventHandler(syncDB);*/
        }

        private void syncDB(object sender, EventArgs e) { new Database().Sync(); }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            if (File.Exists("EstablishmentData.bin"))
            {
                RefreshFirmData();
            }

            // Starts data refresh timer *sync*
            //mainTimer.Start();
        }

        // Display "Alert" window - Click wherever in "Alert" zone
        private void openAlertWindow(object sender, EventArgs e)
        {
            // Sets the window on top if it is already open
            if (!alertWindow.Visible)
            {
                alertWindow = new AlertListWindow();
                alertWindow.Show();
            }
            else
                alertWindow.Focus();
        }

        // Display "About" window
        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Sets the window on top if it is already open
            if (!aboutScreen.Visible)
            {
                aboutScreen = new AboutScreen();
                aboutScreen.Show();
            }
            else
                aboutScreen.Focus();
        }

        // Display "Orders" window
        private void btnOrders_Click(object sender, EventArgs e)
        {
            // Sets the window on top if it is already open
            if (!ordersScreen.Visible)
            {
                ordersScreen = new OrdersScreen();
                ordersScreen.Show();
            }
            else
                ordersScreen.Focus();
        }

        // Display "Firm" window
        private void lblEditFirm_Click(object sender, EventArgs e)
        {
            // Sets the window on top if it is already open
            if (!firmEditScreen.Visible)
            {
                firmEditScreen = new FirmEditScreen(this);
                firmEditScreen.Show();
            }
            else
                firmEditScreen.Focus();
        }

        // Mouse hover effect - enter
        private void lblEditFirm_MouseEnter(object sender, EventArgs e)
        {
            lblEditFirm.Font = new Font(lblEditFirm.Font.Name, lblEditFirm.Font.SizeInPoints, FontStyle.Underline);
        }
        // Mouse hover effect - leave
        private void lblEditFirm_MouseLeave(object sender, EventArgs e)
        {
            lblEditFirm.Font = new Font(lblEditFirm.Font.Name, lblEditFirm.Font.SizeInPoints, FontStyle.Regular);
        }

        public void RefreshFirmData()
        {
            lblFirmName.Text = Establishment.GetName();
            lblMail.Text = Establishment.GetMail();
            lblTelephone.Text = Establishment.GetTelephone();
            lblWebsite.Text = Establishment.GetWebsite();
            firmLogo.Image = new Bitmap(Establishment.GetImageLocation());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbRefresh_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbRefresh, "Force sync with DB");
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            // *sync*
            //new Database().Sync();
        }
    }
}
