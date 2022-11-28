namespace SpendWise
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_savings = new System.Windows.Forms.Button();
            this.btn_money = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.ComboBox();
            this.lbl_savings = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            this.txt_amount = new MetroFramework.Controls.MetroTextBox();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.menuTransactions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.item_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_income = new System.Windows.Forms.Panel();
            this.chart_income = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_expenditure = new System.Windows.Forms.Panel();
            this.chart_expenditure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_least = new System.Windows.Forms.Label();
            this.lbl_common = new System.Windows.Forms.Label();
            this.lbl_saved = new System.Windows.Forms.Label();
            this.lbl_expenditure = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.lbl_lst = new System.Windows.Forms.Label();
            this.lbl_com = new System.Windows.Forms.Label();
            this.cmb_month = new MetroFramework.Controls.MetroComboBox();
            this.date_select = new MetroFramework.Controls.MetroDateTime();
            this.menuUI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_transactions = new System.Windows.Forms.Panel();
            this.data_transactions = new System.Windows.Forms.DataGridView();
            this.panel_money = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_amount = new System.Windows.Forms.Panel();
            this.lbl_title_amount = new System.Windows.Forms.Label();
            this.panel_input = new System.Windows.Forms.Panel();
            this.lbl_title_transactions = new System.Windows.Forms.Label();
            this.panel_savings = new System.Windows.Forms.Panel();
            this.lbl_title_savings = new System.Windows.Forms.Label();
            this.panel_overal_income = new System.Windows.Forms.Panel();
            this.btn_income = new System.Windows.Forms.Button();
            this.lbl_title_income = new System.Windows.Forms.Label();
            this.panel_overall_expenditure = new System.Windows.Forms.Panel();
            this.btn_expenditure = new System.Windows.Forms.Button();
            this.lbl_title_expenditure = new System.Windows.Forms.Label();
            this.panel_total_saved = new System.Windows.Forms.Panel();
            this.btn_saved = new System.Windows.Forms.Button();
            this.lbl_title_saved = new System.Windows.Forms.Label();
            this.panel_frequency = new System.Windows.Forms.Panel();
            this.panel_date = new System.Windows.Forms.Panel();
            this.lbl_title_date = new System.Windows.Forms.Label();
            this.panel_month = new System.Windows.Forms.Panel();
            this.lbl_title_month = new System.Windows.Forms.Label();
            this.panel_growth = new System.Windows.Forms.Panel();
            this.btn_growth = new System.Windows.Forms.Button();
            this.lbl_title_growth = new System.Windows.Forms.Label();
            this.lbl_growth = new System.Windows.Forms.Label();
            this.panel_investments = new System.Windows.Forms.Panel();
            this.btn_investments = new System.Windows.Forms.Button();
            this.lbl_title_investment = new System.Windows.Forms.Label();
            this.lbl_divider = new System.Windows.Forms.Label();
            this.lbl_complete_investments = new System.Windows.Forms.Label();
            this.lbl_investments = new System.Windows.Forms.Label();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.picbox_image = new System.Windows.Forms.PictureBox();
            this.panel_owner = new System.Windows.Forms.Panel();
            this.btn_owner = new System.Windows.Forms.Button();
            this.splitContainer_charts = new System.Windows.Forms.SplitContainer();
            this.splitContainer_dataCharts = new System.Windows.Forms.SplitContainer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuTransactions.SuspendLayout();
            this.panel_income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_income)).BeginInit();
            this.panel_expenditure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_expenditure)).BeginInit();
            this.menuUI.SuspendLayout();
            this.panel_transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_transactions)).BeginInit();
            this.panel_money.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.panel_amount.SuspendLayout();
            this.panel_input.SuspendLayout();
            this.panel_savings.SuspendLayout();
            this.panel_overal_income.SuspendLayout();
            this.panel_overall_expenditure.SuspendLayout();
            this.panel_total_saved.SuspendLayout();
            this.panel_frequency.SuspendLayout();
            this.panel_date.SuspendLayout();
            this.panel_month.SuspendLayout();
            this.panel_growth.SuspendLayout();
            this.panel_investments.SuspendLayout();
            this.panel_nav.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_image)).BeginInit();
            this.panel_owner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_charts)).BeginInit();
            this.splitContainer_charts.Panel1.SuspendLayout();
            this.splitContainer_charts.Panel2.SuspendLayout();
            this.splitContainer_charts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_dataCharts)).BeginInit();
            this.splitContainer_dataCharts.Panel1.SuspendLayout();
            this.splitContainer_dataCharts.Panel2.SuspendLayout();
            this.splitContainer_dataCharts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_savings
            // 
            this.btn_savings.BackColor = System.Drawing.Color.Transparent;
            this.btn_savings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_savings.BackgroundImage")));
            this.btn_savings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_savings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_savings.FlatAppearance.BorderSize = 0;
            this.btn_savings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.btn_savings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savings.Location = new System.Drawing.Point(143, 0);
            this.btn_savings.Name = "btn_savings";
            this.btn_savings.Size = new System.Drawing.Size(57, 64);
            this.btn_savings.TabIndex = 3;
            this.btn_savings.UseVisualStyleBackColor = false;
            this.btn_savings.Click += new System.EventHandler(this.btn_savings_Click);
            // 
            // btn_money
            // 
            this.btn_money.BackColor = System.Drawing.Color.Transparent;
            this.btn_money.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_money.BackgroundImage")));
            this.btn_money.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_money.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_money.FlatAppearance.BorderSize = 0;
            this.btn_money.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.btn_money.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_money.Location = new System.Drawing.Point(142, 0);
            this.btn_money.Name = "btn_money";
            this.btn_money.Size = new System.Drawing.Size(58, 64);
            this.btn_money.TabIndex = 4;
            this.btn_money.UseVisualStyleBackColor = false;
            this.btn_money.Click += new System.EventHandler(this.lbl_currency_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_desc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_desc.ForeColor = System.Drawing.Color.Gray;
            this.txt_desc.FormattingEnabled = true;
            this.txt_desc.Items.AddRange(new object[] {
            "Accessories",
            "Business",
            "Education",
            "Family",
            "Food",
            "Private",
            "Friend",
            "Fun",
            "Games",
            "Hand out",
            "Hobby",
            "Medication",
            "Phone bill ",
            "Religion",
            "Transport",
            "Utility bill",
            "Work",
            "Habbit"});
            this.txt_desc.Location = new System.Drawing.Point(16, 24);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(166, 27);
            this.txt_desc.TabIndex = 1;
            this.txt_desc.Tag = "";
            this.txt_desc.Text = "Description";
            // 
            // lbl_savings
            // 
            this.lbl_savings.AutoSize = true;
            this.lbl_savings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_savings.ForeColor = System.Drawing.Color.White;
            this.lbl_savings.Location = new System.Drawing.Point(12, 26);
            this.lbl_savings.Name = "lbl_savings";
            this.lbl_savings.Size = new System.Drawing.Size(45, 24);
            this.lbl_savings.TabIndex = 0;
            this.lbl_savings.Text = "0.00";
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_money.ForeColor = System.Drawing.Color.White;
            this.lbl_money.Location = new System.Drawing.Point(12, 26);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(45, 24);
            this.lbl_money.TabIndex = 0;
            this.lbl_money.Text = "0.00";
            // 
            // txt_amount
            // 
            // 
            // 
            // 
            this.txt_amount.CustomButton.Image = null;
            this.txt_amount.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txt_amount.CustomButton.Name = "";
            this.txt_amount.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_amount.CustomButton.TabIndex = 1;
            this.txt_amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_amount.CustomButton.UseSelectable = true;
            this.txt_amount.CustomButton.Visible = false;
            this.txt_amount.DisplayIcon = true;
            this.txt_amount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_amount.Lines = new string[0];
            this.txt_amount.Location = new System.Drawing.Point(16, 24);
            this.txt_amount.MaxLength = 32767;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PasswordChar = '\0';
            this.txt_amount.PromptText = "Amount 0.00";
            this.txt_amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_amount.SelectedText = "";
            this.txt_amount.SelectionLength = 0;
            this.txt_amount.SelectionStart = 0;
            this.txt_amount.ShortcutsEnabled = true;
            this.txt_amount.ShowClearButton = true;
            this.txt_amount.Size = new System.Drawing.Size(167, 29);
            this.txt_amount.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_amount.TabIndex = 0;
            this.txt_amount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_amount.UseSelectable = true;
            this.txt_amount.WaterMark = "Amount 0.00";
            this.txt_amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // lbl_currency
            // 
            this.lbl_currency.AutoSize = true;
            this.lbl_currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_currency.ForeColor = System.Drawing.Color.White;
            this.lbl_currency.Location = new System.Drawing.Point(13, 3);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(55, 15);
            this.lbl_currency.TabIndex = 0;
            this.lbl_currency.Text = "Currency";
            this.lbl_currency.Click += new System.EventHandler(this.lbl_currency_Click);
            // 
            // menuTransactions
            // 
            this.menuTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.menuTransactions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_remove});
            this.menuTransactions.Name = "dataMenu";
            this.menuTransactions.ShowImageMargin = false;
            this.menuTransactions.Size = new System.Drawing.Size(93, 26);
            this.menuTransactions.Style = MetroFramework.MetroColorStyle.Green;
            this.menuTransactions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuTransactions.UseStyleColors = true;
            // 
            // item_remove
            // 
            this.item_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.item_remove.ForeColor = System.Drawing.Color.White;
            this.item_remove.Image = ((System.Drawing.Image)(resources.GetObject("item_remove.Image")));
            this.item_remove.Name = "item_remove";
            this.item_remove.Size = new System.Drawing.Size(92, 22);
            this.item_remove.Text = "Remove";
            this.item_remove.Click += new System.EventHandler(this.item_remove_Click);
            // 
            // panel_income
            // 
            this.panel_income.BackColor = System.Drawing.Color.Transparent;
            this.panel_income.Controls.Add(this.chart_income);
            this.panel_income.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_income.Location = new System.Drawing.Point(0, 0);
            this.panel_income.Name = "panel_income";
            this.panel_income.Size = new System.Drawing.Size(303, 182);
            this.panel_income.TabIndex = 4;
            // 
            // chart_income
            // 
            this.chart_income.BackColor = System.Drawing.Color.Transparent;
            this.chart_income.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_income.BorderlineColor = System.Drawing.Color.Empty;
            this.chart_income.BorderlineWidth = 0;
            this.chart_income.BorderSkin.BackColor = System.Drawing.Color.Empty;
            this.chart_income.BorderSkin.BorderWidth = 0;
            chartArea1.Area3DStyle.Inclination = 2;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 20;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 20;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Empty;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartArea1.ShadowOffset = 20;
            this.chart_income.ChartAreas.Add(chartArea1);
            this.chart_income.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart_income.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chart_income.Legends.Add(legend1);
            this.chart_income.Location = new System.Drawing.Point(0, 0);
            this.chart_income.Name = "chart_income";
            this.chart_income.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series1.BackSecondaryColor = System.Drawing.Color.DarkGreen;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.LimeGreen;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelForeColor = System.Drawing.Color.Empty;
            series1.Legend = "Legend1";
            series1.Name = "Income";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ShadowOffset = 6;
            this.chart_income.Series.Add(series1);
            this.chart_income.Size = new System.Drawing.Size(303, 182);
            this.chart_income.TabIndex = 2;
            this.chart_income.Text = "chart1";
            // 
            // panel_expenditure
            // 
            this.panel_expenditure.BackColor = System.Drawing.Color.Transparent;
            this.panel_expenditure.Controls.Add(this.chart_expenditure);
            this.panel_expenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_expenditure.Location = new System.Drawing.Point(0, 0);
            this.panel_expenditure.Name = "panel_expenditure";
            this.panel_expenditure.Size = new System.Drawing.Size(303, 177);
            this.panel_expenditure.TabIndex = 5;
            // 
            // chart_expenditure
            // 
            this.chart_expenditure.BackColor = System.Drawing.Color.Transparent;
            this.chart_expenditure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_expenditure.BorderlineColor = System.Drawing.Color.Empty;
            this.chart_expenditure.BorderlineWidth = 0;
            this.chart_expenditure.BorderSkin.BackColor = System.Drawing.Color.Empty;
            this.chart_expenditure.BorderSkin.BorderWidth = 0;
            chartArea2.Area3DStyle.Inclination = 2;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 20;
            chartArea2.Area3DStyle.Rotation = 5;
            chartArea2.Area3DStyle.WallWidth = 20;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Empty;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 94F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 3F;
            chartArea2.ShadowOffset = 20;
            this.chart_expenditure.ChartAreas.Add(chartArea2);
            this.chart_expenditure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart_expenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.chart_expenditure.Legends.Add(legend2);
            this.chart_expenditure.Location = new System.Drawing.Point(0, 0);
            this.chart_expenditure.Name = "chart_expenditure";
            this.chart_expenditure.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BackSecondaryColor = System.Drawing.Color.Red;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Out";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ShadowOffset = 6;
            this.chart_expenditure.Series.Add(series2);
            this.chart_expenditure.Size = new System.Drawing.Size(303, 177);
            this.chart_expenditure.TabIndex = 2;
            this.chart_expenditure.Text = "chart1";
            // 
            // lbl_least
            // 
            this.lbl_least.AutoSize = true;
            this.lbl_least.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_least.ForeColor = System.Drawing.Color.White;
            this.lbl_least.Location = new System.Drawing.Point(82, 36);
            this.lbl_least.Name = "lbl_least";
            this.lbl_least.Size = new System.Drawing.Size(59, 15);
            this.lbl_least.TabIndex = 0;
            this.lbl_least.Text = "Unknown";
            // 
            // lbl_common
            // 
            this.lbl_common.AutoSize = true;
            this.lbl_common.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_common.ForeColor = System.Drawing.Color.White;
            this.lbl_common.Location = new System.Drawing.Point(82, 9);
            this.lbl_common.Name = "lbl_common";
            this.lbl_common.Size = new System.Drawing.Size(59, 15);
            this.lbl_common.TabIndex = 0;
            this.lbl_common.Text = "Unknown";
            // 
            // lbl_saved
            // 
            this.lbl_saved.AutoSize = true;
            this.lbl_saved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_saved.ForeColor = System.Drawing.Color.White;
            this.lbl_saved.Location = new System.Drawing.Point(12, 26);
            this.lbl_saved.Name = "lbl_saved";
            this.lbl_saved.Size = new System.Drawing.Size(45, 24);
            this.lbl_saved.TabIndex = 0;
            this.lbl_saved.Text = "0.00";
            // 
            // lbl_expenditure
            // 
            this.lbl_expenditure.AutoSize = true;
            this.lbl_expenditure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_expenditure.ForeColor = System.Drawing.Color.White;
            this.lbl_expenditure.Location = new System.Drawing.Point(12, 26);
            this.lbl_expenditure.Name = "lbl_expenditure";
            this.lbl_expenditure.Size = new System.Drawing.Size(45, 24);
            this.lbl_expenditure.TabIndex = 0;
            this.lbl_expenditure.Text = "0.00";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_income.ForeColor = System.Drawing.Color.White;
            this.lbl_income.Location = new System.Drawing.Point(12, 26);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(45, 24);
            this.lbl_income.TabIndex = 0;
            this.lbl_income.Text = "0.00";
            // 
            // lbl_lst
            // 
            this.lbl_lst.AutoSize = true;
            this.lbl_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_lst.ForeColor = System.Drawing.Color.White;
            this.lbl_lst.Location = new System.Drawing.Point(15, 36);
            this.lbl_lst.Name = "lbl_lst";
            this.lbl_lst.Size = new System.Drawing.Size(56, 15);
            this.lbl_lst.TabIndex = 0;
            this.lbl_lst.Text = "Avoided: ";
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_com.ForeColor = System.Drawing.Color.White;
            this.lbl_com.Location = new System.Drawing.Point(15, 9);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(61, 15);
            this.lbl_com.TabIndex = 0;
            this.lbl_com.Text = "Common:";
            // 
            // cmb_month
            // 
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.ItemHeight = 23;
            this.cmb_month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_month.Location = new System.Drawing.Point(16, 24);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.PromptText = "Month";
            this.cmb_month.Size = new System.Drawing.Size(166, 29);
            this.cmb_month.Style = MetroFramework.MetroColorStyle.Green;
            this.cmb_month.TabIndex = 12;
            this.cmb_month.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmb_month.UseSelectable = true;
            this.cmb_month.SelectedIndexChanged += new System.EventHandler(this.Cmb_month_SelectedIndexChanged);
            // 
            // date_select
            // 
            this.date_select.CustomFormat = "";
            this.date_select.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_select.Location = new System.Drawing.Point(16, 24);
            this.date_select.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_select.Name = "date_select";
            this.date_select.Size = new System.Drawing.Size(167, 29);
            this.date_select.Style = MetroFramework.MetroColorStyle.Green;
            this.date_select.TabIndex = 11;
            this.date_select.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.date_select.ValueChanged += new System.EventHandler(this.Date_select_ValueChanged);
            // 
            // menuUI
            // 
            this.menuUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.menuUI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuUI.Name = "uiMenu";
            this.menuUI.ShowImageMargin = false;
            this.menuUI.Size = new System.Drawing.Size(86, 70);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel_transactions
            // 
            this.panel_transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel_transactions.Controls.Add(this.data_transactions);
            this.panel_transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_transactions.Location = new System.Drawing.Point(0, 0);
            this.panel_transactions.Name = "panel_transactions";
            this.panel_transactions.Size = new System.Drawing.Size(533, 363);
            this.panel_transactions.TabIndex = 10;
            // 
            // data_transactions
            // 
            this.data_transactions.AllowUserToAddRows = false;
            this.data_transactions.AllowUserToDeleteRows = false;
            this.data_transactions.AllowUserToResizeRows = false;
            this.data_transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_transactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_transactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.data_transactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_transactions.ContextMenuStrip = this.menuTransactions;
            this.data_transactions.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_transactions.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_transactions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.data_transactions.Location = new System.Drawing.Point(0, 0);
            this.data_transactions.Name = "data_transactions";
            this.data_transactions.ReadOnly = true;
            this.data_transactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_transactions.Size = new System.Drawing.Size(533, 363);
            this.data_transactions.TabIndex = 0;
            this.data_transactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_transactions_CellClick);
            // 
            // panel_money
            // 
            this.panel_money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_money.Controls.Add(this.btn_money);
            this.panel_money.Controls.Add(this.lbl_money);
            this.panel_money.Controls.Add(this.lbl_currency);
            this.panel_money.Location = new System.Drawing.Point(415, 3);
            this.panel_money.Name = "panel_money";
            this.panel_money.Size = new System.Drawing.Size(200, 64);
            this.panel_money.TabIndex = 0;
            // 
            // panel_top
            // 
            this.panel_top.AutoScroll = true;
            this.panel_top.Controls.Add(this.panel_amount);
            this.panel_top.Controls.Add(this.panel_input);
            this.panel_top.Controls.Add(this.panel_money);
            this.panel_top.Controls.Add(this.panel_savings);
            this.panel_top.Controls.Add(this.panel_overal_income);
            this.panel_top.Controls.Add(this.panel_overall_expenditure);
            this.panel_top.Controls.Add(this.panel_total_saved);
            this.panel_top.Controls.Add(this.panel_frequency);
            this.panel_top.Controls.Add(this.panel_date);
            this.panel_top.Controls.Add(this.panel_month);
            this.panel_top.Controls.Add(this.panel_growth);
            this.panel_top.Controls.Add(this.panel_investments);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(226, 60);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(840, 213);
            this.panel_top.TabIndex = 11;
            // 
            // panel_amount
            // 
            this.panel_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_amount.Controls.Add(this.lbl_title_amount);
            this.panel_amount.Controls.Add(this.txt_amount);
            this.panel_amount.Location = new System.Drawing.Point(3, 3);
            this.panel_amount.Name = "panel_amount";
            this.panel_amount.Size = new System.Drawing.Size(200, 64);
            this.panel_amount.TabIndex = 0;
            // 
            // lbl_title_amount
            // 
            this.lbl_title_amount.AutoSize = true;
            this.lbl_title_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_title_amount.ForeColor = System.Drawing.Color.White;
            this.lbl_title_amount.Location = new System.Drawing.Point(13, 3);
            this.lbl_title_amount.Name = "lbl_title_amount";
            this.lbl_title_amount.Size = new System.Drawing.Size(91, 15);
            this.lbl_title_amount.TabIndex = 0;
            this.lbl_title_amount.Text = "Specify amount";
            this.lbl_title_amount.Click += new System.EventHandler(this.lbl_currency_Click);
            // 
            // panel_input
            // 
            this.panel_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_input.Controls.Add(this.lbl_title_transactions);
            this.panel_input.Controls.Add(this.txt_desc);
            this.panel_input.Location = new System.Drawing.Point(209, 3);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(200, 64);
            this.panel_input.TabIndex = 0;
            // 
            // lbl_title_transactions
            // 
            this.lbl_title_transactions.AutoSize = true;
            this.lbl_title_transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_title_transactions.ForeColor = System.Drawing.Color.White;
            this.lbl_title_transactions.Location = new System.Drawing.Point(13, 3);
            this.lbl_title_transactions.Name = "lbl_title_transactions";
            this.lbl_title_transactions.Size = new System.Drawing.Size(119, 15);
            this.lbl_title_transactions.TabIndex = 0;
            this.lbl_title_transactions.Text = "Describe transaction";
            this.lbl_title_transactions.Click += new System.EventHandler(this.lbl_currency_Click);
            // 
            // panel_savings
            // 
            this.panel_savings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_savings.Controls.Add(this.btn_savings);
            this.panel_savings.Controls.Add(this.lbl_title_savings);
            this.panel_savings.Controls.Add(this.lbl_savings);
            this.panel_savings.Location = new System.Drawing.Point(621, 3);
            this.panel_savings.Name = "panel_savings";
            this.panel_savings.Size = new System.Drawing.Size(200, 64);
            this.panel_savings.TabIndex = 0;
            // 
            // lbl_title_savings
            // 
            this.lbl_title_savings.AutoSize = true;
            this.lbl_title_savings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_title_savings.ForeColor = System.Drawing.Color.White;
            this.lbl_title_savings.Location = new System.Drawing.Point(13, 3);
            this.lbl_title_savings.Name = "lbl_title_savings";
            this.lbl_title_savings.Size = new System.Drawing.Size(50, 15);
            this.lbl_title_savings.TabIndex = 0;
            this.lbl_title_savings.Text = "Savings";
            // 
            // panel_overal_income
            // 
            this.panel_overal_income.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_overal_income.Controls.Add(this.btn_income);
            this.panel_overal_income.Controls.Add(this.lbl_title_income);
            this.panel_overal_income.Controls.Add(this.lbl_income);
            this.panel_overal_income.Location = new System.Drawing.Point(3, 73);
            this.panel_overal_income.Name = "panel_overal_income";
            this.panel_overal_income.Size = new System.Drawing.Size(200, 64);
            this.panel_overal_income.TabIndex = 0;
            // 
            // btn_income
            // 
            this.btn_income.BackColor = System.Drawing.Color.Transparent;
            this.btn_income.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_income.BackgroundImage")));
            this.btn_income.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_income.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_income.FlatAppearance.BorderSize = 0;
            this.btn_income.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_income.Location = new System.Drawing.Point(142, 0);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(58, 64);
            this.btn_income.TabIndex = 4;
            this.btn_income.UseVisualStyleBackColor = false;
            // 
            // lbl_title_income
            // 
            this.lbl_title_income.AutoSize = true;
            this.lbl_title_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_title_income.ForeColor = System.Drawing.Color.White;
            this.lbl_title_income.Location = new System.Drawing.Point(13, 3);
            this.lbl_title_income.Name = "lbl_title_income";
            this.lbl_title_income.Size = new System.Drawing.Size(48, 15);
            this.lbl_title_income.TabIndex = 0;
            this.lbl_title_income.Text = "Income";
            // 
            // panel_overall_expenditure
            // 
            this.panel_overall_expenditure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_overall_expenditure.Controls.Add(this.btn_expenditure);
            this.panel_overall_expenditure.Controls.Add(this.lbl_title_expenditure);
            this.panel_overall_expenditure.Controls.Add(this.lbl_expenditure);
            this.panel_overall_expenditure.Location = new System.Drawing.Point(209, 73);
            this.panel_overall_expenditure.Name = "panel_overall_expenditure";
            this.panel_overall_expenditure.Size = new System.Drawing.Size(200, 64);
            this.panel_overall_expenditure.TabIndex = 0;
            // 
            // btn_expenditure
            // 
            this.btn_expenditure.BackColor = System.Drawing.Color.Transparent;
            this.btn_expenditure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_expenditure.BackgroundImage")));
            this.btn_expenditure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_expenditure.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_expenditure.FlatAppearance.BorderSize = 0;
            this.btn_expenditure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.btn_expenditure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expenditure.Location = new System.Drawing.Point(142, 0);
            this.btn_expenditure.Name = "btn_expenditure";
            this.btn_expenditure.Size = new System.Drawing.Size(58, 64);
            this.btn_expenditure.TabIndex = 4;
            this.btn_expenditure.UseVisualStyleBackColor = false;
            // 
            // lbl_title_expenditure
            // 
            this.lbl_title_expenditure.AutoSize = true;
            this.lbl_title_expenditure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_title_expenditure.ForeColor = System.Drawing.Color.White;
            this.lbl_title_expenditure.Location = new System.Drawing.Point(13, 3);
            this.lbl_title_expenditure.Name = "lbl_title_expenditure";
            this.lbl_title_expenditure.Size = new System.Drawing.Size(73, 15);
            this.lbl_title_expenditure.TabIndex = 0;
            this.lbl_title_expenditure.Text = "Expenditure";
            // 
            // panel_total_saved
            // 
            this.panel_total_saved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_total_saved.Controls.Add(this.btn_saved);
            this.panel_total_saved.Controls.Add(this.lbl_title_saved);
            this.panel_total_saved.Controls.Add(this.lbl_saved);
            this.panel_total_saved.Location = new System.Drawing.Point(415, 73);
            this.panel_total_saved.Name = "panel_total_saved";
            this.panel_total_saved.Size = new System.Drawing.Size(200, 64);
            this.panel_total_saved.TabIndex = 0;
            // 
            // btn_saved
            // 
            this.btn_saved.BackColor = System.Drawing.Color.Transparent;
            this.btn_saved.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_saved.BackgroundImage")));
            this.btn_saved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_saved.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_saved.FlatAppearance.BorderSize = 0;
            this.btn_saved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.btn_saved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saved.Location = new System.Drawing.Point(143, 0);
            this.btn_saved.Name = "btn_saved";
            this.btn_saved.Size = new System.Drawing.Size(57, 64);
            this.btn_saved.TabIndex = 3;
            this.btn_saved.UseVisualStyleBackColor = false;
            // 
            // lbl_title_saved
            // 
            this.lbl_title_saved.AutoSize = true;
            this.lbl_title_saved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_title_saved.ForeColor = System.Drawing.Color.White;
            this.lbl_title_saved.Location = new System.Drawing.Point(13, 3);
            this.lbl_title_saved.Name = "lbl_title_saved";
            this.lbl_title_saved.Size = new System.Drawing.Size(69, 15);
            this.lbl_title_saved.TabIndex = 0;
            this.lbl_title_saved.Text = "Total saved";
            // 
            // panel_frequency
            // 
            this.panel_frequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_frequency.Controls.Add(this.lbl_least);
            this.panel_frequency.Controls.Add(this.lbl_com);
            this.panel_frequency.Controls.Add(this.lbl_common);
            this.panel_frequency.Controls.Add(this.lbl_lst);
            this.panel_frequency.Location = new System.Drawing.Point(621, 73);
            this.panel_frequency.Name = "panel_frequency";
            this.panel_frequency.Size = new System.Drawing.Size(200, 64);
            this.panel_frequency.TabIndex = 0;
            // 
            // panel_date
            // 
            this.panel_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_date.Controls.Add(this.lbl_title_date);
            this.panel_date.Controls.Add(this.date_select);
            this.panel_date.Location = new System.Drawing.Point(3, 143);
            this.panel_date.Name = "panel_date";
            this.panel_date.Size = new System.Drawing.Size(200, 64);
            this.panel_date.TabIndex = 0;
            // 
            // lbl_title_date
            // 
            this.lbl_title_date.AutoSize = true;
            this.lbl_title_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_title_date.ForeColor = System.Drawing.Color.White;
            this.lbl_title_date.Location = new System.Drawing.Point(13, 3);
            this.lbl_title_date.Name = "lbl_title_date";
            this.lbl_title_date.Size = new System.Drawing.Size(73, 15);
            this.lbl_title_date.TabIndex = 0;
            this.lbl_title_date.Text = "Specify date";
            // 
            // panel_month
            // 
            this.panel_month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_month.Controls.Add(this.lbl_title_month);
            this.panel_month.Controls.Add(this.cmb_month);
            this.panel_month.Location = new System.Drawing.Point(209, 143);
            this.panel_month.Name = "panel_month";
            this.panel_month.Size = new System.Drawing.Size(200, 64);
            this.panel_month.TabIndex = 0;
            // 
            // lbl_title_month
            // 
            this.lbl_title_month.AutoSize = true;
            this.lbl_title_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_title_month.ForeColor = System.Drawing.Color.White;
            this.lbl_title_month.Location = new System.Drawing.Point(13, 3);
            this.lbl_title_month.Name = "lbl_title_month";
            this.lbl_title_month.Size = new System.Drawing.Size(84, 15);
            this.lbl_title_month.TabIndex = 0;
            this.lbl_title_month.Text = "Specify month";
            // 
            // panel_growth
            // 
            this.panel_growth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_growth.Controls.Add(this.btn_growth);
            this.panel_growth.Controls.Add(this.lbl_title_growth);
            this.panel_growth.Controls.Add(this.lbl_growth);
            this.panel_growth.Location = new System.Drawing.Point(415, 143);
            this.panel_growth.Name = "panel_growth";
            this.panel_growth.Size = new System.Drawing.Size(200, 64);
            this.panel_growth.TabIndex = 0;
            // 
            // btn_growth
            // 
            this.btn_growth.BackColor = System.Drawing.Color.Transparent;
            this.btn_growth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_growth.BackgroundImage")));
            this.btn_growth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_growth.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_growth.FlatAppearance.BorderSize = 0;
            this.btn_growth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_growth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_growth.Location = new System.Drawing.Point(143, 0);
            this.btn_growth.Name = "btn_growth";
            this.btn_growth.Size = new System.Drawing.Size(57, 64);
            this.btn_growth.TabIndex = 3;
            this.btn_growth.UseVisualStyleBackColor = false;
            this.btn_growth.Click += new System.EventHandler(this.Btn_growth_Click);
            // 
            // lbl_title_growth
            // 
            this.lbl_title_growth.AutoSize = true;
            this.lbl_title_growth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_title_growth.ForeColor = System.Drawing.Color.White;
            this.lbl_title_growth.Location = new System.Drawing.Point(13, 3);
            this.lbl_title_growth.Name = "lbl_title_growth";
            this.lbl_title_growth.Size = new System.Drawing.Size(46, 15);
            this.lbl_title_growth.TabIndex = 0;
            this.lbl_title_growth.Text = "Growth";
            // 
            // lbl_growth
            // 
            this.lbl_growth.AutoSize = true;
            this.lbl_growth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_growth.ForeColor = System.Drawing.Color.White;
            this.lbl_growth.Location = new System.Drawing.Point(14, 26);
            this.lbl_growth.Name = "lbl_growth";
            this.lbl_growth.Size = new System.Drawing.Size(35, 24);
            this.lbl_growth.TabIndex = 0;
            this.lbl_growth.Text = "0%";
            // 
            // panel_investments
            // 
            this.panel_investments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_investments.Controls.Add(this.btn_investments);
            this.panel_investments.Controls.Add(this.lbl_title_investment);
            this.panel_investments.Controls.Add(this.lbl_divider);
            this.panel_investments.Controls.Add(this.lbl_complete_investments);
            this.panel_investments.Controls.Add(this.lbl_investments);
            this.panel_investments.Location = new System.Drawing.Point(621, 143);
            this.panel_investments.Name = "panel_investments";
            this.panel_investments.Size = new System.Drawing.Size(200, 64);
            this.panel_investments.TabIndex = 0;
            // 
            // btn_investments
            // 
            this.btn_investments.BackColor = System.Drawing.Color.Transparent;
            this.btn_investments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_investments.BackgroundImage")));
            this.btn_investments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_investments.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_investments.FlatAppearance.BorderSize = 0;
            this.btn_investments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_investments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_investments.Location = new System.Drawing.Point(143, 0);
            this.btn_investments.Name = "btn_investments";
            this.btn_investments.Size = new System.Drawing.Size(57, 64);
            this.btn_investments.TabIndex = 3;
            this.btn_investments.UseVisualStyleBackColor = false;
            this.btn_investments.Click += new System.EventHandler(this.Btn_investments_Click);
            // 
            // lbl_title_investment
            // 
            this.lbl_title_investment.AutoSize = true;
            this.lbl_title_investment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_title_investment.ForeColor = System.Drawing.Color.White;
            this.lbl_title_investment.Location = new System.Drawing.Point(13, 3);
            this.lbl_title_investment.Name = "lbl_title_investment";
            this.lbl_title_investment.Size = new System.Drawing.Size(72, 15);
            this.lbl_title_investment.TabIndex = 0;
            this.lbl_title_investment.Text = "Investments";
            // 
            // lbl_divider
            // 
            this.lbl_divider.AutoSize = true;
            this.lbl_divider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_divider.ForeColor = System.Drawing.Color.White;
            this.lbl_divider.Location = new System.Drawing.Point(42, 29);
            this.lbl_divider.Name = "lbl_divider";
            this.lbl_divider.Size = new System.Drawing.Size(15, 24);
            this.lbl_divider.TabIndex = 0;
            this.lbl_divider.Text = "/";
            // 
            // lbl_complete_investments
            // 
            this.lbl_complete_investments.AutoSize = true;
            this.lbl_complete_investments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_complete_investments.ForeColor = System.Drawing.Color.White;
            this.lbl_complete_investments.Location = new System.Drawing.Point(14, 29);
            this.lbl_complete_investments.Name = "lbl_complete_investments";
            this.lbl_complete_investments.Size = new System.Drawing.Size(20, 24);
            this.lbl_complete_investments.TabIndex = 0;
            this.lbl_complete_investments.Text = "0";
            // 
            // lbl_investments
            // 
            this.lbl_investments.AutoSize = true;
            this.lbl_investments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_investments.ForeColor = System.Drawing.Color.White;
            this.lbl_investments.Location = new System.Drawing.Point(65, 29);
            this.lbl_investments.Name = "lbl_investments";
            this.lbl_investments.Size = new System.Drawing.Size(20, 24);
            this.lbl_investments.TabIndex = 0;
            this.lbl_investments.Text = "0";
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel_nav.Controls.Add(this.flowLayoutPanel1);
            this.panel_nav.Controls.Add(this.picbox_image);
            this.panel_nav.Controls.Add(this.panel_owner);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(20, 60);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(206, 576);
            this.panel_nav.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_plus);
            this.flowLayoutPanel1.Controls.Add(this.btn_minus);
            this.flowLayoutPanel1.Controls.Add(this.btn_refresh);
            this.flowLayoutPanel1.Controls.Add(this.btn_reset);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 192);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Segoe UI", 26.25F);
            this.btn_plus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_plus.Location = new System.Drawing.Point(3, 3);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(95, 88);
            this.btn_plus.TabIndex = 2;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Segoe UI", 26.25F);
            this.btn_minus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_minus.Location = new System.Drawing.Point(104, 3);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(95, 88);
            this.btn_minus.TabIndex = 3;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(3, 97);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(95, 88);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.Location = new System.Drawing.Point(104, 97);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(95, 88);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // picbox_image
            // 
            this.picbox_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.picbox_image.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbox_image.ErrorImage")));
            this.picbox_image.Image = ((System.Drawing.Image)(resources.GetObject("picbox_image.Image")));
            this.picbox_image.Location = new System.Drawing.Point(0, 0);
            this.picbox_image.Name = "picbox_image";
            this.picbox_image.Size = new System.Drawing.Size(206, 213);
            this.picbox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_image.TabIndex = 5;
            this.picbox_image.TabStop = false;
            this.picbox_image.Click += new System.EventHandler(this.Picbox_image_Click);
            // 
            // panel_owner
            // 
            this.panel_owner.Controls.Add(this.btn_owner);
            this.panel_owner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_owner.Location = new System.Drawing.Point(0, 541);
            this.panel_owner.Name = "panel_owner";
            this.panel_owner.Size = new System.Drawing.Size(206, 35);
            this.panel_owner.TabIndex = 4;
            // 
            // btn_owner
            // 
            this.btn_owner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_owner.FlatAppearance.BorderSize = 0;
            this.btn_owner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_owner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_owner.ForeColor = System.Drawing.Color.Gray;
            this.btn_owner.Location = new System.Drawing.Point(0, 6);
            this.btn_owner.Name = "btn_owner";
            this.btn_owner.Size = new System.Drawing.Size(206, 29);
            this.btn_owner.TabIndex = 6;
            this.btn_owner.Text = "Owner";
            this.btn_owner.UseVisualStyleBackColor = true;
            this.btn_owner.Click += new System.EventHandler(this.Btn_owner_Click);
            // 
            // splitContainer_charts
            // 
            this.splitContainer_charts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_charts.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_charts.Name = "splitContainer_charts";
            this.splitContainer_charts.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_charts.Panel1
            // 
            this.splitContainer_charts.Panel1.Controls.Add(this.panel_income);
            // 
            // splitContainer_charts.Panel2
            // 
            this.splitContainer_charts.Panel2.Controls.Add(this.panel_expenditure);
            this.splitContainer_charts.Size = new System.Drawing.Size(303, 363);
            this.splitContainer_charts.SplitterDistance = 182;
            this.splitContainer_charts.TabIndex = 14;
            // 
            // splitContainer_dataCharts
            // 
            this.splitContainer_dataCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_dataCharts.Location = new System.Drawing.Point(226, 273);
            this.splitContainer_dataCharts.Name = "splitContainer_dataCharts";
            // 
            // splitContainer_dataCharts.Panel1
            // 
            this.splitContainer_dataCharts.Panel1.Controls.Add(this.panel_transactions);
            // 
            // splitContainer_dataCharts.Panel2
            // 
            this.splitContainer_dataCharts.Panel2.Controls.Add(this.splitContainer_charts);
            this.splitContainer_dataCharts.Size = new System.Drawing.Size(840, 363);
            this.splitContainer_dataCharts.SplitterDistance = 533;
            this.splitContainer_dataCharts.TabIndex = 15;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1086, 656);
            this.ContextMenuStrip = this.menuUI;
            this.Controls.Add(this.splitContainer_dataCharts);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "SpendWise";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.menuTransactions.ResumeLayout(false);
            this.panel_income.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_income)).EndInit();
            this.panel_expenditure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_expenditure)).EndInit();
            this.menuUI.ResumeLayout(false);
            this.panel_transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_transactions)).EndInit();
            this.panel_money.ResumeLayout(false);
            this.panel_money.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_amount.ResumeLayout(false);
            this.panel_amount.PerformLayout();
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.panel_savings.ResumeLayout(false);
            this.panel_savings.PerformLayout();
            this.panel_overal_income.ResumeLayout(false);
            this.panel_overal_income.PerformLayout();
            this.panel_overall_expenditure.ResumeLayout(false);
            this.panel_overall_expenditure.PerformLayout();
            this.panel_total_saved.ResumeLayout(false);
            this.panel_total_saved.PerformLayout();
            this.panel_frequency.ResumeLayout(false);
            this.panel_frequency.PerformLayout();
            this.panel_date.ResumeLayout(false);
            this.panel_date.PerformLayout();
            this.panel_month.ResumeLayout(false);
            this.panel_month.PerformLayout();
            this.panel_growth.ResumeLayout(false);
            this.panel_growth.PerformLayout();
            this.panel_investments.ResumeLayout(false);
            this.panel_investments.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_image)).EndInit();
            this.panel_owner.ResumeLayout(false);
            this.splitContainer_charts.Panel1.ResumeLayout(false);
            this.splitContainer_charts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_charts)).EndInit();
            this.splitContainer_charts.ResumeLayout(false);
            this.splitContainer_dataCharts.Panel1.ResumeLayout(false);
            this.splitContainer_dataCharts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_dataCharts)).EndInit();
            this.splitContainer_dataCharts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_income;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_income;
        private System.Windows.Forms.Panel panel_expenditure;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_expenditure;
        public System.Windows.Forms.Label lbl_currency;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Label lbl_expenditure;
        private System.Windows.Forms.Label lbl_common;
        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.Label lbl_least;
        private System.Windows.Forms.Label lbl_lst;
        public System.Windows.Forms.Label lbl_money;
        public System.Windows.Forms.Label lbl_savings;
        private System.Windows.Forms.Label lbl_saved;
        private System.Windows.Forms.ComboBox txt_desc;
        private System.Windows.Forms.Button btn_savings;
        private System.Windows.Forms.Button btn_money;
        private MetroFramework.Controls.MetroContextMenu menuTransactions;
        private System.Windows.Forms.ToolStripMenuItem item_remove;
        private MetroFramework.Controls.MetroDateTime date_select;
        private MetroFramework.Controls.MetroComboBox cmb_month;
        private MetroFramework.Controls.MetroTextBox txt_amount;
        private System.Windows.Forms.ContextMenuStrip menuUI;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel_transactions;
        public System.Windows.Forms.DataGridView data_transactions;
        private System.Windows.Forms.Panel panel_money;
        private System.Windows.Forms.FlowLayoutPanel panel_top;
        private System.Windows.Forms.Panel panel_savings;
        public System.Windows.Forms.Label lbl_title_savings;
        private System.Windows.Forms.Panel panel_overal_income;
        public System.Windows.Forms.Label lbl_title_income;
        private System.Windows.Forms.Panel panel_overall_expenditure;
        public System.Windows.Forms.Label lbl_title_expenditure;
        private System.Windows.Forms.Panel panel_total_saved;
        public System.Windows.Forms.Label lbl_title_saved;
        private System.Windows.Forms.Panel panel_frequency;
        private System.Windows.Forms.Panel panel_input;
        private System.Windows.Forms.Panel panel_date;
        private System.Windows.Forms.Panel panel_month;
        public System.Windows.Forms.Label lbl_title_date;
        public System.Windows.Forms.Label lbl_title_month;
        private System.Windows.Forms.Panel panel_amount;
        public System.Windows.Forms.Label lbl_title_amount;
        public System.Windows.Forms.Label lbl_title_transactions;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Panel panel_owner;
        private System.Windows.Forms.PictureBox picbox_image;
        private System.Windows.Forms.SplitContainer splitContainer_charts;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_owner;
        private System.Windows.Forms.SplitContainer splitContainer_dataCharts;
        private System.Windows.Forms.Panel panel_growth;
        public System.Windows.Forms.Label lbl_title_growth;
        private System.Windows.Forms.Panel panel_investments;
        public System.Windows.Forms.Label lbl_title_investment;
        private System.Windows.Forms.Button btn_growth;
        private System.Windows.Forms.Label lbl_growth;
        private System.Windows.Forms.Button btn_investments;
        private System.Windows.Forms.Label lbl_investments;
        private System.Windows.Forms.Button btn_income;
        private System.Windows.Forms.Button btn_expenditure;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_divider;
        private System.Windows.Forms.Label lbl_complete_investments;
        private System.Windows.Forms.Button btn_saved;
    }
}

