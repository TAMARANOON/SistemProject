using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    //入力した会員情報を確認する画面
    public partial class RegisterCheck : Form
    {
        Register register;
        int CurrentId;
        public RegisterCheck(Register register)
        {
            InitializeComponent();
            this.register = register;
        }

        // 登録
        private void registerButtonClick(object sender, EventArgs e){ 
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=client.db")){
                connection.Open();
                using (SQLiteTransaction transaction = connection.BeginTransaction()){
                    SQLiteCommand command = connection.CreateCommand();
                    //インサート
                    command.CommandText = 
                        "INSERT INTO m_client (client_name, address, phone_number) " +
                        "VALUES (@Name, @Address, @Phone)";
                    //パラメータセット
                    command.Parameters.Add("Name", DbType.String);
                    command.Parameters.Add("Address", DbType.String);
                    command.Parameters.Add("Phone", DbType.String);
                    //データ追加
                    command.Parameters["Name"].Value = nameLabel.Text;
                    command.Parameters["Address"].Value = addressLabel.Text;
                    command.Parameters["Phone"].Value = phoneLabel.Text;
                    command.ExecuteNonQuery();
                    //コミット
                    transaction.Commit();
                    command.CommandText = "SELECT last_insert_rowid()";
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CurrentId = reader.GetInt32(0);
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            //登録完了画面に遷移
            RegisterComplete registerComplete = new RegisterComplete();
            registerComplete.Numberlabel.Text = CurrentId.ToString();
            register.Close();
            registerComplete.Show();
            this.Close();
        }

        //戻る
        private void returnButton_Click(object sender, EventArgs e)
        {
            register.Show();
            this.Close();
        }
    }
}
