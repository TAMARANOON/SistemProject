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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // 登録
        private void button2_Click(object sender, EventArgs e) 
        {
            Form4 form4 = new Form4(this);

            form4.label7.Text = textBox1.Text;
            form4.label8.Text = textBox2.Text;
            form4.label9.Text = textBox3.Text;

            form4.ShowDialog();
        }

        // 戻る
        private void button1_Click(object sender, EventArgs e) 
        {
            Portal form1 = new Portal();
            form1.Show();
            this.Close();
        }
    }
}
