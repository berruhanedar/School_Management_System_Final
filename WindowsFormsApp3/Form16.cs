using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace WindowsFormsApp3
{
    public partial class Form16 : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );

        public Form16()
        {
            InitializeComponent();
            progressBar.Value = 0;
            timer1.Interval = 150; // 3 saniye
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 20; //we will increment the value of the progressbar by +2
            progressBar.Text = progressBar.Value.ToString() + "%";
            if (progressBar.Value == 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide(); // SplashScreen formunu gizler
                Form18 mainForm = new Form18();
                mainForm.Show(); // MainForm formunu gösterir
            }


        }
    }
}
