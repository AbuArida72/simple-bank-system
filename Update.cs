using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Visual_Project
{
    public partial class Update : Form
    {
        SQLiteConnection database_connection;

        string chosen;

        public Update()
        {
            InitializeComponent();
        }
        private void Update_Load(object sender, EventArgs e)
        {
            database_connection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                database_connection.Open();

                string update = "UPDATE client SET Name='" + textBox3.Text + "', Email='" + textBox2.Text + "', Age='" + textBox4.Text + "', Account='" + chosen + "', Balance='" + numericUpDown1.Value + "' WHERE IBAN='" + textBox1.Text + "' ";

                SQLiteCommand command = new SQLiteCommand(update, database_connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Client Successfully Updated");

                database_connection.Close();
            }
            catch
            {
                MessageBox.Show("Client Update Failed");

                database_connection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
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
    }
}
