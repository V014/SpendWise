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
            datagrid.Columns[0].Width = 30;
            datagrid.Columns[3].Width = 50;
            datagrid.Columns[4].Width = 120;
        }
    }
}
