namespace SpendWise
{
    partial class Expenditure
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_expenditure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_expenditure)).BeginInit();
            this.SuspendLayout();
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
            this.chart_expenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.chart_expenditure.Legends.Add(legend2);
            this.chart_expenditure.Location = new System.Drawing.Point(20, 60);
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
            this.chart_expenditure.Size = new System.Drawing.Size(460, 420);
            this.chart_expenditure.TabIndex = 3;
            this.chart_expenditure.Text = "chart1";
            // 
            // Expenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.chart_expenditure);
            this.Name = "Expenditure";
            this.Opacity = 0.96D;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Expenditure";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.chart_expenditure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart_expenditure;
    }
}