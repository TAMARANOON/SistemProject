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
        Form3 form3 = new Form3();
        Form6 form6 = new Form6();

        public Form4()
        {
            InitializeComponent();
        }

        // 登録
        private void button2_Click_1(object sender, EventArgs e)
        {
            form3.Close();
            form6.Show();
            this.Close();
        }
        //戻る
        private void button1_Click_1(object sender, EventArgs e)
        {

            form3.Show();
            this.Close();
        }
    }
}
