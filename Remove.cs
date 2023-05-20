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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Visual_Project
{
    public partial class Remove : Form
    {
        SQLiteConnection database_connection;

        public Remove()
        {
            InitializeComponent();
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            database_connection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                database_connection.Open();

                string remove = "DELETE FROM client WHERE IBAN='" + textBox1.Text + "'";

                SQLiteCommand command = new SQLiteCommand(remove, database_connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Client Successfully Removed");

                database_connection.Close();
            }
            catch
            {
                MessageBox.Show("Client Removal Failed");

                database_connection.Close();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
