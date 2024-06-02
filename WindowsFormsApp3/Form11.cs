using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData(string nameFilter = "", string idFilter = "")
        {
            string connectionString = "server=localhost;user=root;password=1905Doctorgs;database=usersınfo";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM usersınfo.mobilereg";

                if (!string.IsNullOrEmpty(nameFilter) || !string.IsNullOrEmpty(idFilter))
                {
                    sql += " WHERE 1=1";

                    if (!string.IsNullOrEmpty(nameFilter))
                    {
                        sql += " AND name LIKE @name";
                    }

                    if (!string.IsNullOrEmpty(idFilter))
                    {
                        sql += " AND id = @id";
                    }
                }

                MySqlCommand command = new MySqlCommand(sql, connection);

                if (!string.IsNullOrEmpty(nameFilter))
                {
                    command.Parameters.AddWithValue("@name", "%" + nameFilter + "%");
                }

                if (!string.IsNullOrEmpty(idFilter))
                {
                    command.Parameters.AddWithValue("@id", idFilter);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                teachertable.DataSource = dataTable;

                int rowCount = dataTable.Rows.Count;
                Total.Text = "Total User: " + rowCount.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form7 anaEkran = new Form7();
            this.Hide();
            anaEkran.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

       

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            string nameFilter = txtNameFilter.Text;
            string idFilter = txtIdFilter.Text;
            LoadData(nameFilter, idFilter);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
