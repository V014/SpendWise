﻿using System;
using System.Data.SQLite;
using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace SpendWise
{
    public partial class Dashboard : Form
    {
        // reference the required classes
        readonly Money money = new Money();
        readonly Transaction transaction = new Transaction();
        readonly Connection con = new Connection();
        readonly SQLiteConnection sqlcon = new SQLiteConnection();
        readonly StyleDataGrid theme = new StyleDataGrid();
        // constructor
        public Dashboard()
        {
            InitializeComponent();
            // play chime
            //SoundPlayer chime = new SoundPlayer(@"sfx/melancholy.wav");
            //chime.Play();
            RefreshUI();
            // setup UI optimization
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            // setting up hints
            ToolTips();
            // set timer to auto refresh
            Timer timer = new Timer
            {
                Interval = (15 * 1000) // 15 secs
            };
            // start the ticker
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            // load previous window state
            PreviousState();
            // load previous theme
            PreviousTheme();
            // check for notifications
            LoadInvestmentDot();
            // check your income to expenditure ratio and present dot
            LoadMoneyDot();
            // show details on transaction counter
            try
            {
                // get the month from the database.
                string currentMonth = con.ReadString("SELECT strftime('%m', 'now', 'localtime')");
                // show the income
                lbl_income_count.Text = LoadIncomeCount(currentMonth);
                // show the exoenditure
                lbl_expenditure_count.Text = LoadExpenditureCount(currentMonth);
                // show all transactions
                lbl_transactions_count.Text = LoadTransactionsCount(currentMonth);

                lbl_annual_count.Text = LoadAnnualCount();
            }
            catch (Exception)
            {
                lbl_income_count.Text = "0";
                lbl_expenditure_count.Text = "0";
                lbl_transactions_count.Text = "0";
                lbl_annual_count.Text = "0";
            }
        }
        // refreshes the whole app
        private void RefreshUI()
        {
            // display user name at the bottom of the ui
            userToolStripMenuItem.Text = LoadUser();
            // displays profile image
            LoadPicture();
            // show money
            lbl_money.Text = money.CheckMoney();
            // style datagrid
            // theme.style(data_transactions);
            // load the data into the data grid
            transaction.LoadTransactions(data_transactions);
            // loads the set currency
            lbl_currency.Text = LoadCurrency();
            // load charts
            LoadCharts();

            txt_amount.Text = "";
            txt_investment.Text = "Income";
            txt_expenditure.Text = "Expenditure";
            // update investment dot
            LoadInvestmentDot();
        }
        // refreshes part of the app
        private void AutoRefresh()
        {
            // display user name at the bottom of the ui
            userToolStripMenuItem.Text = LoadUser();
            // displays profile image
            LoadPicture();
            // show money
            lbl_money.Text = money.CheckMoney();
            // loads the set currency
            lbl_currency.Text = LoadCurrency();
            // update investment dot
            LoadInvestmentDot();
        }
        // check to see if there any pending investments 
        private void LoadInvestmentDot()
        {
            if (LoadInvestments() == LoadCompleteInvestments())
            {
                dot_investments.Visible = false;
            }
            else
            {
                dot_investments.Visible = true;
            }
        }
        // check to see if there any pending investments 
        private void LoadMoneyDot()
        {
            try
            {
                if (int.Parse(LoadIncome()) > int.Parse(LoadExpenditure()))
                {
                    dot_income.Visible = true;
                    dot_expenditure.Visible = false;
                }
                else
                {
                    dot_income.Visible = false;
                    dot_expenditure.Visible = true;
                }
            }
            catch (Exception)
            {
                dot_income.Visible = false;
                dot_expenditure.Visible = false;
            }
            
        }
        // load previous state
        private void PreviousState()
        {
            this.Width = int.Parse(con.ReadString("SELECT width FROM ui"));
            this.Height = int.Parse(con.ReadString("SELECT height FROM ui"));
        }
        // load pervious theme
        private void PreviousTheme()
        {
            try
            {
                string UserTheme = con.ReadString("SELECT Theme FROM wallet");
                if (UserTheme == "Light")
                {
                    LightMode();
                }
                else if (UserTheme == "Dark")
                {
                    DarkMode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // loads charts when called
        private void LoadCharts()
        {
            SQLiteConnection connection = con.GetConnection();
            // get income
            SQLiteCommand queryMoney = new SQLiteCommand("SELECT amount FROM transactions WHERE action = '+' AND strftime('%Y', 'now')", connection);
            SQLiteDataReader income = queryMoney.ExecuteReader();
            // get expenditure
            SQLiteCommand queryExpenditure = new SQLiteCommand("SELECT amount FROM transactions WHERE action = '-' AND strftime('%Y', 'now')", connection);
            SQLiteDataReader expenditure = queryExpenditure.ExecuteReader();
            try
            {
                chart_income.Series[0].Points.Clear(); // first set of data income
                chart_income.Series[1].Points.Clear(); // second set of data expenditure

                while (income.Read() && expenditure.Read())
                {
                    chart_income.Series[0].Points.Add(income.GetInt32(0)); // first set of data income
                    chart_income.Series[1].Points.Add(expenditure.GetInt32(0)); // second set of data expenditure
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Charts unavailabe" + ex.ToString(), "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // set tool tips where required
        public void ToolTips()
        {
            ToolTip buttonToolTip = new ToolTip
            {
                ToolTipTitle = "Hint",
                UseFading = false,
                UseAnimation = true,
                IsBalloon = false,
                ShowAlways = true,

                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500
            };

            buttonToolTip.SetToolTip(btn_refresh, "Click to refresh");
            buttonToolTip.SetToolTip(lbl_currency, "Click to change currency");
            buttonToolTip.SetToolTip(btn_execute, "Add or subtract from wallet");
            buttonToolTip.SetToolTip(lbl_income_count, "This is how many times you have been paid this month");
            buttonToolTip.SetToolTip(lbl_expenditure_count, "This is how many times you have spent this month");
            buttonToolTip.SetToolTip(lbl_transactions_count, "This is how many times you have transacted this month");
            buttonToolTip.SetToolTip(chart_income, "This chart shows your daily income activity depending on the setting.");
        }
        // pull user name from system
        private string LoadUser()
        {
            string username = con.ReadString("SELECT owner FROM wallet");
            return username;
        }
        // pull user profile picture
        private void LoadPicture()
        {
            picbox_image.ImageLocation = @"res/profile/" + LoadUser() + ".jpeg";
        }
        // load the currency the user has set
        private string LoadCurrency()
        {
            string queryCurrency = "SELECT currency FROM wallet";
            string symbol = con.ReadString(queryCurrency);
            return symbol;
        }
        // load the initial capital
        public int LoadCapital()
        {
            // beginning value, your capital or investment
            int capital = int.Parse(con.ReadString("SELECT amount FROM transactions WHERE action = '+' ORDER BY ID ASC LIMIT 1"));
            return capital;
        }
        // load revenue
        public int LoadRevenue()
        {
            // ending value, your revenue at the end of the year
            int revenue = int.Parse(LoadIncome());
            return revenue;
        }
        // load year of establishment
        public int LoadEstablished()
        {
            int established = int.Parse(con.ReadString("SELECT strftime('%Y', MIN(`Date`)) FROM transactions"));
            return established;
        }
        // load current year
        public int LoadYear()
        {
            int yearNow = int.Parse(con.ReadString("SELECT strftime('%Y')"));
            return yearNow;
        }
        // load growth//////////////////////////////////////////////////////////////
        public string LoadGrowth()
        {
            try
            {
                if(!string.IsNullOrEmpty(LoadIncome()))
                {
                    // call capital
                    int capital = LoadCapital();
                    // call revenue
                    int revenue = LoadRevenue();
                    // year of establishment
                    int established = LoadEstablished();
                    // extract current year
                    int yearNow = LoadYear();
                    // subtract beginning year from current year 
                    int years = yearNow - established;
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////
                    // Compound Annual Growth Rate (CAGR) @github.com/V014/SpendWise
                    // if years in business is not equal to zero
                    if (years != 0) 
                    {
                        // divide 1 by the amount of years in business
                        double factor = (1 / years) - 1 ;
                        // Following BIDMAS rule -> brackets, indices, division, multiplication, addition, subtraction
                        // call math dot power function, divide capital from revenue, to the power of the factor, minus one
                        double total = Math.Pow(revenue / capital, factor);
                        // multiply total by a hundred to get percentage
                        double percent = total * 100;
                        // return the CAGR
                        return Math.Round(percent, 2).ToString();
                    }
                    else
                    {
                        // if business is not a year old return zero, CARG is stricly calculated Annually
                        return 0.ToString();
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////
                }
                return 0.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Growth feature unavailable! " + ex.Message, "Assistant");
                // play chime
                SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                save.Play();
                // log the error
                con.ExecuteQuery("INSERT INTO events (date, Description, Location) VALUES(strftime('%Y-%m-%d %H:%M, 'now', ''localtime), 'SQL error', 'Growth action')");
                return 0.ToString();
            }
        }
        // load investments
        private string LoadInvestments()
        {
            string investments = con.ReadString("SELECT COUNT(id) FROM investments");
            return investments;
        }
        // load complete investments
        private string LoadCompleteInvestments()
        {
            string investments = con.ReadString("SELECT COUNT(id) FROM investments WHERE progress = 100");
            return investments;
        }
        // load the overall income
        public string LoadIncome()
        {
            string Income = con.ReadString("SELECT sum(Amount) FROM transactions WHERE Action = '+'");
            return Income;
        }
        // load times gotten income in the month
        private string LoadIncomeCount(string setting)
        {
            string Income = con.ReadString($"SELECT COUNT(amount) FROM transactions WHERE action = '+' AND strftime('%m', date) = '{setting}'");
            return Income;
        }
        // load times spent money in the month
        private string LoadExpenditureCount(string setting)
        {
            string Expenditure = con.ReadString($"SELECT COUNT(amount) FROM transactions WHERE action = '-' AND strftime('%m', date) = '{setting}'");
            return Expenditure;
        }
        // load total monthly transactions
        private string LoadTransactionsCount(string setting)
        {
            string Transactions = con.ReadString($"SELECT COUNT(amount) FROM transactions WHERE strftime('%m', date) = '{setting}'");
            return Transactions;
        }
        // load Annual transactions
        private string LoadAnnualCount()
        {
            string annualTransactions = con.ReadString("SELECT COUNT(amount) FROM transactions");
            return annualTransactions;
        }
        // load the overall expenditure
        private string LoadExpenditure()
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
        public int LoadSaved()
        {
            try
            {
                int saved = int.Parse(LoadIncome()) - int.Parse(LoadExpenditure());
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
        public string LoadCommon()
        {
            string queryCommon = "SELECT description, count(description) AS cnt FROM transactions GROUP BY description ORDER BY cnt DESC LIMIT 1";
            string Common = con.ReadString(queryCommon);
            return Common;
        }
        // load the common purchased item
        private string LoadLeast()
        {
            string queryLeast = "SELECT description, count(description) AS cnt FROM transactions GROUP BY description ORDER BY cnt ASC LIMIT 1";
            string Least = con.ReadString(queryLeast);
            return Least;
        }
        // when the plus button is clicked/////////////////////////////////////////
        private void Btn_plus_Click(object sender, System.EventArgs e)
        {
            try
            {
                // instanciate values from controls
                string desc = txt_investment.Text;
                string date = date_select.Text;
                int amount = Convert.ToInt32(txt_amount.Text);
                int wallet = Convert.ToInt32(money.CheckMoney());
                int savings = Convert.ToInt32(money.CheckSavings());

                // check if a description and amount both exist
                if (txt_investment.Text != "Description" && txt_amount.Text != "" && txt_expenditure.Text == "Description")
                {
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
                    con.ExecuteQuery($"INSERT INTO transactions (description, amount, date, action) VALUES('{desc}', {amount}, '{date}', '+')");
                    // refresh app
                    RefreshUI();
                    // update the money count
                    lbl_money.Text = moneyNow.ToString();
                    // refresh the data grid
                    transaction.LoadTransactions(data_transactions);
                    // refresh charts
                    LoadCharts();
                    // load data from where the user stopped
                    Date_select_ValueChanged(sender, e);
                    // play chime
                    SoundPlayer win = new SoundPlayer(@"sfx/win.wav");
                    win.Play();

                }
                else if (txt_expenditure.Text != "Description" && txt_amount.Text != "" && txt_investment.Text == "Description")
                {
                    
                    // subtract the previous and adding values
                    int moneyNow = wallet - amount;
                    // build the query
                    con.ExecuteQuery($"UPDATE wallet SET money = '{moneyNow}'");
                    // update the money count
                    lbl_money.Text = moneyNow.ToString();
                    // log the changes
                    con.ExecuteQuery($"INSERT INTO transactions(description, amount, date, action) VALUES('{desc}', '{amount}', strftime('%Y-%m-%d %H:%M','now','localtime'), '-')");
                    // refresh app
                    RefreshUI();
                    // refresh the data grid
                    transaction.LoadTransactions(data_transactions);
                    // refresh charts
                    LoadCharts();
                    // load data from where the user stopped
                    Date_select_ValueChanged(sender, e);
                    // play chime
                    SoundPlayer coins = new SoundPlayer(@"sfx/coins.wav");
                    coins.Play();

                }
                else
                {
                    // play chime
                    SoundPlayer save = new SoundPlayer(@"sfx/pop.wav");
                    save.Play();
                    // show suggestion box
                    MessageBox.Show("Add both a description and amount for either an investment or expenditure, not all fields should be set at once!", "Suggestion");
                }
            }
            catch (Exception ex)
            {
                // play chime
                SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                save.Play();
                // log the error
                con.ExecuteQuery("INSERT INTO events (date, description, location) VALUES(strftime('%Y-%m-%d %H:%M','now','localtime'), 'SQL error', 'Plus action')");
                MessageBox.Show("Execute feature unavailable! " + ex.Message, "Assistant");
            }
            
        }
        // when the amount textbox is clicked
        private void Txt_amount_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Btn_about_Click(object sender, EventArgs e)
        {
            SoundPlayer chime = new SoundPlayer(@"sfx/click.wav");
            chime.Play();
            About us = new About();
            us.Show();
        }
        // flush the database after confirmation
        private void Btn_reset_Click(object sender, EventArgs e)
        {

        }
        // what happens when name is clicked
        private void Lbl_owner_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }
        // when the user clicks the currency label
        private void Lbl_currency_Click(object sender, EventArgs e)
        {
            Currency currency = new Currency();
            currency.Show();
        }
        // transfers details from table transactions to the controls on the top left
        private void Data_transactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // play chime
            SoundPlayer chime = new SoundPlayer(@"sfx/click.wav");
            chime.Play();
        }
        // clean up when form closes
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            con.ExecuteQuery($"UPDATE ui SET width = '{Width}', height = '{Height}'");
            sqlcon.Close();
        }
        // when refresh button pressed
        public void Btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshUI();
            SoundPlayer edit = new SoundPlayer(@"sfx/beep.wav");
            edit.Play();
        }
        // when savings button is clicked
        private void Btn_savings_Click(object sender, EventArgs e)
        {
            Savings savings = new Savings();
            savings.Show();
        }
        // when the remove menu item is clicked
        private void Item_remove_Click(object sender, EventArgs e)
        {
            // play chime
            SoundPlayer delete = new SoundPlayer(@"sfx/error.wav");
            delete.Play();
            DialogResult dialogResult = MessageBox.Show("Delete transaction?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // collect the id
                    var id = data_transactions.CurrentRow.Cells[0].Value;
                    // build query to delete user transaction
                    con.ExecuteQuery($"DELETE FROM transactions WHERE id = '{id}'");                 
                    // build query to pull transactions
                    transaction.LoadTransactions(data_transactions);
                    // refresh charts
                    LoadCharts();
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
                    try
                    {
                        // log the error 
                        con.ExecuteQuery($"INSERT INTO events  (Date, description, location) VALUES( 'date('now')', 'SQL error', 'Transaction log')");
                        MessageBox.Show("Error logged");
                    }
                    catch
                    {
                        // if logging fails, close the application
                        Application.Exit();
                    }
                }
            }
        }
        // loads details from a particular date or month or year///////////////////////
        private void Date_select_ValueChanged(object sender, EventArgs e)
        {
            transaction.LoadDate(date_select.Text, data_transactions);
            string date = date_select.Text;
            // call special connection class
            SQLiteConnection connection = con.GetConnection();
            // get income
            SQLiteCommand queryMoney = new SQLiteCommand($"SELECT Amount FROM transactions WHERE Action = '+' AND date LIKE '{date}%'", connection);
            SQLiteDataReader income_data = queryMoney.ExecuteReader();
            // get expenditure
            SQLiteCommand queryExpenditure = new SQLiteCommand($"SELECT Amount FROM transactions WHERE Action = '-' AND date LIKE '{date}%'", connection);
            SQLiteDataReader expenditure_data = queryExpenditure.ExecuteReader();
            // do some math to show the dots
            string income = con.ReadString($"SELECT SUM(Amount) FROM transactions WHERE Action = '+' AND date LIKE '{date}%'");
            string expenditure = con.ReadString($"SELECT SUM(Amount) FROM transactions WHERE Action = '-' AND date LIKE '{date}%'");
            // alawys use a try to catch unexpected errors 
            try
            {
                // make a comparision to see which is highest
                if (Convert.ToInt32(income) > Convert.ToInt32(expenditure))
                {
                    // show green dot if income is higher, hide red dot
                    dot_income.Visible = true;
                    dot_expenditure.Visible = false;
                }
                else
                {
                    // show red dot if expenditure is higher, hide green dot
                    dot_expenditure.Visible = true;
                    dot_income.Visible = false;
                }
            }
            catch (Exception)
            {
                // if income or expenditure is null do nothing
            }
            // now to populate the charts
            try
            {
                chart_income.Series[0].Points.Clear();
                chart_income.Series[1].Points.Clear();
                while (income_data.Read())
                {
                    chart_income.Series[0].Points.Add(income_data.GetInt32(0));
                    chart_income.Series[1].Points.Add(expenditure_data.GetInt32(0));
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Income unavailabe", "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // stops timer to prevent refresh
            timer.Stop();
        }
        // loads details from a oarticular month///////////////////////////////////////
        private void Cmb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = LoadYear();
            transaction.LoadMonth(cmb_month.Text, year, data_transactions);
            string month = transaction.getMonthNumber(cmb_month.Text);
            
            SQLiteConnection connection = con.GetConnection();
            // get income
            SQLiteCommand queryMoney = new SQLiteCommand($"SELECT amount FROM transactions WHERE action = '+' AND strftime('%m', date) = '{month}' AND strftime('%Y', date) = '{year}'", connection);
            SQLiteDataReader income_data = queryMoney.ExecuteReader();
            // get expenditure
            SQLiteCommand queryExpenditure = new SQLiteCommand($"SELECT amount FROM transactions WHERE action = '-' AND strftime('%m', date) = '{month}' AND strftime('%Y', date) = '{year}'", connection);
            SQLiteDataReader expenditure_data = queryExpenditure.ExecuteReader();
            // check values
            string income = con.ReadString($"SELECT SUM(amount) FROM transactions WHERE action = '+' AND strftime('%m', date) = '{month}' AND strftime('%Y', date) = '{year}'");
            string expenditure = con.ReadString($"SELECT SUM(amount) FROM transactions WHERE action = '-' AND strftime('%m', date) = '{month}' AND strftime('%Y', date) = '{year}'");
            // dot notification
            try
            {
                // make a comparision to see which is highest
                if (int.Parse(income) > int.Parse(expenditure))
                {
                    // show green dot if income is higher, hide red dot
                    dot_income.Visible = true;
                    dot_expenditure.Visible = false;
                }
                else
                {
                    // show red dot if expenditure is higher, hide green dot
                    dot_expenditure.Visible = true;
                    dot_income.Visible = false;
                }

            }
            catch (Exception)
            {
                // Incase of error do nothing
            }
            
            // Fill income chart
            try
            {
                chart_income.Series[0].Points.Clear();
                chart_income.Series[1].Points.Clear();
                while (income_data.Read())
                {
                    chart_income.Series[0].Points.Add(income_data.GetInt32(0));
                    chart_income.Series[1].Points.Add(expenditure_data.GetInt32(0));
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Charts unavailabe", "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // displays about message
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
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
                string name = LoadUser();
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
            AutoRefresh();
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
            if (this.Width <= 880)
            {
                splitContainer_dataCharts.Panel2Collapsed = true;
            }
            else
            {
                splitContainer_dataCharts.Panel2Collapsed = false;
            }
            if (this.Height <= 500)
            {
                picbox_image.Visible = false;
            }
            else
            {
                picbox_image.Visible = true;
            }
        }
        // when the user clicks the expenditure button
        private void Btn_expenditure_Click(object sender, EventArgs e)
        {
            Expenditure expenditure = new Expenditure();
            expenditure.Show();
        }
        // when user clicks the income button
        private void Btn_income_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
        }
        // when the user clicks the wallet button
        private void Btn_money_Click(object sender, EventArgs e)
        {
            Currency currency = new Currency();
            currency.Show();
        }
        // light mode properties
        private void LightMode()
        {
            try
            {
                // style app
                this.BackColor = Color.White;
                // style datagrid
                theme.LightStyle(data_transactions);
                // style panels
                panel_money.BackColor = Color.FromArgb(235, 235, 235);
                panel_savings.BackColor = Color.FromArgb(235, 235, 235);
                panel_overal_income.BackColor = Color.FromArgb(235, 235, 235);
                panel_overall_expenditure.BackColor = Color.FromArgb(235, 235, 235);
                panel_growth.BackColor = Color.FromArgb(235, 235, 235);
                panel_investments.BackColor = Color.FromArgb(235, 235, 235);
                // style text
                lbl_currency.ForeColor = Color.Black;
                lbl_money.ForeColor = Color.Black;
                // style buttons
                btn_execute.BackColor = Color.FromArgb(72, 174, 120);
                btn_refresh.BackColor = Color.SteelBlue;
                // style controls
                txt_amount.Theme = MetroFramework.MetroThemeStyle.Light;
                txt_investment.BackColor = Color.White;
                date_select.Theme = MetroFramework.MetroThemeStyle.Light;
                cmb_month.Theme = MetroFramework.MetroThemeStyle.Light;
                // update the wallet theme property in the db
                // con.ExecuteQuery("UPDATE wallet SET Theme = 'Light'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Light mode feature unavailable! " + ex.Message, "Assistant");
            }
        }
        // dark mode properties
        private void DarkMode()
        {
            try
            {
                // style app
                this.BackColor = Color.FromArgb(17, 17, 17);
                // style datagrid
                theme.DarkStyle(data_transactions);
                // style panels
                panel_money.BackColor = Color.FromArgb(24, 24, 24);
                panel_savings.BackColor = Color.FromArgb(24, 24, 24);
                panel_overal_income.BackColor = Color.FromArgb(24, 24, 24);
                panel_overall_expenditure.BackColor = Color.FromArgb(24, 24, 24);
                panel_growth.BackColor = Color.FromArgb(24, 24, 24);
                panel_investments.BackColor = Color.FromArgb(24, 24, 24);
                // style text
                lbl_currency.ForeColor = Color.White;
                lbl_money.ForeColor = Color.White;
                // style buttons
                btn_execute.BackColor = Color.FromArgb(20, 30, 30);
                btn_refresh.BackColor = Color.FromArgb(20, 30, 40);
                // style controls
                txt_amount.Theme = MetroFramework.MetroThemeStyle.Dark;
                txt_investment.BackColor = Color.FromArgb(17, 17, 17);
                date_select.Theme = MetroFramework.MetroThemeStyle.Dark;
                cmb_month.Theme = MetroFramework.MetroThemeStyle.Dark;
                // update the wallet theme property in the db
                // con.ExecuteQuery("UPDATE wallet SET Theme = 'Dark'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dark mode feature unavailable, " + ex.Message, "Assistant");
            }
        }
        // when user sets light mode
        private void LightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LightMode();
        }
        // when user sets dark mode
        private void DarkModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DarkMode();
        }
        // if user edits in datagrid, reflect the changes
        private void data_transactions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = data_transactions.SelectedRows[0];
                string id = selectedRow.Cells[0].Value.ToString();
                string description = selectedRow.Cells[1].Value.ToString();
                string amount = selectedRow.Cells[2].Value.ToString();
                string date = selectedRow.Cells[4].Value.ToString();
                string action = selectedRow.Cells[3].Value.ToString();

                con.ExecuteQuery($"Update transactions SET Description='{description}', Amount='{amount}', Action='{action}', date='{date}' WHERE ID={id}");
                RefreshUI();
            }
            catch (Exception)
            {
                // do nothing
            }
        }

        private void ImportStripMenuItem_Click(object sender, EventArgs e)
        {
            // Imports data into apps
            MessageBox.Show("Copy and replace database file into the spendwise application folder");
        }

        private void ExportStripMenuItem_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.Show();
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // play chime
            SoundPlayer chime = new SoundPlayer(@"sfx/glass.wav");
            chime.Play();
            DialogResult dialogResult = MessageBox.Show("Resetting the wallet database will clear all your transaction history and settings, are you sure?", "Reset Wallet", MessageBoxButtons.YesNo);

            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    // delete transactions
                    con.ExecuteQuery("DELETE FROM transactions");
                    // update wallet
                    con.ExecuteQuery("UPDATE wallet SET Money = 0.00, Savings = 0, Owner = 'My wallet', State = 'Mini', Currency = 'MWK', Theme = 'Light'");
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

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }
    }
}