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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string connectionString = "server=localhost;user=root;password=1905Doctorgs;database=usersınfo";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.ConnectionString = connectionString;
            connection.Open();
            string sql = "SELECT * FROM usersınfo.studentarrived";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            string mql = "SELECT * FROM usersınfo.studentabsence";
            MySqlCommand cmd = new MySqlCommand(mql, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable datatbl = new DataTable();
            adp.Fill(datatbl);
            dataGridView2.DataSource = datatbl;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 anaEkran = new Form2();
            this.Hide();
            anaEkran.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form7 anaEkran = new Form7();
            this.Hide();
            anaEkran.Show();
        }
    }
}