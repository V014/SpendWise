using System;
using System.Windows.Forms;

namespace SpendWise
{
    class Transaction
    {
        Connection con = new Connection();
        // load transactions
        public void loadTransactions(DataGridView datagrid)
        {
            string queryTransactions = "SELECT ID, Description, Amount, Action, Date  FROM transactions";
            con.LoadData(queryTransactions, datagrid);
            datagrid.Columns[0].Visible = false;
        }
        // load the number of the month through the name
        public string getMonthNumber(string month)
        {
            string monthNumber;
            switch (month)
            {
                case "January":
                    monthNumber = "01";
                    return monthNumber;
                case "February":
                    monthNumber = "02";
                    return monthNumber;
                case "March":
                    monthNumber = "03";
                    return monthNumber;
                case "April":
                    monthNumber = "04";
                    return monthNumber;
                case "May":
                    monthNumber = "05";
                    return monthNumber;
                case "June":
                    monthNumber = "06";
                    return monthNumber;
                case "July":
                    monthNumber = "07";
                    return monthNumber;
                case "August":
                    monthNumber = "08";
                    return monthNumber;
                case "September":
                    monthNumber = "09";
                    return monthNumber;
                case "October":
                    monthNumber = "10";
                    return monthNumber;
                case "November":
                    monthNumber = "11";
                    return monthNumber;
                case "December":
                    monthNumber = "12";
                    return monthNumber;
                default:
                    monthNumber = "01";
                    return monthNumber;
            }
        }
        // load specific transactions
        public void loadDate(string date, DataGridView dataGrid)
        {
            try
            {
                con.LoadData($"SELECT Description, Amount, Action, Date FROM Transactions WHERE date LIKE '{date}%'", dataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // load specific month
        public void loadMonth(string date, DataGridView dataGrid)
        {
            try
            {
                con.LoadData($"SELECT Description, Amount, Action, Date FROM Transactions WHERE strftime('%m', date) = '{getMonthNumber(date)}'", dataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
