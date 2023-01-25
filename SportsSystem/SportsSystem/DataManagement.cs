using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    public partial class DataManagement : Form
    {
        public DataManagement()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
