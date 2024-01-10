namespace Proiect_FInal
{
    partial class CreateProfileForm
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
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.createLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerName.Location = new System.Drawing.Point(16, 59);
            this.textBoxPlayerName.MaxLength = 25;
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(271, 26);
            this.textBoxPlayerName.TabIndex = 0;
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabel.Location = new System.Drawing.Point(12, 9);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(395, 23);
            this.createLabel.TabIndex = 1;
            this.createLabel.Text = "Alege un nume pentru a crea profilul (max 25 caractere)";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.confirmButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(311, 48);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(90, 45);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "CREAZA";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // CreateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 104);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.textBoxPlayerName);
            this.Name = "CreateProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Button confirmButton;
    }
}