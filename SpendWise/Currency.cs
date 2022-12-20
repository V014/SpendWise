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
        }
        
        private void Btn_save_Click(object sender, EventArgs e)
        { 
            con.ExecuteQuery($"UPDATE wallet SET currency = '{txt_currency.Text}'");
            lbl_title.Text = "Wallet renamed!";
            lbl_title.ForeColor = Color.FromArgb(43, 140, 94);
        }
    }
}
