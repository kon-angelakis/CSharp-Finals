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
    public partial class Form4 : Form
    {
        Boolean flag;
        string connstring;
        int editID;
        SQLiteConnection con;
        SQLiteCommand cmd;
        public Form4(Boolean flag)
        {
            InitializeComponent();
            this.flag = flag;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            connstring = "Data Source=./Applications.db;Version=3;";

            if (flag)
            {
                editCont.Enabled = true;
                editCont.Visible = true;
            }
            else
            {
                deleteCont.Enabled = true;
                deleteCont.Visible = true;
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (textBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Fill out both fields.");
            }
            else
            {
                con = new SQLiteConnection(connstring);
                con.Open();
                cmd = new SQLiteCommand(con);
                cmd.CommandText = "SELECT * FROM Applications WHERE Name LIKE @name AND Application_Type = @type";
                cmd.Parameters.AddWithValue("name", "%"+textBox1.Text+"%");
                cmd.Parameters.AddWithValue("type", comboBox2.Text);
                cmd.ExecuteNonQuery();
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    richTextBox1.AppendText(reader.GetInt16(0) + " | "
                                            + reader.GetString(1) + " | "
                                            + reader.GetString(2) + " | "
                                            + reader.GetString(3) + " | "
                                            + reader.GetString(4) + " | "
                                            + reader.GetString(5) + " | "
                                            + reader.GetString(6) + " | "
                                            + reader.GetString(7) + " | "
                                            + reader.GetString(8) + '\n');
                }
                con.Close();
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int value = Int16.Parse(numericUpDown2.Value.ToString());
            con = new SQLiteConnection(connstring);
            con.Open();
            cmd = new SQLiteCommand(con);
            cmd.CommandText = "DELETE FROM Applications WHERE ID = @id;"; 
            cmd.Parameters.AddWithValue("ID", value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Entry");
        }

        private void selButton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            ssnBox.Clear();
            mailBox.Clear();
            addrBox.Clear();
            phoneBox.Clear();
            dateTimePicker1.ResetText();
            appBox.ResetText();
            editID = int.Parse(numericUpDown1.Value.ToString());
            con = new SQLiteConnection(connstring);
            con.Open();
            cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM Applications WHERE ID=@id";
            cmd.Parameters.AddWithValue("id", editID);
            cmd.ExecuteNonQuery();
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nameBox.AppendText(reader.GetString(1));
                ssnBox.AppendText(reader.GetString(2));
                mailBox.AppendText(reader.GetString(3));
                phoneBox.AppendText(reader.GetString(4));
                addrBox.AppendText(reader.GetString(5));
                dateTimePicker1.Text = reader.GetString(6);
                appBox.Text = reader.GetString(7);
            }
            con.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || mailBox.Text == "" || ssnBox.Text == "" || phoneBox.Text == "" || addrBox.Text == "" || appBox.Text == "")
            {
                MessageBox.Show("Fill out all the fields.");
            }
            else
            {
                con = new SQLiteConnection(connstring);
                con.Open();
                cmd = new SQLiteCommand(con);
                cmd.CommandText = "Update Applications SET Name=@name," +
                    "SSN=@ssn," +
                    "Email=@email," +
                    "Phone=@phone," +
                    "Address=@address," +
                    "Date_of_Birth=@dob," +
                    "Application_Type=@app WHERE ID=@id";
                cmd.Parameters.AddWithValue("name", nameBox.Text);
                cmd.Parameters.AddWithValue("ssn", ssnBox.Text);
                cmd.Parameters.AddWithValue("email", mailBox.Text);
                cmd.Parameters.AddWithValue("phone", phoneBox.Text);
                cmd.Parameters.AddWithValue("address", addrBox.Text);
                cmd.Parameters.AddWithValue("dob", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("app", appBox.Text);  
                cmd.Parameters.AddWithValue("ID", editID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Edited Entry");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
