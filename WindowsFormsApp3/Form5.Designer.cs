namespace WindowsFormsApp3
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.SaveButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TcMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TcPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TcAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TcSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TcName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TcID = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Area = new System.Windows.Forms.Label();
            this.TcArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TcGrade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TcGender = new System.Windows.Forms.ComboBox();
            this.Birth_Date = new System.Windows.Forms.TextBox();
            this.Reg_Date = new System.Windows.Forms.TextBox();
            this.TcLetter = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new WindowsFormsApp3.GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(109)))), ((int)(((byte)(40)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(454, 386);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(363, 33);
            this.SaveButton.TabIndex = 58;
            this.SaveButton.Text = "Save Teacher";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(647, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 55;
            this.label11.Text = "Registration Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "Birthday Date";
            // 
            // AddPhoto
            // 
            this.AddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPhoto.Location = new System.Drawing.Point(870, 303);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(313, 34);
            this.AddPhoto.TabIndex = 53;
            this.AddPhoto.Text = "Add Photo";
            this.AddPhoto.UseVisualStyleBackColor = false;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Mail Adress";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TcMail
            // 
            this.TcMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TcMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TcMail.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.TcMail.Location = new System.Drawing.Point(454, 51);
            this.TcMail.Name = "TcMail";
            this.TcMail.Size = new System.Drawing.Size(363, 32);
            this.TcMail.TabIndex = 46;
            this.TcMail.TextChanged += new System.EventHandler(this.ParentMail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Phone Number";
            // 
            // TcPhone
            // 
            this.TcPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TcPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TcPhone.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.TcPhone.Location = new System.Drawing.Point(24, 303);
            this.TcPhone.Name = "TcPhone";
            this.TcPhone.Size = new System.Drawing.Size(354, 32);
            this.TcPhone.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Adress";
            // 
            // TcAdress
            // 
            this.TcAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TcAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TcAdress.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.TcAdress.Location = new System.Drawing.Point(25, 387);
            this.TcAdress.Name = "TcAdress";
            this.TcAdress.Size = new System.Drawing.Size(354, 32);
            this.TcAdress.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Teacher Surname";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TcSurname
            // 
            this.TcSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TcSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TcSurname.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.TcSurname.Location = new System.Drawing.Point(25, 219);
            this.TcSurname.Name = "TcSurname";
            this.TcSurname.Size = new System.Drawing.Size(354, 32);
            this.TcSurname.TabIndex = 36;
            this.TcSurname.TextChanged += new System.EventHandler(this.MotherName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Teacher Name";
            // 
            // TcName
            // 
            this.TcName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TcName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TcName.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.TcName.Location = new System.Drawing.Point(24, 135);
            this.TcName.Name = "TcName";
            this.TcName.Size = new System.Drawing.Size(355, 32);
            this.TcName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Teacher ID";
            // 
            // TcID
            // 
            this.TcID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TcID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TcID.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.TcID.Location = new System.Drawing.Point(22, 51);
            this.TcID.Name = "TcID";
            this.TcID.Size = new System.Drawing.Size(356, 32);
            this.TcID.TabIndex = 30;
            this.TcID.TextChanged += new System.EventHandler(this.TcID_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog2";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(647, 112);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(36, 16);
            this.Area.TabIndex = 57;
            this.Area.Text = "Area";
            // 
            // TcArea
            // 
            this.TcArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TcArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TcArea.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.TcArea.FormattingEnabled = true;
            this.TcArea.Items.AddRange(new object[] {
            "Math",
            "Turkish",
            "English",
            "German",
            "Fen",
            "PE",
            "Drawing",
            "Music",
            "Social Information"});
            this.TcArea.Location = new System.Drawing.Point(650, 135);
            this.TcArea.Name = "TcArea";
            this.TcArea.Size = new System.Drawing.Size(167, 38);
            this.TcArea.TabIndex = 50;
            this.TcArea.SelectedIndexChanged += new System.EventHandler(this.TcArea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Letter";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Grade";
            // 
            // TcGrade
            // 
            this.TcGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TcGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TcGrade.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.TcGrade.FormattingEnabled = true;
            this.TcGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.TcGrade.Location = new System.Drawing.Point(650, 227);
            this.TcGrade.Name = "TcGrade";
            this.TcGrade.Size = new System.Drawing.Size(167, 38);
            this.TcGrade.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Gender";
            // 
            // TcGender
            // 
            this.TcGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TcGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TcGender.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.TcGender.FormattingEnabled = true;
            this.TcGender.Items.AddRange(new object[] {
            "Male\t",
            "Female"});
            this.TcGender.Location = new System.Drawing.Point(454, 135);
            this.TcGender.Name = "TcGender";
            this.TcGender.Size = new System.Drawing.Size(167, 38);
            this.TcGender.TabIndex = 64;
            // 
            // Birth_Date
            // 
            this.Birth_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Birth_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Birth_Date.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.Birth_Date.Location = new System.Drawing.Point(454, 303);
            this.Birth_Date.Name = "Birth_Date";
            this.Birth_Date.Size = new System.Drawing.Size(167, 32);
            this.Birth_Date.TabIndex = 66;
            // 
            // Reg_Date
            // 
            this.Reg_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Reg_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reg_Date.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.Reg_Date.Location = new System.Drawing.Point(650, 305);
            this.Reg_Date.Name = "Reg_Date";
            this.Reg_Date.Size = new System.Drawing.Size(167, 32);
            this.Reg_Date.TabIndex = 67;
            // 
            // TcLetter
            // 
            this.TcLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TcLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TcLetter.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.TcLetter.FormattingEnabled = true;
            this.TcLetter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.TcLetter.Location = new System.Drawing.Point(454, 227);
            this.TcLetter.Name = "TcLetter";
            this.TcLetter.Size = new System.Drawing.Size(167, 38);
            this.TcLetter.TabIndex = 60;
            this.TcLetter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(870, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 120F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(109)))), ((int)(((byte)(40)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.pictureBox4);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1318, 560);
            this.gradientPanel1.TabIndex = 70;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(182)))), ((int)(((byte)(64)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(33, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 37);
            this.panel2.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(61, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 30);
            this.label12.TabIndex = 68;
            this.label12.Text = "TEACHER REGISTRATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.AddPhoto);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.TcGrade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TcGender);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TcLetter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Area);
            this.panel1.Controls.Add(this.TcName);
            this.panel1.Controls.Add(this.TcArea);
            this.panel1.Controls.Add(this.Reg_Date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Birth_Date);
            this.panel1.Controls.Add(this.TcID);
            this.panel1.Controls.Add(this.TcSurname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TcAdress);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TcMail);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TcPhone);
            this.panel1.Location = new System.Drawing.Point(34, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 452);
            this.panel1.TabIndex = 71;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, -11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(782, 571);
            this.pictureBox3.TabIndex = 68;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(885, -54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(587, 597);
            this.pictureBox4.TabIndex = 72;
            this.pictureBox4.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1298, 532);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Registration";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TcMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TcPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TcAdress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TcSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TcName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TcID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.ComboBox TcArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TcGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TcGender;
        private System.Windows.Forms.TextBox Birth_Date;
        private System.Windows.Forms.TextBox Reg_Date;
        private System.Windows.Forms.ComboBox TcLetter;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
    }
}