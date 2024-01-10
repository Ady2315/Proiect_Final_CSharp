namespace Proiect_FInal
{
    partial class ProfileMenu
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
            this.playersList = new System.Windows.Forms.ListBox();
            this.createProfileButton = new System.Windows.Forms.Button();
            this.listTitleLabel = new System.Windows.Forms.Label();
            this.chooseProfileButton = new System.Windows.Forms.Button();
            this.deleteProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playersList
            // 
            this.playersList.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersList.FormattingEnabled = true;
            this.playersList.ItemHeight = 25;
            this.playersList.Location = new System.Drawing.Point(12, 66);
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(396, 354);
            this.playersList.TabIndex = 0;
            this.playersList.DoubleClick += new System.EventHandler(this.playersList_DoubleClick);
            // 
            // createProfileButton
            // 
            this.createProfileButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createProfileButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProfileButton.Location = new System.Drawing.Point(130, 453);
            this.createProfileButton.Name = "createProfileButton";
            this.createProfileButton.Size = new System.Drawing.Size(133, 55);
            this.createProfileButton.TabIndex = 1;
            this.createProfileButton.Text = "CREAZA UN NOU PROFIL";
            this.createProfileButton.UseVisualStyleBackColor = false;
            this.createProfileButton.Click += new System.EventHandler(this.createProfileButton_Click);
            // 
            // listTitleLabel
            // 
            this.listTitleLabel.AutoSize = true;
            this.listTitleLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTitleLabel.Location = new System.Drawing.Point(12, 21);
            this.listTitleLabel.Name = "listTitleLabel";
            this.listTitleLabel.Size = new System.Drawing.Size(312, 25);
            this.listTitleLabel.TabIndex = 2;
            this.listTitleLabel.Text = "Selecteaza sau creaza un profil nou...";
            // 
            // chooseProfileButton
            // 
            this.chooseProfileButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chooseProfileButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseProfileButton.Location = new System.Drawing.Point(294, 453);
            this.chooseProfileButton.Name = "chooseProfileButton";
            this.chooseProfileButton.Size = new System.Drawing.Size(114, 55);
            this.chooseProfileButton.TabIndex = 3;
            this.chooseProfileButton.Text = "ALEGE";
            this.chooseProfileButton.UseVisualStyleBackColor = false;
            this.chooseProfileButton.Click += new System.EventHandler(this.chooseProfileButton_Click);
            // 
            // deleteProfileButton
            // 
            this.deleteProfileButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteProfileButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProfileButton.Location = new System.Drawing.Point(12, 453);
            this.deleteProfileButton.Name = "deleteProfileButton";
            this.deleteProfileButton.Size = new System.Drawing.Size(88, 55);
            this.deleteProfileButton.TabIndex = 4;
            this.deleteProfileButton.Text = "STERGE";
            this.deleteProfileButton.UseVisualStyleBackColor = false;
            this.deleteProfileButton.Click += new System.EventHandler(this.deleteProfileButton_Click);
            // 
            // ProfileMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 520);
            this.Controls.Add(this.deleteProfileButton);
            this.Controls.Add(this.chooseProfileButton);
            this.Controls.Add(this.listTitleLabel);
            this.Controls.Add(this.createProfileButton);
            this.Controls.Add(this.playersList);
            this.Name = "ProfileMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playersList;
        private System.Windows.Forms.Button createProfileButton;
        private System.Windows.Forms.Label listTitleLabel;
        private System.Windows.Forms.Button chooseProfileButton;
        private System.Windows.Forms.Button deleteProfileButton;
    }
}