using System;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Expenditure : Form
    {
        readonly Connection con = new Connection();
        readonly StyleDataGrid styleGrid = new StyleDataGrid();

        public Expenditure()
        {
            InitializeComponent();
            LoadInvestments();
        }
        // load things that cost the user
        private void LoadInvestments()
        {
            try
            {
                con.LoadData($"SELECT Description, COUNT(description) AS Occured, SUM(Amount) AS Amount FROM transactions WHERE action = '-' GROUP BY Description ORDER BY Amount DESC", Data_expenditure);
                styleGrid.style(Data_expenditure);
            }
            catch (Exception)
            {
                MessageBox.Show("Suggestion list unavailable!", "Assistant");
            }
        }
    }
}
