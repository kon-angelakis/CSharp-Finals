using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WhackAMole
{

    public partial class Form1 : Form
    {
        string difficulty, playername, cs1, cs2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cs1 = "Data source=./Highscores.db;Version=3;";
            cs2 = "Data source=./Playerinfo.db;Version=3;";
            var con1 = new SQLiteConnection(cs1);
            con1.Open();
            var cmd1 = new SQLiteCommand(con1);
            cmd1.CommandText = "CREATE TABLE IF NOT EXISTS HighScores(ID INTEGER PRIMARY KEY," +
                                "Names TEXT," +
                                " Scores INTEGER)";
            cmd1.ExecuteNonQuery();
            con1.Close();
            var con2 = new SQLiteConnection(cs2);
            con2.Open();
            var cmd2 = new SQLiteCommand(con2);

            cmd2.CommandText = "CREATE TABLE IF NOT EXISTS Playerinfo(Score_ID integer primary key AUTOINCREMENT," +
                "Name text not null," +
                " Score integer)";
            cmd2.ExecuteNonQuery();
            con2.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            playername = logText.Text;
            if (logText.Text == "")
            {
                MessageBox.Show("Give user");
            }
            else
            {
                {
                    if (radioButton1.Checked)
                    {
                        difficulty = new Difficulty(radioButton1.Text).GetDifficulty();
                    }
                    else if (radioButton2.Checked)
                    {
                        difficulty = new Difficulty(radioButton2.Text).GetDifficulty();
                    }
                    else if (radioButton3.Checked)
                    {
                        difficulty = new Difficulty(radioButton3.Text).GetDifficulty();
                    }
                    else
                    {
                        difficulty = new Difficulty(radioButton4.Text).GetDifficulty();
                    }
                }
                Form2 f2 = new Form2(difficulty, playername, cs1, cs2);
                f2.Show();
            }
        }
    }
}
