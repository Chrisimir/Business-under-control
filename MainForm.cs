// Chris Lund Schober

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Business_under_control
{
    /*
     * Main Screen - Principal screen of the program.
     *  It contains acces to all the categories of the program.
     */
    public partial class MainForm : Form
    {
        OrdersForm ordersScreen;
        FirmEditScreen firmEditScreen;
        AlertListWindow alertWindow;
        AboutScreen aboutScreen;
        StatisticsScreen statisticsScreen;
        StockScreen stockScreen;

        public MainForm()
        {
            InitializeComponent();

            ordersScreen = new OrdersForm();
            firmEditScreen = new FirmEditScreen();
            alertWindow = new AlertListWindow();
            aboutScreen = new AboutScreen();
            statisticsScreen = new StatisticsScreen();
            stockScreen = new StockScreen();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            // TODO: Start when data is there StartDatabaseTimer();

            if (File.Exists("EstablishmentData.bin"))
            {
                RefreshFirmData();
            }            
        }

        private void StartDatabaseTimer()
        {
            Timer mainTimer = new Timer();
            mainTimer.Interval = (5 * 60 * 1000); // 5 min
            mainTimer.Tick += new EventHandler(syncDB);
            mainTimer.Start();
        }
        void syncDB(object sender, EventArgs e) { new Database().Sync(); }

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
                ordersScreen = new OrdersForm();
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

        // Display "Statistics" window
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            // Sets the window on top if it is already open
            if (!statisticsScreen.Visible)
            {
                Cursor = Cursors.WaitCursor;
                statisticsScreen = new StatisticsScreen();
                statisticsScreen.Show();
            }
            else
                statisticsScreen.Focus();
            Cursor = Cursors.Arrow;
        }

        // Display "Stock" window
        private void btnStock_Click(object sender, EventArgs e)
        {
            // Sets the window on top if it is already open
            if (!stockScreen.Visible)
            {
                stockScreen = new StockScreen();
                stockScreen.Show();
            }
            else
                stockScreen.Focus();
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
            // TODO: Uncomment when data is there
            //new Database().Sync();
        }
    }
}
