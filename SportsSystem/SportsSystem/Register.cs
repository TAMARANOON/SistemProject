using System;
using System.Windows.Forms;

namespace SportsSystem
{
    //登録する情報を入力
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // 登録
        private void registerButton_Click(object sender, EventArgs e) 
        {
            RegisterCheck registerCheck = new RegisterCheck(this);

            //氏名、電話番号、住所を遷移先に渡す
            registerCheck.nameLabel.Text = nameBox.Text;
            registerCheck.phoneLabel.Text = phoneBox.Text;
            registerCheck.addressLabel.Text = addressBox.Text;

            registerCheck.ShowDialog();
        }

        // メインメニューに戻る
        private void returnButton_Click(object sender, EventArgs e) 
        {
            Portal portal = new Portal();
            portal.Show();
            this.Close();
        }
    }
}
