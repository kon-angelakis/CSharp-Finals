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

namespace KEP
{
    public partial class Form3 : Form
    {
        SearchedUser user;
        List<SearchedUser> users = new List<SearchedUser>();
        Boolean flag;
        string connstring;
        SQLiteConnection con;
        SQLiteCommand cmd;
        public Form3(Boolean flag)
        {
            this.flag = flag;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connstring = "Data Source=./Applications.db;Version=3;";
            if (flag)
            {

            }
            else
            {
                label1.Enabled = true;
                label1.Visible = true;
                label2.Enabled = true;
                label2.Visible = true;
                textBox1.Enabled = true;
                textBox1.Visible = true;
                textBox2.Enabled = true;
                textBox2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            con = new SQLiteConnection(connstring);
            con.Open();
            if (flag)
            {
                cmd = new SQLiteCommand(con);
                cmd.CommandText = "SELECT * FROM Applications";
                cmd.ExecuteNonQuery();
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user = new SearchedUser(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5),
                        reader.GetString(6), reader.GetString(7), reader.GetString(8));
                    users.Add(user);
                }
            }
            else
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    cmd = new SQLiteCommand(con);
                    cmd.CommandText = "SELECT * FROM Applications WHERE Name = @name AND SSN = @ssn";
                    cmd.Parameters.AddWithValue("name", textBox1.Text);
                    cmd.Parameters.AddWithValue("ssn", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        user = new SearchedUser(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3), reader.GetString(4), reader.GetString(5),
                            reader.GetString(6), reader.GetString(7), reader.GetString(8));
                        users.Add(user);
                    }
                }
                else
                {
                    MessageBox.Show("Fill out both fields.");
                }
                con.Close();
            }
            foreach(SearchedUser u in users)
            {
                richTextBox1.AppendText(u.ToString() + "\n");
            }

        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
