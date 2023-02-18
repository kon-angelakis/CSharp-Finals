using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace KEP
{
    public partial class Form2 : Form
    {
        string connstring;

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        SQLiteConnection con;
        SQLiteCommand cmd;

        private void Form2_Load(object sender, EventArgs e)
        {
            connstring = "Data Source=./Applications.db;Version=3;";
            con = new SQLiteConnection(connstring);
            con.Open();

            cmd = new SQLiteCommand(con);
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Applications(ID INTEGER PRIMARY KEY," +
                "Name TEXT," +
                "SSN TEXT," +
                "Email TEXT," +
                "Phone TEXT," +
                "Address TEXT," +
                "Date_of_Birth TEXT," +
                "Application_Type TEXT," +
                "Application_DateTime TEXT)";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Form2()
        {
            InitializeComponent();

        }

        private void submitButt_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Equals("") || ssnBox.Text.Equals("") || emailBox.Text.Equals("") || phoneBox.Text.Equals("") || addrBox.Text.Equals("") || comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Fill out all the fields before submitting.");
            }
            else
            {
                SubmittedUser user = new SubmittedUser(nameBox.Text, ssnBox.Text, emailBox.Text, phoneBox.Text,
                    addrBox.Text, dateTimePicker1.Text, comboBox1.Text);

                con.Open();
                cmd = new SQLiteCommand(con);
                cmd.CommandText = "INSERT INTO Applications(Name, SSN, Email, Phone, Address, Date_of_Birth, Application_Type, Application_DateTime) " +
                                            "VALUES (@name, @ssn, @email, @phone, @address, @dob, @app, DateTime('now'))";

                cmd.Parameters.AddWithValue("name", user.getName());
                cmd.Parameters.AddWithValue("ssn", user.getSsn());
                cmd.Parameters.AddWithValue("email", user.getEmail());
                cmd.Parameters.AddWithValue("phone", user.getPhone());
                cmd.Parameters.AddWithValue("address", user.getAddress());
                cmd.Parameters.AddWithValue("dob", user.getDate());
                cmd.Parameters.AddWithValue("app", user.getType());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entry submitted");
            }
        }
    }
}
