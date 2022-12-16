using System;
using System.Windows.Forms;

namespace SportsSystem
{
    public partial class Registercomplete : Form
    {
        public Registercomplete()
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
