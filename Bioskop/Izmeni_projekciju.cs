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
    public partial class Izmeni_projekciju : Form
    {
        Projekcija trenutna_projekcija;
        public Izmeni_projekciju()
        {
            InitializeComponent();
            trenutna_projekcija = new Projekcija();
        }

        private void Izmeni_projekciju_Load(object sender, EventArgs e)
        {
            foreach (Film f in Film.vrati_film())
            {
                cbListaFilmova.Items.Add(f.film_info());


            }
            foreach (Sala s in Sala.vrati_listu_sala())
            {
                cbListaSala.Items.Add(s.sala_info());
            }


        }

        private void btnIzmeniProjekciju_Click(object sender, EventArgs e)
        {
            int cena;
            bool provera_datum = Validacija.proveraDatum(tbDatumProjekcije.Text);
            bool provera_vreme_pocetka = Validacija.proveraSatMinut(tbVremePocetkaProjekcije.Text);
            bool cena_karte = Int32.TryParse(tbCenaKarte.Text, out cena);
            if (!provera_datum && !provera_vreme_pocetka)
            {
                MessageBox.Show("Unesite ispravan datum/vreme pocetka");
            }
            if (!cena_karte)
            {
                MessageBox.Show("Unesite broj za cenu karte");
            }

            if (cbListaFilmova.SelectedIndex == -1 || cbListaSala.SelectedIndex == -1)
            {
                MessageBox.Show("Selektujte film/salu");

            }
            if (cbListaFilmova.SelectedIndex != -1 && cbListaSala.SelectedIndex != -1 && provera_datum && provera_vreme_pocetka && cena_karte)
            {
                trenutna_projekcija.set_cena_karte(cena);
                trenutna_projekcija.set_datum_projekcije(tbDatumProjekcije.Text);
                trenutna_projekcija.set_vreme_pocetka_projekcije(tbVremePocetkaProjekcije.Text);


                foreach (Film film in Film.vrati_film())
                {
                    if (film.film_info() == cbListaFilmova.SelectedItem.ToString())
                    {
                        trenutna_projekcija.set_film(film);
                        MessageBox.Show("Film je promenjen ");
                        break;
                    }
                }
                foreach (Sala sala in Sala.vrati_listu_sala())
                {
                    if (sala.sala_info() == cbListaSala.SelectedItem.ToString())
                    {
                        trenutna_projekcija.set_sala(sala);
                        MessageBox.Show("Sala je promenjana");
                    }
                }
                Projekcija.upisi_projekciju(Projekcija.vrati_projekcije());
                MessageBox.Show("Projekcija je promenjena" + trenutna_projekcija.projekcija_info());


            }
        }

        private void cbListaFilmova_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
