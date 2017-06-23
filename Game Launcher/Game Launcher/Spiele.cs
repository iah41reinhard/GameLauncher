using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Launcher
{
    class Spiele
    {
        private String _Titel = "";
        private String _Installationsdatum;
        private String _Installationspfad;
        public String zuletzt_gespielt = "";
        private String _Kategorie;
        private String _Publisher;
        private int _USK;

        public Spiele(String Titel, String Installationsdatum, String Installationspfad, String Kategorie, String Publisher, int USK)
        {
            _Titel = Titel;
            _Installationsdatum = Installationsdatum;
            _Installationspfad = Installationspfad;
            _Kategorie = Kategorie;
            _Publisher = Publisher;
            _USK = USK;
        }

        public String Installationspfad
        {
           get { return _Installationspfad; }
        }

        public String Titel
        {
            get { return _Titel; }
        }

        public String installationsdatum
        {
            get { return _Installationsdatum; }
        }

        public String Kategorie
        {
            get { return _Kategorie; }
        }

        public String Publisher
        {
            get { return _Publisher; }
        }

        public int USK
        {
            get { return _USK; }
        }

        public override string ToString()
        {
            return _Titel;
        }
    }
}
