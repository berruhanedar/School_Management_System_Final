using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 anaEkran = new Form3();
            this.Hide();
            anaEkran.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 anaEkran = new Form4();
            this.Hide();
            anaEkran.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5 anaEkran = new Form5();
            this.Hide();
            anaEkran.Show();
        }

        private void Reporting_Click(object sender, EventArgs e)
        {
            Form7 anaEkran = new Form7();
            this.Hide();
            anaEkran.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
