namespace SpendWise
{
    partial class Edit
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.ComboBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_plus = new System.Windows.Forms.RadioButton();
            this.radio_minus = new System.Windows.Forms.RadioButton();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.radio_minus);
            this.panel_main.Controls.Add(this.radio_plus);
            this.panel_main.Controls.Add(this.txt_desc);
            this.panel_main.Controls.Add(this.txt_amount);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.lbl_description);
            this.panel_main.Controls.Add(this.lbl_amount);
            this.panel_main.Controls.Add(this.btn_edit);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(20, 60);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(245, 311);
            this.panel_main.TabIndex = 1;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(94)))));
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Roboto", 11F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(0, 267);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(245, 44);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_desc.Font = new System.Drawing.Font("Roboto", 14F);
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
            this.txt_desc.Location = new System.Drawing.Point(9, 138);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(229, 31);
            this.txt_desc.TabIndex = 9;
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amount.Font = new System.Drawing.Font("Roboto", 14F);
            this.txt_amount.ForeColor = System.Drawing.Color.Gray;
            this.txt_amount.Location = new System.Drawing.Point(9, 46);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(229, 30);
            this.txt_amount.TabIndex = 8;
            this.txt_amount.Text = "0.00";
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Roboto", 20F);
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(3, 88);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(152, 33);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Description";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Roboto", 20F);
            this.lbl_amount.ForeColor = System.Drawing.Color.White;
            this.lbl_amount.Location = new System.Drawing.Point(3, 0);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(111, 33);
            this.lbl_amount.TabIndex = 7;
            this.lbl_amount.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Action";
            // 
            // radio_plus
            // 
            this.radio_plus.AutoSize = true;
            this.radio_plus.Font = new System.Drawing.Font("Roboto", 14F);
            this.radio_plus.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.radio_plus.Location = new System.Drawing.Point(9, 228);
            this.radio_plus.Name = "radio_plus";
            this.radio_plus.Size = new System.Drawing.Size(39, 27);
            this.radio_plus.TabIndex = 10;
            this.radio_plus.TabStop = true;
            this.radio_plus.Text = "+";
            this.radio_plus.UseVisualStyleBackColor = true;
            // 
            // radio_minus
            // 
            this.radio_minus.AutoSize = true;
            this.radio_minus.Font = new System.Drawing.Font("Roboto", 14F);
            this.radio_minus.ForeColor = System.Drawing.Color.Crimson;
            this.radio_minus.Location = new System.Drawing.Point(57, 228);
            this.radio_minus.Name = "radio_minus";
            this.radio_minus.Size = new System.Drawing.Size(33, 27);
            this.radio_minus.TabIndex = 10;
            this.radio_minus.TabStop = true;
            this.radio_minus.Text = "-";
            this.radio_minus.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 391);
            this.Controls.Add(this.panel_main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit ";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox txt_desc;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_minus;
        private System.Windows.Forms.RadioButton radio_plus;
    }
}