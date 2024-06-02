namespace WindowsFormsApp3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.gradientPanel1 = new WindowsFormsApp3.GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.balancasdae = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.TextBox();
            this.StName = new System.Windows.Forms.TextBox();
            this.Banned = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StSurname = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StAbsence = new System.Windows.Forms.ComboBox();
            this.StID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StGender = new System.Windows.Forms.ComboBox();
            this.StSchoolID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.FatherName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ParentMail = new System.Windows.Forms.TextBox();
            this.StReg_Date = new System.Windows.Forms.TextBox();
            this.ParentPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBletter = new System.Windows.Forms.ComboBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CByear = new System.Windows.Forms.ComboBox();
            this.MotherName = new System.Windows.Forms.TextBox();
            this.StBirth_Date = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 315F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(109)))), ((int)(((byte)(40)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.pictureBox4);
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1334, 562);
            this.gradientPanel1.TabIndex = 84;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(182)))), ((int)(((byte)(64)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(33, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 37);
            this.panel2.TabIndex = 84;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.balancasdae);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.Balance);
            this.panel1.Controls.Add(this.StName);
            this.panel1.Controls.Add(this.Banned);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StSurname);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.StAbsence);
            this.panel1.Controls.Add(this.StID);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StGender);
            this.panel1.Controls.Add(this.StSchoolID);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.FatherName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.ParentMail);
            this.panel1.Controls.Add(this.StReg_Date);
            this.panel1.Controls.Add(this.ParentPhone);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CBletter);
            this.panel1.Controls.Add(this.Adress);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CByear);
            this.panel1.Controls.Add(this.MotherName);
            this.panel1.Controls.Add(this.StBirth_Date);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(34, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 452);
            this.panel1.TabIndex = 87;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(961, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add Photo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(923, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // balancasdae
            // 
            this.balancasdae.AutoSize = true;
            this.balancasdae.Location = new System.Drawing.Point(841, 289);
            this.balancasdae.Name = "balancasdae";
            this.balancasdae.Size = new System.Drawing.Size(57, 16);
            this.balancasdae.TabIndex = 81;
            this.balancasdae.Text = "Balance";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1028, 289);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 16);
            this.label19.TabIndex = 83;
            this.label19.Text = "Restricted Products";
            // 
            // Balance
            // 
            this.Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Balance.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.Balance.ForeColor = System.Drawing.Color.White;
            this.Balance.Location = new System.Drawing.Point(844, 312);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(167, 32);
            this.Balance.TabIndex = 80;
            // 
            // StName
            // 
            this.StName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StName.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.StName.Location = new System.Drawing.Point(22, 227);
            this.StName.Name = "StName";
            this.StName.Size = new System.Drawing.Size(167, 32);
            this.StName.TabIndex = 4;
            this.StName.TextChanged += new System.EventHandler(this.StName_TextChanged);
            // 
            // Banned
            // 
            this.Banned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Banned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Banned.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.Banned.Location = new System.Drawing.Point(1031, 312);
            this.Banned.Name = "Banned";
            this.Banned.Size = new System.Drawing.Size(167, 32);
            this.Banned.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StSurname
            // 
            this.StSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StSurname.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.StSurname.Location = new System.Drawing.Point(211, 227);
            this.StSurname.Name = "StSurname";
            this.StSurname.Size = new System.Drawing.Size(167, 32);
            this.StSurname.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(109)))), ((int)(((byte)(40)))));
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(844, 390);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(354, 37);
            this.SaveButton.TabIndex = 28;
            this.SaveButton.Text = "SAVE STUDENT";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(620, 375);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 16);
            this.label17.TabIndex = 79;
            this.label17.Text = "Absence ";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student Surname";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // StAbsence
            // 
            this.StAbsence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StAbsence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StAbsence.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.StAbsence.FormattingEnabled = true;
            this.StAbsence.Items.AddRange(new object[] {
            "Absence\t",
            "Arrived"});
            this.StAbsence.Location = new System.Drawing.Point(622, 392);
            this.StAbsence.Name = "StAbsence";
            this.StAbsence.Size = new System.Drawing.Size(171, 38);
            this.StAbsence.TabIndex = 78;
            // 
            // StID
            // 
            this.StID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StID.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.StID.Location = new System.Drawing.Point(22, 51);
            this.StID.Name = "StID";
            this.StID.Size = new System.Drawing.Size(356, 32);
            this.StID.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(434, 373);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 77;
            this.label16.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student School ID";
            // 
            // StGender
            // 
            this.StGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StGender.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.StGender.FormattingEnabled = true;
            this.StGender.Items.AddRange(new object[] {
            "Male\t",
            "Female"});
            this.StGender.Location = new System.Drawing.Point(437, 392);
            this.StGender.Name = "StGender";
            this.StGender.Size = new System.Drawing.Size(167, 38);
            this.StGender.TabIndex = 76;
            // 
            // StSchoolID
            // 
            this.StSchoolID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StSchoolID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StSchoolID.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.StSchoolID.Location = new System.Drawing.Point(23, 140);
            this.StSchoolID.Name = "StSchoolID";
            this.StSchoolID.Size = new System.Drawing.Size(355, 32);
            this.StSchoolID.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(620, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Letter";
            // 
            // FatherName
            // 
            this.FatherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FatherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FatherName.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.FatherName.Location = new System.Drawing.Point(211, 315);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(167, 32);
            this.FatherName.TabIndex = 8;
            this.FatherName.TextChanged += new System.EventHandler(this.FatherName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Parent Mail Adress";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Grade";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // ParentMail
            // 
            this.ParentMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ParentMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParentMail.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.ParentMail.Location = new System.Drawing.Point(437, 227);
            this.ParentMail.Name = "ParentMail";
            this.ParentMail.Size = new System.Drawing.Size(356, 32);
            this.ParentMail.TabIndex = 16;
            // 
            // StReg_Date
            // 
            this.StReg_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StReg_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StReg_Date.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.StReg_Date.Location = new System.Drawing.Point(23, 398);
            this.StReg_Date.Name = "StReg_Date";
            this.StReg_Date.Size = new System.Drawing.Size(167, 32);
            this.StReg_Date.TabIndex = 73;
            // 
            // ParentPhone
            // 
            this.ParentPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ParentPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParentPhone.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.ParentPhone.Location = new System.Drawing.Point(437, 140);
            this.ParentPhone.Name = "ParentPhone";
            this.ParentPhone.Size = new System.Drawing.Size(356, 32);
            this.ParentPhone.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Parent Phone Number";
            // 
            // CBletter
            // 
            this.CBletter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CBletter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBletter.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.CBletter.FormattingEnabled = true;
            this.CBletter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.CBletter.Location = new System.Drawing.Point(622, 309);
            this.CBletter.Name = "CBletter";
            this.CBletter.Size = new System.Drawing.Size(167, 38);
            this.CBletter.TabIndex = 20;
            // 
            // Adress
            // 
            this.Adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Adress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Adress.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.Adress.Location = new System.Drawing.Point(437, 51);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(356, 32);
            this.Adress.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 375);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 16);
            this.label14.TabIndex = 71;
            this.label14.Text = "Registration Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Father Name";
            // 
            // CByear
            // 
            this.CByear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CByear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CByear.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.CByear.FormattingEnabled = true;
            this.CByear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.CByear.Location = new System.Drawing.Point(437, 309);
            this.CByear.Name = "CByear";
            this.CByear.Size = new System.Drawing.Size(167, 38);
            this.CByear.TabIndex = 19;
            this.CByear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MotherName
            // 
            this.MotherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MotherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MotherName.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.MotherName.Location = new System.Drawing.Point(22, 315);
            this.MotherName.Name = "MotherName";
            this.MotherName.Size = new System.Drawing.Size(167, 32);
            this.MotherName.TabIndex = 6;
            // 
            // StBirth_Date
            // 
            this.StBirth_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StBirth_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StBirth_Date.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.StBirth_Date.Location = new System.Drawing.Point(211, 398);
            this.StBirth_Date.Name = "StBirth_Date";
            this.StBirth_Date.Size = new System.Drawing.Size(167, 32);
            this.StBirth_Date.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 375);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 70;
            this.label15.Text = "Birthday Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mother Name";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(700, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(611, 549);
            this.pictureBox4.TabIndex = 86;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(680, 543);
            this.pictureBox3.TabIndex = 85;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(66, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 30);
            this.label10.TabIndex = 85;
            this.label10.Text = "STUDENT REGISTRATION";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1298, 532);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox StID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StSchoolID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FatherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MotherName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ParentMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ParentPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.ComboBox CByear;
        private System.Windows.Forms.ComboBox CBletter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SaveButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox StReg_Date;
        private System.Windows.Forms.TextBox StBirth_Date;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox StGender;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox StAbsence;
        private System.Windows.Forms.Label balancasdae;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Banned;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
    }
}