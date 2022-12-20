using System;
using System.Media;
using System.Security.Principal;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Profile : Form
    {
        readonly Connection con = new Connection();
        public Profile()
        {
            InitializeComponent();
            txt_name.Text = WindowsIdentity.GetCurrent().Name;
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            try
            { 
                con.ExecuteQuery($"UPDATE wallet SET owner = '{name}'");
                MessageBox.Show("Profile updated!", "Assistant");
            }
            catch
            {
                // play chime
                SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                save.Play();
                // log the error
                con.ExecuteQuery("INSERT INTO events (date, description, location) VALUES('date('now')', 'SQL error', 'Profile')");
                MessageBox.Show("Feature unavailable", "Assistant");
            }
            
        }
    }
}
