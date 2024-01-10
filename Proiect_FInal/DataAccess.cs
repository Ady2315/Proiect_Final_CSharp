using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proiect_FInal
{
    public class DataAccess
    {
        public List<Player> GetPlayers()
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("XMAS_RUSH_DB")))
            {
                var output = connection.Query<Player>("Afiseaza_Jucatori").ToList();
                return output;
            }
        }

        public void InsertPlayer(string userName)
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("XMAS_RUSH_DB")))
            {
                connection.Execute("Adauga_Jucator", new {UserName = userName}, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeletePlayer(string userName)
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("XMAS_RUSH_DB")))
            {
                connection.Execute("Sterge_Jucator", new {p_userName = userName}, commandType: CommandType.StoredProcedure);
            }
        }
        
        public void MarkLastPlayerSelected(string userName)
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("XMAS_RUSH_DB")))
            {
                connection.Execute("Actualizeaza_Jucator_Curent", new { p_userName = userName }, commandType: CommandType.StoredProcedure);
            }
        }
        public Player GetLastPlayerSelected()
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("XMAS_RUSH_DB")))
            {
                var output = connection.Query<Player>("Afiseaza_Ultimul_Jucator").ToList();
                return output[0];
            }
        }

        public void UpdatePlayerHighScore(string userName, int score)
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("XMAS_RUSH_DB")))
            {
                connection.Execute("Actualizeaza_Scor_Jucator", new { p_UserName = userName, p_Scor = score }, commandType: CommandType.StoredProcedure);
            }
        }

        public int GetPlayerHighScore(string userName)
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("XMAS_RUSH_DB")))
            {
                var output = connection.Query<Player>("Obtine_Scor_Jucator", new {userName = userName}).ToList();
                return output[0].HighScore;
            }
        }

        public List<Player> GetTopPlayers()
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("XMAS_RUSH_DB")))
            {
                var output = connection.Query<Player>("Afiseaza_Jucatori_Dupa_Scor").ToList();
                return output;
            }
        }
    }
}
