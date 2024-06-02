using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            string connectionString = "server=localhost;user=root;password=Berru3434++;database=usersınfo";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.ConnectionString = connectionString;
            connection.Open();
            string sql = "SELECT * FROM usersınfo.canteenproducts";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            teachertable.DataSource = dataTable;
            int rowCount = dataTable.Rows.Count;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentId.Text, out int studentId) && int.TryParse(txtProductId.Text, out int productId))
            {
                if (!StudentExists(studentId))
                {
                    MessageBox.Show("Geçerli bir öğrenci numarası giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!ProductExists(productId))
                {
                    MessageBox.Show("Geçerli bir ürün numarası giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CanStudentBuyProduct(studentId, productId))
                {
                    ProcessPurchase(studentId, productId);
                }
                else
                {
                    MessageBox.Show("Bu ürünü satın alamazsınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir öğrenci numarası ve ürün numarası giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private bool StudentExists(int studentId)
        {
            string connectionString = "server=localhost;user=root;password=Berru3434++;database=usersınfo";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM kayitstudent WHERE id = @studentId";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool ProductExists(int productId)
        {
            string connectionString = "server=localhost;user=root;password=Berru3434++;database=usersınfo";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM canteenproducts WHERE id = @productId";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@productId", productId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool CanStudentBuyProduct(int studentId, int productId)
        {
            string connectionString = "server=localhost;user=root;password=Berru3434++;database=usersınfo";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM bannedproducts WHERE id = @studentId AND Banned = @productId";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0;
                }
            }
        }

        private void ProcessPurchase(int studentId, int productId)
        {
            string connectionString = "server=localhost;user=root;password=Berru3434++;database=usersınfo";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Ürünün fiyatını al
                        string priceQuery = "SELECT Price FROM canteenproducts WHERE id = @productId";
                        using (MySqlCommand priceCmd = new MySqlCommand(priceQuery, connection, transaction))
                        {
                            priceCmd.Parameters.AddWithValue("@productId", productId);
                            decimal price = Convert.ToDecimal(priceCmd.ExecuteScalar());

                            // Öğrencinin bakiyesini kontrol et
                            string balanceQuery = "SELECT Balance FROM kayitstudent WHERE id = @studentId";
                            using (MySqlCommand balanceCmd = new MySqlCommand(balanceQuery, connection, transaction))
                            {
                                balanceCmd.Parameters.AddWithValue("@studentId", studentId);
                                decimal balance = Convert.ToDecimal(balanceCmd.ExecuteScalar());

                                if (balance >= price)
                                {
                                    // Öğrencinin bakiyesini güncelle
                                    string updateBalanceQuery = "UPDATE kayitstudent SET Balance = Balance - @Price WHERE id = @studentId";
                                    using (MySqlCommand updateBalanceCmd = new MySqlCommand(updateBalanceQuery, connection, transaction))
                                    {
                                        updateBalanceCmd.Parameters.AddWithValue("@Price", price);
                                        updateBalanceCmd.Parameters.AddWithValue("@studentId", studentId);
                                        updateBalanceCmd.ExecuteNonQuery();
                                    }

                                    // Ürünün stokunu güncelle
                                    string updateStockQuery = "UPDATE canteenproducts SET Stock = Stock - 1 WHERE id = @productId";
                                    using (MySqlCommand updateStockCmd = new MySqlCommand(updateStockQuery, connection, transaction))
                                    {
                                        updateStockCmd.Parameters.AddWithValue("@productId", productId);
                                        updateStockCmd.ExecuteNonQuery();
                                    }

                                    transaction.Commit();
                                    MessageBox.Show("Satın alma başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Yetersiz bakiye!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void teachertable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form18 anaEkran = new Form18();
            this.Hide();
            anaEkran.Show();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
