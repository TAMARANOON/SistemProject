using System;
using System.Windows.Forms;

namespace SportsSystem
{
    //システムを終了する
    public partial class Shutdown : Form
    {
        public Shutdown()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
