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

namespace SportsSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 会員管理
        private void button1_Click(object sender, EventArgs e) 
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        // 終了
        private void button2_Click(object sender, EventArgs e) 
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        // 会員登録
        private void button3_Click(object sender, EventArgs e) 
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

            using (SQLiteConnection con = new SQLiteConnection("Data Source=client.db"))
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS [m_client](" +
                                      "create table m_client(client_id INTEGER  PRIMARY KEY AUTOINCREMENT, client_name TEXT, address INTEGER, phone_number INTEGER)" +
                                      ");";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
