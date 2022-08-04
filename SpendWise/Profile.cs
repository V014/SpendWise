using System;
using System.Security.Principal;
using System.Windows.Forms;
using System.Drawing;

namespace SpendWise
{
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
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
                string queryName = "UPDATE wallet SET owner ='"+ name + "' WHERE id = 1";
                con.ExecuteQuery(queryName);
                lbl_title.Text = "Restart app now or later";
                lbl_title.ForeColor = Color.FromArgb(43, 140, 94);
            }
            catch
            {
                MessageBox.Show("Sorry app error");
            }
            
        }
    }
}
