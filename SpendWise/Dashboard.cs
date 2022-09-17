using System;
using System.Drawing;
using System.Data.SQLite;
using System.Media;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace SpendWise
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        // reference the required classes
        Money money = new Money();
        Transaction transaction = new Transaction();
        Connection con = new Connection();
        StyleDataGrid theme = new StyleDataGrid();
        Income income = new Income();
        Expenditure expenditure = new Expenditure();
        string date = DateTime.Now.ToString("g");
        // constructor
        public Dashboard()
        {
            InitializeComponent();
            // play chime
            //SoundPlayer chime = new SoundPlayer(@"sfx/open.wav");
            //chime.Play();
            refresh();
            // setup UI optimization
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            // setting up hints
            toolTips();
            // setup UI size
            string state = UiState();
            if(state == "Mini")
            {
                setMiniUi();
                btn_UI.Image = Image.FromFile(@"res/expand.png");
            }
            else
            {
                setLargeUi();
                btn_UI.Image = Image.FromFile(@"res/compress.png");
            }
        }
        // refreshes the whole app
        public void refresh()
        {
            // display user
            lbl_owner.Text = loadUser();
            // show money
            lbl_money.Text = money.checkMoney();
            lbl_savings.Text = money.checkSavings();
            lbl_saved.Text = loadSaved().ToString();
            // style datagrid
            theme.style(data_transactions);
            // load the data into the data grid
            transaction.loadTransactions(data_transactions);
            // loads the set currency
            lbl_currency.Text = loadCurrency();
            // load charts
            loadCharts();
            lbl_income.Text = loadIncome();
            lbl_expenditure.Text = loadExpenditure();
            lbl_common.Text = loadCommon();
            lbl_least.Text = loadLeast();
            txt_amount.Text = "";
            txt_desc.Text = "";
        }
        // loads charts when called
        public void loadCharts()
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
            // display overall income
            /*
            try
            {
                chart_overall.Series[0].Points.Clear();
                chart_overall.Series[1].Points.Clear();
                chart_overall.Series[0].Points.Add(Convert.ToInt32(loadIncome()));
                chart_overall.Series[1].Points.Add(Convert.ToInt32(loadExpenditure()));
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load overall income", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        // set tool tips where required
        void toolTips()
        {
            ToolTip buttonToolTip = new ToolTip();
            buttonToolTip.ToolTipTitle = "Hint";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = false;
            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btn_refresh, "Click to refresh");
            buttonToolTip.SetToolTip(btn_UI, "Toggle UI");
            buttonToolTip.SetToolTip(lbl_owner, "Click to rename");
            buttonToolTip.SetToolTip(lbl_currency, "Click to change currency");
            buttonToolTip.SetToolTip(btn_update, "Green: Updated | Blue: Updating | White: Outdated");
            buttonToolTip.SetToolTip(btn_plus, "Add to wallet");
            buttonToolTip.SetToolTip(btn_minus, "Remove from wallet");
            buttonToolTip.SetToolTip(btn_trash, "Remove from list");
            buttonToolTip.SetToolTip(btn_edit, "Edit selected item");
            buttonToolTip.SetToolTip(chart_income, "Click to expand");
            buttonToolTip.SetToolTip(chart_expenditure, "Click to expand");
        }
        // set the interface to minimal
        void setMiniUi()
        {
            // reduce the size of the window
            this.Width = 912;
            this.Height = 500;
            // refuce the size of the controls
            panel_transactions.Height = 200;
            panel_income.Height = 200;
            panel_income.Width = 211;
            panel_expenditure.Height = 200;
            panel_expenditure.Width = 211;
        }
        // check the current ui state
        string UiState()
        {
            string setState = con.ReadString("SELECT state FROM wallet");
            return setState;
        }
        // set the interface to large
        void setLargeUi()
        {
            // reduce the size of the window
            this.Width = 1347;
            this.Height = 697;
            // reduce the size of the controls
            panel_transactions.Height = 400;
            panel_income.Height = 400;
            panel_income.Width = 420;
            panel_expenditure.Height = 400;
            panel_expenditure.Width = 420;
        }
        // pull user name from system
        private string loadUser()
        {
            string queryUser = "SELECT owner FROM wallet";
            string username = con.ReadString(queryUser);
            return username;
        }
        // load the currency the user has set
        private string loadCurrency()
        {
            string queryCurrency = "SELECT currency FROM wallet";
            string symbol = con.ReadString(queryCurrency);
            return symbol;
        }
        // load the overall income
        private string loadIncome()
        {
            string queryIncome = "SELECT sum(amount) FROM transactions WHERE action = '+'";
            string Income = con.ReadString(queryIncome);
            return Income;
        }
        // load the overall expenditure
        private string loadExpenditure()
        {
            string Expenditure = con.ReadString("SELECT sum(amount) FROM transactions WHERE action = '-'");
            return Expenditure;
        }
        // load the overall saved
        private int loadSaved()
        {
            int saved = int.Parse(loadIncome()) - int.Parse(loadExpenditure());
            return saved;
        }
        // load the common purchased item
        private string loadCommon()
        {
            string queryCommon = "SELECT description, count(description) AS cnt FROM transactions GROUP BY description ORDER BY cnt DESC LIMIT 1";
            string Common = con.ReadString(queryCommon);
            return Common;
        }
        // load the common purchased item
        private string loadLeast()
        {
            string queryLeast = "SELECT description, count(description) AS cnt FROM transactions GROUP BY description ORDER BY cnt ASC LIMIT 1";
            string Least = con.ReadString(queryLeast);
            return Least;
        }
        // when the plus button is clicked...
        private void btn_plus_Click(object sender, System.EventArgs e)
        {
            // check if a description and amount both exist
            if (txt_desc.Text != "" && Convert.ToInt32(txt_amount.Text) != 0)
            {
                // pull the last amount in the wallet then credit it
                try
                {
                    // instanciate values from controls
                    int amount = Convert.ToInt32(txt_amount.Text);
                    int wallet = Convert.ToInt32(money.checkMoney());
                    int savings = Convert.ToInt32(money.checkSavings());
                    // add the previous and adding values
                    int moneyNow = wallet + amount;
                    // build the querys
                    con.ExecuteQuery($"UPDATE wallet SET money = {moneyNow} WHERE id = 1");
                    // calculate savings
                    int calculatedSavings = amount / 100 * 10;
                    // add it to your current savings
                    int savingsNow = savings + calculatedSavings;
                    // document new savings
                    con.ExecuteQuery($"UPDATE wallet SET savings = {savingsNow} WHERE id = 1");
                    // log the changes
                    con.ExecuteQuery($"INSERT INTO transactions (description, amount, date, action) VALUES('{txt_desc.Text}', {amount}, '{date}', '+')");
                    // refresh app
                    refresh();
                    // update the money count
                    lbl_money.Text = moneyNow.ToString();
                    // refresh the data grid
                    transaction.loadTransactions(data_transactions);
                    // refresh charts
                    loadCharts();
                    // play chime
                    SoundPlayer win = new SoundPlayer(@"sfx/win.wav");
                    win.Play();
                }
                //(Exception ex)
                catch
                {
                    // play chime
                    SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                    save.Play();
                    // show suggestion box
                    MessageBox.Show("The application has failed to either update your wallet or record the transaction.", "Application error");
                    // log the error
                    string queryEvents = "INSERT INTO events (date, description, location) VALUES('" + date + "', 'SQL error', 'Plus action')";
                    con.ExecuteQuery(queryEvents);
                    MessageBox.Show("Error recorded!");      
                }
            } else
            {
                // play chime
                SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                save.Play();
                // show suggestion box
                MessageBox.Show("Add both a description and amount!", "Suggestion");
            }
        }
        // when the minus button is clicked...
        private void btn_minus_Click(object sender, EventArgs e)
        {
            // check if a description and amount both exist
            if (txt_desc.Text != "" && Convert.ToInt32(txt_amount.Text) != 0)
            {
                // pull the last amount in the wallet then credit it
                try
                {
                    // instanciate values from controls
                    int amount = Convert.ToInt32(txt_amount.Text);
                    int wallet = Convert.ToInt32(money.checkMoney());
                    // subtract the previous and adding values
                    int moneyNow = wallet - amount;
                    // build the query
                    string queryMinus = "UPDATE wallet SET money = '" + moneyNow + "' WHERE id = 1";
                    con.ExecuteQuery(queryMinus);
                    // update the money count
                    lbl_money.Text = moneyNow.ToString();
                    // log the changes
                    string queryTransaction = "INSERT INTO transactions(description, amount, date, action) VALUES('" + txt_desc.Text + "', " + amount + ", '" + date + "', '-')";
                    con.ExecuteQuery(queryTransaction);
                    // refresh app
                    refresh();
                    // refresh the data grid
                    transaction.loadTransactions(data_transactions);
                    // refresh charts
                    loadCharts();
                    // play chime
                    SoundPlayer coins = new SoundPlayer(@"sfx/coins.wav");
                    coins.Play();
                }
                catch//(Exception ex)
                {
                    // play chime
                    SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                    save.Play();
                    // show suggestion box
                    //MessageBox.Show(ex.ToString());
                    MessageBox.Show("The application has failed to either update your wallet or record the transaction.", "Application error");
                    // log the error
                    string queryEvents = "INSERT INTO events (date, description, location) VALUES('" + date + "', 'SQL error', 'Minus action')";
                    con.ExecuteQuery(queryEvents);
                    MessageBox.Show("Error recorded");
                }
            }
            else
            {
                // play chime
                SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                save.Play();
                // show suggestion box
                MessageBox.Show("Add both a description and amount!", "Suggestion");
            }
        }
        // when the trash button is pressed
        private void btn_trash_Click(object sender, EventArgs e)
        {
            // play chime
            SoundPlayer delete = new SoundPlayer(@"sfx/error.wav");
            delete.Play();
            DialogResult dialogResult = MessageBox.Show("Delete transaction?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var id = data_transactions.CurrentRow.Cells[0].Value;
                    // build query to delete user transaction
                    string queryDelete = "DELETE FROM transactions WHERE id = '" + id + "'";
                    con.ExecuteQuery(queryDelete);
                    // build query to pull transactions
                    transaction.loadTransactions(data_transactions);
                    // refresh charts
                    loadCharts();
                    // play chime
                    SoundPlayer trash = new SoundPlayer(@"sfx/click.wav");
                    trash.Play();
                }
                catch (Exception ex)
                {
                    // play chime
                    SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                    save.Play();
                    // show suggestion box
                    MessageBox.Show(ex.ToString());
                    //MessageBox.Show("The application has failed to either update your transactions.", "Application error");
                    try
                    {
                        // log the error
                        string queryEvents = "INSERT INTO events  (Date, description, location) VALUES( '" + date + "', 'SQL error', 'Transaction log')";
                        con.ExecuteQuery(queryEvents);
                        MessageBox.Show("Error recorded");
                    }
                    catch
                    {
                        // if logging fails, close the application
                        Application.Exit();
                    }
                }
            }
        }
        // when the amount textbox is clicked
        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
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
        // when the about button is clicked
        private void btn_about_Click(object sender, EventArgs e)
        {
            SoundPlayer chime = new SoundPlayer(@"sfx/click.wav");
            chime.Play();
            About us = new About();
            us.Show();
        }
        // flush the database after confirmation
        private void btn_reset_Click(object sender, EventArgs e)
        {
            // play chime
            SoundPlayer chime = new SoundPlayer(@"sfx/glass.wav");
            chime.Play();
            DialogResult dialogResult = MessageBox.Show("Resetting the wallet database will clear all your transaction history and settings, are you sure?", "Reset Wallet", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // play chime
                SoundPlayer chime2 = new SoundPlayer(@"sfx/erase.wav");
                chime2.Play();
                string queryResetTrans = "DELETE FROM transactions";
                con.ExecuteQuery(queryResetTrans);
                string queryResetWallet = "UPDATE wallet SET money = 0.00 WHERE id = 1";
                con.ExecuteQuery(queryResetWallet);
                // refresh app
                refresh();
            }
        }
        // what happens when name is clicked
        private void lbl_owner_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }
        // when user wants to export document
        private void btn_export_Click(object sender, EventArgs e)
        {
            // display UI that enable user to save file location
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // collect all the known transactions
                        string queryExport = "SELECT id, description, amount, action, date FROM transactions";
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            // export them to an excel file Note. DataTable required
                            workbook.Worksheets.Add(con.ExportData(queryExport));
                            workbook.SaveAs(sfd.FileName);
                        }
                        // play chime
                        SoundPlayer ice = new SoundPlayer(@"sfx/ice.wav");
                        ice.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // when the user clicks the currency label
        private void lbl_currency_Click(object sender, EventArgs e)
        {
            Currency currency = new Currency();
            currency.Show();
        }
        // when a user needs to import their own database
        private void btn_import_Click(object sender, EventArgs e)
        {
            Coming pro = new Coming();
            pro.Show();
            /*
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // retrieve the excel file
                string file = ofd.FileName;
                // target the database file
                string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", file);
                OleDbConnection Econ = new OleDbConnection(constr);
                string Query = string.Format("Select [description],[amount],[action],[date] FROM [{0}]", "Sheet1$");
                OleDbCommand Ecom = new OleDbCommand(Query, Econ);
                Econ.Open();

                loadTransactions();
                
                DataSet ds = new DataSet();
                OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
                Econ.Close();
                oda.Fill(ds);
                DataTable Exceldt = ds.Tables[0];
               
            }  
            */
        }
        // transfers details from table transactions to the controls on the top left
        private void data_transactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // play chime
            SoundPlayer chime = new SoundPlayer(@"sfx/beep.wav");
            chime.Play();
            try
            {
                DataGridViewRow row = data_transactions.Rows[e.RowIndex];
                txt_desc.Text = row.Cells[1].Value.ToString();
                txt_amount.Text = row.Cells[2].Value.ToString();
                int itemId = int.Parse(row.Cells[0].Value.ToString());
                con.ExecuteQuery($"UPDATE item SET itemId = {itemId}");
            }
            catch (Exception) // reset textboxes
            {
                // refresh fields
                txt_amount.Text = "0.00";
                txt_desc.Text = "";
            }
        }
        // when the user clicks the edit button
        private void btn_edit_Click(object sender, EventArgs e)
        {
            // play chime
            SoundPlayer chime = new SoundPlayer(@"sfx/click.wav");
            chime.Play();
            Edit edit = new Edit();
            edit.Show();
        }
        // clean up when form closes
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.ExecuteQuery($"UPDATE item SET itemId = 0");
            Application.Exit();
        }
        // when refresh button pressed
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
            SoundPlayer edit = new SoundPlayer(@"sfx/beep.wav");
            edit.Play();
        }
        // when UI toggle button clicked
        private void btn_UI_Click(object sender, EventArgs e)
        {
            // if the windows starts out large
            if (this.Height == 697)
            {
                SoundPlayer chime = new SoundPlayer(@"sfx/close.wav");
                chime.Play();
                con.ExecuteQuery("UPDATE wallet SET state = 'Mini'");
                setMiniUi();
                btn_UI.Image = Image.FromFile(@"res/expand.png");
            }
            else
            {
                SoundPlayer chime = new SoundPlayer(@"sfx/close.wav");
                chime.Play();
                con.ExecuteQuery("UPDATE wallet SET state = 'Large'");
                setLargeUi();
                btn_UI.Image = Image.FromFile(@"res/compress.png");
            }
        }
        // when user clicks update button
        private void btn_update_Click(object sender, EventArgs e)
        {
            Coming pro = new Coming();
            pro.Show();
        }
        // Maximise income chart when clicked
        private void chart_income_Click(object sender, EventArgs e)
        { 
            income.Show();
        }
        // Maximise expenditure chart when clicked
        private void chart_expenditure_Click(object sender, EventArgs e)
        {
            expenditure.Show();
        }
    }
}