using System;
using System.Drawing;
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
            PreviousTheme();
        }
        // load things that profile the user
        private void LoadInvestments()
        {
            try
            {
                con.LoadData($"SELECT Description, COUNT(description) AS Occured, SUM(Amount) AS Amount FROM transactions WHERE action = '+' GROUP BY Description ORDER BY Amount DESC", Data_income);
                styleGrid.DarkStyle(Data_income);
            }
            catch (Exception)
            {
                MessageBox.Show("Suggestion list unavailable!", "Assistant");
            }
        }
        private void PreviousTheme()
        {
            try
            {
                string UserTheme = con.ReadString("SELECT Theme FROM wallet");
                if (UserTheme == "Light")
                {
                    this.BackColor = Color.White;
                    styleGrid.LightStyle(Data_income);
                }
                else if (UserTheme == "Dark")
                {
                    this.BackColor = Color.FromArgb(17, 17, 17);
                    styleGrid.DarkStyle(Data_income);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
