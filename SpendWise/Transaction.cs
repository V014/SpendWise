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
            string queryTransactions = "SELECT id, description, amount, action, date  FROM transactions";
            con.LoadData(queryTransactions, datagrid);
            //datagrid.Columns[0].Width = 30;
            //datagrid.Columns[3].Width = 50;
            //datagrid.Columns[4].Width = 120;
        }
        public int getMonthNumber(string month)
        {
            int monthNumber;
            switch (month)
            {
                case "January":
                    monthNumber = 1;
                    return monthNumber;
                case "February":
                    monthNumber = 2;
                    return monthNumber;
                case "March":
                    monthNumber = 3;
                    return monthNumber;
                case "April":
                    monthNumber = 4;
                    return monthNumber;
                case "May":
                    monthNumber = 5;
                    return monthNumber;
                case "June":
                    monthNumber = 6;
                    return monthNumber;
                case "July":
                    monthNumber = 7;
                    return monthNumber;
                case "August":
                    monthNumber = 8;
                    return monthNumber;
                case "September":
                    monthNumber = 9;
                    return monthNumber;
                case "October":
                    monthNumber = 10;
                    return monthNumber;
                case "Novemer":
                    monthNumber = 11;
                    return monthNumber;
                case "December":
                    monthNumber = 12;
                    return monthNumber;
                default:
                    monthNumber = 1;
                    return monthNumber;
            }
        }
        // load specific transactions
        public void loadDate(string date, DataGridView dataGrid)
        {
            try
            {
                con.LoadData($"SELECT id, description, amount, action, date FROM Transactions WHERE Date LIKE '%{ date }%'", dataGrid);
                dataGrid.Columns[0].Width = 30;
                dataGrid.Columns[3].Width = 50;
                dataGrid.Columns[4].Width = 120;
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
                con.LoadData($"SELECT id, description, amount, action, date FROM Transactions WHERE Date LIKE '{ getMonthNumber(date) }%'", dataGrid);
                dataGrid.Columns[0].Width = 30;
                dataGrid.Columns[3].Width = 50;
                dataGrid.Columns[4].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
