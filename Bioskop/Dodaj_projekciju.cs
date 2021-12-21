using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioskop
{
    public partial class Dodaj_projekciju : Form
    {
        Projekcija nova_projekcija;
        public Dodaj_projekciju()
        {
            InitializeComponent();
            nova_projekcija = new Projekcija();
        }

        private void Dodaj_projekciju_Load(object sender, EventArgs e)
        {
            var lista_filmova = Film.vrati_film();
            if (lista_filmova != null)
            {
                foreach (Film f in Film.vrati_film())
                {
                    cbListaFilmova.Items.Add(f.get_naziv());
                }
            }
            var lista_sala = Sala.vrati_listu_sala();
            if (lista_sala != null)
            {
                foreach (Sala s in Sala.vrati_listu_sala())
                {
                    cbListaSala.Items.Add($"{s.get_broj_sale()}");
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnDodajProjekciju_Click(object sender, EventArgs e)
        {
            
            bool datum = Validacija.proveraDatum(tbDatumProjekcije.Text);
            bool vreme = Validacija.proveraSatMinut(tbVremePocetkaProjekcije.Text);
            int cena;
            bool cena_karte = Int32.TryParse(tbCenaKarte.Text, out cena);
            bool sala = false;
            bool film = false;
            Sala izabrana_sala = new Sala();
            Film izabran_film = new Film();
            if ((string.IsNullOrEmpty(cbListaFilmova.Text))){
                film = false;
                
            }
            else
            {
                film = true;
                foreach (Film f in Film.vrati_film())
                {
                    if (f.get_naziv() == cbListaFilmova.SelectedItem.ToString()) ;
                    {
                        izabran_film = f;
                        break;

                    }
                }
            }
            if ((string.IsNullOrEmpty(cbListaSala.Text)))
            {
                sala = false;

            }
            else
            {
                sala = true;
                foreach (Sala s in Sala.vrati_listu_sala())
                {
                    if (s.get_broj_sale() == Int32.Parse(cbListaSala.SelectedItem.ToString())) ;
                    {
                        izabrana_sala = s;
                        break;

                    }
                }
            }
            
            if(datum && vreme && cena_karte && cena > 0&& sala && film)
            {
                nova_projekcija = new Projekcija(tbDatumProjekcije.Text, izabrana_sala, cena, tbVremePocetkaProjekcije.Text,izabran_film);
                Projekcija.dodaj_projekciju(nova_projekcija);
                Projekcija.upisi_projekciju(Projekcija.vrati_projekcije());
                
                MessageBox.Show("Projekcija je uspesno dodata"+ nova_projekcija.projekcija_info());
            }
            else
            {
                MessageBox.Show("Neuspesno dodavanje, proverite podatke");
            }
        }
    }
}
