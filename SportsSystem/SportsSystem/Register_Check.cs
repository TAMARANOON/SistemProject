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
    public partial class Register_Check : Form
    {
        Register register;

        public Register_Check(Register form3)
        {
            InitializeComponent();
            this.register = form3;
        }

        // 登録
        private void button2_Click_1(object sender, EventArgs e){ 
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
                    cmd.Parameters["Name"].Value = label7.Text;
                    cmd.Parameters["Address"].Value = label9.Text;
                    cmd.Parameters["Phone"].Value = label8.Text;
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                    //自動採番されたidの取得
                    cmd.CommandText = "select * from m_client where rowid = last_insert_rowid()";
                }
            }
            Register_Complete form6 = new Register_Complete();
            register.Close();
            form6.Show();
            this.Close();
        }
        //戻る
        private void button1_Click_1(object sender, EventArgs e)
        {
            register.Show();
            this.Close();
        }
    }
}
