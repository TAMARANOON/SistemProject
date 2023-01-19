using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    //会員を会員番号、氏名、電話番号で検索
    public partial class Search : Form
    {
        string SearchFormat = "client_id";
        string SearchType = "=";
        string Persent = "";
        public Search()
        {
            InitializeComponent();
        }
        private void idRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (idRadio.Checked)
            {
                searchLabel.Text = "会員番号";
                SearchFormat = "client_id";
            }
        }

        private void nameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (nameRadio.Checked)
            {
                searchLabel.Text = "氏名";
                SearchFormat = "client_name";
            }
        }

        private void phoneRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (phoneRadio.Checked)
            {
                searchLabel.Text = "電話番号";
                SearchFormat = "phone_number";
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SearchType = "=";
            Persent =  "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SearchType = "LIKE";
            Persent = "%";
        }

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

            using (SQLiteConnection con = new SQLiteConnection("Data Source=client.db"))
            {
                con.Open();
                var dataTable = new DataTable();
                var adapter = new SQLiteDataAdapter("SELECT * FROM m_client WHERE " + SearchFormat + SearchType + Persent + "'" + SearchWord.ToString() + "'" + Persent, con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
        }

    }
}