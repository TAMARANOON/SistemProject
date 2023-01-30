using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    //会員を会員番号、氏名、電話番号で検索
    public partial class Search : Form
    {
        //検索する要素　初期値会員番号
        string SearchFormat = "client_id";
        string Number;

        public Search()
        {
            InitializeComponent();
        }
        #region ラジオボタン関係
        //会員番号押下時
        private void idRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (idRadio.Checked)
            {
                searchLabel.Text = "会員番号";
                SearchFormat = "client_id";
            }
        }
        //氏名押下時
        private void nameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (nameRadio.Checked)
            {
                searchLabel.Text = "氏名";
                SearchFormat = "client_name";
            }
        }
        //電話番号押下時
        private void phoneRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (phoneRadio.Checked)
            {
                searchLabel.Text = "電話番号";
                SearchFormat = "phone_number";
            }
        }
        #endregion
        // 戻る
        private void button1_Click(object sender, EventArgs e)
        {
            Portal portal = new Portal();
            portal.Show();
            this.Close();
        }

        // 検索
        private void button2_Click(object sender, EventArgs e)
        {
            string SearchWord;
            SearchWord = SearchBox.Text;

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=client.db"))
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter
                    ("SELECT * FROM m_client WHERE " + SearchFormat + "='" + SearchWord + "'", connection);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
                //該当データの件数
                int cnt = dataGridView1.Rows.Count;
                SubjectCount.Text = "該当件数  " + cnt.ToString() + "件";
            }
        }
        //管理
        private void button3_Click(object sender, EventArgs e)
        {
            DataManagement dataManagement = new DataManagement();
            Number = manageNumber.Text;
            //テキストボックスに何も入力されていない場合
            if (manageNumber.Text.Length == 0)
            {
                MessageBox.Show
                    ("変更する会員の番号が入力されていません。",
                    "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    
                //入力した会員番号を次の画面に
                dataManagement.numberLabel.Text = Number;
                string Name = "";
                string Phone = "";
                string Address = "";

                using (SQLiteConnection connection = new SQLiteConnection("Data Source=client.db"))
                {
                    connection.Open();
                    using (SQLiteTransaction transaction = connection.BeginTransaction())
                    {
                        SQLiteCommand command = connection.CreateCommand();
                        command.CommandText = "SELECT client_name , phone_number, address FROM m_client WHERE client_id = " + Number + " ";
                        using(SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read() == true)
                            {
                                Name = reader["client_name"] as string;
                                Phone = reader["phone_number"] as string;
                                Address = reader["address"] as string;
                            }
                        }
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                dataManagement.nameLabel.Text = Name;
                dataManagement.phoneLabel.Text = Phone;
                dataManagement.addressLabel.Text = Address;
                dataManagement.Show();
                this.Close();
            }
        }
    
    }
    
}
