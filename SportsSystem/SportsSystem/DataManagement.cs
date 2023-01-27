using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    public partial class DataManagement : Form
    {
        public DataManagement()
        {
            InitializeComponent();

            //using (SQLiteConnection connection = new SQLiteConnection("Data Source=client.db"))
            //{
            //    connection.Open();
            //    using (SQLiteTransaction transaction = connection.BeginTransaction())
            //    {
            //        SQLiteCommand command = connection.CreateCommand();
            //        command.CommandText = "SELECT " + Number + " FROM m_client WHERE client_id";
            //        command.ExecuteNonQuery();
            //    }
            //    connection.Close();
            //}
        }
        //戻る
        private void returnButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Close();
            search.Show();
        }

        //削除
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //変更
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
