using System;
using System.Data;
using System.Windows.Forms;

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
        
        // 検索
        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}