using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Classlist_Click(object sender, EventArgs e)
        {
            Form8 anaEkran = new Form8();
            this.Hide();
            anaEkran.Show();
        }

        private void TeacherList_Click(object sender, EventArgs e)
        {
            Form9 anaEkran = new Form9();
            this.Hide();
            anaEkran.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 anaEkran = new Form10();
            this.Hide();
            anaEkran.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 anaEkran = new Form2();
            this.Hide();
            anaEkran.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 anaEkran = new Form11();
            this.Hide();
            anaEkran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 anaEkran = new Form12();
            this.Hide();
            anaEkran.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
