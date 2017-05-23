// Chris Lund Schober
using System;
using System.Windows.Forms;

namespace Business_under_control
{
    /*
     * About Screen - Has information about the program and the creator
     */
    public partial class AboutScreen : Form
    {
        public AboutScreen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
