using System;
using System.Security.Principal;
using System.Windows.Forms;
using System.Drawing;

namespace SpendWise
{
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        Dashboard dashboard = new Dashboard();
        public Profile()
        {
            InitializeComponent();
            txt_name.Text = WindowsIdentity.GetCurrent().Name;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            try
            { 
                con.ExecuteQuery($"UPDATE wallet SET owner = '{name}' WHERE id = 1");
                MessageBox.Show("Profile updated!", "Assistant");
            }
            catch
            {
                MessageBox.Show("Sorry app error");
            }
            
        }
    }
}
