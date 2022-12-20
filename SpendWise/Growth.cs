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
                MessageBox.Show("Data unavilable!", "Assistant");
                // play chime
                SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                save.Play();
                // log the error
                con.ExecuteQuery("INSERT INTO events (date, Description, Location) VALUES('date('now')', 'SQL error', 'Growth action')");
            }
            
        }
    }
}
