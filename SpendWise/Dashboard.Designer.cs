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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_input = new System.Windows.Forms.Panel();
            this.txt_desc = new System.Windows.Forms.ComboBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.panel_wallet = new System.Windows.Forms.Panel();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            this.pictureBox_money = new System.Windows.Forms.PictureBox();
            this.lbl_wallet = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.panel_transactions = new System.Windows.Forms.Panel();
            this.data_transactions = new System.Windows.Forms.DataGridView();
            this.btn_trash = new System.Windows.Forms.Button();
            this.panel_income = new System.Windows.Forms.Panel();
            this.chart_income = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_expenditure = new System.Windows.Forms.Panel();
            this.chart_expenditure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_overall = new System.Windows.Forms.Panel();
            this.chart_overall = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_info = new System.Windows.Forms.Panel();
            this.lbl_least = new System.Windows.Forms.Label();
            this.lbl_common = new System.Windows.Forms.Label();
            this.lbl_expenditure = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.lbl_lst = new System.Windows.Forms.Label();
            this.lbl_com = new System.Windows.Forms.Label();
            this.lbl_ex = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_in = new System.Windows.Forms.Label();
            this.lbl_owner = new System.Windows.Forms.Label();
            this.panel_owner = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel_controls = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_data = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_transControls = new System.Windows.Forms.Panel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel_input.SuspendLayout();
            this.panel_wallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money)).BeginInit();
            this.panel_settings.SuspendLayout();
            this.panel_transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_transactions)).BeginInit();
            this.panel_income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_income)).BeginInit();
            this.panel_expenditure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_expenditure)).BeginInit();
            this.panel_overall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_overall)).BeginInit();
            this.panel_info.SuspendLayout();
            this.panel_owner.SuspendLayout();
            this.panel_controls.SuspendLayout();
            this.panel_data.SuspendLayout();
            this.panel_transControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_input
            // 
            this.panel_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel_input.Controls.Add(this.txt_desc);
            this.panel_input.Controls.Add(this.txt_amount);
            this.panel_input.Controls.Add(this.lbl_description);
            this.panel_input.Controls.Add(this.lbl_amount);
            this.panel_input.Location = new System.Drawing.Point(3, 3);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(211, 200);
            this.panel_input.TabIndex = 3;
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_desc.ForeColor = System.Drawing.Color.Gray;
            this.txt_desc.FormattingEnabled = true;
            this.txt_desc.Items.AddRange(new object[] {
            "Hand out",
            "Transport",
            "Food",
            "Phone bill ",
            "Utility bill",
            "Accessories",
            "Medication",
            "Education",
            "Hobby",
            "Religion",
            "Family",
            "Friend",
            "Work",
            "Business",
            "Games",
            "Fun",
            "Forgotten"});
            this.txt_desc.Location = new System.Drawing.Point(9, 141);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(189, 32);
            this.txt_desc.TabIndex = 5;
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_amount.ForeColor = System.Drawing.Color.Gray;
            this.txt_amount.Location = new System.Drawing.Point(9, 49);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(189, 30);
            this.txt_amount.TabIndex = 4;
            this.txt_amount.Text = "0.00";
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(3, 91);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(151, 31);
            this.lbl_description.TabIndex = 0;
            this.lbl_description.Text = "Description";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_amount.ForeColor = System.Drawing.Color.White;
            this.lbl_amount.Location = new System.Drawing.Point(3, 3);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(107, 31);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "Amount";
            // 
            // panel_wallet
            // 
            this.panel_wallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_wallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel_wallet.Controls.Add(this.lbl_currency);
            this.panel_wallet.Controls.Add(this.lbl_money);
            this.panel_wallet.Controls.Add(this.pictureBox_money);
            this.panel_wallet.Controls.Add(this.lbl_wallet);
            this.panel_wallet.Location = new System.Drawing.Point(220, 3);
            this.panel_wallet.Name = "panel_wallet";
            this.panel_wallet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_wallet.Size = new System.Drawing.Size(211, 200);
            this.panel_wallet.TabIndex = 1;
            // 
            // lbl_currency
            // 
            this.lbl_currency.AutoSize = true;
            this.lbl_currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_currency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(94)))));
            this.lbl_currency.Location = new System.Drawing.Point(9, 48);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(55, 15);
            this.lbl_currency.TabIndex = 0;
            this.lbl_currency.Text = "Currency";
            this.lbl_currency.Click += new System.EventHandler(this.lbl_currency_Click);
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(94)))));
            this.lbl_money.Location = new System.Drawing.Point(3, 155);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(67, 31);
            this.lbl_money.TabIndex = 0;
            this.lbl_money.Text = "0.00";
            // 
            // pictureBox_money
            // 
            this.pictureBox_money.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_money.Image")));
            this.pictureBox_money.Location = new System.Drawing.Point(3, 58);
            this.pictureBox_money.Name = "pictureBox_money";
            this.pictureBox_money.Size = new System.Drawing.Size(95, 94);
            this.pictureBox_money.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_money.TabIndex = 1;
            this.pictureBox_money.TabStop = false;
            // 
            // lbl_wallet
            // 
            this.lbl_wallet.AutoSize = true;
            this.lbl_wallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_wallet.ForeColor = System.Drawing.Color.White;
            this.lbl_wallet.Location = new System.Drawing.Point(3, 3);
            this.lbl_wallet.Name = "lbl_wallet";
            this.lbl_wallet.Size = new System.Drawing.Size(89, 31);
            this.lbl_wallet.TabIndex = 0;
            this.lbl_wallet.Text = "Wallet";
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.btn_plus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_plus.Location = new System.Drawing.Point(437, 3);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(211, 200);
            this.btn_plus.TabIndex = 2;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.btn_minus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_minus.Location = new System.Drawing.Point(654, 3);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(211, 200);
            this.btn_minus.TabIndex = 2;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // panel_settings
            // 
            this.panel_settings.Controls.Add(this.btn_export);
            this.panel_settings.Controls.Add(this.btn_import);
            this.panel_settings.Controls.Add(this.btn_reset);
            this.panel_settings.Controls.Add(this.btn_about);
            this.panel_settings.Location = new System.Drawing.Point(1088, 3);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(211, 200);
            this.panel_settings.TabIndex = 5;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_export.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Image = ((System.Drawing.Image)(resources.GetObject("btn_export.Image")));
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.Location = new System.Drawing.Point(0, 150);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(211, 50);
            this.btn_export.TabIndex = 5;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_import.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_import.FlatAppearance.BorderSize = 0;
            this.btn_import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Image = ((System.Drawing.Image)(resources.GetObject("btn_import.Image")));
            this.btn_import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_import.Location = new System.Drawing.Point(0, 100);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(211, 50);
            this.btn_import.TabIndex = 4;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(0, 50);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(211, 50);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Image = ((System.Drawing.Image)(resources.GetObject("btn_about.Image")));
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.Location = new System.Drawing.Point(0, 0);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(211, 50);
            this.btn_about.TabIndex = 2;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // panel_transactions
            // 
            this.panel_transactions.BackColor = System.Drawing.Color.Transparent;
            this.panel_transactions.Controls.Add(this.data_transactions);
            this.panel_transactions.Controls.Add(this.panel_transControls);
            this.panel_transactions.Location = new System.Drawing.Point(3, 3);
            this.panel_transactions.Name = "panel_transactions";
            this.panel_transactions.Size = new System.Drawing.Size(428, 400);
            this.panel_transactions.TabIndex = 4;
            // 
            // data_transactions
            // 
            this.data_transactions.AllowUserToAddRows = false;
            this.data_transactions.AllowUserToDeleteRows = false;
            this.data_transactions.AllowUserToResizeRows = false;
            this.data_transactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_transactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_transactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_transactions.Location = new System.Drawing.Point(0, 0);
            this.data_transactions.Name = "data_transactions";
            this.data_transactions.ReadOnly = true;
            this.data_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_transactions.Size = new System.Drawing.Size(428, 350);
            this.data_transactions.TabIndex = 0;
            this.data_transactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_transactions_CellClick);
            // 
            // btn_trash
            // 
            this.btn_trash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_trash.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_trash.FlatAppearance.BorderSize = 0;
            this.btn_trash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_trash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trash.Image = ((System.Drawing.Image)(resources.GetObject("btn_trash.Image")));
            this.btn_trash.Location = new System.Drawing.Point(0, 0);
            this.btn_trash.Name = "btn_trash";
            this.btn_trash.Size = new System.Drawing.Size(211, 50);
            this.btn_trash.TabIndex = 1;
            this.btn_trash.UseVisualStyleBackColor = false;
            this.btn_trash.Click += new System.EventHandler(this.btn_trash_Click);
            // 
            // panel_income
            // 
            this.panel_income.BackColor = System.Drawing.Color.Transparent;
            this.panel_income.Controls.Add(this.chart_income);
            this.panel_income.Location = new System.Drawing.Point(437, 3);
            this.panel_income.Name = "panel_income";
            this.panel_income.Size = new System.Drawing.Size(428, 400);
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
            chartArea10.Area3DStyle.Inclination = 2;
            chartArea10.Area3DStyle.IsRightAngleAxes = false;
            chartArea10.Area3DStyle.Perspective = 20;
            chartArea10.Area3DStyle.Rotation = 5;
            chartArea10.Area3DStyle.WallWidth = 20;
            chartArea10.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea10.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea10.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea10.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea10.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea10.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea10.BackColor = System.Drawing.Color.Transparent;
            chartArea10.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea10.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea10.BorderColor = System.Drawing.Color.Empty;
            chartArea10.BorderWidth = 0;
            chartArea10.Name = "ChartArea1";
            chartArea10.Position.Auto = false;
            chartArea10.Position.Height = 94F;
            chartArea10.Position.Width = 94F;
            chartArea10.Position.X = 3F;
            chartArea10.Position.Y = 3F;
            chartArea10.ShadowOffset = 20;
            this.chart_income.ChartAreas.Add(chartArea10);
            this.chart_income.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chart_income.Legends.Add(legend10);
            this.chart_income.Location = new System.Drawing.Point(0, 0);
            this.chart_income.Name = "chart_income";
            this.chart_income.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series13.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series13.BackSecondaryColor = System.Drawing.Color.DarkGreen;
            series13.BorderWidth = 0;
            series13.ChartArea = "ChartArea1";
            series13.Color = System.Drawing.Color.LimeGreen;
            series13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            series13.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series13.LabelForeColor = System.Drawing.Color.Empty;
            series13.Legend = "Legend1";
            series13.Name = "In";
            series13.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series13.ShadowOffset = 6;
            this.chart_income.Series.Add(series13);
            this.chart_income.Size = new System.Drawing.Size(428, 400);
            this.chart_income.TabIndex = 2;
            this.chart_income.Text = "chart1";
            // 
            // panel_expenditure
            // 
            this.panel_expenditure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel_expenditure.Controls.Add(this.chart_expenditure);
            this.panel_expenditure.Location = new System.Drawing.Point(871, 3);
            this.panel_expenditure.Name = "panel_expenditure";
            this.panel_expenditure.Size = new System.Drawing.Size(428, 400);
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
            chartArea11.Area3DStyle.Inclination = 2;
            chartArea11.Area3DStyle.IsRightAngleAxes = false;
            chartArea11.Area3DStyle.Perspective = 20;
            chartArea11.Area3DStyle.Rotation = 5;
            chartArea11.Area3DStyle.WallWidth = 20;
            chartArea11.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea11.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea11.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea11.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea11.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea11.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea11.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea11.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea11.BackColor = System.Drawing.Color.Transparent;
            chartArea11.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea11.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea11.BorderColor = System.Drawing.Color.Empty;
            chartArea11.BorderWidth = 0;
            chartArea11.Name = "ChartArea1";
            chartArea11.Position.Auto = false;
            chartArea11.Position.Height = 94F;
            chartArea11.Position.Width = 94F;
            chartArea11.Position.X = 3F;
            chartArea11.Position.Y = 3F;
            chartArea11.ShadowOffset = 20;
            this.chart_expenditure.ChartAreas.Add(chartArea11);
            this.chart_expenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            legend11.Name = "Legend1";
            this.chart_expenditure.Legends.Add(legend11);
            this.chart_expenditure.Location = new System.Drawing.Point(0, 0);
            this.chart_expenditure.Name = "chart_expenditure";
            this.chart_expenditure.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series14.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series14.BackSecondaryColor = System.Drawing.Color.Red;
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Out";
            series14.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series14.ShadowOffset = 6;
            this.chart_expenditure.Series.Add(series14);
            this.chart_expenditure.Size = new System.Drawing.Size(428, 400);
            this.chart_expenditure.TabIndex = 2;
            this.chart_expenditure.Text = "chart1";
            // 
            // panel_overall
            // 
            this.panel_overall.BackColor = System.Drawing.Color.Transparent;
            this.panel_overall.Controls.Add(this.chart_overall);
            this.panel_overall.Location = new System.Drawing.Point(3, 409);
            this.panel_overall.Name = "panel_overall";
            this.panel_overall.Size = new System.Drawing.Size(211, 200);
            this.panel_overall.TabIndex = 5;
            this.panel_overall.Visible = false;
            // 
            // chart_overall
            // 
            this.chart_overall.BackColor = System.Drawing.Color.Transparent;
            this.chart_overall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_overall.BorderlineColor = System.Drawing.Color.Empty;
            this.chart_overall.BorderlineWidth = 0;
            this.chart_overall.BorderSkin.BackColor = System.Drawing.Color.Empty;
            this.chart_overall.BorderSkin.BorderWidth = 0;
            chartArea12.Area3DStyle.Inclination = 2;
            chartArea12.Area3DStyle.IsRightAngleAxes = false;
            chartArea12.Area3DStyle.Perspective = 20;
            chartArea12.Area3DStyle.Rotation = 5;
            chartArea12.Area3DStyle.WallWidth = 20;
            chartArea12.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea12.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea12.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea12.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea12.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea12.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea12.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea12.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea12.BackColor = System.Drawing.Color.Transparent;
            chartArea12.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea12.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea12.BorderColor = System.Drawing.Color.Empty;
            chartArea12.BorderWidth = 0;
            chartArea12.Name = "ChartArea1";
            chartArea12.Position.Auto = false;
            chartArea12.Position.Height = 94F;
            chartArea12.Position.Width = 94F;
            chartArea12.Position.X = 3F;
            chartArea12.Position.Y = 3F;
            chartArea12.ShadowOffset = 20;
            this.chart_overall.ChartAreas.Add(chartArea12);
            this.chart_overall.Dock = System.Windows.Forms.DockStyle.Fill;
            legend12.BackColor = System.Drawing.Color.Transparent;
            legend12.ForeColor = System.Drawing.Color.White;
            legend12.Name = "Legend1";
            this.chart_overall.Legends.Add(legend12);
            this.chart_overall.Location = new System.Drawing.Point(0, 0);
            this.chart_overall.Name = "chart_overall";
            this.chart_overall.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series15.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series15.BackSecondaryColor = System.Drawing.Color.DarkGreen;
            series15.BorderWidth = 0;
            series15.ChartArea = "ChartArea1";
            series15.Color = System.Drawing.Color.LimeGreen;
            series15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            series15.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series15.LabelForeColor = System.Drawing.Color.Empty;
            series15.Legend = "Legend1";
            series15.Name = "In";
            series15.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series15.ShadowOffset = 6;
            series16.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series16.BackSecondaryColor = System.Drawing.Color.Red;
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Out";
            series16.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart_overall.Series.Add(series15);
            this.chart_overall.Series.Add(series16);
            this.chart_overall.Size = new System.Drawing.Size(211, 200);
            this.chart_overall.TabIndex = 2;
            this.chart_overall.Text = "chart1";
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.Transparent;
            this.panel_info.Controls.Add(this.lbl_least);
            this.panel_info.Controls.Add(this.lbl_common);
            this.panel_info.Controls.Add(this.lbl_expenditure);
            this.panel_info.Controls.Add(this.lbl_income);
            this.panel_info.Controls.Add(this.lbl_lst);
            this.panel_info.Controls.Add(this.lbl_com);
            this.panel_info.Controls.Add(this.lbl_ex);
            this.panel_info.Controls.Add(this.label4);
            this.panel_info.Controls.Add(this.lbl_in);
            this.panel_info.Location = new System.Drawing.Point(871, 3);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(211, 200);
            this.panel_info.TabIndex = 6;
            // 
            // lbl_least
            // 
            this.lbl_least.AutoSize = true;
            this.lbl_least.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_least.ForeColor = System.Drawing.Color.White;
            this.lbl_least.Location = new System.Drawing.Point(126, 159);
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
            this.lbl_common.Location = new System.Drawing.Point(126, 125);
            this.lbl_common.Name = "lbl_common";
            this.lbl_common.Size = new System.Drawing.Size(59, 15);
            this.lbl_common.TabIndex = 0;
            this.lbl_common.Text = "Unknown";
            // 
            // lbl_expenditure
            // 
            this.lbl_expenditure.AutoSize = true;
            this.lbl_expenditure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_expenditure.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_expenditure.Location = new System.Drawing.Point(126, 92);
            this.lbl_expenditure.Name = "lbl_expenditure";
            this.lbl_expenditure.Size = new System.Drawing.Size(31, 15);
            this.lbl_expenditure.TabIndex = 0;
            this.lbl_expenditure.Text = "0.00";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_income.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(94)))));
            this.lbl_income.Location = new System.Drawing.Point(126, 64);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(31, 15);
            this.lbl_income.TabIndex = 0;
            this.lbl_income.Text = "0.00";
            // 
            // lbl_lst
            // 
            this.lbl_lst.AutoSize = true;
            this.lbl_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_lst.ForeColor = System.Drawing.Color.White;
            this.lbl_lst.Location = new System.Drawing.Point(17, 159);
            this.lbl_lst.Name = "lbl_lst";
            this.lbl_lst.Size = new System.Drawing.Size(43, 15);
            this.lbl_lst.TabIndex = 0;
            this.lbl_lst.Text = "Least: ";
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_com.ForeColor = System.Drawing.Color.White;
            this.lbl_com.Location = new System.Drawing.Point(17, 125);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(61, 15);
            this.lbl_com.TabIndex = 0;
            this.lbl_com.Text = "Common:";
            // 
            // lbl_ex
            // 
            this.lbl_ex.AutoSize = true;
            this.lbl_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_ex.ForeColor = System.Drawing.Color.White;
            this.lbl_ex.Location = new System.Drawing.Point(17, 92);
            this.lbl_ex.Name = "lbl_ex";
            this.lbl_ex.Size = new System.Drawing.Size(76, 15);
            this.lbl_ex.TabIndex = 0;
            this.lbl_ex.Text = "Expenditure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Overall";
            // 
            // lbl_in
            // 
            this.lbl_in.AutoSize = true;
            this.lbl_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_in.ForeColor = System.Drawing.Color.White;
            this.lbl_in.Location = new System.Drawing.Point(17, 64);
            this.lbl_in.Name = "lbl_in";
            this.lbl_in.Size = new System.Drawing.Size(51, 15);
            this.lbl_in.TabIndex = 0;
            this.lbl_in.Text = "Income:";
            // 
            // lbl_owner
            // 
            this.lbl_owner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_owner.AutoSize = true;
            this.lbl_owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_owner.ForeColor = System.Drawing.Color.Gray;
            this.lbl_owner.Location = new System.Drawing.Point(147, 4);
            this.lbl_owner.Name = "lbl_owner";
            this.lbl_owner.Size = new System.Drawing.Size(52, 18);
            this.lbl_owner.TabIndex = 1;
            this.lbl_owner.Text = "Owner";
            this.lbl_owner.Click += new System.EventHandler(this.lbl_owner_Click);
            // 
            // panel_owner
            // 
            this.panel_owner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_owner.Controls.Add(this.btn_refresh);
            this.panel_owner.Controls.Add(this.lbl_owner);
            this.panel_owner.Location = new System.Drawing.Point(1089, 19);
            this.panel_owner.Name = "panel_owner";
            this.panel_owner.Size = new System.Drawing.Size(200, 35);
            this.panel_owner.TabIndex = 2;
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(97, 1);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(39, 30);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // panel_controls
            // 
            this.panel_controls.Controls.Add(this.panel_input);
            this.panel_controls.Controls.Add(this.panel_wallet);
            this.panel_controls.Controls.Add(this.btn_plus);
            this.panel_controls.Controls.Add(this.btn_minus);
            this.panel_controls.Controls.Add(this.panel_info);
            this.panel_controls.Controls.Add(this.panel_settings);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_controls.Location = new System.Drawing.Point(20, 60);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(1307, 209);
            this.panel_controls.TabIndex = 7;
            // 
            // panel_data
            // 
            this.panel_data.Controls.Add(this.panel_transactions);
            this.panel_data.Controls.Add(this.panel_income);
            this.panel_data.Controls.Add(this.panel_expenditure);
            this.panel_data.Controls.Add(this.panel_overall);
            this.panel_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_data.Location = new System.Drawing.Point(20, 269);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(1307, 408);
            this.panel_data.TabIndex = 8;
            // 
            // panel_transControls
            // 
            this.panel_transControls.Controls.Add(this.btn_edit);
            this.panel_transControls.Controls.Add(this.btn_trash);
            this.panel_transControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_transControls.Location = new System.Drawing.Point(0, 350);
            this.panel_transControls.Name = "panel_transControls";
            this.panel_transControls.Size = new System.Drawing.Size(428, 50);
            this.panel_transControls.TabIndex = 2;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(217, 0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(211, 50);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1347, 697);
            this.Controls.Add(this.panel_data);
            this.Controls.Add(this.panel_controls);
            this.Controls.Add(this.panel_owner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Opacity = 0.96D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "SpendWise";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.panel_wallet.ResumeLayout(false);
            this.panel_wallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money)).EndInit();
            this.panel_settings.ResumeLayout(false);
            this.panel_transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_transactions)).EndInit();
            this.panel_income.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_income)).EndInit();
            this.panel_expenditure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_expenditure)).EndInit();
            this.panel_overall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_overall)).EndInit();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.panel_owner.ResumeLayout(false);
            this.panel_owner.PerformLayout();
            this.panel_controls.ResumeLayout(false);
            this.panel_data.ResumeLayout(false);
            this.panel_transControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_wallet;
        private System.Windows.Forms.Label lbl_wallet;
        private System.Windows.Forms.PictureBox pictureBox_money;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Panel panel_input;
        private System.Windows.Forms.Panel panel_transactions;
        private System.Windows.Forms.Button btn_trash;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Panel panel_income;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_income;
        private System.Windows.Forms.Panel panel_expenditure;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_expenditure;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ComboBox txt_desc;
        public System.Windows.Forms.Label lbl_owner;
        public System.Windows.Forms.Label lbl_currency;
        private System.Windows.Forms.Panel panel_overall;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_overall;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Label lbl_in;
        private System.Windows.Forms.Label lbl_expenditure;
        private System.Windows.Forms.Label lbl_ex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_common;
        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.Label lbl_least;
        private System.Windows.Forms.Label lbl_lst;
        private System.Windows.Forms.Panel panel_owner;
        public System.Windows.Forms.Label lbl_money;
        public System.Windows.Forms.DataGridView data_transactions;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.FlowLayoutPanel panel_controls;
        private System.Windows.Forms.FlowLayoutPanel panel_data;
        private System.Windows.Forms.Panel panel_transControls;
        private System.Windows.Forms.Button btn_edit;
    }
}

