using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    //管理者用　テーブルの削除、今登録されている情報の確認
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        //戻る
        private void button1_Click(object sender, EventArgs e)
        {
            Portal portal = new Portal();
            portal.Show();
            this.Close();
        }
        //テーブル削除
        private void button2_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=client.db"))
            {
                connection.Open();
                using(SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "drop table m_client";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            Application.Exit();
        }
        //データ表示
        private void button3_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=client.db"))
            {
                DataTable dataTable = new DataTable();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM m_client", connection);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
