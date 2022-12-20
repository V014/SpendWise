using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Savings : Form
    {
        readonly Connection con = new Connection();
        public Savings()
        {
            InitializeComponent();
            string percent = con.ReadString("SELECT save FROM wallet");
            lbl_percent.Text = percent + "%";
            scrollbar_savings_percentage.Value = int.Parse(percent);
        }

        private void TrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_percent.Text = scrollbar_savings_percentage.Value.ToString() + "%";
        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            int percentage = scrollbar_savings_percentage.Value;
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

        private void Scrollbar_savings_percentage_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_percent.Text = scrollbar_savings_percentage.Value.ToString() + "%";
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            // play chime
            SoundPlayer chime = new SoundPlayer(@"sfx/glass.wav");
            chime.Play();
            DialogResult dialogResult = MessageBox.Show("Resetting the savings will clear all your savings history, are you sure?", "Reset Savings?", MessageBoxButtons.YesNo);

            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    // play chime
                    SoundPlayer chime2 = new SoundPlayer(@"sfx/erase.wav");
                    chime2.Play();
                    // update wallet
                    con.ExecuteQuery("UPDATE wallet SET savings = 0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
