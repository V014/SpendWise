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
    public partial class Investments : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        string date = DateTime.Now.ToString("g");
        Dashboard dash = new Dashboard();
        StyleDataGrid styleGrid = new StyleDataGrid();
        int investID;
        public Investments()
        {
            InitializeComponent();
        }

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

        private void Investments_Load(object sender, EventArgs e)
        {
            try
            {
                con.LoadData($"SELECT ID, Title, Amount, Description, Progress, DateSet FROM investments", data_investments);
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

        private void Data_investments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = data_investments.Rows[e.RowIndex];
            investID = int.Parse(row.Cells[0].Value.ToString());
            txt_investment.Text = row.Cells[1].Value.ToString();
            txt_amount.Text = row.Cells[2].Value.ToString();
            txt_desc.Text = row.Cells[3].Value.ToString();
            scrollbar_progress.Value = int.Parse(row.Cells[4].Value.ToString());
        }

        private void Scrollbar_progress_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_progress.Text = scrollbar_progress.Value.ToString() + "%";
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_investment.Text) && !string.IsNullOrEmpty(txt_amount.Text))
            {
                try
                {
                    con.ExecuteQuery($"INSERT INTO investments (title, amount, description, progress, dateSet) VALUES ('{txt_investment.Text}', '{txt_amount.Text}', '{txt_desc.Text}', '{scrollbar_progress.Value.ToString()}','{date}')");
                    MessageBox.Show("Investment set!", "Assistant");
                    Investments_Load(sender, e);
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

        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_investment.Text) && !string.IsNullOrEmpty(txt_amount.Text))
            {
                try
                {
                    con.ExecuteQuery($"UPDATE investments SET title ='{txt_investment.Text}', amount = '{txt_amount.Text}', description = '{txt_desc.Text}', progress = '{scrollbar_progress.Value.ToString()}' WHERE id = '{investID}'");
                    MessageBox.Show("Investment updated!", "Assistant");
                    Investments_Load(sender, e);
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
    }
}
