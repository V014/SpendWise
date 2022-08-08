namespace SpendWise
{
    partial class Income
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_income = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_income)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_income
            // 
            this.chart_income.BackColor = System.Drawing.Color.Transparent;
            this.chart_income.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_income.BorderlineColor = System.Drawing.Color.Empty;
            this.chart_income.BorderlineWidth = 0;
            this.chart_income.BorderSkin.BackColor = System.Drawing.Color.Empty;
            this.chart_income.BorderSkin.BorderWidth = 0;
            chartArea3.Area3DStyle.Inclination = 2;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.Perspective = 20;
            chartArea3.Area3DStyle.Rotation = 5;
            chartArea3.Area3DStyle.WallWidth = 20;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.Empty;
            chartArea3.BorderWidth = 0;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 94F;
            chartArea3.Position.Width = 94F;
            chartArea3.Position.X = 3F;
            chartArea3.Position.Y = 3F;
            chartArea3.ShadowOffset = 20;
            this.chart_income.ChartAreas.Add(chartArea3);
            this.chart_income.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.chart_income.Legends.Add(legend3);
            this.chart_income.Location = new System.Drawing.Point(20, 60);
            this.chart_income.Name = "chart_income";
            this.chart_income.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series3.BackSecondaryColor = System.Drawing.Color.DarkGreen;
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.LimeGreen;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.LabelForeColor = System.Drawing.Color.Empty;
            series3.Legend = "Legend1";
            series3.Name = "In";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ShadowOffset = 6;
            this.chart_income.Series.Add(series3);
            this.chart_income.Size = new System.Drawing.Size(460, 420);
            this.chart_income.TabIndex = 3;
            this.chart_income.Text = "chart1";
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.chart_income);
            this.Name = "Income";
            this.Opacity = 0.96D;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Income";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.chart_income)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart_income;
    }
}