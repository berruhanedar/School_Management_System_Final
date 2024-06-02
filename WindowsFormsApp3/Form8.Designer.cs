namespace WindowsFormsApp3
{
    partial class Form8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.ClassList = new System.Windows.Forms.DataGridView();
            this.MaleNum = new System.Windows.Forms.Label();
            this.FemaleNum = new System.Windows.Forms.Label();
            this.toplam = new System.Windows.Forms.Label();
            this.labelc5 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new WindowsFormsApp3.GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GradeCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LetterCb = new System.Windows.Forms.ComboBox();
            this.SearchBt = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClassList)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassList
            // 
            this.ClassList.AllowUserToAddRows = false;
            this.ClassList.BackgroundColor = System.Drawing.Color.OldLace;
            this.ClassList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(109)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(109)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassList.Location = new System.Drawing.Point(37, 217);
            this.ClassList.Name = "ClassList";
            this.ClassList.RowHeadersVisible = false;
            this.ClassList.RowHeadersWidth = 51;
            this.ClassList.RowTemplate.Height = 24;
            this.ClassList.Size = new System.Drawing.Size(1063, 322);
            this.ClassList.TabIndex = 81;
            this.ClassList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassList_CellContentClick);
            // 
            // MaleNum
            // 
            this.MaleNum.AutoSize = true;
            this.MaleNum.Location = new System.Drawing.Point(488, 503);
            this.MaleNum.Name = "MaleNum";
            this.MaleNum.Size = new System.Drawing.Size(0, 16);
            this.MaleNum.TabIndex = 85;
            // 
            // FemaleNum
            // 
            this.FemaleNum.AutoSize = true;
            this.FemaleNum.Location = new System.Drawing.Point(738, 503);
            this.FemaleNum.Name = "FemaleNum";
            this.FemaleNum.Size = new System.Drawing.Size(0, 16);
            this.FemaleNum.TabIndex = 86;
            // 
            // toplam
            // 
            this.toplam.AutoSize = true;
            this.toplam.Location = new System.Drawing.Point(971, 503);
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(0, 16);
            this.toplam.TabIndex = 87;
            // 
            // labelc5
            // 
            this.labelc5.AutoSize = true;
            this.labelc5.Location = new System.Drawing.Point(81, 503);
            this.labelc5.Name = "labelc5";
            this.labelc5.Size = new System.Drawing.Size(0, 16);
            this.labelc5.TabIndex = 94;
            this.labelc5.Click += new System.EventHandler(this.label3_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 30F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(109)))), ((int)(((byte)(40)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.pictureBox4);
            this.gradientPanel1.Location = new System.Drawing.Point(-2, 1);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1157, 580);
            this.gradientPanel1.TabIndex = 95;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(182)))), ((int)(((byte)(64)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(39, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 45);
            this.panel2.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 89;
            this.label3.Text = "CLASS LIST REPORT";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.GradeCb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LetterCb);
            this.panel1.Controls.Add(this.SearchBt);
            this.panel1.Location = new System.Drawing.Point(39, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 134);
            this.panel1.TabIndex = 0;
            // 
            // GradeCb
            // 
            this.GradeCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GradeCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradeCb.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.GradeCb.FormattingEnabled = true;
            this.GradeCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.GradeCb.Location = new System.Drawing.Point(47, 63);
            this.GradeCb.Name = "GradeCb";
            this.GradeCb.Size = new System.Drawing.Size(297, 38);
            this.GradeCb.TabIndex = 80;
            this.GradeCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(401, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 93;
            this.label2.Text = "LETTER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 92;
            this.label1.Text = "GRADE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(962, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // LetterCb
            // 
            this.LetterCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LetterCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LetterCb.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
            this.LetterCb.ForeColor = System.Drawing.Color.Black;
            this.LetterCb.FormattingEnabled = true;
            this.LetterCb.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.LetterCb.Location = new System.Drawing.Point(404, 63);
            this.LetterCb.Name = "LetterCb";
            this.LetterCb.Size = new System.Drawing.Size(297, 38);
            this.LetterCb.TabIndex = 79;
            // 
            // SearchBt
            // 
            this.SearchBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBt.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.SearchBt.ForeColor = System.Drawing.Color.White;
            this.SearchBt.Location = new System.Drawing.Point(802, 63);
            this.SearchBt.Name = "SearchBt";
            this.SearchBt.Size = new System.Drawing.Size(154, 38);
            this.SearchBt.TabIndex = 82;
            this.SearchBt.Text = "SEARCH";
            this.SearchBt.UseVisualStyleBackColor = false;
            this.SearchBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(751, 601);
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(685, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(505, 601);
            this.pictureBox4.TabIndex = 90;
            this.pictureBox4.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1135, 570);
            this.Controls.Add(this.labelc5);
            this.Controls.Add(this.toplam);
            this.Controls.Add(this.FemaleNum);
            this.Controls.Add(this.MaleNum);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class List Report Screen";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassList)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LetterCb;
        private System.Windows.Forms.ComboBox GradeCb;
        private System.Windows.Forms.DataGridView ClassList;
        private System.Windows.Forms.Button SearchBt;
        private System.Windows.Forms.Label MaleNum;
        private System.Windows.Forms.Label FemaleNum;
        private System.Windows.Forms.Label toplam;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelc5;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}