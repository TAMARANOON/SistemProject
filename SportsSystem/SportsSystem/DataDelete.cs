using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    public partial class DataDelete : Form
    {
        public DataDelete()
        {
            InitializeComponent();
        }

        //完了
        private void returnButton_Click(object sender, EventArgs e)
        {
            string DeleteId;
            DeleteId = deleteLabel.Text;

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=client.db"))
            {
                connection.Open(); SQLiteCommand command = connection.CreateCommand();

                command.CommandText = "DELETE FROM m_client WHERE client_id = " + DeleteId;
                command.ExecuteNonQuery();
                connection.Close();
            }

            Portal portal = new Portal();
            portal.Show();
            this.Close();
        }
    }
}
