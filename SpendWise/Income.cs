using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Income : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        public Income()
        {
            InitializeComponent();
            loadIncome();
        }
        public void loadIncome()
        {
            SQLiteConnection connection = con.GetConnection();
            // get income
            SQLiteCommand queryMoney = new SQLiteCommand("SELECT amount FROM transactions WHERE action = '+'", connection);
            SQLiteDataReader income = queryMoney.ExecuteReader();
            // get expenditure
            SQLiteCommand queryExpenditure = new SQLiteCommand("SELECT amount FROM transactions WHERE action = '-'", connection);
            SQLiteDataReader expenditure = queryExpenditure.ExecuteReader();
            try
            {
                chart_income.Series[0].Points.Clear();
                while (income.Read())
                {
                    chart_income.Series[0].Points.Add(income.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
