using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioskop
{
    public partial class Rezervacija : Form
    {

        Kupac trenutni_kupac;
        Rezervacije nova_rezervacija;
        CultureInfo srb;
        List<Projekcija> lista_projekcija;
        List<Projekcija> lista_izabranih_projekcija;
        Projekcija trenutna_projekcija;



        public Rezervacija()
        {
            InitializeComponent();
            srb = new CultureInfo("sr");
            trenutna_projekcija = new Projekcija();
            lista_projekcija = new List<Projekcija>();
            lista_izabranih_projekcija = new List<Projekcija>();
            nova_rezervacija = new Rezervacije();
            trenutni_kupac = new Kupac();



        }


        private void Rezervacija_Load(object sender, EventArgs e)
        {

            lblNaslov.Location = new Point(
            this.ClientSize.Width / 2 - lblNaslov.Size.Width / 2, 0 + lblNaslov.Size.Height);
            lista_izabranih_projekcija = new List<Projekcija>();
            dtPocetniDatum.Format = DateTimePickerFormat.Custom;
            dtPocetniDatum.CustomFormat = "dd/MM/yyyy";
            dtKrajnjiDatum.Format = DateTimePickerFormat.Custom;
            dtKrajnjiDatum.CustomFormat = "dd/MM/yyyy";


            var min_datum = DateTime.Parse("30/12/2050", srb);
            var max_datum = DateTime.Parse("30/12/1999", srb);
            foreach (Projekcija p in Projekcija.vrati_projekcije())
            {
                DateTime datum = DateTime.Parse(p.get_datum_projekcije(), srb);
                if (datum < min_datum)
                {
                    min_datum = datum.AddDays(-1);
                }
                if (datum > max_datum)
                {
                    max_datum = datum.AddDays(+1);
                }

            }
            dtPocetniDatum.Text = min_datum.ToString();
            dtKrajnjiDatum.Text = max_datum.ToString();
            dtPocetniDatum.MinDate = min_datum;
            dtKrajnjiDatum.MaxDate = max_datum;



            var lista_sala = Sala.vrati_listu_sala();
            var lista_film = Film.vrati_film();
            if (lista_sala == null)
            {
                MessageBox.Show("Trenutno nema sala na raspolaganju");
            }
            else
            {
                foreach (Sala s in lista_sala)
                {
                    cbSala.Items.Add($"{s.get_broj_sale()}");
                }
            }
            if (lista_film == null)
            {
                MessageBox.Show("Trenutno nema filmova na raspolaganju");
            }
            else
            {
                foreach (Film f in lista_film)
                {
                    cbNaziv.Items.Add($"{f.get_naziv()}");
                }
            }
        }

        private void dtPocetniDatum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPrikaziDostupneProjekcije_Click(object sender, EventArgs e)
        {

            lbPrikazProjekcija.Items.Clear();

            lista_projekcija = Projekcija.vrati_projekcije();
            bool filter_film = !(string.IsNullOrEmpty(cbNaziv.Text));
            bool filter_sala = !(string.IsNullOrEmpty(cbSala.Text));
            int broj_sale = -1;
            string naziv_projekcije = "";


            if (lista_projekcija != null)
            {
                if (filter_sala)
                {
                    broj_sale = Int32.Parse(cbSala.SelectedItem.ToString());
                }
                if (filter_film)
                {
                    naziv_projekcije = cbNaziv.SelectedItem.ToString();
                }
                DateTime pocetni_datum = DateTime.Parse(dtPocetniDatum.Text, srb);
                DateTime krajnji_datum = DateTime.Parse(dtKrajnjiDatum.Text, srb);
                List<Projekcija> odgovarajuci_datum = new List<Projekcija>();
                foreach (Projekcija p in lista_projekcija)
                {
                    var datum = DateTime.Parse(p.get_datum_projekcije(), srb);
                    if (datum < krajnji_datum && datum > pocetni_datum)
                    {
                        odgovarajuci_datum.Add(p);
                    }
                }


                if (!filter_film && !filter_sala)
                {
                    foreach (Projekcija p in lista_projekcija)
                    {
                        if (odgovarajuci_datum.Contains(p))
                        {
                            lbPrikazProjekcija.Items.Add(p.projekcija_info());


                        }
                    }

                }
                if (!filter_film && filter_sala)
                {
                    foreach (Projekcija p in lista_projekcija)
                    {
                        if (p.get_sala().get_broj_sale() == broj_sale && odgovarajuci_datum.Contains(p))
                        {
                            lbPrikazProjekcija.Items.Add(p.projekcija_info());

                        }

                    }

                }
                if (filter_film && !filter_sala)
                {
                    foreach (Projekcija p in lista_projekcija)
                    {
                        if (p.get_film().get_naziv() == naziv_projekcije && odgovarajuci_datum.Contains(p))
                        {
                            lbPrikazProjekcija.Items.Add(p.projekcija_info());

                        }

                    }

                }
                if (filter_film && filter_sala)
                {
                    foreach (Projekcija p in lista_projekcija)
                    {
                        if (p.get_film().get_naziv() == naziv_projekcije && p.get_sala().get_broj_sale() == broj_sale && odgovarajuci_datum.Contains(p))
                        {
                            lbPrikazProjekcija.Items.Add(p.projekcija_info());

                        }

                    }

                }
                foreach (var p in lbPrikazProjekcija.Items)
                {
                    string ps = p.ToString();

                    foreach (Projekcija pr in lista_projekcija)
                    {
                        if (pr.projekcija_info() == ps)
                        {
                            lista_izabranih_projekcija.Add(pr);
                            break;

                        }
                    }

                }

            }

            else
            {
                MessageBox.Show("Trenutno nema dostupnih projekcija");
            }





        }



        private void PromenaSelektovanogElementa(object sender, EventArgs e)
        {
            int trenutni_indeks = Int32.Parse(lbPrikazProjekcija.SelectedIndex.ToString());
            if (lbPrikazProjekcija.SelectedIndex != -1)
            {
                foreach (Kupac k in Kupac.vrati_listu_kupaca())
                {
                    if (k.get_id().ToString() == lblIdKupac.Text)
                    {
                        trenutni_kupac = k;
                    }
                    break;
                }
                trenutna_projekcija = lista_izabranih_projekcija.ElementAt(trenutni_indeks);
            }

            numUpDownBrojMesta.Value = 0;
        }
        private void btnRezervisi_Click(object sender, EventArgs e)
        {

            int cena;
            int broj;

            bool broj_karata = Int32.TryParse(numUpDownBrojMesta.Value.ToString(), out broj);
            bool cena_karata = Int32.TryParse(tbUkupnaCena.Text, out cena);
            if (broj_karata && cena_karata)
            {
                int dostupne_karte = trenutna_projekcija.get_sala().get_broj_sedista() - broj;
                if (dostupne_karte >= 0)
                {
                    trenutna_projekcija.get_sala().set_broj_sedista(trenutna_projekcija.get_sala().get_broj_sedista() - broj);
                    nova_rezervacija = new Rezervacije(Int32.Parse(lblIdKupac.Text), broj, cena);
                    trenutni_kupac.dodaj_rezervaciju(nova_rezervacija);
                    Rezervacije.dodaj_rezervaciju(nova_rezervacija);
                    Rezervacije.upisi_rezervaciju(Rezervacije.vrati_listu_rezervacija());
                    Kupac.upisi_kupca(Kupac.vrati_listu_kupaca());

                    MessageBox.Show("Rezervacija je uspesno kreirana" + nova_rezervacija.rezervacija_info());
                    MessageBox.Show("Rezervacija je dodata na listu rezervacija kupca" + trenutni_kupac.info_short());
                }
                else
                {
                    MessageBox.Show($"Neuspesna registracija! Broj slobodnih mesta:{trenutna_projekcija.get_sala().get_broj_sedista()}");
                }

            }



        }
        private void numUpDownBrojMesta_ValueChanged(object sender, EventArgs e)
        {
            int broj_karata = (int)numUpDownBrojMesta.Value;
            if (lbPrikazProjekcija.SelectedItem != null)
            {
                int cena = trenutna_projekcija.get_cena_karte();

                numUpDownBrojMesta.Minimum = 0;
                tbUkupnaCena.Text = $"{broj_karata * cena}";


            }
            else
            {
                MessageBox.Show("Selektujete zeljenu projekciju");

            }









        }



        private void lblNaslov_Click(object sender, EventArgs e)
        {

        }
    }
}
