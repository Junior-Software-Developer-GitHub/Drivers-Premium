using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobe
{
   public class ListaOsoba
    {
        #region Attributes
        readonly List<Osoba> _listaOsoba;
        private static ListaOsoba _instance = null;
        #endregion Attributes

        #region Property
        public List<Osoba> ListaOsobaValues
        {
            get { return _listaOsoba; }
        }
        public static ListaOsoba Instance
        {
            get
            {
                if (_instance == null) _instance = new ListaOsoba();
                return _instance;
            }
        }
        #endregion Property

        #region Constructor
        private ListaOsoba()
        {
            _listaOsoba = new List<Osoba>();//Singleton
        }
        #endregion Constructor
        
        #region Methods
        public bool DodajOsobu(Osoba o)
        {
            if (PostojiUlisti(o)) return false;
            _listaOsoba.Add(o);
            return true;
        }

        public bool ObrisiOsobu(Osoba o)
        {
            if (!PostojiUlisti(o)) return false;
            _listaOsoba.Remove(o);
            return true;
        }
        public bool PostojiUlisti(Osoba o)
        {
            foreach(var v in _listaOsoba)
                if (v.BrDozvole == o.BrDozvole)
                    return true;
            return false;
        }

        public Osoba VratiOsobu(String brDozovle)
        {
            foreach (var v in _listaOsoba)
                if (v.BrDozvole == brDozovle)
                    return v;
            return null;
        }
        #endregion Methods
    }
}
