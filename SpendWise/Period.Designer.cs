namespace SpendWise
{
    partial class Period
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
            this.label1 = new System.Windows.Forms.Label();
            this.date_from = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.date_till = new MetroFramework.Controls.MetroDateTime();
            this.btn_apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting from";
            // 
            // date_from
            // 
            this.date_from.Location = new System.Drawing.Point(27, 93);
            this.date_from.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(209, 29);
            this.date_from.Style = MetroFramework.MetroColorStyle.Green;
            this.date_from.TabIndex = 0;
            this.date_from.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Up till ";
            // 
            // date_till
            // 
            this.date_till.Location = new System.Drawing.Point(31, 184);
            this.date_till.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_till.Name = "date_till";
            this.date_till.Size = new System.Drawing.Size(209, 29);
            this.date_till.Style = MetroFramework.MetroColorStyle.Green;
            this.date_till.TabIndex = 1;
            this.date_till.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(94)))));
            this.btn_apply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_apply.FlatAppearance.BorderSize = 0;
            this.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_apply.ForeColor = System.Drawing.Color.White;
            this.btn_apply.Location = new System.Drawing.Point(20, 241);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(223, 44);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = false;
            // 
            // Period
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 305);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.date_till);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_from);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Period";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Period";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime date_from;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime date_till;
        private System.Windows.Forms.Button btn_apply;
    }
}