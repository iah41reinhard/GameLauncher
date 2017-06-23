using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Game_Launcher
{
    class Controller
    {
        public List<Spiele> Spiel = new List<Spiele>();
        
        public void Spiel_starten(Spiele zu_startendes_Spiel)
        {
            if (!(File.Exists(zu_startendes_Spiel.Installationspfad)))
            {
                throw new ArgumentException();
            }
            else if (!(Spiel.Contains(zu_startendes_Spiel)))
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                Process.Start(zu_startendes_Spiel.Installationspfad);
            }
        }
    
        public void Spiel_hinzufügen(String Titel, String Installationsdatum, String Installationspfad, String Kategorie, String Publisher, int USK) 
        {
            if (Titel == "" || Installationsdatum == "" || Installationspfad == "" || Kategorie == "" || Publisher == "" || USK > 18 || USK < 0)
            {
                throw new ArgumentNullException();
            }
            else if (!(File.Exists(Installationspfad))) //überprüft ob der angegebene Pfad existiert.
            {
                throw new ArgumentException();
            }
            else { Spiel.Add(new Spiele(Titel, Installationsdatum, Installationspfad, Kategorie, Publisher, USK)); }
        }

        public void Spiel_entfernen(Spiele zu_entfernendes_Spiel) 
        {
            if (!(Spiel.Contains(zu_entfernendes_Spiel)))
            {
                throw new ArgumentException();
            }
            else
            {
                for (int i = 0; i < Spiel.Count; i++)
                {
                    if (Spiel[i] == zu_entfernendes_Spiel)
                    {
                        Spiel.Remove(zu_entfernendes_Spiel);
                    }

                }
            }
        }
    }
}
