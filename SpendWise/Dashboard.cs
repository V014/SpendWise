using System;
using System.Data.SQLite;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace SpendWise
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        // reference the required classes
        Money money = new Money();
        Transaction transaction = new Transaction();
        Connection con = new Connection();
        StyleDataGrid theme = new StyleDataGrid();
        string date = DateTime.Now.ToString("g");
        string time = DateTime.Now.ToShortTimeString();
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
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            // setting up hints
            toolTips();
            // set timer to auto refresh
            Timer timer = new Timer();
            timer.Interval = (15 * 1000); // 15 secs
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            // load previous window state
            previousState();
        }
        // refreshes the whole app
        private void refresh()
        {
            // display user name at the bottom of the ui
            btn_owner.Text = loadUser();
            // displays profile image
            loadPicture();
            // show money
            lbl_money.Text = money.checkMoney();
            // show savings
            lbl_savings.Text = money.checkSavings();
            // show saved
            if (loadSaved() > 0)
            {
                lbl_saved.Text = loadSaved().ToString();
            }
            // style datagrid
            theme.style(data_transactions);
            // load the data into the data grid
            transaction.loadTransactions(data_transactions);
            // loads the set currency
            lbl_currency.Text = loadCurrency();
            // load charts
            loadCharts();
            // apply details
            lbl_income.Text = loadIncome();
            lbl_expenditure.Text = loadExpenditure();
            lbl_common.Text = loadCommon();
            lbl_least.Text = loadLeast();
            txt_amount.Text = "";
            txt_desc.Text = "Description";
            lbl_investments.Text = loadInvestments();
            lbl_complete_investments.Text = loadCompleteInvestments();
            lbl_growth.Text = LoadGrowth().ToString() + "%";
        }
        // refreshes part of the app
        private void autoRefresh()
        {
            // display user name at the bottom of the ui
            btn_owner.Text = loadUser();
            // displays profile image
            loadPicture();
            // show money
            lbl_money.Text = money.checkMoney();
            // show savings
            lbl_savings.Text = money.checkSavings();
            // show saved
            if (loadSaved() > 0)
            {
                lbl_saved.Text = loadSaved().ToString();
            }
            // loads the set currency
            lbl_currency.Text = loadCurrency();
            // loads the most common transaction
            lbl_common.Text = loadCommon();
            // loads the least common transaction
            lbl_least.Text = loadLeast();
            // loads the number of investments set
            lbl_investments.Text = loadInvestments();
            // loads the number of complete investments
            lbl_complete_investments.Text = loadCompleteInvestments();
        }
        // load previous state
        private void previousState()
        {
            this.Width = int.Parse(con.ReadString("SELECT width FROM ui"));
            this.Height = int.Parse(con.ReadString("SELECT height FROM ui"));
            //return username;
        }
        // loads charts when called
        private void loadCharts()
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
            catch (Exception)
            {
                MessageBox.Show("Income unavailabe", "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Expenditure unavailabe", "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // set tool tips where required
        public void toolTips()
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
            buttonToolTip.SetToolTip(btn_owner, "Click to rename");
            buttonToolTip.SetToolTip(lbl_currency, "Click to change currency");
            buttonToolTip.SetToolTip(btn_plus, "Add to wallet");
            buttonToolTip.SetToolTip(btn_minus, "Remove from wallet");
            
        }
        // pull user name from system
        private string loadUser()
        {
            string username = con.ReadString("SELECT owner FROM wallet");
            return username;
        }
        // pull user profile picture
        private void loadPicture()
        {
            picbox_image.ImageLocation = @"res/profile/" + loadUser() + ".jpeg";
        }
        // load the currency the user has set
        private string loadCurrency()
        {
            string queryCurrency = "SELECT currency FROM wallet";
            string symbol = con.ReadString(queryCurrency);
            return symbol;
        }
        // load growth
        public double LoadGrowth()
        {
            try
            {
                if(!string.IsNullOrEmpty(loadIncome()))
                {
                    // beginning value
                    int bv = int.Parse(con.ReadString("SELECT amount FROM transactions WHERE action = '+' ORDER BY id ASC LIMIT 1"));
                    // ending value
                    int ev = int.Parse(loadIncome());

                    // beginning year, current year, solve difference
                    int by = int.Parse(con.ReadString("SELECT strftime('%Y') FROM transactions WHERE action = '+' ORDER BY id ASC LIMIT 1"));
                    int yearNow = int.Parse(con.ReadString("SELECT strftime('%Y')"));
                    int years = yearNow - by;

                    // This is an example that assumes sqlites year extraction function is called year, we group records by year and
                    // from the final counting of each unique year we understand the amount of unique years that have gone by
                    

                    // Years have been extracted from sqlite
                    if (years != 0)
                    {
                        double factor = 1 / years;
                        double total = Math.Pow(ev / bv, factor) - 1;
                        double percent = total * 100;
                        return percent;
                    }
                    else
                    {
                        return 0;
                    }
                }
                return 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Growth feature error!", "Assistant");
                return 0;
            }
        }
        
        // load investments
        private string loadInvestments()
        {
            string queryCurrency = "SELECT COUNT(id) FROM investments";
            string investments = con.ReadString(queryCurrency);
            return investments;
        }
        // load complete investments
        private string loadCompleteInvestments()
        {
            string queryCurrency = "SELECT COUNT(id) FROM investments WHERE progress = 100";
            string investments = con.ReadString(queryCurrency);
            return investments;
        }
        // load the overall income
        public string loadIncome()
        {
            string queryIncome = "SELECT sum(amount) FROM transactions WHERE action = '+'";
            string Income = con.ReadString(queryIncome);
            return Income;
        }
        // load the overall expenditure
        private string loadExpenditure()
        {
            try
            {
                string Expenditure = con.ReadString("SELECT sum(amount) FROM transactions WHERE action = '-'");
                return Expenditure;
            }
            catch (Exception)
            {
                return 0.ToString();
            }
            
        }
        // load the overall saved
        private int loadSaved()
        {
            try
            {
                int saved = int.Parse(loadIncome()) - int.Parse(loadExpenditure());
                if(saved > 1)
                {
                    return saved;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
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
            if (txt_desc.Text != "Description" && txt_amount.Text != "")
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
                    // get save percentage
                    int percent = int.Parse(con.ReadString("SELECT save FROM wallet"));
                    // calculate savings
                    int calculatedSavings = amount / 100 * percent;
                    // add it to your current savings
                    int savingsNow = savings + calculatedSavings;
                    // document new savings
                    con.ExecuteQuery($"UPDATE wallet SET savings = {savingsNow} WHERE id = 1");
                    // log the changes
                    con.ExecuteQuery($"INSERT INTO transactions (description, amount, date, action) VALUES('{txt_desc.Text}', {amount}, '{date_select.Text} {time}', '+')");
                    // refresh app
                    refresh();
                    // update the money count
                    lbl_money.Text = moneyNow.ToString();
                    // refresh the data grid
                    transaction.loadTransactions(data_transactions);
                    // refresh charts
                    loadCharts();
                    // load data from where the user stopped
                    Date_select_ValueChanged(sender, e);
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
            if (txt_desc.Text != "Description" && txt_amount.Text != "")
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
                    con.ExecuteQuery($"UPDATE wallet SET money = '{moneyNow}'");
                    // update the money count
                    lbl_money.Text = moneyNow.ToString();
                    // log the changes
                    con.ExecuteQuery($"INSERT INTO transactions(description, amount, date, action) VALUES('{txt_desc.Text}', '{amount}', '{date_select.Text} {time}', '-')");
                    // refresh app
                    refresh();
                    // refresh the data grid
                    transaction.loadTransactions(data_transactions);
                    // refresh charts
                    loadCharts();
                    // load data from where the user stopped
                    Date_select_ValueChanged(sender, e);
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

            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    // play chime
                    SoundPlayer chime2 = new SoundPlayer(@"sfx/erase.wav");
                    chime2.Play();
                    // delete transactions
                    con.ExecuteQuery("DELETE FROM transactions");
                    // update wallet
                    con.ExecuteQuery("UPDATE wallet SET money = 0.00, savings = 0, owner = 'My wallet', state = 'Mini', currency = 'MWK'");
                    // reset events
                    con.ExecuteQuery("DELETE FROM events");
                    // reset sequences
                    con.ExecuteQuery("UPDATE sqlite_sequence SET seq = 1");
                    // reset investments
                    con.ExecuteQuery("DELETE FROM investments");
                    // restart app
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        }
        // when the user clicks the currency label
        private void lbl_currency_Click(object sender, EventArgs e)
        {
            Currency currency = new Currency();
            currency.Show();
        }
        
        // transfers details from table transactions to the controls on the top left
        private void data_transactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // play chime
            SoundPlayer chime = new SoundPlayer(@"sfx/click.wav");
            chime.Play();
        }
        // clean up when form closes
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            con.ExecuteQuery($"UPDATE ui SET width = '{this.Width}', height = '{this.Height}'");
        }
        // when refresh button pressed
        public void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
            SoundPlayer edit = new SoundPlayer(@"sfx/beep.wav");
            edit.Play();
        }
        // when savings button is clicked
        private void btn_savings_Click(object sender, EventArgs e)
        {
            Savings savings = new Savings();
            savings.Show();
        }
        // when a transaction is clicked
        private void data_transactions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data_transactions.Rows[e.RowIndex];

                txt_desc.Text = row.Cells[1].Value.ToString();
                txt_amount.Text = row.Cells[2].Value.ToString();

                int Id = int.Parse(row.Cells[0].Value.ToString());
                string description = row.Cells[1].Value.ToString();
                int amount = int.Parse(row.Cells[2].Value.ToString());
                string action = row.Cells[3].Value.ToString();
                string date = row.Cells[4].Value.ToString();
                
                con.ExecuteQuery($"UPDATE transactions SET description = '{description}', amount = '{amount}', date = '{date}', action = '{action}' WHERE Id = {Id}");

                transaction.loadTransactions(data_transactions);
                MessageBox.Show("Saved!");
            }
            catch (Exception ex) // reset textboxes
            {
                // refresh fields
                txt_amount.Text = "0.00";
                txt_desc.Text = "";
                MessageBox.Show(ex.ToString(),"Not saved!");
            }
        }
        // when the remove menu item is clicked
        private void item_remove_Click(object sender, EventArgs e)
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
                    con.ExecuteQuery($"DELETE FROM transactions WHERE id = '{id}'");
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
                        string queryEvents = $"INSERT INTO events  (Date, description, location) VALUES( '{date}', 'SQL error', 'Transaction log')";
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
        // loads details from a particular date or month or year
        private void Date_select_ValueChanged(object sender, EventArgs e)
        {
            transaction.loadDate(date_select.Text, data_transactions);
            string date = date_select.Text;
            SQLiteConnection connection = con.GetConnection();
            // get income
            SQLiteCommand queryMoney = new SQLiteCommand($"SELECT amount FROM transactions WHERE action = '+' AND date LIKE '{date}%'", connection);
            SQLiteDataReader income_data = queryMoney.ExecuteReader();
            // get expenditure
            SQLiteCommand queryExpenditure = new SQLiteCommand($"SELECT amount FROM transactions WHERE action = '-' AND date LIKE '{date}%'", connection);
            SQLiteDataReader expenditure_data = queryExpenditure.ExecuteReader();
            // do some math to show the dots
            string income = con.ReadString($"SELECT SUM(amount) FROM transactions WHERE action = '+' AND date LIKE '{date}%'");
            string expenditure = con.ReadString($"SELECT SUM(amount) FROM transactions WHERE action = '-' AND date LIKE '{date}%'");
            // check for empty string
            if (!string.IsNullOrEmpty(income) && !string.IsNullOrEmpty(expenditure))
            {
                // make a comparision to see which is highest
                if (int.Parse(income) > int.Parse(expenditure))
                {
                    dot_income.Visible = true;
                }
                else
                {
                    dot_investments.Visible = true;
                }
                try
                {
                    chart_income.Series[0].Points.Clear();
                    while (income_data.Read())
                    {
                        chart_income.Series[0].Points.Add(income_data.GetInt32(0));
                    }

                    lbl_income.Text = con.ReadString($"SELECT SUM(amount) FROM transactions WHERE action = '+' AND date LIKE '{date}%'");
                }
                catch (Exception)
                {
                    MessageBox.Show("Income unavailabe", "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    chart_expenditure.Series[0].Points.Clear();
                    while (expenditure_data.Read())
                    {
                        chart_expenditure.Series[0].Points.Add(expenditure_data.GetInt32(0));
                    }

                    lbl_expenditure.Text = con.ReadString($"SELECT SUM(amount) FROM transactions WHERE action = '-' AND date LIKE '{date}%'");
                }
                catch (Exception)
                {
                    MessageBox.Show("Expenditure unavailabe", "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // stops timer to prevent refresh
                timer.Stop();
            }
            
        }
        // loads details from a oarticular month
        private void Cmb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            transaction.loadMonth(cmb_month.Text, data_transactions);
            string month = transaction.getMonthNumber(cmb_month.Text);

            SQLiteConnection connection = con.GetConnection();
            // get income
            SQLiteCommand queryMoney = new SQLiteCommand($"SELECT amount FROM transactions WHERE action = '+' AND date LIKE '{month}%'", connection);
            SQLiteDataReader income_data = queryMoney.ExecuteReader();
            // get expenditure
            SQLiteCommand queryExpenditure = new SQLiteCommand($"SELECT amount FROM transactions WHERE action = '-' AND date LIKE '{month}%'", connection);
            SQLiteDataReader expenditure_data = queryExpenditure.ExecuteReader();
            // check values
            string income = con.ReadString($"SELECT SUM(amount) FROM transactions WHERE action = '+' AND date LIKE '{month}%'");
            string expenditure = con.ReadString($"SELECT SUM(amount) FROM transactions WHERE action = '-' AND date LIKE '{month}%'");
            // dot notification
            try
            {
                // make a comparision to see which is highest
                if (int.Parse(income) > int.Parse(expenditure))
                {
                    dot_income.Visible = true;
                    dot_expenditure.Visible = false;
                }
                else
                {
                    dot_expenditure.Visible = true;
                    dot_income.Visible = false;
                }
                
            }
            catch (Exception)
            {
                // MessageBox.Show("No recent transactions from this month", "Assistant");
                /*
                if (string.IsNullOrEmpty(income))
                {
                    splitContainer_charts.Panel1.Controls.Clear();
                    splitContainer_charts.Panel1.Controls.Add(cover);
                    cover.Dock = DockStyle.Fill;
                    cover.Show();

                }
                else if (string.IsNullOrEmpty(expenditure))
                {
                    splitContainer_charts.Panel2.Controls.Clear();
                    splitContainer_charts.Panel2.Controls.Add(cover);
                    cover.Dock = DockStyle.Fill;
                    cover.Show();
                }
                else if (string.IsNullOrEmpty(income) & string.IsNullOrEmpty(expenditure))
                {
                    splitContainer_charts.Panel1.Controls.Clear();
                    splitContainer_charts.Panel1.Controls.Add(cover);
                    cover.Dock = DockStyle.Fill;
                    cover.Show();

                    splitContainer_charts.Panel2.Controls.Clear();
                    splitContainer_charts.Panel2.Controls.Add(cover);
                    cover.Dock = DockStyle.Fill;
                    cover.Show();
                }
                */
                
            }
                // Fill income chart
                try
                {
                chart_income.Series[0].Points.Clear();
                while (income_data.Read())
                {
                    chart_income.Series[0].Points.Add(income_data.GetInt32(0));
                }

                lbl_income.Text = con.ReadString($"SELECT SUM(amount) FROM transactions WHERE action = '+' AND date LIKE '{month}%'");
            }
            catch (Exception)
            {
                MessageBox.Show("Income unavailabe", "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // fill expenditure chart
            try
            {
                chart_expenditure.Series[0].Points.Clear();
                while (expenditure_data.Read())
                {
                    chart_expenditure.Series[0].Points.Add(expenditure_data.GetInt32(0));
                }

                lbl_expenditure.Text = con.ReadString($"SELECT SUM(amount) FROM transactions WHERE action = '-' AND date LIKE '{month}%'");
            }
            catch (Exception)
            {
                MessageBox.Show("Expenditure unavailabe", "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Imports data into apps
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy and replace database file into the spendwise application folder");
        }
        // eports data from app
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.Show();
        }
        // displays about message
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer chime = new SoundPlayer(@"sfx/click.wav");
            chime.Play();
            About us = new About();
            us.Show();
        }
        // when the user presses the owner button
        private void Btn_owner_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }
        // when the picture box is clicked
        private void Picbox_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = ofd.FileName;
                string name = loadUser();
                string destinationPath = @"res/profile/" + name + ".jpeg";
                if (!File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, destinationPath);
                    picbox_image.ImageLocation = sourcePath;
                }
                else
                {
                    File.Delete(destinationPath);
                    File.Copy(sourcePath, destinationPath);
                    picbox_image.ImageLocation = sourcePath;
                }
            }
        }
        // displays the investment window
        private void Btn_investments_Click(object sender, EventArgs e)
        {
            Investments investment = new Investments();
            investment.Show();
            dot_investments.Hide();
        }
        // what should happen when the timer resets
        private void Timer_Tick(object sender, EventArgs e)
        {
            autoRefresh();
        }
        // displays growth form
        private void Btn_growth_Click(object sender, EventArgs e)
        {
            Growth growth = new Growth();
            growth.Show();
        }
        // toggles charts depending on size
        private void Dashboard_Resize(object sender, EventArgs e)
        {
            if(this.Width <= 880)
            {
                splitContainer_dataCharts.Panel2Collapsed = true;
            }
            else
            {
                splitContainer_dataCharts.Panel2Collapsed = false;
            }
        }
    }
}