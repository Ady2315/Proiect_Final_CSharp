using Newtonsoft.Json;
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
    public partial class CreateProfileForm : Form
    {
        internal ProfileMenu profileMenu;
        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPlayer(textBoxPlayerName.Text);
            profileMenu.players = db.GetPlayers();
            MessageBox.Show("Ai creat cu succes profilul cu numele " + textBoxPlayerName.Text);
            this.Close();
            profileMenu.RefreshPlayersList();
        }
    }
}
