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
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }

        // 会員管理
        private void button1_Click(object sender, EventArgs e) 
        {
            Search form2 = new Search();
            form2.Show();
            this.Hide();
        }

        // 終了
        private void button2_Click(object sender, EventArgs e) 
        {
            Shatdown form5 = new Shatdown();
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
                    cmd.CommandText = "create table if not exists m_client(client_id INTEGER PRIMARY KEY AUTOINCREMENT, client_name TEXT, address TEXT, phone_number TEXT)";
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        //管理者用メニュー（消去予定）
        private void button4_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
