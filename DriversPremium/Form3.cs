using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Osobe;

namespace DriversPremium
{
    public partial class Form3 : Form
    {
        #region Attributes
        private static DataTable dt1 = new DataTable();
        private static DataTable dt2 = new DataTable();
        #endregion Attributes

        #region Constructor
        public Form3()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Properties
        public DataTable DT1
        {
            get { return dt1; }
            set { dt1 = value; }
        }
        public DataTable DT2
        {
            get { return dt2; }
            set { dt2 = value; }
        }
        public ComboBox Kategorija
        {
            get { return comboBoxKategorija; }
            set { comboBoxKategorija = value; }
        }

        public DateTimePicker DatumOd
        {
            get { return dateTimePickerOd; }
            set { dateTimePickerOd = value; }
        }
        public DateTimePicker DatumDo
        {
            get { return dateTimePickerDo; }
            set { dateTimePickerOd = value; }
        }
        #endregion Properties

        #region Methods
        private void Prosledi_dgm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = (Form2)Application.OpenForms["Form2"];
            fm2.DodajNovuKategoriju.Enabled = fm2.DodajNovuZabranu.Enabled = true;
           
            if (this.Text == "ZABRANA")
            {
                NapraviKolone(DT1);

                if (DT1.Columns.Count > 0) fm2.ObrisiZabranu.Enabled = true;
                
                DT1.Rows.Add(comboBoxKategorija.SelectedItem, dateTimePickerOd.Value, dateTimePickerDo.Value);
                fm2.Zabrane.DataSource = DT1;
            }
            else
            {
                NapraviKolone(DT2);

                if (DT2.Columns.Count > 0) fm2.ObrisiKategoriju.Enabled = true;
                DT2.Rows.Add(comboBoxKategorija.SelectedItem, dateTimePickerOd.Value, dateTimePickerDo.Value);
                fm2.Kategorije.DataSource = DT2;    
            }
            fm2.Show();
        }
        
        private void NapraviKolone(DataTable dt)
        {
            _ = (dt.Columns.Count == 0) ? (dt.Columns.Add("Kategorije"), dt.Columns.Add("Vazenje od"),
                   dt.Columns.Add("Vazenje do")) : (null, null, null);
        }
        private void Zatvori_dgm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li zelite da zatvorite prozor?",
                      "Zatvaranje", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
            }
        }
        #endregion Methods
    }
}
