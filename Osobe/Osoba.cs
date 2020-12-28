using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobe
{
    public class Osoba
    {
        #region Attributes
        String _ime;
        String _prezime;
        String _mestoIzdavanja;
        String _pol;
        DateTime _datumRodj, _vazenjeOd, _vazenjeDo;
        String _brDozvole;
        List<string> _kategorije, _zabrane;
        String _slika;
        List<string> _vazenjeZabraneOd;
        List<string> _vazenjeZabraneDo;
        #endregion Attributes

        #region Property
        public String Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }
        public String Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }
        public DateTime DatumRodj
        {
            get { return _datumRodj; }
            set { _datumRodj = value; }
        }
        public DateTime VazenjeOd
        {
            get { return _vazenjeOd; }
            set { _vazenjeOd = value; }
        }
        public DateTime VazenjeDo
        {
            get { return _vazenjeDo; }
            set { _vazenjeDo = value; }
        }
        public List<string> VazenjeZabraneOd
        {
            get { return _vazenjeZabraneOd; }
            set { _vazenjeZabraneOd = value; }
        }
        public List<string> VazenjeZabraneDo
        {
            get { return _vazenjeZabraneOd; }
            set { _vazenjeZabraneDo = value; }
        }
        public String BrDozvole
        {
            get { return _brDozvole; }
            set { _brDozvole = value; }
        }
        public String MestoIzdavanja
        {
            get { return _mestoIzdavanja; }
            set { _mestoIzdavanja = value; }
        }
        public String Pol
        {
            get { return _pol; }
            set { _pol = value; }
        }

        public List<string> Kategorije
        {
            get { return _kategorije; }
            set { _kategorije = value; }
        }
        public List<string> Zabrane
        {
            get { return _zabrane; }
            set { _zabrane = value; }
        }

        public String Slika
        {
            get { return _slika; }
            set { _slika = value; }
        }
        #endregion Property

        #region Constructor
        public Osoba(String ime, String prezime, DateTime datumRodj, DateTime vazenjeOd, DateTime vazenjeDo
            , String brDozvole, String mestoIzdavanja, String pol, List<string> kategorije,
            List<string> zabrane, List<string> vazenjeZabraneOd, List<string> vazenjeZabraneDo, String slika)
        {
            _ime = ime;
            _prezime = prezime;
            _datumRodj = datumRodj;
            _vazenjeOd = vazenjeOd;
            _vazenjeDo = vazenjeDo;
            _brDozvole = brDozvole;
            _mestoIzdavanja = mestoIzdavanja;
            _pol = pol;
            _kategorije=kategorije;
            _zabrane = zabrane;
            _vazenjeZabraneOd = vazenjeZabraneOd;
            _vazenjeZabraneDo = vazenjeZabraneDo;
            _slika = slika;
        }
        #endregion Constructor
    }
}
