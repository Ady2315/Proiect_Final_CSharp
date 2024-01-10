namespace Proiect_FInal
{
    partial class LeaderBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.leaderBoardTitleLabel = new System.Windows.Forms.Label();
            this.leaderBoardTable = new System.Windows.Forms.DataGridView();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume_Jucator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.leaderBoardTable)).BeginInit();
            this.SuspendLayout();
            // 
            // leaderBoardTitleLabel
            // 
            this.leaderBoardTitleLabel.AutoSize = true;
            this.leaderBoardTitleLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderBoardTitleLabel.Location = new System.Drawing.Point(118, 29);
            this.leaderBoardTitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.leaderBoardTitleLabel.Name = "leaderBoardTitleLabel";
            this.leaderBoardTitleLabel.Size = new System.Drawing.Size(209, 37);
            this.leaderBoardTitleLabel.TabIndex = 1;
            this.leaderBoardTitleLabel.Text = "TOP JUCATORI";
            // 
            // leaderBoardTable
            // 
            this.leaderBoardTable.AllowUserToAddRows = false;
            this.leaderBoardTable.AllowUserToDeleteRows = false;
            this.leaderBoardTable.AllowUserToResizeColumns = false;
            this.leaderBoardTable.AllowUserToResizeRows = false;
            this.leaderBoardTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leaderBoardTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.leaderBoardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderBoardTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Loc,
            this.Nume_Jucator,
            this.Scor});
            this.leaderBoardTable.Location = new System.Drawing.Point(12, 94);
            this.leaderBoardTable.MultiSelect = false;
            this.leaderBoardTable.Name = "leaderBoardTable";
            this.leaderBoardTable.ReadOnly = true;
            this.leaderBoardTable.RowHeadersWidth = 4;
            this.leaderBoardTable.RowTemplate.ReadOnly = true;
            this.leaderBoardTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.leaderBoardTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.leaderBoardTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.leaderBoardTable.Size = new System.Drawing.Size(435, 444);
            this.leaderBoardTable.TabIndex = 2;
            // 
            // Loc
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Loc.DefaultCellStyle = dataGridViewCellStyle3;
            this.Loc.FillWeight = 59.16948F;
            this.Loc.HeaderText = "Loc";
            this.Loc.Name = "Loc";
            this.Loc.ReadOnly = true;
            this.Loc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nume_Jucator
            // 
            this.Nume_Jucator.FillWeight = 164.6884F;
            this.Nume_Jucator.HeaderText = "Nume Jucator";
            this.Nume_Jucator.Name = "Nume_Jucator";
            this.Nume_Jucator.ReadOnly = true;
            this.Nume_Jucator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Scor
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Scor.DefaultCellStyle = dataGridViewCellStyle4;
            this.Scor.FillWeight = 76.14214F;
            this.Scor.HeaderText = "Scor";
            this.Scor.Name = "Scor";
            this.Scor.ReadOnly = true;
            this.Scor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(459, 550);
            this.Controls.Add(this.leaderBoardTable);
            this.Controls.Add(this.leaderBoardTitleLabel);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LeaderBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaderBoard";
            this.Load += new System.EventHandler(this.LeaderBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaderBoardTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label leaderBoardTitleLabel;
        private System.Windows.Forms.DataGridView leaderBoardTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume_Jucator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scor;
    }
}