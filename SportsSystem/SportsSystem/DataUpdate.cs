using System;
using System.Windows.Forms;

namespace SportsSystem
{
    public partial class DataUpdate : Form
    {
        public DataUpdate()
        {
            InitializeComponent();
        }

        //戻る
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
