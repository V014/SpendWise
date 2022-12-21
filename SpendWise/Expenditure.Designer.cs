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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Data_expenditure = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data_expenditure)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_expenditure
            // 
            this.Data_expenditure.AllowUserToAddRows = false;
            this.Data_expenditure.AllowUserToDeleteRows = false;
            this.Data_expenditure.AllowUserToResizeColumns = false;
            this.Data_expenditure.AllowUserToResizeRows = false;
            this.Data_expenditure.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_expenditure.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Data_expenditure.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Data_expenditure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_expenditure.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Data_expenditure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_expenditure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Data_expenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_expenditure.Location = new System.Drawing.Point(10, 10);
            this.Data_expenditure.MultiSelect = false;
            this.Data_expenditure.Name = "Data_expenditure";
            this.Data_expenditure.ReadOnly = true;
            this.Data_expenditure.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Data_expenditure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_expenditure.Size = new System.Drawing.Size(294, 341);
            this.Data_expenditure.TabIndex = 4;
            // 
            // Expenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(314, 361);
            this.Controls.Add(this.Data_expenditure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Expenditure";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.Data_expenditure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Data_expenditure;
    }
}