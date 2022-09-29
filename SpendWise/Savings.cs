using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Savings : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        public Savings()
        {
            InitializeComponent();
            string percent = con.ReadString("SELECT save FROM wallet");
            lbl_percent.Text = percent + "%";
            TrackBar.Value = int.Parse(percent);
        }

        private void TrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_percent.Text = TrackBar.Value.ToString() + "%";
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            int percentage = TrackBar.Value;
            try
            {
                con.ExecuteQuery($"UPDATE wallet SET save = '{percentage}'");
                lbl_title.Text = "Change saved!";
                lbl_title.ForeColor = Color.MediumSeaGreen;
            }
            catch (Exception)
            {
                lbl_title.Text = "Error!";
                lbl_title.ForeColor = Color.Crimson;
            }
            
        }
    }
}
