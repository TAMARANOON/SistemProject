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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // 登録
        private void button2_Click(object sender, EventArgs e) 
        {
            int number = 00000000;
            string name = textBox1.Text;
            string address = textBox2.Text;
            string phone_number = textBox3.Text;

            using (SQLiteConnection con = new SQLiteConnection("Data Source=client.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO m_client (client_id, client_name, address, phone_number) VALUES (@Id, @Name, @Address, @Phone)";

                    cmd.Parameters.Add("Id", System.Data.DbType.Int64);
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("Address", System.Data.DbType.String);
                    cmd.Parameters.Add("Phone", System.Data.DbType.Int64);

                    cmd.Parameters["Id"].Value = number;
                    cmd.Parameters["Name"].Value = name;
                    cmd.Parameters["Address"].Value = address;
                    cmd.Parameters["Phone"].Value = phone_number;
                    cmd.ExecuteNonQuery();

                    trans.Commit();
                }
            }
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // 戻る
        private void button1_Click(object sender, EventArgs e) 
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
