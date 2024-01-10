using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FInal
{
    public partial class LeaderBoard : Form
    {
        //String listFormat = "{0, -30} {1, -30} {2, -35}";
        List<Player> topPlayers = new List<Player>();
        public LeaderBoard()
        {
            InitializeComponent();
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {
            //leaderBoardListBox.Items.Add(String.Format(listFormat, "Loc", "Nume_Jucator", "Scor"));
            
            DataAccess db = new DataAccess();
            topPlayers = db.GetTopPlayers();
           // leaderBoardListBox
            int i = 1;

            //String index, username, highscore;
            

            foreach (Player player in topPlayers)
            {
                //index = i++ + ".";
                //username = player.UserName;
                //highscore = player.HighScore.ToString();
                //leaderBoardListBox.Items.Add(String.Format(listFormat, index, username, highscore));
                leaderBoardTable.Rows.Add(i++ + ".", player.UserName, player.HighScore);
            }
        }
    }
}
