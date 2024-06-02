
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace WindowsFormsApp3
{
    public partial class Form15 : Form
    {
        private bool passwordVisible = false;

        public Form15()
        {
            InitializeComponent();
            pictureBox4.Click += new EventHandler(pictureBox4_Click); // Add this line to manually attach the event

            passwordTextBox.PasswordChar = '•'; // Şifreyi gizlemek için PasswordChar'ı başlat
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•'; // Form yüklendiğinde şifrenin gizli olduğundan emin olun
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = usernameTextBox.Text;
            string sifre = passwordTextBox.Text;

            try
            {
                string connectionString = "server=localhost;user=root;password=Berru3434++;database=usersınfo";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string sql = "SELECT COUNT(*) FROM canteenreg WHERE username=@username AND password=@password";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", kullaniciAdi);
                command.Parameters.AddWithValue("@password", sifre);

                int kullaniciSayisi = Convert.ToInt32(command.ExecuteScalar());

                if (kullaniciSayisi > 0)
                {
                    Form16 anaEkran = new Form16();
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

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
    }
}