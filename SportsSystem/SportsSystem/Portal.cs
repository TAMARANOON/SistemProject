using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    //メインメニュー　会員の管理、登録画面に遷移できる
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
            using (SQLiteConnection con = new SQLiteConnection("Data Source=client.db"))
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    //m_clientを作成
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS m_client(client_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        " client_name TEXT, address TEXT, phone_number TEXT)";
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
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
