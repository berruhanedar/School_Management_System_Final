using MySql.Data.MySqlClient;
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
    public partial class Form9 : Form
    {
        private DataTable dataTable;

        public Form9()
        {
            InitializeComponent();
            LoadData();
            PopulateColumnComboBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            string connectionString = "server=localhost;user=root;password=Berru3434++;database=usersınfo";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.ConnectionString = connectionString;
            connection.Open();
            string sql = "SELECT * FROM usersınfo.teacherlistreport";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            teachertable.DataSource = dataTable;
            int rowCount = dataTable.Rows.Count;

            // Erkek ve kadın sayısını hesaplama
            int maleCount = 0;
            int femaleCount = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                string gender = row["Tcgender"].ToString().Trim().ToLower();
                if (gender == "male")
                {
                    maleCount++;
                }
                else if (gender == "female")
                {
                    femaleCount++;
                }
            }
            Total.Text = "Total Teacher: " + rowCount.ToString();
            Male.Text = "Total Male: " + maleCount.ToString();
            Female.Text = "Total Female: " + femaleCount.ToString();
        }

        private void PopulateColumnComboBox()
        {
            foreach (DataColumn column in dataTable.Columns)
            {
                comboBoxColumns.Items.Add(column.ColumnName);
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxColumns.SelectedItem.ToString();
            string filterValue = textBoxFilter.Text;

            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("{0} LIKE '%{1}%'", selectedColumn, filterValue);
            teachertable.DataSource = dv;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 anaEkran = new Form7();
            this.Hide();
            anaEkran.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void buttonFilter_Click_1(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxColumns.SelectedItem.ToString();
            string filterValue = textBoxFilter.Text;

            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("{0} LIKE '%{1}%'", selectedColumn, filterValue);
            teachertable.DataSource = dv;
        }
    }
}
