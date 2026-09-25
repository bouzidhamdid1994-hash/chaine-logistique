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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=C:\Users\baghdadi\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Letos\logistics.db;Version=3;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO login2 (username, password) VALUES (@username, @password)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("تمت الإضافة بنجاح!");
            }
        }
    }
}
