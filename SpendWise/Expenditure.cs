using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Expenditure : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        public Expenditure()
        {
            InitializeComponent();
            loadExpenditure();
        }
        public void loadExpenditure()
        {
            SQLiteConnection connection = con.GetConnection();
            // get expenditure
            SQLiteCommand queryExpenditure = new SQLiteCommand("SELECT amount FROM transactions WHERE action = '-'", connection);
            SQLiteDataReader expenditure = queryExpenditure.ExecuteReader();
            try
            {
                chart_expenditure.Series[0].Points.Clear();
                while (expenditure.Read())
                {
                    chart_expenditure.Series[0].Points.Add(expenditure.GetInt32(0));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load expenditure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
