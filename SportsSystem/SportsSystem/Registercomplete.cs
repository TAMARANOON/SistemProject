using System;
using System.Windows.Forms;

namespace SportsSystem
{
    //登録した会員情報の番号を確認できる
    public partial class RegisterComplete : Form
    {
        public RegisterComplete()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Portal portal = new Portal();
            portal.Show();
            this.Close();
        }
    }
}