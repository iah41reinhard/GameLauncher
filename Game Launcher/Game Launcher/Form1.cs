using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Launcher
{
    public partial class SteamBibliothek : Form
    {
        Controller c = new Controller();
        public SteamBibliothek()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < c.Spiel.Count; i++)
            {
                listBoxSpiele.Items.Add(c.Spiel[i]);
            }
        }

        private void listBoxSpiele_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTitel.Text = ((Spiele)listBoxSpiele.SelectedItem).Titel;
            tbPublisher.Text = ((Spiele)listBoxSpiele.SelectedItem).Publisher;
            tbUSK.Text = ((Spiele)listBoxSpiele.SelectedItem).USK.ToString();
            tbInstallationsdatum.Text = ((Spiele)listBoxSpiele.SelectedItem).installationsdatum.ToString();
            tbInstallationspfad.Text = ((Spiele)listBoxSpiele.SelectedItem).Installationspfad;
            tbKategorie.Text = ((Spiele)listBoxSpiele.SelectedItem).Kategorie;
            tbZuletztGespielt.Text = ((Spiele)listBoxSpiele.SelectedItem).zuletzt_gespielt.ToString();
        }

        private void bthinzufügen_Click(object sender, EventArgs e)
        {
            if (tbTitel.Text == "" || tbInstallationsdatum.Text == "" || tbKategorie.Text == "" || tbInstallationspfad.Text == "" || tbPublisher.Text == "" || tbUSK.Text == "")
            {
                MessageBox.Show("Keins der Felder darf leer sein! Bis auf zuletzt_gespiel!!", "ERROR");
            }
            else if (Convert.ToInt32(tbUSK.Text) < 0 || Convert.ToInt32(tbUSK.Text) > 18)
            {
                MessageBox.Show("Die USK muss zwischen 0 und 18 liegen!!!", "ERROR");
            }
            else
            {
                c.Spiel_hinzufügen(tbTitel.Text, tbInstallationsdatum.Text, tbInstallationspfad.Text, tbKategorie.Text, tbPublisher.Text, Convert.ToInt32(tbUSK.Text));
                listBoxSpiele.Items.Clear();
                for (int i = 0; i < c.Spiel.Count; i++)
                {
                    listBoxSpiele.Items.Add(c.Spiel[i]);
                }
            }

        }

        private void tbentfernen_Click(object sender, EventArgs e)
        {
            if (listBoxSpiele.SelectedItem == null)
            {
                MessageBox.Show("Wähle ein Spiel aus!", "ERROR");
            }
            else
            {
                c.Spiel_entfernen(((Spiele)listBoxSpiele.SelectedItem));
                listBoxSpiele.Items.Clear();
                for (int i = 0; i < c.Spiel.Count; i++)
                {
                    listBoxSpiele.Items.Add(c.Spiel[i]);
                }
            }
        }

        private void btstarten_Click(object sender, EventArgs e)
        {
            if (listBoxSpiele.SelectedItem == null)
            {
                MessageBox.Show("Wähle ein Spiel aus!", "ERROR");
            }
            else
            {
                c.Spiel_starten(((Spiele)listBoxSpiele.SelectedItem));
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            DialogResult result = openFileDialog1.ShowDialog(); // ermöglicht es Dateien zu durchsuchen um eine exe-Datei auszuwählen.
            if (result == DialogResult.OK)
            {
                tbInstallationspfad.Text = openFileDialog1.FileName;
            } 
        }
    }
}
