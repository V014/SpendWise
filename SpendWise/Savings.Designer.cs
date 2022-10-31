namespace SpendWise
{
    partial class Savings
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
            this.btn_apply = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.scrollbar_savings_percentage = new MetroFramework.Controls.MetroScrollBar();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel_controls = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.panel_controls)).BeginInit();
            this.panel_controls.Panel1.SuspendLayout();
            this.panel_controls.Panel2.SuspendLayout();
            this.panel_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(94)))));
            this.btn_apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_apply.FlatAppearance.BorderSize = 0;
            this.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Font = new System.Drawing.Font("Roboto", 11F);
            this.btn_apply.ForeColor = System.Drawing.Color.White;
            this.btn_apply.Location = new System.Drawing.Point(0, 0);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(118, 40);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Roboto", 16F);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(23, 60);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Percentage";
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Font = new System.Drawing.Font("Roboto", 66F);
            this.lbl_percent.ForeColor = System.Drawing.Color.White;
            this.lbl_percent.Location = new System.Drawing.Point(23, 87);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(143, 106);
            this.lbl_percent.TabIndex = 3;
            this.lbl_percent.Text = "00";
            // 
            // scrollbar_savings_percentage
            // 
            this.scrollbar_savings_percentage.LargeChange = 10;
            this.scrollbar_savings_percentage.Location = new System.Drawing.Point(23, 212);
            this.scrollbar_savings_percentage.Maximum = 100;
            this.scrollbar_savings_percentage.Minimum = 0;
            this.scrollbar_savings_percentage.MouseWheelBarPartitions = 10;
            this.scrollbar_savings_percentage.Name = "scrollbar_savings_percentage";
            this.scrollbar_savings_percentage.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.scrollbar_savings_percentage.ScrollbarSize = 10;
            this.scrollbar_savings_percentage.Size = new System.Drawing.Size(227, 10);
            this.scrollbar_savings_percentage.Style = MetroFramework.MetroColorStyle.Green;
            this.scrollbar_savings_percentage.TabIndex = 6;
            this.scrollbar_savings_percentage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.scrollbar_savings_percentage.UseSelectable = true;
            this.scrollbar_savings_percentage.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scrollbar_savings_percentage_Scroll);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Roboto", 11F);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(0, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(111, 40);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // panel_controls
            // 
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controls.Location = new System.Drawing.Point(20, 246);
            this.panel_controls.Name = "panel_controls";
            // 
            // panel_controls.Panel1
            // 
            this.panel_controls.Panel1.Controls.Add(this.btn_apply);
            // 
            // panel_controls.Panel2
            // 
            this.panel_controls.Panel2.Controls.Add(this.btn_reset);
            this.panel_controls.Size = new System.Drawing.Size(233, 40);
            this.panel_controls.SplitterDistance = 118;
            this.panel_controls.TabIndex = 7;
            // 
            // Savings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 306);
            this.Controls.Add(this.panel_controls);
            this.Controls.Add(this.scrollbar_savings_percentage);
            this.Controls.Add(this.lbl_percent);
            this.Controls.Add(this.lbl_title);
            this.MaximizeBox = false;
            this.Name = "Savings";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Savings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_controls.Panel1.ResumeLayout(false);
            this.panel_controls.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_controls)).EndInit();
            this.panel_controls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_percent;
        private MetroFramework.Controls.MetroScrollBar scrollbar_savings_percentage;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.SplitContainer panel_controls;
    }
}