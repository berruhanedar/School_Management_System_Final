using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
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
    public partial class Form8 : Form
    {
        private string connectionString = "server=localhost;user=root;password=1905Doctorgs;database=usersınfo";
        public Form8()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedNumber = GradeCb.SelectedItem.ToString();
            string selectedLetter = LetterCb.SelectedItem.ToString();
            SearchData(selectedNumber, selectedLetter);
            GetTeacherName(selectedNumber, selectedLetter);
        }
        private void SearchData(string number, string letter)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Dinamik SQL sorgusu oluşturma
                    string query = "SELECT * FROM classlistreport WHERE Grade = @number AND Letter = @letter";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@number", number);
                        cmd.Parameters.AddWithValue("@letter", letter);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        ClassList.DataSource = dt;

                        int maleCount = 0;
                        int femaleCount = 0;

                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["Gender"].ToString() == "Male")
                            {
                                maleCount++;
                            }
                            else if (row["Gender"].ToString() == "Female")
                            {
                                femaleCount++;
                            }
                        }

                        int totalCount = dt.Rows.Count;

                        // Sonuçları etiketlerde gösterme
                        MaleNum.Text = "Total Male: " + maleCount.ToString();
                        FemaleNum.Text = "Total Female: " + femaleCount.ToString();
                        toplam.Text = "Total Person: " + totalCount.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void GetTeacherName(string number, string letter)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Öğretmen bilgilerini sorgulama
                    string query = "SELECT Tcname, Tcsurname FROM teacherlistreport WHERE TcGrade = @number AND TcLetter = @letter";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@number", number);
                        cmd.Parameters.AddWithValue("@letter", letter);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string teacherName = reader["Tcname"].ToString();
                                string teacherSurname = reader["Tcsurname"].ToString();
                                labelc5.Text = "Teacher: " + teacherName + " " + teacherSurname;
                            }
                            else
                            {
                                labelc5.Text = "Teacher: Not Found";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ClassList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 anaEkran = new Form7();
            this.Hide();
            anaEkran.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
