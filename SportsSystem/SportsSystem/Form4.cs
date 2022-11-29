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
    public partial class Form4 : Form
    {
        private string name;
        private void Form4_Shown()
        {
            //label7.Text =;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();

        }

        // 登録
        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            Form3 form3 = new Form3();
            form3.Close();
            form6.Show();
            this.Close();
        }
    }
}
