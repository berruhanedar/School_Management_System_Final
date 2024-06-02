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
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        string connectionString = "server=localhost;user=root;password=1905Doctorgs;database=usersınfo";
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StSearchBt_Click(object sender, EventArgs e)
        {
            string name = StSearchTxt.Text;
            string number = StIdSearchTxt.Text;
            SearchData(name, number);
        }

        private void SearchData(string name, string number)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Dinamik SQL sorgusu oluşturma
                    string query = "SELECT * FROM listofstudent WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        query += " AND (Name LIKE @name OR Surname LIKE @name)";
                    }

                    if (!string.IsNullOrWhiteSpace(number))
                    {
                        query += " AND id LIKE @number";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                        }

                        if (!string.IsNullOrWhiteSpace(number))
                        {
                            cmd.Parameters.AddWithValue("@number", "%" + number + "%");
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        StSearchTbl.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form3 anaEkran = new Form3();
            this.Hide();
            anaEkran.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StSearchTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
