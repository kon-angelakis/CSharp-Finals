using System.Data.SQLite;

namespace Battleship
{
    public class Player
    {
        private string name;
        private int gamecount, totalwins, totallosses;

        public Player(string name)
        {
            this.name = name;
        }

        public void setGameCount(int gamecount) { this.gamecount = gamecount; }
        public void setTotalWins(int wins) { this.totalwins = wins; }
        public void setTotalLosses(int losses) { this.totallosses = losses; }

        public void updateDatabase(string winner, int timeElapsed) 
        {
            string str = "Data source=./Games.db;Version=3;";
            var con = new SQLiteConnection(str);
            con.Open();
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Games(ID INTEGER PRIMARY KEY," + "Nickname TEXT," + "Winner TEXT," + "Duration INTEGER)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO Games(Nickname, Winner, Duration) VALUES (@nickname, @winner, @duration)";
            cmd.Parameters.AddWithValue("nickname", name);
            cmd.Parameters.AddWithValue("winner", winner);
            cmd.Parameters.AddWithValue("duration", timeElapsed);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string getName() { return name; }
        public int getGameCount() { return gamecount; }
        public int getTotalWins() { return totalwins; }
        public int getTotalLosses() { return totallosses; }

    }
}
