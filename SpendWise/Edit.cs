using System;
using System.Media;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Edit : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        Money money = new Money();
        Transaction transaction = new Transaction();
        Dashboard dashboard = new Dashboard();
        public Edit()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_amount.Text) && !string.IsNullOrEmpty(txt_desc.Text) && radio_plus.Checked == true || radio_minus.Checked == true)
            {
                int amount = int.Parse(txt_amount.Text);
                string desc = txt_desc.Text;
                // collect id of selected item
                string itemId = con.ReadString("SELECT itemId FROM item");
                // collect the current count of money
                int moneyThen = int.Parse(money.checkMoney());
                // if the user is adding
                if (radio_plus.Checked == true)
                {
                    // add the previous and adding values
                    int moneyNow = moneyThen + amount;
                    con.ExecuteQuery($"UPDATE wallet SET money = {moneyNow}");
                    // update the transaction
                    con.ExecuteQuery($"UPDATE transactions SET amount = {amount}, description = '{desc}', action = '+' WHERE id = {itemId}");
                    // update the money count
                    dashboard.lbl_money.Text = moneyNow.ToString();
                }
                else
                {
                    // add the previous and adding values
                    int moneyNow = moneyThen - amount;
                    con.ExecuteQuery($"UPDATE wallet SET money = {moneyNow}");
                    // update the transaction
                    con.ExecuteQuery($"UPDATE transactions SET amount = {amount}, description = '{desc}', action = '-' WHERE id = {itemId}");
                    // update the money count
                    dashboard.lbl_money.Text = moneyNow.ToString();
                }
                // play chime
                SoundPlayer edit = new SoundPlayer(@"click.wav");
                edit.Play();
                this.Name = "Now Refresh 💱";
            }
            else
            {
                // play chime
                SoundPlayer save = new SoundPlayer(@"error.wav");
                save.Play();
                // show suggestion box
                MessageBox.Show("Add both a description and amount!", "Suggestion");
            } 
        }
    }
}
