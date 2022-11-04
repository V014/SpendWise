using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Growth : MetroFramework.Forms.MetroForm
    {
        Dashboard dashboard = new Dashboard();
        Connection con = new Connection();
        public Growth()
        {
            InitializeComponent();
            // beginning value
            int bv = int.Parse(con.ReadString("SELECT amount FROM transactions WHERE action = '+' ORDER BY id ASC LIMIT 1"));
            // ending value
            int ev = int.Parse(dashboard.loadIncome());
            // beginning year, current year, solve difference
            int by = int.Parse(con.ReadString("SELECT strftime('%Y') FROM transactions WHERE action = '+' ORDER BY id ASC LIMIT 1"));
            int yearNow = int.Parse(con.ReadString("SELECT strftime('%Y')"));
            int years = yearNow - by;

            lbl_bv.Text = bv.ToString();
            lbl_ev.Text = ev.ToString();
            lbl_years.Text = years.ToString();
            lbl_CAGR.Text = dashboard.LoadGrowth().ToString() + "%";
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = @"res/growth/Formula.jpg";
        }
    }
}
