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
    public partial class Form19 : Form
    {
        private string connectionString = "server=localhost;user=root;password=1905Doctorgs;database=usersınfo";
        private MySqlConnection connection;

        public Form19()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            LoadData();
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM canteenproducts";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AddProduct(int id,string name, double price, int stock)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO canteenproducts (id, NameOfProduct, Price, Stock) VALUES (@id, @name, @price, @stock)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                LoadData();
            }
        }

        private void UpdateProduct(int id, string name, double price, int stock)
        {
            try
            {
                connection.Open();
                string query = "UPDATE canteenproducts SET NameOfProduct = @name, Price = @price, Stock = @stock WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                LoadData();
            }
        }

        private void DeleteProduct(int id)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM canteenproducts WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                LoadData();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            double price = double.Parse(priceTextBox.Text);
            int stock = int.Parse(stockTextBox.Text);
            AddProduct(id, name, price, stock);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            double price = double.Parse(priceTextBox.Text);
            int stock = int.Parse(stockTextBox.Text);
            UpdateProduct(id, name, price, stock);
        
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            DeleteProduct(id);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form18 anaEkran = new Form18();
            this.Hide();
            anaEkran.Show();
        }

        private void stockTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
