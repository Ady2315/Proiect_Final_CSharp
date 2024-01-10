using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FInal
{
    public partial class Meniu : Form
    {
        internal Player player = new Player();
        public Meniu()
        {
            InitializeComponent();
            OverlayPanel.BackColor = Color.FromArgb(100, Color.Black);

            DataAccess db = new DataAccess();
            player = db.GetLastPlayerSelected();
            UpdateUserName(player.UserName);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InGame g = new InGame();
            g.Meniu = this;
            g.Show();
            Thread.Sleep(1500);
        }

        private void profileMenuButton_Click(object sender, EventArgs e)
        {
            ProfileMenu profileMenu = new ProfileMenu();
            profileMenu.meniu = this;
            profileMenu.ShowDialog();
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            LeaderBoard leaderBoard = new LeaderBoard();
            leaderBoard.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        internal void UpdateUserName(string userName)
        {
            playerName.Text = userName;
        }

        internal void UpdatePlayerHighScore(int score)
        {
            DataAccess db = new DataAccess();
            if (player.HighScore < score)
            {
                db.UpdatePlayerHighScore(player.UserName, score);
            }
        }
    }
}
