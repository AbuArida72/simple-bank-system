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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Visual_Project
{
    public partial class Add : Form
    {
        SQLiteConnection database_connection;

        string chosen;

        public Add()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            database_connection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                chosen = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                chosen = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                chosen = radioButton3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                database_connection.Open();

                string add;

                add = "INSERT INTO client (Name, Email, Age, Account, Balance) VALUES ('" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox1.Text + "', '" + chosen + "', '" + numericUpDown1.Value + "')";

                SQLiteCommand command = new SQLiteCommand(add, database_connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Client Successfully Registered");

                database_connection.Close();
            }
            catch
            {
                MessageBox.Show("Client Registration Failed");

                database_connection.Close();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                database_connection.Open();

                string select = "SELECT * FROM client ORDER BY IBAN DESC";

                SQLiteCommand command = new SQLiteCommand(select, database_connection);
                SQLiteDataReader reader = command.ExecuteReader();

                string output = "";

                while (reader.Read())
                {
                    output += "IBAN : " + reader["IBAN"] + "\tName : " + reader["Name"] + "\n";
                }

                MessageBox.Show(output, "");

                database_connection.Close();
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
