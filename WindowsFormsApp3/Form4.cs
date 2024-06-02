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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 anaEkran = new Form2();
            this.Hide();
            anaEkran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StID.Text) || string.IsNullOrWhiteSpace(StSchoolID.Text) ||
       string.IsNullOrWhiteSpace(ParentMail.Text) || string.IsNullOrWhiteSpace(MotherName.Text) ||
       string.IsNullOrWhiteSpace(FatherName.Text) || string.IsNullOrWhiteSpace(CByear.Text)
                    || string.IsNullOrWhiteSpace(CBletter.Text) || string.IsNullOrWhiteSpace(StSurname.Text) || string.IsNullOrWhiteSpace(Adress.Text)
                    || string.IsNullOrWhiteSpace(ParentPhone.Text) || string.IsNullOrWhiteSpace(StID.Text))


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
                    string query = "INSERT INTO kayitstudent (Name, NationId, ParentEmail, MotherName, FatherName, Grade, Surname, Adress, ParentPhone, Letter, id, Gender, Birth_Date, Reg_Date, Absence,Balance,Banned) VALUES (@Name,@NationId, @ParentEmail, @MotherName, @FatherName, @Grade, @Surname, @Adress, @ParentPhone, @Letter, @id, @Gender, @Birth_Date, @Reg_Date, @Absence, @Balance, @Banned)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", StID.Text);
                    command.Parameters.AddWithValue("@NationId", StSchoolID.Text);
                    command.Parameters.AddWithValue("@ParentEmail", ParentMail.Text);
                    command.Parameters.AddWithValue("@MotherName", MotherName.Text);
                    command.Parameters.AddWithValue("@FatherName", FatherName.Text);
                    command.Parameters.AddWithValue("@Grade", CByear.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Letter", CBletter.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Gender", StGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Absence", StAbsence.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Surname", StSurname.Text);
                    command.Parameters.AddWithValue("@Adress", Adress.Text);
                    command.Parameters.AddWithValue("@ParentPhone", ParentPhone.Text);
                    command.Parameters.AddWithValue("@Name", StName.Text);
                    command.Parameters.AddWithValue("@Birth_Date", StBirth_Date.Text);
                    command.Parameters.AddWithValue("@Reg_Date", StReg_Date.Text);
                    command.Parameters.AddWithValue("@Balance", Balance.Text);
                    command.Parameters.AddWithValue("@Banned", Banned.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Registration Added Successfully");
                    Form4 anaEkran = new Form4();
                    this.Hide();
                    anaEkran.Show();
                }
                catch (Exception ex)
                {
                     MessageBox.Show("An error occurred while adding the registration: " + ex.Message, "Hata", MessageBoxButtons.OK);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FatherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
