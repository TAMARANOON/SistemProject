using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    public partial class DataUpdate : Form
    {
        public string UpdateNumber;
        public DataUpdate()
        {
            InitializeComponent();
        }

        //戻る
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //更新
        private void registerButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=client.db"))
            {
                connection.Open();
                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    SQLiteCommand command = connection.CreateCommand();
                    //インサート
                    command.CommandText =
                        "UPDATE m_client SET client_name = @Name, address = @Address, phone_number = @Phone" +
                        "WHERE" + int.Parse(UpdateNumber);
                    //パラメータセット
                    command.Parameters.Add("Name", DbType.String);
                    command.Parameters.Add("Address", DbType.String);
                    command.Parameters.Add("Phone", DbType.String);
                    //データ追加
                    command.Parameters["Name"].Value = nameBox.Text;
                    command.Parameters["Address"].Value = addressBox.Text;
                    command.Parameters["Phone"].Value = phoneBox.Text;
                    command.ExecuteNonQuery();
                    //コミット
                    transaction.Commit();

                    connection.Close();
                }
            }
        }
    }
}
