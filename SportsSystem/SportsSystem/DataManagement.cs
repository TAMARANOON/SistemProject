using System;
using System.Windows.Forms;

namespace SportsSystem
{
    public partial class DataManagement : Form
    {
        public DataManagement()
        {
            InitializeComponent();

        }
        //戻る
        private void returnButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Close();
        }

        //削除
        private void button2_Click(object sender, EventArgs e)
        {
            DataDelete dataDelete = new DataDelete();
            dataDelete.ShowDialog();
        }

        //変更
        private void button1_Click(object sender, EventArgs e)
        {
            DataUpdate dataUpdate = new DataUpdate();
            dataUpdate.Show();
        }
    }
}
