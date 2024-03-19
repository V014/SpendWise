using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Currency : Form
    {
        readonly Connection con = new Connection();

        public Currency()
        {
            InitializeComponent();
            txt_currency.Text = con.ReadString("SELECT currency FROM wallet");
            // load previous theme
            PreviousTheme();
        }
        
        private void Btn_save_Click(object sender, EventArgs e)
        { 
            con.ExecuteQuery($"UPDATE wallet SET currency = '{txt_currency.Text}'");
            lbl_title.Text = "Wallet renamed!";
            lbl_title.ForeColor = Color.FromArgb(43, 140, 94);
        }
        private void PreviousTheme()
        {
            try
            {
                string UserTheme = con.ReadString("SELECT Theme FROM wallet");
                if (UserTheme == "Light")
                {
                    this.BackColor = Color.White;
                    lbl_title.ForeColor = Color.Black;
                    txt_currency.BackColor = Color.FromArgb(235, 235, 235);
                }
                else if (UserTheme == "Dark")
                {
                    this.BackColor = Color.FromArgb(17, 17, 17);
                    lbl_title.ForeColor = Color.White;
                    txt_currency.BackColor = Color.FromArgb(17, 17, 17);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
