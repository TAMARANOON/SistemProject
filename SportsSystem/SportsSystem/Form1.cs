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
        string clientDB = @"C:\client.db";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();

                using (var con = new SQLiteConnection("Data Source=client.db"))
                {
                    con.Open();
                //データベースが存在していたら作成しない 未完
                if (System.IO.File.Exists(clientDB)) 
                {
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText =
                            "create table m_client(client_id INTEGER  PRIMARY KEY AUTOINCREMENT, client_name TEXT, address INTEGER, phone_number INTEGER)";//autoincrement = 自動採番
                        command.ExecuteNonQuery();
                    }
                }
                    con.Close();
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
