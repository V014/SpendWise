namespace SpendWise
{
    partial class Currency
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.txt_currency = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.txt_currency);
            this.panel_main.Controls.Add(this.btn_save);
            this.panel_main.Controls.Add(this.lbl_title);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(20, 60);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(241, 173);
            this.panel_main.TabIndex = 1;
            // 
            // txt_currency
            // 
            this.txt_currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_currency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_currency.Font = new System.Drawing.Font("Roboto", 11F);
            this.txt_currency.ForeColor = System.Drawing.Color.Gray;
            this.txt_currency.FormattingEnabled = true;
            this.txt_currency.Items.AddRange(new object[] {
            "₹ Indian Rupee",
            "£ British Pound",
            "$ United States Dollar",
            "€ European Euro",
            "MWK Malawian Kwacha"});
            this.txt_currency.Location = new System.Drawing.Point(8, 54);
            this.txt_currency.Name = "txt_currency";
            this.txt_currency.Size = new System.Drawing.Size(230, 26);
            this.txt_currency.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(94)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Roboto", 11F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(0, 116);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(239, 44);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Roboto", 16F);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(3, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(137, 27);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Select below";
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 253);
            this.Controls.Add(this.panel_main);
            this.Name = "Currency";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Currency";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox txt_currency;
    }
}