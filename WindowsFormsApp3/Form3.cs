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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        string connectionString = "server=localhost;user=root;password=1905Doctorgs;database=usersınfo";
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM listofstudent";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // İlk DataGridView için filtreleme
                    DataView arrivedView = new DataView(dataTable);
                    arrivedView.RowFilter = "Absence = 'Arrived'";
                    dataGridView1.DataSource = arrivedView;

                    // İkinci DataGridView için filtreleme
                    DataView absenceView = new DataView(dataTable);
                    absenceView.RowFilter = "Absence = 'Absence'";
                    dataGridView2.DataSource = absenceView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Message has been sent to parent");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 anaEkran = new Form6();
            this.Hide();
            anaEkran.Show();
        }
    }
}
