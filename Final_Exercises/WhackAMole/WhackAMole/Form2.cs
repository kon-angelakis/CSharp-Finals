using System;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WhackAMole
{
    public partial class Form2 : Form
    {
        Enemy gort = new Enemy();
        int timeLeft, score, multiplier;
        int[] scores = new int[10];
        bool flag;
        string[] names = new string[10]; //parallel to scores[]
        string difficulty, playername, cs1, cs2;
        SQLiteConnection con1, con2;
        SQLiteCommand cmd1, cmd2;

        public Form2(string difficulty, string playername, string cs1, string cs2)
        {
            InitializeComponent();
            this.difficulty = difficulty;
            this.playername = playername;
            this.cs1 = cs1;
            this.cs2 = cs2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (difficulty == "Easy") { setDifficulty(1500, 150); timeLeft = 120; multiplier = 1; }
            else if (difficulty == "Medium") { setDifficulty(1000, 100); timeLeft = 90; multiplier = 2; }
            else if (difficulty == "Hard") { setDifficulty(500, 50); timeLeft = 60; multiplier = 3; }
            else { setDifficulty(250, 25); timeLeft = 30; multiplier = 10; }

            posTimer.Start();
            remTimer.Start();

            insertIntoArrays();
        }

        private void setDifficulty(int posTime, int size)
        {
            posTimer.Interval = posTime;
            enemyPic.Size = new Size(size, size);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void remTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = "Time Left: " + --timeLeft;
            timeCheck();
        }

        private void posTimer_Tick(object sender, EventArgs e)
        {
            enemyPic.Location = new Point(gort.LocationX(Width, enemyPic.Width),gort.LocationY(Height, enemyPic.Height));
        }

        private void enemyPic_MouseClick(object sender, MouseEventArgs e)
        {
            score += 10 * multiplier;
            scoreLabel.Text = "Score: " + score;
        }

        private void timeCheck()
        {
            if (timeLeft == 0)
            {
                timeLabel.Enabled = false;
                enemyPic.Enabled = false;
                timeLabel.Visible = false;
                enemyPic.Visible = false;
                con2 = new SQLiteConnection(cs2);
                con2.Open();
                cmd2 = new SQLiteCommand(con2);
                cmd2.CommandText = "INSERT INTO Playerinfo(Name, Score) VALUES (@name,@score)";
                cmd2.Parameters.AddWithValue("name", playername);
                cmd2.Parameters.AddWithValue("score", score);
                cmd2.ExecuteNonQuery();
                con2.Close();
                MessageBox.Show("Time's Up!");
                remTimer.Stop();
                posTimer.Stop();
                checkHighscores();
                Close();
            }
        }

        //Check if new score is a highscore
        private void checkHighscores()
        {
            if (score > scores.Min())
            {
                flag = true;
                int k = 0;
                while ((k < 10) && (flag))
                {
                    if (scores[k] == scores.Min())
                    {
                        names[k] = playername;
                        scores[k] = score;
                        flag = false;
                    }
                    k++;
                }
            }
            Array.Sort(scores, names); //Overloaded diversion of sort with the 2 parallel arrays
            Array.Reverse(scores);
            Array.Reverse(names);
            insertIntoDB();
        }

        private void insertIntoArrays()
        {
            int i = 0;
            con1 = new SQLiteConnection(cs1);
            con1.Open();
            String selectSQL = "Select * from HighScores";

            SQLiteCommand cmd = new SQLiteCommand(selectSQL, con1);

            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                names[i] = reader.GetString(1);
                scores[i] = reader.GetInt16(2);
                i++;
            }

            con1.Close();
        }

        //After checking for new highscore insert the 2 arrays into the database
        private void insertIntoDB()
        {
            con1 = new SQLiteConnection(cs1);
            con1.Open();
            cmd1 = new SQLiteCommand(con1);
            cmd1.CommandText = "DELETE FROM HighScores";
            cmd1.ExecuteNonQuery();
            for (int i = 0; i < 10; i++)
            {
                cmd1.CommandText = "INSERT INTO HighScores(ID, Names, Scores) VALUES (@id,@name,@score)";
                cmd1.Parameters.AddWithValue("id", i + 1);
                if (names[i] == null)
                {
                    cmd1.Parameters.AddWithValue("name", "Unknown");
                    cmd1.Parameters.AddWithValue("score", -1);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("name", names[i]);
                    cmd1.Parameters.AddWithValue("score", scores[i]);
                }

                cmd1.ExecuteNonQuery();
            }
            con1.Close();
        }
    }
}
