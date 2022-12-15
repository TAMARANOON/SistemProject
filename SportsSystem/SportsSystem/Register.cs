using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        // 登録
        private void button2_Click(object sender, EventArgs e) 
        {
            Register_Check r_Check = new Register_Check(this);

            r_Check.label7.Text = textBox1.Text;
            r_Check.label8.Text = textBox2.Text;
            r_Check.label9.Text = textBox3.Text;

            r_Check.ShowDialog();
        }

        // 戻る
        private void button1_Click(object sender, EventArgs e) 
        {
            Portal portal = new Portal();
            portal.Show();
            this.Close();
        }
    }
}
