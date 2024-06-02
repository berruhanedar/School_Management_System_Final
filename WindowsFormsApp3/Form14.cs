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
    public partial class Form14 : Form
    {
        private bool passwordVisible = false;

        public Form14()
        {
            InitializeComponent();
            pictureBox3.Click += new EventHandler(pictureBox3_Click); // Add this line to manually attach the event
            passwordTextBox.PasswordChar = '•'; // Initialize the PasswordChar to hide the password
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•'; // Ensure the password is hidden when the form loads

        }

        private void label1_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•'; // Ensure the password is hidden when the form loads

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = usernameTextBox.Text;
            string sifre = passwordTextBox.Text;

            try
            {
                string connectionString = "server=localhost;user=root;password=1905Doctorgs;database=usersınfo";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "SELECT COUNT(*) FROM desktopauthorization WHERE Username=@Username AND Password=@Password";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", kullaniciAdi);
                command.Parameters.AddWithValue("@Password", sifre);

                int kullaniciSayisi = Convert.ToInt32(command.ExecuteScalar());

                if (kullaniciSayisi > 0)
                {
                    Form13 anaEkran = new Form13();
                    this.Hide();
                    anaEkran.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (passwordVisible)
            {
                passwordTextBox.PasswordChar = '•'; // Hide password
                passwordVisible = false;
            }
            else
            {
                passwordTextBox.PasswordChar = '\0'; // Show password
                passwordVisible = true;
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
