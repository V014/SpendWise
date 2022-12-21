using System;
using System.Media;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Growth : Form
    {
        private readonly Dashboard dashboard = new Dashboard();
        private readonly Connection con = new Connection();
        public Growth()
        {
            InitializeComponent();
            try
            {
                // pull established year from dashboard
                int established = dashboard.LoadEstablished();
                // pull current year from dashborad
                int yearNow = dashboard.LoadYear();
                // calculates years in service
                int years = yearNow - established;
                // display beginning value
                lbl_bv.Text = dashboard.LoadCapital().ToString();
                // display ending value
                lbl_ev.Text = dashboard.LoadRevenue().ToString();
                // display years
                lbl_years.Text = years.ToString();
                // display compound annual growth rate
                lbl_CAGR.Text = dashboard.LoadGrowth().ToString() + "%";
            }
            catch (Exception)
            {
                // play chime
                SoundPlayer chime = new SoundPlayer(@"sfx/warning.wav");
                chime.Play();

                MessageBox.Show("Data unavilable!", "Assistant");
                // log the error
                // con.ExecuteQuery("INSERT INTO events (date, Description, Location) VALUES(strftime('%Y-%m-%d %H:%M', 'now', 'localtime'), 'SQL error', 'Growth action')");
            }
            
        }
    }
}
