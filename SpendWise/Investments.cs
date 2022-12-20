using System;
using System.Media;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Investments : Form
    {
        readonly Connection con = new Connection();
        readonly StyleDataGrid styleGrid = new StyleDataGrid();
        readonly Transaction transaction = new Transaction();
        int investID;
        // constructor
        public Investments()
        {
            InitializeComponent();
        }
        // regulate wrong types in certain controls
        private void MetroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if ((asciiCode != 8))
            {
                if ((asciiCode >= 48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Numbers Only Please!", "Error: Number Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }
        // load set invesments
        private void LoadInvestments(object sender, EventArgs e)
        {
            try
            {
                con.LoadData($"SELECT * FROM investments", data_investments);
                styleGrid.style(data_investments);
                data_investments.Columns[0].Visible = false;
                data_investments.Columns[2].Visible = false;
                data_investments.Columns[3].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Investment list unavailable!","Assistant");
            }
        }
        // display values from the db on controls
        private void Data_investments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = data_investments.Rows[e.RowIndex];
            investID = int.Parse(row.Cells[0].Value.ToString());
            txt_investment.Text = row.Cells[1].Value.ToString();
            txt_amount.Text = row.Cells[2].Value.ToString();
            txt_desc.Text = row.Cells[3].Value.ToString();
            scrollbar_progress.Value = int.Parse(row.Cells[4].Value.ToString());
        }
        // update label when slider is scrubbed
        private void Scrollbar_progress_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_progress.Text = scrollbar_progress.Value.ToString() + "%";
        }
        // when user adds data to the controls and presses add
        private void Btn_add_Click(object sender, EventArgs e)
        {
            string investment = txt_investment.Text;
            string amount = txt_amount.Text;
            string description = txt_desc.Text;
            string progress = scrollbar_progress.Value.ToString();

            if (!string.IsNullOrEmpty(txt_investment.Text) && !string.IsNullOrEmpty(txt_amount.Text))
            {
                try
                {
                    con.ExecuteQuery($"INSERT INTO investments (Title, Amount, Description, Progress, Date) VALUES ('{investment}', '{amount}', '{description}', '{progress}','date('now')')");
                    MessageBox.Show("Investment set!", "Assistant");
                    LoadInvestments(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Feature unavailable!", "Assistant");
                }
            }
            else
            {
                MessageBox.Show("Fill in both the title and amount first!", "Assistant");
            }
        }
        // when user changes values on control and clicks update
        private void Btn_update_Click(object sender, EventArgs e)
        {
            string investment = txt_investment.Text;
            string amount = txt_amount.Text;
            string description = txt_desc.Text;
            string progress = scrollbar_progress.Value.ToString();

            if (!string.IsNullOrEmpty(txt_investment.Text) && !string.IsNullOrEmpty(txt_amount.Text))
            {
                try
                {
                    con.ExecuteQuery($"UPDATE investments SET Title ='{investment}', Amount = '{amount}', Description = '{description}', Progress = '{progress}' WHERE id = '{investID}'");
                    MessageBox.Show("Investment updated!", "Assistant");
                    LoadInvestments(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Feature unavailable!", "Assistant");
                }
            }
            else
            {
                MessageBox.Show("Fill in both the title and amount first!", "Assistant");
            }
        }
        // remove values when user selects row
        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // play chime
            SoundPlayer delete = new SoundPlayer(@"sfx/error.wav");
            delete.Play();
            DialogResult dialogResult = MessageBox.Show("Delete investment?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // collect the id
                    var id = data_investments.CurrentRow.Cells[0].Value;
                    // build query to delete user transaction
                    con.ExecuteQuery($"DELETE FROM investments WHERE ID = '{id}'");
                    // build query to pull transactions
                    transaction.loadTransactions(data_investments);
                    // refresh charts
                    LoadInvestments(sender, e);
                    // play chime
                    SoundPlayer trash = new SoundPlayer(@"sfx/click.wav");
                    trash.Play();
                }
                catch (Exception)
                {
                    // play chime
                    SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                    save.Play();
                    try
                    {
                        // log the error
                        string queryEvents = $"INSERT INTO events  (Date, description, location) VALUES( 'date('now')', 'SQL error', 'Investments')";
                        con.ExecuteQuery(queryEvents);
                        MessageBox.Show("Feature not available", "Assistant");
                    }
                    catch
                    {
                        // if logging fails, close the application
                        Application.Exit();
                    }
                }
            }
        }
    }
}
