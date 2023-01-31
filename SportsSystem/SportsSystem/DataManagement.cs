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
            DialogResult result = MessageBox.Show("該当データを削除します。よろしいですか？",
                                                  "削除",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Exclamation,
                                                  MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                DataDelete dataDelete = new DataDelete();
                dataDelete.deleteLabel.Text = numberLabel.Text;
                dataDelete.ShowDialog();
                this.Close();
            }
        }

        //変更
        private void button1_Click(object sender, EventArgs e)
        {
            DataUpdate dataUpdate = new DataUpdate();
            dataUpdate.UpdateNumber = numberLabel.Text;
            dataUpdate.nameBox.Text = nameLabel.Text;
            dataUpdate.phoneBox.Text = phoneLabel.Text;
            dataUpdate.addressBox.Text = addressLabel.Text;
            dataUpdate.ShowDialog();
            this.Close();
        }
    }
}
