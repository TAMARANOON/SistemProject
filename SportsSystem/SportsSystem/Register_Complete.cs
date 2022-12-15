using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsSystem
{
    public partial class Register_Complete : Form
    {
        public Register_Complete()
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
