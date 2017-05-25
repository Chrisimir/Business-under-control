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
        int rating;
        bool noError;

        public AboutScreen()
        {
            InitializeComponent();
            rating = 0;
            noError = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void star_Click(object sender, EventArgs e)
        {
            string message = "Thanks\n\n Stars: ";
            switch (((PictureBox)(sender)).Name)
            {
                case "pbStar1":
                    lblStars.Text = message + "1";
                    rating = 1;
                    break;
                case "pbStar2":
                    lblStars.Text = message + "2";
                    rating = 2;
                    break;
                case "pbStar3":
                    lblStars.Text = message + "3";
                    rating = 3;
                    break;
                case "pbStar4":
                    lblStars.Text = message + "4";
                    rating = 4;
                    break;
                case "pbStar5":
                    lblStars.Text = message + "5";
                    rating = 5;
                    break;
                default:
                    MessageBox.Show("Something went very wrong");
                    noError = false;
                    break;
            };
            lblStars.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (noError)
            {
                Mail mail = new Mail("smtp.gmail.com", "chrisdenizless@gmail.com", 587, DateTime.Now);
                mail.Send("chrislund97@gmail.com", "Rate", rating.ToString(), ref noError);
            }

            if (noError)
            {
                gbPoll.Visible = false;
                MessageBox.Show("Thanks for rating");
            }
            else
            {
                MessageBox.Show("Error submition");
            }
        }
    }
}
