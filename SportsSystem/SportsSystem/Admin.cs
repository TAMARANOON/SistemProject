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

    }
}
