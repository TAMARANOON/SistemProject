using System;
using System.Data;
using System.Windows.Forms;

namespace SportsSystem
{
    //会員を会員番号、氏名、電話番号で検索
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
        
        // 検索
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void idRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (idRadio.Checked)
            {
                searchLabel.Text = "会員番号";
            }
        }

        private void nameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (nameRadio.Checked)
            {
                searchLabel.Text = "氏名";
            }
        }

        private void phoneRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (phoneRadio.Checked)
            {
                searchLabel.Text = "電話番号";
            }
        }
    }
}