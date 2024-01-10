namespace Proiect_FInal
{
    partial class Meniu
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
            this.OverlayPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.profileMenuButton = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.Label();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.OverlayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OverlayPanel
            // 
            this.OverlayPanel.BackColor = System.Drawing.Color.Transparent;
            this.OverlayPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OverlayPanel.Controls.Add(this.closeButton);
            this.OverlayPanel.Controls.Add(this.profileMenuButton);
            this.OverlayPanel.Controls.Add(this.playerName);
            this.OverlayPanel.Controls.Add(this.leaderboardButton);
            this.OverlayPanel.Controls.Add(this.playButton);
            this.OverlayPanel.Location = new System.Drawing.Point(-2, -3);
            this.OverlayPanel.Name = "OverlayPanel";
            this.OverlayPanel.Size = new System.Drawing.Size(897, 504);
            this.OverlayPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(373, 219);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(139, 55);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "INCHIDE";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // profileMenuButton
            // 
            this.profileMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.profileMenuButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileMenuButton.Location = new System.Drawing.Point(758, 134);
            this.profileMenuButton.Name = "profileMenuButton";
            this.profileMenuButton.Size = new System.Drawing.Size(108, 47);
            this.profileMenuButton.TabIndex = 3;
            this.profileMenuButton.Text = "PROFILE";
            this.profileMenuButton.UseVisualStyleBackColor = false;
            this.profileMenuButton.Click += new System.EventHandler(this.profileMenuButton_Click);
            // 
            // playerName
            // 
            this.playerName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.Color.White;
            this.playerName.Location = new System.Drawing.Point(603, 54);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(263, 77);
            this.playerName.TabIndex = 2;
            this.playerName.Text = "Alege sau creaza un profil";
            this.playerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leaderboardButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardButton.Location = new System.Drawing.Point(347, 134);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(200, 55);
            this.leaderboardButton.TabIndex = 1;
            this.leaderboardButton.Text = "LEADERBOARD";
            this.leaderboardButton.UseVisualStyleBackColor = false;
            this.leaderboardButton.Click += new System.EventHandler(this.leaderboardButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(373, 54);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(139, 55);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "JOACA";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_FInal.Properties.Resources.xmas_menu_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(893, 495);
            this.Controls.Add(this.OverlayPanel);
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X-MAS RUSH";
            this.OverlayPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OverlayPanel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button profileMenuButton;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Button leaderboardButton;
        private System.Windows.Forms.Button closeButton;
    }
}