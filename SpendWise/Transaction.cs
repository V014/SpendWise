using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SpendWise
{
    class Transaction
    {
        Connection con = new Connection();
        // load transactions
        public void loadTransactions(DataGridView datagrid)
        {
            string queryTransactions = "SELECT id, description, amount, action, date FROM transactions";
            con.LoadData(queryTransactions, datagrid);
            datagrid.Columns[0].Visible = false;
        }
    }
}
