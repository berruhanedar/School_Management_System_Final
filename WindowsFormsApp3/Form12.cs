using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadData(string filter = "")
        {
            string connectionString = "server=localhost;user=root;password=1905Doctorgs;database=usersınfo";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM usersınfo.canteenproducts";
                if (!string.IsNullOrEmpty(filter))
                {
                    sql += " WHERE NameofProduct LIKE @filter";
                }
                MySqlCommand command = new MySqlCommand(sql, connection);
                if (!string.IsNullOrEmpty(filter))
                {
                    command.Parameters.AddWithValue("@filter", "%" + filter + "%");
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                teachertable.DataSource = dataTable;
                int rowCount = dataTable.Rows.Count;
                Total.Text = "Total Product: " + rowCount.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            Form7 anaEkran = new Form7();
            this.Hide();
            anaEkran.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
        }

        

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            string filter = txtFilter.Text;
            LoadData(filter);
        }
    }
}
