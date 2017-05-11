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
    public partial class FirmEditScreen : Form
    {
        private MainScreen mainScreen;
        public FirmEditScreen(MainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();
        }
        public FirmEditScreen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Updates information about the firm (user of program)
        private void btnSave_Click(object sender, EventArgs e)
        {
            Establishment.Save(tbName.Text, tbWebsite.Text, tbPhone.Text, tbMail.Text);
            // Update main screen
            mainScreen.RefreshFirmData();
        }
    }
}
