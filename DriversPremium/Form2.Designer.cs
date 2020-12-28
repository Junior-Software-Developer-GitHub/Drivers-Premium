namespace DriversPremium
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxSlikaVozaca = new System.Windows.Forms.PictureBox();
            this.dateTimePickerVazenjeDo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVazenjeOd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.pol_comboBox = new System.Windows.Forms.ComboBox();
            this.mestoIzdavanja_txt = new System.Windows.Forms.TextBox();
            this.brDozvole_txt = new System.Windows.Forms.TextBox();
            this.prezime_txt = new System.Windows.Forms.TextBox();
            this.ime_txt = new System.Windows.Forms.TextBox();
            this.DodajSliku_dgm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKategorije = new System.Windows.Forms.DataGridView();
            this.ObrisiKategoriju_dgm = new System.Windows.Forms.Button();
            this.DodajKategoriju_dgm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewZabrane = new System.Windows.Forms.DataGridView();
            this.ObrisiZabranu_dgm = new System.Windows.Forms.Button();
            this.DodajNovuZabranu_dgm = new System.Windows.Forms.Button();
            this.Prosledi_dgm = new System.Windows.Forms.Button();
            this.Zatvori_dgm = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaVozaca)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorije)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZabrane)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rodjenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vazenje dozvole od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "do:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Br. vozacke dozvole:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mesto izdavanja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pol:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxSlikaVozaca);
            this.groupBox1.Controls.Add(this.dateTimePickerVazenjeDo);
            this.groupBox1.Controls.Add(this.dateTimePickerVazenjeOd);
            this.groupBox1.Controls.Add(this.dateTimePickerDatumRodjenja);
            this.groupBox1.Controls.Add(this.pol_comboBox);
            this.groupBox1.Controls.Add(this.mestoIzdavanja_txt);
            this.groupBox1.Controls.Add(this.brDozvole_txt);
            this.groupBox1.Controls.Add(this.prezime_txt);
            this.groupBox1.Controls.Add(this.ime_txt);
            this.groupBox1.Controls.Add(this.DodajSliku_dgm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci";
            // 
            // pictureBoxSlikaVozaca
            // 
            this.pictureBoxSlikaVozaca.Location = new System.Drawing.Point(327, 6);
            this.pictureBoxSlikaVozaca.Name = "pictureBoxSlikaVozaca";
            this.pictureBoxSlikaVozaca.Size = new System.Drawing.Size(105, 119);
            this.pictureBoxSlikaVozaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlikaVozaca.TabIndex = 10;
            this.pictureBoxSlikaVozaca.TabStop = false;
            // 
            // dateTimePickerVazenjeDo
            // 
            this.dateTimePickerVazenjeDo.Enabled = false;
            this.dateTimePickerVazenjeDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVazenjeDo.Location = new System.Drawing.Point(135, 124);
            this.dateTimePickerVazenjeDo.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerVazenjeDo.Name = "dateTimePickerVazenjeDo";
            this.dateTimePickerVazenjeDo.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerVazenjeDo.TabIndex = 5;
            // 
            // dateTimePickerVazenjeOd
            // 
            this.dateTimePickerVazenjeOd.Enabled = false;
            this.dateTimePickerVazenjeOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVazenjeOd.Location = new System.Drawing.Point(135, 99);
            this.dateTimePickerVazenjeOd.MaxDate = new System.DateTime(2109, 8, 16, 0, 0, 0, 0);
            this.dateTimePickerVazenjeOd.MinDate = new System.DateTime(1768, 12, 25, 0, 0, 0, 0);
            this.dateTimePickerVazenjeOd.Name = "dateTimePickerVazenjeOd";
            this.dateTimePickerVazenjeOd.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerVazenjeOd.TabIndex = 4;
            this.dateTimePickerVazenjeOd.ValueChanged += new System.EventHandler(this.DateTimePickerVazenjeOd_ValueChanged);
            // 
            // dateTimePickerDatumRodjenja
            // 
            this.dateTimePickerDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatumRodjenja.Location = new System.Drawing.Point(135, 74);
            this.dateTimePickerDatumRodjenja.MaxDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDatumRodjenja.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDatumRodjenja.Name = "dateTimePickerDatumRodjenja";
            this.dateTimePickerDatumRodjenja.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDatumRodjenja.TabIndex = 3;
            this.dateTimePickerDatumRodjenja.Value = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDatumRodjenja.ValueChanged += new System.EventHandler(this.DateTimePickerDatumRodjenja_ValueChanged);
            // 
            // pol_comboBox
            // 
            this.pol_comboBox.DisplayMember = "0";
            this.pol_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pol_comboBox.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.pol_comboBox.Location = new System.Drawing.Point(135, 199);
            this.pol_comboBox.Name = "pol_comboBox";
            this.pol_comboBox.Size = new System.Drawing.Size(100, 21);
            this.pol_comboBox.Sorted = true;
            this.pol_comboBox.TabIndex = 8;
            // 
            // mestoIzdavanja_txt
            // 
            this.mestoIzdavanja_txt.Location = new System.Drawing.Point(135, 174);
            this.mestoIzdavanja_txt.Name = "mestoIzdavanja_txt";
            this.mestoIzdavanja_txt.Size = new System.Drawing.Size(100, 20);
            this.mestoIzdavanja_txt.TabIndex = 7;
            this.mestoIzdavanja_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MestoIzdavanja_txt_KeyPress);
            // 
            // brDozvole_txt
            // 
            this.brDozvole_txt.Location = new System.Drawing.Point(135, 149);
            this.brDozvole_txt.MaxLength = 9;
            this.brDozvole_txt.Name = "brDozvole_txt";
            this.brDozvole_txt.Size = new System.Drawing.Size(100, 20);
            this.brDozvole_txt.TabIndex = 6;
            this.brDozvole_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BrDozvole_txt_KeyPress);
            // 
            // prezime_txt
            // 
            this.prezime_txt.Location = new System.Drawing.Point(135, 49);
            this.prezime_txt.Name = "prezime_txt";
            this.prezime_txt.Size = new System.Drawing.Size(100, 20);
            this.prezime_txt.TabIndex = 2;
            this.prezime_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prezime_txt_KeyPress);
            // 
            // ime_txt
            // 
            this.ime_txt.Location = new System.Drawing.Point(135, 24);
            this.ime_txt.Name = "ime_txt";
            this.ime_txt.Size = new System.Drawing.Size(100, 20);
            this.ime_txt.TabIndex = 1;
            this.ime_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ime_txt_KeyPress);
            // 
            // DodajSliku_dgm
            // 
            this.DodajSliku_dgm.Location = new System.Drawing.Point(342, 131);
            this.DodajSliku_dgm.Name = "DodajSliku_dgm";
            this.DodajSliku_dgm.Size = new System.Drawing.Size(75, 23);
            this.DodajSliku_dgm.TabIndex = 9;
            this.DodajSliku_dgm.Text = "Dodaj sliku";
            this.DodajSliku_dgm.UseVisualStyleBackColor = true;
            this.DodajSliku_dgm.Click += new System.EventHandler(this.DodajSliku_dgm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewKategorije);
            this.groupBox2.Controls.Add(this.ObrisiKategoriju_dgm);
            this.groupBox2.Controls.Add(this.DodajKategoriju_dgm);
            this.groupBox2.Location = new System.Drawing.Point(13, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategorija";
            // 
            // dataGridViewKategorije
            // 
            this.dataGridViewKategorije.AllowUserToAddRows = false;
            this.dataGridViewKategorije.AllowUserToDeleteRows = false;
            this.dataGridViewKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategorije.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewKategorije.Name = "dataGridViewKategorije";
            this.dataGridViewKategorije.ReadOnly = true;
            this.dataGridViewKategorije.Size = new System.Drawing.Size(434, 88);
            this.dataGridViewKategorije.TabIndex = 0;
            // 
            // ObrisiKategoriju_dgm
            // 
            this.ObrisiKategoriju_dgm.Enabled = false;
            this.ObrisiKategoriju_dgm.Image = global::DriversPremium.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.ObrisiKategoriju_dgm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ObrisiKategoriju_dgm.Location = new System.Drawing.Point(311, 113);
            this.ObrisiKategoriju_dgm.Name = "ObrisiKategoriju_dgm";
            this.ObrisiKategoriju_dgm.Size = new System.Drawing.Size(129, 46);
            this.ObrisiKategoriju_dgm.TabIndex = 2;
            this.ObrisiKategoriju_dgm.Text = "Obrisi kategoriju";
            this.ObrisiKategoriju_dgm.UseVisualStyleBackColor = true;
            this.ObrisiKategoriju_dgm.Click += new System.EventHandler(this.ObrisiKategoriju_dgm_Click);
            // 
            // DodajKategoriju_dgm
            // 
            this.DodajKategoriju_dgm.Image = global::DriversPremium.Properties.Resources.plus_icon_icons_com_70890;
            this.DodajKategoriju_dgm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DodajKategoriju_dgm.Location = new System.Drawing.Point(20, 113);
            this.DodajKategoriju_dgm.Name = "DodajKategoriju_dgm";
            this.DodajKategoriju_dgm.Size = new System.Drawing.Size(110, 46);
            this.DodajKategoriju_dgm.TabIndex = 1;
            this.DodajKategoriju_dgm.Text = "Dodaj novu kategoriju";
            this.DodajKategoriju_dgm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DodajKategoriju_dgm.UseVisualStyleBackColor = true;
            this.DodajKategoriju_dgm.Click += new System.EventHandler(this.DodajKategoriju_dgm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewZabrane);
            this.groupBox3.Controls.Add(this.ObrisiZabranu_dgm);
            this.groupBox3.Controls.Add(this.DodajNovuZabranu_dgm);
            this.groupBox3.Location = new System.Drawing.Point(13, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zabrana upravljanja";
            // 
            // dataGridViewZabrane
            // 
            this.dataGridViewZabrane.AllowUserToAddRows = false;
            this.dataGridViewZabrane.AllowUserToDeleteRows = false;
            this.dataGridViewZabrane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZabrane.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewZabrane.Name = "dataGridViewZabrane";
            this.dataGridViewZabrane.ReadOnly = true;
            this.dataGridViewZabrane.Size = new System.Drawing.Size(434, 88);
            this.dataGridViewZabrane.TabIndex = 0;
            // 
            // ObrisiZabranu_dgm
            // 
            this.ObrisiZabranu_dgm.Enabled = false;
            this.ObrisiZabranu_dgm.Image = global::DriversPremium.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.ObrisiZabranu_dgm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ObrisiZabranu_dgm.Location = new System.Drawing.Point(311, 113);
            this.ObrisiZabranu_dgm.Name = "ObrisiZabranu_dgm";
            this.ObrisiZabranu_dgm.Size = new System.Drawing.Size(129, 46);
            this.ObrisiZabranu_dgm.TabIndex = 2;
            this.ObrisiZabranu_dgm.Text = "Obrisi zabranu";
            this.ObrisiZabranu_dgm.UseVisualStyleBackColor = true;
            this.ObrisiZabranu_dgm.Click += new System.EventHandler(this.ObrisiZabranu_dgm_Click);
            // 
            // DodajNovuZabranu_dgm
            // 
            this.DodajNovuZabranu_dgm.Image = global::DriversPremium.Properties.Resources.plus_icon_icons_com_70890;
            this.DodajNovuZabranu_dgm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DodajNovuZabranu_dgm.Location = new System.Drawing.Point(20, 113);
            this.DodajNovuZabranu_dgm.Name = "DodajNovuZabranu_dgm";
            this.DodajNovuZabranu_dgm.Size = new System.Drawing.Size(110, 46);
            this.DodajNovuZabranu_dgm.TabIndex = 1;
            this.DodajNovuZabranu_dgm.Text = "Dodaj novu zabranu";
            this.DodajNovuZabranu_dgm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DodajNovuZabranu_dgm.UseVisualStyleBackColor = true;
            this.DodajNovuZabranu_dgm.Click += new System.EventHandler(this.DodajNovuZabranu_dgm_Click);
            // 
            // Prosledi_dgm
            // 
            this.Prosledi_dgm.Location = new System.Drawing.Point(147, 607);
            this.Prosledi_dgm.Name = "Prosledi_dgm";
            this.Prosledi_dgm.Size = new System.Drawing.Size(75, 23);
            this.Prosledi_dgm.TabIndex = 3;
            this.Prosledi_dgm.Text = "Prosledi";
            this.Prosledi_dgm.UseVisualStyleBackColor = true;
            this.Prosledi_dgm.Click += new System.EventHandler(this.Prosledi_dgm_Click);
            // 
            // Zatvori_dgm
            // 
            this.Zatvori_dgm.Location = new System.Drawing.Point(256, 607);
            this.Zatvori_dgm.Name = "Zatvori_dgm";
            this.Zatvori_dgm.Size = new System.Drawing.Size(75, 23);
            this.Zatvori_dgm.TabIndex = 4;
            this.Zatvori_dgm.Text = "Zatvori";
            this.Zatvori_dgm.UseVisualStyleBackColor = true;
            this.Zatvori_dgm.Click += new System.EventHandler(this.Zatvori_dgm_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 642);
            this.Controls.Add(this.Zatvori_dgm);
            this.Controls.Add(this.Prosledi_dgm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaVozaca)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorije)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZabrane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DodajSliku_dgm;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRodjenja;
        private System.Windows.Forms.DateTimePicker dateTimePickerVazenjeDo;
        private System.Windows.Forms.DateTimePicker dateTimePickerVazenjeOd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Zatvori_dgm;
        private System.Windows.Forms.TextBox ime_txt;
        private System.Windows.Forms.TextBox prezime_txt;
        private System.Windows.Forms.TextBox mestoIzdavanja_txt;
        private System.Windows.Forms.ComboBox pol_comboBox;
        public System.Windows.Forms.Button Prosledi_dgm;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox brDozvole_txt;
        private System.Windows.Forms.PictureBox pictureBoxSlikaVozaca;
        private System.Windows.Forms.DataGridView dataGridViewKategorije;
        private System.Windows.Forms.DataGridView dataGridViewZabrane;
        private System.Windows.Forms.Button DodajKategoriju_dgm;
        private System.Windows.Forms.Button ObrisiKategoriju_dgm;
        private System.Windows.Forms.Button ObrisiZabranu_dgm;
        private System.Windows.Forms.Button DodajNovuZabranu_dgm;
    }
}