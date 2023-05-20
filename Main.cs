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
using System.Data.SqlClient;
using System.Collections.Specialized;

namespace Visual_Project
{
    public partial class Main : Form
    {
        SQLiteConnection database_connection;

        private void Main_Load(object sender, EventArgs e)
        {
            database_connection = new SQLiteConnection("Data Source=Bank_Database.sqlite;Version=3;");

            database_connection.Open();
        }
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add Check = new Add();
            Check.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove Check = new Remove();
            Check.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update Check = new Update();
            Check.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
