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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MotherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParentMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TcID_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TcID.Text) ||
       string.IsNullOrWhiteSpace(TcMail.Text) || string.IsNullOrWhiteSpace(TcSurname.Text) ||
       
                     string.IsNullOrWhiteSpace(TcArea.Text) || string.IsNullOrWhiteSpace(TcAdress.Text)
                    || string.IsNullOrWhiteSpace(TcPhone.Text))


            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*DateTime secilenTarihSaat = dateTimePicker1.Value;
            DateTime secilenTarih2Saat = dateTimePicker2.Value;*/
            string connectionString = "server=localhost;user=root;password=1905Doctorgs;database=usersınfo";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO kayiteacher (Tcname, TcMail, Tcsurname, TcGender, TcAdress, TcPhone, TcArea, TcGrade, TcLetter, id, Birth_Date, Reg_Date) VALUES (@Tcname, @TcMail, @Tcsurname, @TcGender, @TcAdress, @TcPhone, @TcArea, @TcGrade, @TcLetter, @id, @Birth_Date, @Reg_Date)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", TcID.Text);
                    command.Parameters.AddWithValue("@TcMail", TcMail.Text);
                    command.Parameters.AddWithValue("@Tcsurname", TcSurname.Text);
                    command.Parameters.AddWithValue("@TcGender", TcGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@TcArea", TcArea.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@TcLetter", TcLetter.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@TcGrade", TcGrade.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@TcAdress", TcAdress.Text);
                    command.Parameters.AddWithValue("@TcPhone", TcPhone.Text);
                    command.Parameters.AddWithValue("@Tcname", TcName.Text);
                    command.Parameters.AddWithValue("@Birth_Date", Birth_Date.Text);
                    command.Parameters.AddWithValue("@Reg_Date", Reg_Date.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarıyla eklendi.");
                    Form5 anaEkran = new Form5();
                    this.Hide();
                    anaEkran.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK);
                }
            }
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog2.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog2.FileName;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 anaEkran = new Form2();
            this.Hide();
            anaEkran.Show();
        }

        private void TcArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
