using System;
using System.Windows.Forms;

namespace SportsSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // 登録
        private void registerButton_Click(object sender, EventArgs e) 
        {
            Registercheck registerCheck = new Registercheck(this);

            //氏名、電話番号、住所を遷移先に渡す
            registerCheck.nameLabel.Text = nameBox.Text;
            registerCheck.phoneLabel.Text = phoneLabel.Text;
            registerCheck.addressLabel.Text = addressLabel.Text;

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
