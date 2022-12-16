using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    public partial class Registercheck : Form
    {
        Register register;
        public Registercheck(Register register)
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
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("Address", System.Data.DbType.String);
                    cmd.Parameters.Add("Phone", System.Data.DbType.String);
                    //データ追加
                    cmd.Parameters["Name"].Value = nameLabel.Text;
                    cmd.Parameters["Address"].Value = addressLabel.Text;
                    cmd.Parameters["Phone"].Value = phoneLabel.Text;
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
            Registercomplete registerComplete = new Registercomplete();
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
