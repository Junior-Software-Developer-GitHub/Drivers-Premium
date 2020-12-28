namespace LV04_Luka_Antic_17005
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sortiraj_dgm = new System.Windows.Forms.Button();
            this.IzmeniVozaca_dgm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.ObrisiVozaca_dgm = new System.Windows.Forms.Button();
            this.dodajVozaca_dgm = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.timerVreme = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // Sortiraj_dgm
            // 
            this.Sortiraj_dgm.FlatAppearance.BorderSize = 0;
            this.Sortiraj_dgm.Location = new System.Drawing.Point(262, 16);
            this.Sortiraj_dgm.Name = "Sortiraj_dgm";
            this.Sortiraj_dgm.Size = new System.Drawing.Size(75, 23);
            this.Sortiraj_dgm.TabIndex = 2;
            this.Sortiraj_dgm.Text = "Sortiraj";
            this.Sortiraj_dgm.UseVisualStyleBackColor = true;
            this.Sortiraj_dgm.Click += new System.EventHandler(this.Sortiraj_dgm_Click);
            // 
            // IzmeniVozaca_dgm
            // 
            this.IzmeniVozaca_dgm.Enabled = false;
            this.IzmeniVozaca_dgm.Location = new System.Drawing.Point(150, 226);
            this.IzmeniVozaca_dgm.Name = "IzmeniVozaca_dgm";
            this.IzmeniVozaca_dgm.Size = new System.Drawing.Size(79, 41);
            this.IzmeniVozaca_dgm.TabIndex = 1;
            this.IzmeniVozaca_dgm.Text = "Izmeni vozaca";
            this.IzmeniVozaca_dgm.UseVisualStyleBackColor = true;
            this.IzmeniVozaca_dgm.Click += new System.EventHandler(this.IzmeniVozaca_dgm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewLista);
            this.groupBox1.Controls.Add(this.IzmeniVozaca_dgm);
            this.groupBox1.Controls.Add(this.ObrisiVozaca_dgm);
            this.groupBox1.Controls.Add(this.dodajVozaca_dgm);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista vozaca";
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.AllowUserToAddRows = false;
            this.dataGridViewLista.AllowUserToDeleteRows = false;
            this.dataGridViewLista.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.ReadOnly = true;
            this.dataGridViewLista.Size = new System.Drawing.Size(495, 201);
            this.dataGridViewLista.TabIndex = 3;
            // 
            // ObrisiVozaca_dgm
            // 
            this.ObrisiVozaca_dgm.Enabled = false;
            this.ObrisiVozaca_dgm.Image = global::LV04_Luka_Antic_17005.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.ObrisiVozaca_dgm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ObrisiVozaca_dgm.Location = new System.Drawing.Point(385, 227);
            this.ObrisiVozaca_dgm.Name = "ObrisiVozaca_dgm";
            this.ObrisiVozaca_dgm.Size = new System.Drawing.Size(116, 41);
            this.ObrisiVozaca_dgm.TabIndex = 2;
            this.ObrisiVozaca_dgm.Text = "Obrisi vozaca";
            this.ObrisiVozaca_dgm.UseVisualStyleBackColor = true;
            this.ObrisiVozaca_dgm.Click += new System.EventHandler(this.ObrisiVozaca_dgm_Click);
            // 
            // dodajVozaca_dgm
            // 
            this.dodajVozaca_dgm.Image = global::LV04_Luka_Antic_17005.Properties.Resources.plus_icon_icons_com_70890;
            this.dodajVozaca_dgm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajVozaca_dgm.Location = new System.Drawing.Point(6, 226);
            this.dodajVozaca_dgm.Name = "dodajVozaca_dgm";
            this.dodajVozaca_dgm.Size = new System.Drawing.Size(115, 41);
            this.dodajVozaca_dgm.TabIndex = 0;
            this.dodajVozaca_dgm.Text = "Dodaj vozaca";
            this.dodajVozaca_dgm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dodajVozaca_dgm.UseVisualStyleBackColor = true;
            this.dodajVozaca_dgm.Click += new System.EventHandler(this.DodajVozaca_dgm_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(9, 21);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(117, 13);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "HH:mm:ss dd.MM.yyyy.";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DisplayMember = "0";
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Broj vozacke dozvole",
            "Ime",
            "Prezime"});
            this.comboBoxSort.Location = new System.Drawing.Point(343, 16);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(133, 21);
            this.comboBoxSort.Sorted = true;
            this.comboBoxSort.TabIndex = 3;
            // 
            // timerVreme
            // 
            this.timerVreme.Interval = 1000;
            this.timerVreme.Tick += new System.EventHandler(this.TimerVreme_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 338);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Sortiraj_dgm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozaci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dodajVozaca_dgm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Timer timerVreme;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.Button Sortiraj_dgm;
        private System.Windows.Forms.Button IzmeniVozaca_dgm;
        private System.Windows.Forms.Button ObrisiVozaca_dgm;
    }
}

