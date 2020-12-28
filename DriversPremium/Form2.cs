using Osobe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DriversPremium
{
    public partial class Form2 : Form
    {
        #region Attributes
        public static DataTable dt = new DataTable();
        public static bool proslediKliknuto;
        #endregion Attributes

        #region Constructor
        public Form2()
        {
            InitializeComponent();
            Form1 fm1 = new Form1();
            if (!fm1.DodajKliknuto)
            {
                dateTimePickerVazenjeOd.Format = DateTimePickerFormat.Custom;
                dateTimePickerVazenjeOd.CustomFormat = " ";
                dateTimePickerVazenjeDo.Format = DateTimePickerFormat.Custom;
                dateTimePickerVazenjeDo.CustomFormat = " ";
            }
            
        }
        #endregion Constructor

        #region Properties
        public String Ime
        {
            get { return ime_txt.Text; }
            set { ime_txt.Text = value; }
        }
        public String Prezime
        {
            get { return prezime_txt.Text; }
            set { prezime_txt.Text = value; }
        }
        public DateTime DatumRodjenja
        {
            get { return dateTimePickerDatumRodjenja.Value; }
            set { dateTimePickerDatumRodjenja.Value = value; }
        }
        public DateTime DatumVazenjaOd
        {
            get { return dateTimePickerVazenjeOd.Value; }
            set { dateTimePickerVazenjeOd.Value = value; }
        }
        public DateTime DatumVazenjaDo
        {
            get { return dateTimePickerVazenjeDo.Value; }
            set { dateTimePickerVazenjeDo.Value = value; }
        }
        public String BrDozvole //Vrednost
        {
            get { return brDozvole_txt.Text; }
            set { brDozvole_txt.Text = value; }
        }
        public TextBox BrojDozvole //Textbox
        {
            get { return brDozvole_txt; }
            set { brDozvole_txt = value; }
        }
        public String MestoIzdavanja
        {
            get { return mestoIzdavanja_txt.Text; }
            set { mestoIzdavanja_txt.Text = value; }
        }
        public String Pol
        {
            get { return pol_comboBox.SelectedItem.ToString(); }
            set { pol_comboBox.SelectedItem = value; }
        }
        public PictureBox SlikaVoazaca
        {
            get { return pictureBoxSlikaVozaca; }
            set { pictureBoxSlikaVozaca = value; }
        }
        public DataGridView Kategorije
        {
            get { return dataGridViewKategorije; }
        }
        public DataGridView Zabrane
        {
            get { return dataGridViewZabrane; }
        }

        public Button ObrisiKategoriju
        {
            get { return ObrisiKategoriju_dgm; }
            set { ObrisiKategoriju_dgm = value; }
        }
        public Button ObrisiZabranu
        {
            get { return ObrisiZabranu_dgm; }
            set { ObrisiZabranu_dgm = value; }
        }
        public Button DodajNovuKategoriju
        {
            get { return DodajKategoriju_dgm; }
            set { DodajKategoriju_dgm = value; }
        }
        public Button DodajNovuZabranu
        {
            get { return DodajNovuZabranu_dgm; ; }
            set { DodajNovuZabranu_dgm = value; }
        }

        #endregion Properties

        #region Methods
        private void DodajKategoriju_dgm_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.DatumOd.Enabled = fm3.DatumDo.Enabled = false;
            fm3.DatumOd.Value = dateTimePickerVazenjeOd.Value;
            fm3.DatumDo.Value = dateTimePickerVazenjeDo.Value;
            fm3.Show();
        }

        private void DodajNovuZabranu_dgm_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Kategorija.Items.Clear();
            fm3.DatumOd.Enabled = fm3.DatumDo.Enabled = true;
            foreach (DataGridViewRow dr in dataGridViewKategorije.Rows)
                fm3.Kategorija.Items.Add(dr.Cells["Kategorije"].Value);

            fm3.DatumDo.Enabled = fm3.DatumDo.Enabled = true;
            fm3.Text = "ZABRANA";
            fm3.Show();
        }

        private void Prosledi_dgm_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();

            if (PopunjenostPolja())
            {
                List<string> kategorije = new List<string>();

                foreach(DataGridViewRow dr in Kategorije.Rows)
                    kategorije.Add(dr.Cells[0].Value.ToString());

                List<string> kategorijeZabrana = new List<string>();
                List<string> vazenjeZabraneOd  = new List<string>();
                List<string> vazenjeZabraneDo  = new List<string>();
                bool res;

                if (fm1.DodajKliknuto)
                {
                    foreach(DataGridViewRow dr in Zabrane.Rows)
                    {
                        kategorijeZabrana.Add(dr.Cells[0].Value.ToString());
                        vazenjeZabraneOd.Add(dr.Cells[1].Value.ToString());
                        vazenjeZabraneDo.Add(dr.Cells[2].Value.ToString());
                    }
                    Osoba o = new Osoba(VelikoPocetnoSlovo(ime_txt.Text), VelikoPocetnoSlovo(prezime_txt.Text), dateTimePickerDatumRodjenja.Value
                        , dateTimePickerVazenjeOd.Value, dateTimePickerVazenjeDo.Value, brDozvole_txt.Text, mestoIzdavanja_txt.Text,
                        pol_comboBox.SelectedItem.ToString(), kategorije, kategorijeZabrana, vazenjeZabraneOd, vazenjeZabraneDo, openFileDialog1.FileName);

                    res = ListaOsoba.Instance.DodajOsobu(o);
    
                    if (!res)
                    {
                        MessageBox.Show("GRESKA");
                        return;
                    }
                }
                else
                {
                    Osoba o = ListaOsoba.Instance.VratiOsobu(BrDozvole);
                    o.DatumRodj = dateTimePickerDatumRodjenja.Value;
                    o.VazenjeOd = dateTimePickerVazenjeOd.Value;
                    o.VazenjeDo = dateTimePickerVazenjeDo.Value;
                    o.Kategorije.Clear();
                    o.Zabrane.Clear();
                    o.VazenjeZabraneOd.Clear();
                    o.VazenjeZabraneDo.Clear();
                    foreach (DataGridViewRow dr in Kategorije.Rows)
                        o.Kategorije.Add(dr.Cells[0].Value.ToString());

                    foreach (DataGridViewRow dr in Zabrane.Rows)
                    {
                         o.Zabrane.Add(dr.Cells[0].Value.ToString());
                         o.VazenjeZabraneOd.Add(dr.Cells[1].Value.ToString());
                         o.VazenjeZabraneDo.Add(dr.Cells[2].Value.ToString());
                    }
                    ObrisiDuplikate(o);               
                }

                NapraviKolone(dt);

                Form3 fm3 = new Form3();
                fm3.DT1.Rows.Clear();
                fm3.DT2.Rows.Clear();
                dt.Rows.Add(VelikoPocetnoSlovo(Ime), VelikoPocetnoSlovo(Prezime), BrDozvole);         

                fm1.DTGview.DataSource = dt;
               
                _= (dt.Rows.Count > 0) ? (fm1.ObrisiVozacaDgm.Enabled = fm1.IzmeniVozacaDgm.Enabled = true)
                    : (fm1.ObrisiVozacaDgm.Enabled = fm1.IzmeniVozacaDgm.Enabled = true);
             
                this.Close();
                fm1.Show();
            }            
        }

        private void Zatvori_dgm_Click(object sender, EventArgs e)
        {
          DialogResult dr = MessageBox.Show("Da li zelite da zatvorite aplikaciju?",
                      "Zatvaranje", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;   
            }
        }
        String VelikoPocetnoSlovo(String a)
        {
            return char.ToUpper(a[0]) + a.Substring(1);   
        }
        
        private void ObrisiKategoriju_dgm_Click(object sender, EventArgs e)
        {
            int index = Kategorije.CurrentCell.RowIndex; 
            Form1 fm1 = new Form1();
            if (fm1.DodajKliknuto)
            {
                for (int i = 0; i < Zabrane.Rows.Count; i++)
                {
                    if (Zabrane.Rows[i].Cells[0].Value.ToString() == Kategorije.Rows[index].Cells[0].Value.ToString())
                        Zabrane.Rows.RemoveAt(i);
                }
                Osoba o = ListaOsoba.Instance.VratiOsobu(BrDozvole);
                if (ListaOsoba.Instance.PostojiUlisti(o))
                    o.Kategorije.Remove(Kategorije.Rows[index].Cells[0].Value.ToString());
               
                Kategorije.Rows.RemoveAt(index);
               
                
            }
            else  Kategorije.Rows.RemoveAt(index);
            _ = (Kategorije.Rows.Count == 0) ? ObrisiKategoriju_dgm.Enabled = false : ObrisiKategoriju_dgm.Enabled = true;
        }

        private void ObrisiZabranu_dgm_Click(object sender, EventArgs e)
        {
            int index = Zabrane.CurrentCell.RowIndex;
            Form1 fm1 = new Form1();

            if (!fm1.DodajKliknuto)
            {
                Osoba o = ListaOsoba.Instance.VratiOsobu(BrDozvole);
                if (ListaOsoba.Instance.PostojiUlisti(o))
                    o.Zabrane.Remove(Zabrane.Rows[index].Cells[0].Value.ToString());

                Zabrane.Rows.RemoveAt(index);
            }
            else Zabrane.Rows.RemoveAt(index);
            _ = (Zabrane.Rows.Count == 0) ? ObrisiZabranu_dgm.Enabled = false : ObrisiZabranu_dgm.Enabled = true;
        }
        public void ObrisiDuplikate(Osoba o)
        {
            HashSet<String> hs = new HashSet<String>();
            for (int i = 0; i < o.Kategorije.Count; i++)
                if (!hs.Add(o.Kategorije[i]))
                    o.Kategorije.Remove(o.Kategorije[i]);
            HashSet<String> hs1 = new HashSet<String>();
            for (int i = 0; i < o.Zabrane.Count; i++)
                if (!hs1.Add(o.Zabrane[i]))
                    o.Zabrane.Remove(o.Zabrane[i]);
        }

        private void DodajSliku_dgm_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxSlikaVozaca.ImageLocation = openFileDialog1.FileName;
        }

        private bool PopunjenostPolja()
        {
            if (String.IsNullOrEmpty(Ime) || String.IsNullOrEmpty(Prezime) || BrDozvole.Length<9
                || String.IsNullOrEmpty(MestoIzdavanja) || pol_comboBox.SelectedIndex==-1 ||
                dataGridViewKategorije.Rows.Count == 0 || pictureBoxSlikaVozaca.Image==null) 
            { 
                MessageBox.Show("Popunite svako polje!");
                return false;
            }
            return true;
        }

        private void DateTimePickerDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerVazenjeOd.MinDate = new DateTime(dateTimePickerDatumRodjenja.Value.Year + 17,
                dateTimePickerDatumRodjenja.Value.Month, dateTimePickerDatumRodjenja.Value.Day);

            dateTimePickerVazenjeOd.MaxDate = new DateTime(2021,1,1);

            dateTimePickerDatumRodjenja.Format = DateTimePickerFormat.Short;
            dateTimePickerVazenjeOd.Format = DateTimePickerFormat.Short;

            dateTimePickerVazenjeOd.Enabled = true;
        }

        private void DateTimePickerVazenjeOd_ValueChanged(object sender, EventArgs e)
        {

            dateTimePickerVazenjeDo.MinDate = new DateTime(dateTimePickerVazenjeOd.Value.Year + 10,
                dateTimePickerVazenjeOd.Value.Month, dateTimePickerVazenjeOd.Value.Day);

            dateTimePickerVazenjeDo.Format = DateTimePickerFormat.Custom;
            dateTimePickerVazenjeDo.CustomFormat = dateTimePickerVazenjeDo.MinDate.ToShortDateString();
            dateTimePickerVazenjeDo.Value = dateTimePickerVazenjeDo.MinDate;
        }
        #region KeyPress
        private void NapraviKolone(DataTable dt)
        {
            _ = (dt.Columns.Count == 0) ? (dt.Columns.Add("Ime"), dt.Columns.Add("Prezime"),
               dt.Columns.Add("Broj dozvole")) : (null, null, null);
        }
        private void Ime_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Prezime_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void MestoIzdavanja_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void BrDozvole_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion KeyPress

        #endregion Methods

    }
}
