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
            using (var con = new SQLiteConnection("Data Source=client.db"))
            {
                con.Open();
                using(SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText =
                        "drop table m_client";
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=client.db"))
            {
                var dataTable = new DataTable();

                var adapter = new SQLiteDataAdapter("SELECT * FROM m_client", con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
        }
    }
}
