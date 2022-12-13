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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        // 戻る
        private void button1_Click(object sender, EventArgs e) 
        {
            Portal portal = new Portal();
            portal.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=client.db"))
            {
                var dataTable = new DataTable();

                var adapter = new SQLiteDataAdapter("SELECT * FROM m_client", con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
        }
    }
}
