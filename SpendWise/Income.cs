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
    public partial class Income : Form
    {
        readonly Connection con = new Connection();
        readonly StyleDataGrid styleGrid = new StyleDataGrid();

        public Income()
        {
            InitializeComponent();
            LoadInvestments();
        }
        // load things that profi the user
        private void LoadInvestments()
        {
            try
            {
                con.LoadData($"SELECT Description, COUNT(description) AS Occured, SUM(Amount) AS Amount FROM transactions WHERE action = '+' GROUP BY Description ORDER BY Amount DESC", Data_income);
                styleGrid.style(Data_income);
            }
            catch (Exception)
            {
                MessageBox.Show("Suggestion list unavailable!", "Assistant");
            }
        }
    }
}
