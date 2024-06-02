using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{


    public partial class Form1 : Form
    {

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form14 anaEkran = new Form14();
            this.Hide();
            anaEkran.Show();
        }

        private void Reporting_Click(object sender, EventArgs e)
        {
            Form15 anaEkran = new Form15();
            this.Hide();
            anaEkran.Show();
        }
    }
}
