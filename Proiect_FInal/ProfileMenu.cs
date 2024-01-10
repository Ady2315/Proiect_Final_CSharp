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
    public partial class ProfileMenu : Form
    {
        internal Meniu meniu;
        internal List<Player> players = new List<Player>();
        public ProfileMenu()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();
            players = db.GetPlayers();

            UpdateBinding();
        }

        internal void UpdateBinding()
        {
            playersList.DataSource = players;
            playersList.DisplayMember = "UserName";
        }

        private void createProfileButton_Click(object sender, EventArgs e)
        {
            CreateProfileForm cpf = new CreateProfileForm();
            cpf.profileMenu = this;
            cpf.ShowDialog();
        }

        private void chooseProfileButton_Click(object sender, EventArgs e)
        {
            SelectProfile();
        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            string p = playersList.GetItemText(playersList.SelectedItem);
            if (p != null)
            {
                Player selected = players.Find(x => x.UserName.Contains(p));
                DataAccess db = new DataAccess();
                db.DeletePlayer(p);
                players = db.GetPlayers();

                MessageBox.Show("Jucatorul " + p + " a fost sters cu succes");
                RefreshPlayersList();

                if (selected == meniu.player)
                {
                    meniu.player = null;
                    meniu.UpdateUserName("Creati sau alegi un profil");
                }
            }
        }

        private void ProfileMenu_Load(object sender, EventArgs e)
        {
            
        }

        internal void RefreshPlayersList()
        {
            playersList.DataSource = null;
            UpdateBinding();
        }

        private void playersList_DoubleClick(object sender, EventArgs e)
        {
            SelectProfile();
        }

        private void SelectProfile()
        {
            string p = playersList.GetItemText(playersList.SelectedItem);
            if (p != null)
            {
                Player selected = players.Find(x => x.UserName.Contains(p));
                DataAccess db = new DataAccess();
                db.MarkLastPlayerSelected(p);
                meniu.player = db.GetLastPlayerSelected();

                this.Close();
                meniu.UpdateCurrentPlayer(selected);
            }
        }

        private void ProfileMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (playersList.Items.Count <= 0 && meniu.player != null)
            {
                meniu.player = null;
                meniu.UpdateUserName("Creati un nou profil");
            }
        }
    }
}
