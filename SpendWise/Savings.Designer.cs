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
            this.TrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(94)))));
            this.btn_apply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_apply.FlatAppearance.BorderSize = 0;
            this.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Font = new System.Drawing.Font("Roboto", 11F);
            this.btn_apply.ForeColor = System.Drawing.Color.White;
            this.btn_apply.Location = new System.Drawing.Point(20, 242);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(233, 44);
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
            // TrackBar
            // 
            this.TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrackBar.Location = new System.Drawing.Point(20, 219);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(233, 23);
            this.TrackBar.Style = MetroFramework.MetroColorStyle.Green;
            this.TrackBar.TabIndex = 7;
            this.TrackBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TrackBar.Value = 0;
            this.TrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBar_Scroll);
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Font = new System.Drawing.Font("Roboto", 66F);
            this.lbl_percent.ForeColor = System.Drawing.Color.White;
            this.lbl_percent.Location = new System.Drawing.Point(23, 103);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(143, 106);
            this.lbl_percent.TabIndex = 3;
            this.lbl_percent.Text = "00";
            // 
            // Savings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 306);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.lbl_percent);
            this.Controls.Add(this.lbl_title);
            this.Name = "Savings";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Savings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label lbl_title;
        private MetroFramework.Controls.MetroTrackBar TrackBar;
        private System.Windows.Forms.Label lbl_percent;
    }
}