/*Developers: Chris Lund Schobert, Manuel Coronado
 *Version 0.06 -- 15-May-2017 / 16-May-2017
 *Changes:
 * btnChangeImage_Click method added, now it can change the images
 * by choosing them from a file
 * 
 * TODO: Save the image after it changes
 *       It needs to change the resources
 *       of the app to change the image when it loads
 */

using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Business_under_control
{
    public partial class FirmEditScreen : Form
    {
        private MainScreen mainScreen;
        private string logoFilePath;

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

        // Updates information about the firm
        private void btnSave_Click(object sender, EventArgs e)
        {
            Establishment.Save(tbName.Text, logoFilePath, tbWebsite.Text, tbPhone.Text, tbMail.Text);
            Utilities.SerializeEstablishmentData(Establishment.GetName(), Establishment.GetImageLocation(),
                Establishment.GetWebsite(), Establishment.GetTelephone(), Establishment.GetMail());

            // Update main screen
            mainScreen.RefreshFirmData();
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            // TODO: Copy to exe directory and resize to fit the image
            OpenFileDialog imageFile = new OpenFileDialog();

            // Name of the folder navigation window
            imageFile.Title = "Select logo";

            //Gets the path of the list directory used to set an image
            string exeFile = (new Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            
            imageFile.InitialDirectory = exeDir;

            if (imageFile.ShowDialog() == DialogResult.OK)
            {
                logoFilePath = imageFile.FileName;
                firmLogo.Image = new Bitmap(imageFile.FileName);
            }
        }
    }
}
