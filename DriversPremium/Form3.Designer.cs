namespace DriversPremium
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.Zatvori_dgm = new System.Windows.Forms.Button();
            this.Prosledi_dgm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum do:";
            // 
            // dateTimePickerDo
            // 
            this.dateTimePickerDo.Enabled = false;
            this.dateTimePickerDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDo.Location = new System.Drawing.Point(87, 78);
            this.dateTimePickerDo.Name = "dateTimePickerDo";
            this.dateTimePickerDo.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDo.TabIndex = 5;
            // 
            // dateTimePickerOd
            // 
            this.dateTimePickerOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOd.Location = new System.Drawing.Point(87, 50);
            this.dateTimePickerOd.Name = "dateTimePickerOd";
            this.dateTimePickerOd.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerOd.TabIndex = 4;
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.DisplayMember = "0";
            this.comboBoxKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategorija.Items.AddRange(new object[] {
            "A",
            "A1",
            "A2",
            "AM",
            "B",
            "B1",
            "BE",
            "C",
            "C1",
            "C1E",
            "D",
            "D1",
            "D1E",
            "DE",
            "F",
            "M"});
            this.comboBoxKategorija.Location = new System.Drawing.Point(87, 21);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKategorija.Sorted = true;
            this.comboBoxKategorija.TabIndex = 3;
            // 
            // Zatvori_dgm
            // 
            this.Zatvori_dgm.Location = new System.Drawing.Point(144, 114);
            this.Zatvori_dgm.Name = "Zatvori_dgm";
            this.Zatvori_dgm.Size = new System.Drawing.Size(75, 23);
            this.Zatvori_dgm.TabIndex = 6;
            this.Zatvori_dgm.Text = "Zatvori";
            this.Zatvori_dgm.UseVisualStyleBackColor = true;
            this.Zatvori_dgm.Click += new System.EventHandler(this.Zatvori_dgm_Click);
            // 
            // Prosledi_dgm
            // 
            this.Prosledi_dgm.Location = new System.Drawing.Point(48, 114);
            this.Prosledi_dgm.Name = "Prosledi_dgm";
            this.Prosledi_dgm.Size = new System.Drawing.Size(75, 23);
            this.Prosledi_dgm.TabIndex = 5;
            this.Prosledi_dgm.Text = "Prosledi";
            this.Prosledi_dgm.UseVisualStyleBackColor = true;
            this.Prosledi_dgm.Click += new System.EventHandler(this.Prosledi_dgm_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 151);
            this.Controls.Add(this.Zatvori_dgm);
            this.Controls.Add(this.Prosledi_dgm);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.dateTimePickerDo);
            this.Controls.Add(this.dateTimePickerOd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategorija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Zatvori_dgm;
        private System.Windows.Forms.Button Prosledi_dgm;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
    }
}