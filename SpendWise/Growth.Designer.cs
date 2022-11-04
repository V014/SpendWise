namespace SpendWise
{
    partial class Growth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Growth));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_title_bv = new System.Windows.Forms.Label();
            this.lbl_bv = new System.Windows.Forms.Label();
            this.lbl_title_ev = new System.Windows.Forms.Label();
            this.lbl_ev = new System.Windows.Forms.Label();
            this.lbl_title_years = new System.Windows.Forms.Label();
            this.lbl_years = new System.Windows.Forms.Label();
            this.lbl_title_CAGR = new System.Windows.Forms.Label();
            this.lbl_CAGR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(343, 245);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbl_CAGR);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_years);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ev);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_bv);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_title_CAGR);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_title_years);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_title_ev);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_title_bv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(697, 245);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 1;
            // 
            // lbl_title_bv
            // 
            this.lbl_title_bv.AutoSize = true;
            this.lbl_title_bv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_title_bv.ForeColor = System.Drawing.Color.White;
            this.lbl_title_bv.Location = new System.Drawing.Point(3, 0);
            this.lbl_title_bv.Name = "lbl_title_bv";
            this.lbl_title_bv.Size = new System.Drawing.Size(141, 18);
            this.lbl_title_bv.TabIndex = 0;
            this.lbl_title_bv.Text = "Beginning value (Bv)";
            // 
            // lbl_bv
            // 
            this.lbl_bv.AutoSize = true;
            this.lbl_bv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_bv.ForeColor = System.Drawing.Color.White;
            this.lbl_bv.Location = new System.Drawing.Point(150, 0);
            this.lbl_bv.Name = "lbl_bv";
            this.lbl_bv.Size = new System.Drawing.Size(16, 18);
            this.lbl_bv.TabIndex = 0;
            this.lbl_bv.Text = "0";
            // 
            // lbl_title_ev
            // 
            this.lbl_title_ev.AutoSize = true;
            this.lbl_title_ev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_title_ev.ForeColor = System.Drawing.Color.White;
            this.lbl_title_ev.Location = new System.Drawing.Point(3, 37);
            this.lbl_title_ev.Name = "lbl_title_ev";
            this.lbl_title_ev.Size = new System.Drawing.Size(122, 18);
            this.lbl_title_ev.TabIndex = 0;
            this.lbl_title_ev.Text = "Ending value (Ev)";
            // 
            // lbl_ev
            // 
            this.lbl_ev.AutoSize = true;
            this.lbl_ev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_ev.ForeColor = System.Drawing.Color.White;
            this.lbl_ev.Location = new System.Drawing.Point(150, 37);
            this.lbl_ev.Name = "lbl_ev";
            this.lbl_ev.Size = new System.Drawing.Size(16, 18);
            this.lbl_ev.TabIndex = 0;
            this.lbl_ev.Text = "0";
            // 
            // lbl_title_years
            // 
            this.lbl_title_years.AutoSize = true;
            this.lbl_title_years.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_title_years.ForeColor = System.Drawing.Color.White;
            this.lbl_title_years.Location = new System.Drawing.Point(3, 78);
            this.lbl_title_years.Name = "lbl_title_years";
            this.lbl_title_years.Size = new System.Drawing.Size(46, 18);
            this.lbl_title_years.TabIndex = 0;
            this.lbl_title_years.Text = "Years";
            // 
            // lbl_years
            // 
            this.lbl_years.AutoSize = true;
            this.lbl_years.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_years.ForeColor = System.Drawing.Color.White;
            this.lbl_years.Location = new System.Drawing.Point(150, 78);
            this.lbl_years.Name = "lbl_years";
            this.lbl_years.Size = new System.Drawing.Size(16, 18);
            this.lbl_years.TabIndex = 0;
            this.lbl_years.Text = "0";
            // 
            // lbl_title_CAGR
            // 
            this.lbl_title_CAGR.AutoSize = true;
            this.lbl_title_CAGR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_title_CAGR.ForeColor = System.Drawing.Color.White;
            this.lbl_title_CAGR.Location = new System.Drawing.Point(17, 210);
            this.lbl_title_CAGR.Name = "lbl_title_CAGR";
            this.lbl_title_CAGR.Size = new System.Drawing.Size(264, 18);
            this.lbl_title_CAGR.TabIndex = 0;
            this.lbl_title_CAGR.Text = "Compound annual growth rate( CAGR)";
            // 
            // lbl_CAGR
            // 
            this.lbl_CAGR.AutoSize = true;
            this.lbl_CAGR.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F);
            this.lbl_CAGR.ForeColor = System.Drawing.Color.White;
            this.lbl_CAGR.Location = new System.Drawing.Point(3, 113);
            this.lbl_CAGR.Name = "lbl_CAGR";
            this.lbl_CAGR.Size = new System.Drawing.Size(166, 97);
            this.lbl_CAGR.TabIndex = 0;
            this.lbl_CAGR.Text = "0%";
            // 
            // Growth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 325);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Growth";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Growth";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_CAGR;
        private System.Windows.Forms.Label lbl_years;
        private System.Windows.Forms.Label lbl_ev;
        private System.Windows.Forms.Label lbl_bv;
        private System.Windows.Forms.Label lbl_title_CAGR;
        private System.Windows.Forms.Label lbl_title_years;
        private System.Windows.Forms.Label lbl_title_ev;
        private System.Windows.Forms.Label lbl_title_bv;
    }
}