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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Form17 anaEkran = new Form17();
            this.Hide();
            anaEkran.Show();
        }

        private void Reporting_Click(object sender, EventArgs e)
        {

            Form19 anaEkran = new Form19();
            this.Hide();
            anaEkran.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
