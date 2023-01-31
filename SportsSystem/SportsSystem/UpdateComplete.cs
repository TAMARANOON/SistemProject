using System;
using System.Windows.Forms;

namespace SportsSystem
{
    public partial class UpdateComplete : Form
    {
        public UpdateComplete()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Portal portal = new Portal();
            portal.Show();
            this.Close();
        }
    }
}
