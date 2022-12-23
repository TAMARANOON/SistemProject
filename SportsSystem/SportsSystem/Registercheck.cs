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
        public RegisterCheck(Register register)
        {
            InitializeComponent();
            this.register = register;
        }

        // 登録
        private void registerButton_Click(object sender, EventArgs e){ 
            using (SQLiteConnection con = new SQLiteConnection("Data Source=client.db")){
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction()){
                    SQLiteCommand cmd = con.CreateCommand();
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
