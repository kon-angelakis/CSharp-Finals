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
using System.Configuration;

namespace KEP
{
    public partial class Form5 : Form
    {
        string crit,connstring;
        public Form5()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (textBox1.Text.Equals("") || comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Fill out both fields.");
            }
            else
            {
                crit = comboBox1.Text;
                connstring = "Data Source=./Applications.db;Version=3;";
                SQLiteConnection con = new SQLiteConnection(connstring);
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                switch (crit)
                {
                    case ("Name"):
                        cmd.CommandText = "SELECT * FROM Applications WHERE Name LIKE @info";
                        break;
                    case ("SSN"):
                        cmd.CommandText = "SELECT * FROM Applications WHERE SSN = @info";
                        break;
                    case ("Email"):
                        cmd.CommandText = "SELECT * FROM Applications WHERE Email LIKE @info";
                        break;
                    case ("Phone"):
                        cmd.CommandText = "SELECT * FROM Applications WHERE Phone = @info";
                        break;
                    case ("Address"):
                        cmd.CommandText = "SELECT * FROM Applications WHERE Address = @info";
                        break;
                }
                cmd.Parameters.AddWithValue("info", "%"+textBox1.Text+"%");
                cmd.ExecuteNonQuery();
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    richTextBox1.AppendText(reader.GetString(1) + " | "
                                            +reader.GetString(2) + " | "
                                            +reader.GetString(3) + " | "
                                            +reader.GetString(4) + " | "
                                            +reader.GetString(5) + " | "
                                            +reader.GetString(6) + " | "
                                            +reader.GetString(7) + '\n');
                }
                con.Close();
            }
            
        }
    }
}
