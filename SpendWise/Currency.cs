using System;
using System.Drawing;

namespace SpendWise
{
    public partial class Currency : MetroFramework.Forms.MetroForm
    {
        public Currency()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        private void btn_save_Click(object sender, EventArgs e)
        {
            string queryCurrency = "UPDATE wallet SET currency = '" + txt_currency.Text + "' WHERE id = 1";
            con.ExecuteQuery(queryCurrency);
            lbl_title.Text = "Restart app now or later";
            lbl_title.ForeColor = Color.FromArgb(43, 140, 94);
        }
    }
}
