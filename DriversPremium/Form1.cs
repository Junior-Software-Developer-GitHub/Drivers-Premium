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

    public partial class Form1 : Form
    {
        #region Attributes

        private static  bool dodajKliknuto;
        public static readonly DataTable dt = new DataTable();

        #endregion Attributes

        #region Constructor
        public Form1()
        {
            InitializeComponent();  
        }
        #endregion Constructor

        #region Methods
        private void Form1_Load(object sender, EventArgs e)
        {
            timerVreme.Start();
        }

        private void Sortiraj_dgm_Click(object sender, EventArgs e)
        {
            if (dataGridViewLista.Rows.Count > 0)
            {
                if (comboBoxSort.SelectedItem != null)
                {
                    if (comboBoxSort.SelectedItem.Equals("Broj vozacke dozvole"))
                        dataGridViewLista.Sort(this.dataGridViewLista.Columns["Broj dozvole"], ListSortDirection.Ascending);
                    else if (comboBoxSort.SelectedItem.Equals("Ime"))
                        dataGridViewLista.Sort(this.dataGridViewLista.Columns["Ime"], ListSortDirection.Ascending);
                    else if (comboBoxSort.SelectedItem.Equals("Prezime"))
                        dataGridViewLista.Sort(this.dataGridViewLista.Columns["Prezime"], ListSortDirection.Ascending);
                   
                }
                else
                    MessageBox.Show("Izaberite nacin sortiranja!");
            }
            else
                MessageBox.Show("Prazna tabela!");
        }

        private void DodajVozaca_dgm_Click(object sender, EventArgs e)
        {  
            Form2 fm2 = new Form2();
            fm2.BrojDozvole.Enabled = true;
            dodajKliknuto = true;
            this.Hide();
            fm2.Show();
        }

        private void TimerVreme_Tick(object sender, EventArgs e)
        {
            String str = DateTime.Now.ToString("HH:mm:ss dd:MM:yyyy.");
            labelTime.Text = str;
            labelTime.Font = new Font(labelTime.Font, FontStyle.Bold);
        }

        private void ObrisiVozaca_dgm_Click(object sender, EventArgs e)
        {
            int index = dataGridViewLista.CurrentCell.RowIndex;
            String brDozvole = (string)dataGridViewLista.Rows[index].Cells[2].Value;
            ListaOsoba.Instance.ObrisiOsobu(ListaOsoba.Instance.VratiOsobu(brDozvole));
            dataGridViewLista.Rows.RemoveAt(index);
            ZakljucajObrisiDugme();
        }
        public void ZakljucajObrisiDugme()
        {
            _ = (dataGridViewLista.Rows.Count == 0) ? (ObrisiVozaca_dgm.Enabled = IzmeniVozaca_dgm.Enabled = false)
                : (ObrisiVozaca_dgm.Enabled = IzmeniVozaca_dgm.Enabled = true);
        }

        private void IzmeniVozaca_dgm_Click(object sender, EventArgs e)
        {
            dodajKliknuto = false;
            int indexReda = dataGridViewLista.CurrentCell.RowIndex;
            Osoba o = ListaOsoba.Instance.VratiOsobu(VratiDozvolu());
            UcitajPodatke(o);
            dataGridViewLista.Rows.RemoveAt(indexReda);
           
            this.Close();
        }
        
        public void UcitajPodatke(Osoba o)
        {
            Form2 fm2 = new Form2();
            fm2.BrojDozvole.Enabled = false;
            fm2.ObrisiKategoriju.Enabled = fm2.ObrisiZabranu.Enabled = true;

            _ = (dt.Columns.Count == 0) ? (dt.Columns.Add("Kategorija"), dt.Columns.Add("Vazenje od"),
                dt.Columns.Add("Vazenje do")):(null,null,null);

            Form3 fm3 = new Form3();
            fm2.ObrisiDuplikate(o);
            fm2.openFileDialog1.FileName = o.Ime;
            fm2.Ime = o.Ime;
            fm2.Prezime = o.Prezime;
            fm2.DatumRodjenja = o.DatumRodj;
            fm2.DatumVazenjaOd = o.VazenjeOd;
            fm2.DatumVazenjaDo = o.VazenjeDo;
            fm2.Kategorije.DataSource = fm3.DT2;
            fm2.Zabrane.DataSource = fm3.DT1;
            fm2.SlikaVoazaca.ImageLocation = o.Slika;
            fm2.BrDozvole = o.BrDozvole;
            fm2.MestoIzdavanja = o.MestoIzdavanja;
            fm2.Pol = o.Pol;
            
            foreach (string x in o.Kategorije)
            {
                if(x!=null) fm3.DT2.Rows.Add(x,o.VazenjeOd,o.VazenjeDo);
            } 

            for (int i = 0; i < o.Zabrane.Count; i++)
            {
                if (o.Zabrane[i] != null) fm3.DT1.Rows.Add(o.Zabrane[i], o.VazenjeZabraneOd[i], o.VazenjeZabraneDo[i]);
            }   
            this.Hide();
            fm2.Show();
        }
        public String VratiDozvolu()
        {
            int indexReda = dataGridViewLista.CurrentCell.RowIndex;
                return dataGridViewLista.Rows[indexReda].Cells[2].Value.ToString();
        }
        #endregion Methods

        #region Properties
        public bool DodajKliknuto
        {
            get { return dodajKliknuto; }
            set { dodajKliknuto = value; }
        }

        public DataGridView DTGview
        {
            get { return dataGridViewLista; }
            set { dataGridViewLista = value; }
        }

        public Button IzmeniVozacaDgm
        {
            get { return IzmeniVozaca_dgm; }
        }
        public Button ObrisiVozacaDgm
        {
            get { return ObrisiVozaca_dgm; }
        }

        #endregion Propeties
    }
}