namespace Proiect_FInal
{
    partial class InGame
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
            this.components = new System.ComponentModel.Container();
            this.KidCharacter = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Santa = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCadou = new System.Windows.Forms.PictureBox();
            this.labelScor = new System.Windows.Forms.Label();
            this.labelPierdute = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KidCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadou)).BeginInit();
            this.SuspendLayout();
            // 
            // KidCharacter
            // 
            this.KidCharacter.BackColor = System.Drawing.Color.Transparent;
            this.KidCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KidCharacter.Image = global::Proiect_FInal.Properties.Resources.kid3;
            this.KidCharacter.Location = new System.Drawing.Point(591, 522);
            this.KidCharacter.Name = "KidCharacter";
            this.KidCharacter.Size = new System.Drawing.Size(115, 145);
            this.KidCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.KidCharacter.TabIndex = 0;
            this.KidCharacter.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Santa
            // 
            this.Santa.BackColor = System.Drawing.Color.Transparent;
            this.Santa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Santa.Image = global::Proiect_FInal.Properties.Resources.santa11;
            this.Santa.Location = new System.Drawing.Point(300, 1);
            this.Santa.Name = "Santa";
            this.Santa.Size = new System.Drawing.Size(120, 101);
            this.Santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Santa.TabIndex = 1;
            this.Santa.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBoxCadou
            // 
            this.pictureBoxCadou.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCadou.Image = global::Proiect_FInal.Properties.Resources.present1;
            this.pictureBoxCadou.Location = new System.Drawing.Point(328, 105);
            this.pictureBoxCadou.Name = "pictureBoxCadou";
            this.pictureBoxCadou.Size = new System.Drawing.Size(64, 78);
            this.pictureBoxCadou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCadou.TabIndex = 2;
            this.pictureBoxCadou.TabStop = false;
            // 
            // labelScor
            // 
            this.labelScor.AutoSize = true;
            this.labelScor.BackColor = System.Drawing.Color.ForestGreen;
            this.labelScor.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelScor.Location = new System.Drawing.Point(1189, 116);
            this.labelScor.Name = "labelScor";
            this.labelScor.Size = new System.Drawing.Size(78, 62);
            this.labelScor.TabIndex = 3;
            this.labelScor.Text = "SCOR\r\n0";
            this.labelScor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPierdute
            // 
            this.labelPierdute.AutoSize = true;
            this.labelPierdute.BackColor = System.Drawing.Color.Firebrick;
            this.labelPierdute.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPierdute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPierdute.Location = new System.Drawing.Point(12, 116);
            this.labelPierdute.Name = "labelPierdute";
            this.labelPierdute.Size = new System.Drawing.Size(127, 62);
            this.labelPierdute.TabIndex = 4;
            this.labelPierdute.Text = "PIERDUTE\r\n0/3";
            this.labelPierdute.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_FInal.Properties.Resources.xmas_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1279, 667);
            this.Controls.Add(this.labelPierdute);
            this.Controls.Add(this.labelScor);
            this.Controls.Add(this.pictureBoxCadou);
            this.Controls.Add(this.Santa);
            this.Controls.Add(this.KidCharacter);
            this.Name = "InGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X-MAS RUSH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InGame_FormClosing);
            this.Load += new System.EventHandler(this.InGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.KidCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KidCharacter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Santa;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBoxCadou;
        private System.Windows.Forms.Label labelScor;
        private System.Windows.Forms.Label labelPierdute;
    }
}

