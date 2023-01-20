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
                using (SQLiteTransaction trans = connection.BeginTransaction()){
                    SQLiteCommand cmd = connection.CreateCommand();
                    //インサート
                    cmd.CommandText = "INSERT INTO m_client (client_name, address, phone_number) VALUES (@Name, @Address, @Phone)";
                    //パラメータセット
                    cmd.Parameters.Add("Name", DbType.String);
                    cmd.Parameters.Add("Address", DbType.String);
                    cmd.Parameters.Add("Phone", DbType.String);
                    //データ追加
                    cmd.Parameters["Name"].Value = nameLabel.Text;
                    cmd.Parameters["Address"].Value = addressLabel.Text;
                    cmd.Parameters["Phone"].Value = phoneLabel.Text;
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    connection.Close();
                }
            }
            //登録完了画面に遷移
            RegisterComplete registerComplete = new RegisterComplete();
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
