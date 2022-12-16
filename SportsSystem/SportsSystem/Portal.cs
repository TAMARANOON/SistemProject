using System;
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
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        // 終了
        private void button2_Click(object sender, EventArgs e) 
        {
            Shutdown shutdown = new Shutdown();
            shutdown.ShowDialog();
        }

        // 会員登録
        private void registerButton_Click(object sender, EventArgs e) 
        {
            Register register = new Register();
            register.Show();
            this.Hide();

            using (SQLiteConnection con = new SQLiteConnection("Data Source=client.db"))
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    //登録画面表示時にm_clientを作成
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
