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
    public partial class Administracija : Form
    {
        Projekcija trenutna_projekcija;
        Dodaj_novog_kupca novi_kupac_f;
        Izmeni_film izmeni_film;
        Izmeni_salu izmeni_salu;
        Izmeni_projekciju izmeni_projekciju;
        dodaj_Novi_Film dodaj_film;
        Dodaj_Novu_Salu dodaj_salu;
        Dodaj_projekciju dodaj_projekciju;
        Izmeni_kupca izmena_kupca;
        Novi_kupac novi_kupac;
        
        
        public Administracija()
        {
            
            
            InitializeComponent();
            trenutna_projekcija = new Projekcija();
            izmeni_film = new Izmeni_film();
            izmeni_salu = new Izmeni_salu();
            izmeni_projekciju = new Izmeni_projekciju();
            dodaj_film = new dodaj_Novi_Film();
            dodaj_salu = new Dodaj_Novu_Salu();
            dodaj_projekciju = new Dodaj_projekciju();
            izmena_kupca = new Izmeni_kupca();
            novi_kupac = new Novi_kupac();
            novi_kupac_f = new Dodaj_novog_kupca();
            

        }


        

        private void btnDodajNovogKupca_Click(object sender, EventArgs e)
        {
            if (novi_kupac_f.IsDisposed)
            {
                novi_kupac_f = new Dodaj_novog_kupca();
            }
            novi_kupac_f.Show();
        }

        private void btnIzmeniProjekciju_Click(object sender, EventArgs e)
        {
            if (cbListaProjekcija.Text != "")
            {
                if (izmeni_projekciju.IsDisposed)
                {
                    izmeni_projekciju = new Izmeni_projekciju();


                }
                izmeni_projekciju.Show();
               
                var trenutna_projekcija_lbl= izmeni_projekciju.Controls.Find("lblID", true);
                int redni_broj_projekcije = cbListaProjekcija.SelectedIndex;
                
                trenutna_projekcija_lbl[0].Text = $"{ Projekcija.vrati_projekcije().ElementAt(redni_broj_projekcije).get_id()}";
                

            }
            else
            {
                MessageBox.Show("Izaberite projekciju");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbListaKupaca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajNovuSalu_Click(object sender, EventArgs e)
        {
            if (dodaj_salu.IsDisposed)
            {
                dodaj_salu = new Dodaj_Novu_Salu();
            }
            dodaj_salu.Show();
        }

        private void btnDodajNoviFilm_Click(object sender, EventArgs e)
        {
            if (dodaj_film.IsDisposed)
            {
                dodaj_film = new dodaj_Novi_Film();
            }
            else
            {
                dodaj_film.Show();
            }
        }

        private void btnIzmeniSalu_Click(object sender, EventArgs e)
        {
            if (cbListaSala.Text != "")
            {
                if (izmeni_salu.IsDisposed)
                {
                    izmeni_salu = new Izmeni_salu();


                }

                var trenutna_sala = izmeni_salu.Controls.Find("lblID", true);
                int redni_broj_sale = cbListaSala.SelectedIndex;
                trenutna_sala[0].Text = $"{ Sala.vrati_listu_sala().ElementAt(redni_broj_sale).get_id()}";
                izmeni_salu.Show();

            }

        }

        private void btnIzmeniFilm_Click(object sender, EventArgs e)
        {
            if (cbListaFilmova.Text != "")
            {
                if (izmeni_film.IsDisposed)
                {
                    izmeni_film = new Izmeni_film();


                }

                var trenutni_film = izmeni_film.Controls.Find("lblID", true);
                int redni_broj_filma = cbListaFilmova.SelectedIndex;
                trenutni_film[0].Text = $"{ Film.vrati_film().ElementAt(redni_broj_filma).get_id()}";
                izmeni_film.Show();

            }

        }

        private void cbListaProjekcija_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trenutna_projekcija_info;
            if (cbListaProjekcija.SelectedIndex != -1)
            {
                trenutna_projekcija_info = cbListaProjekcija.SelectedItem.ToString();
                foreach(Projekcija p in Projekcija.vrati_projekcije())
                {
                    if(p.projekcija_info_short() == trenutna_projekcija_info)
                    {
                        trenutna_projekcija = p;
                    }
                }
            }
           

        }

        private void btnDodajNovuProjekciju_Click(object sender, EventArgs e)
        {
            if (dodaj_projekciju.IsDisposed)
            {
                dodaj_projekciju = new Dodaj_projekciju();
            }
            dodaj_projekciju.Show();

        }

        
        private void btnIzmenaKupca_Click(object sender, EventArgs e)
        {
            if (cbListaKupaca.Text != "")
            {
                if (izmena_kupca.IsDisposed)
                {
                    izmena_kupca = new Izmeni_kupca();


                }
                
                var trenutni_kupac = izmena_kupca.Controls.Find("lblID", true);
                string redni_broj_kupca = cbListaKupaca.SelectedItem.ToString();
                foreach(Kupac k in Kupac.vrati_listu_kupaca())
                {
                    if(k.info_short() == redni_broj_kupca)
                    {
                        trenutni_kupac[0].Text = $"{k.get_id()}";
                        break;

                    }
                }
                
                izmena_kupca.Show();

            }
            else
            {
                MessageBox.Show("Izaberite kupca kog želite da ažurirate");
            }
        }
        private void Administracija_Load(object sender, EventArgs e)
        {
            
            
            var lista_kupaca = Kupac.vrati_listu_kupaca();
            
            if (lista_kupaca != null)
            {
                foreach (Kupac k in Kupac.vrati_listu_kupaca())
                {
                    cbListaKupaca.Items.Add($"{k.info_short()}");
                }
            }
            var lista_projekcija = Projekcija.vrati_projekcije();
            if(lista_projekcija != null)
            {
                
                foreach (Projekcija p in Projekcija.vrati_projekcije())
                {
                    
                    cbListaProjekcija.Items.Add(p.projekcija_info_short());

                }

            }
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
                foreach(Sala s in Sala.vrati_listu_sala())
                {
                    cbListaSala.Items.Add(s.sala_info());
                }

            }
            
            
            
            
            

        }

        private void btnObrisiProjekciju_Click(object sender, EventArgs e)
        {
            if (cbListaProjekcija.SelectedIndex != -1)
            {

                string redni_broj_projekcije = (cbListaProjekcija.SelectedItem.ToString());
                foreach (Projekcija  p in Projekcija.vrati_projekcije().ToArray())
                {
                    if (p.projekcija_info_short() == redni_broj_projekcije)
                    {
                        Projekcija.ukloni_projekciju(p);
                        Projekcija.upisi_projekciju(Projekcija.vrati_projekcije());
                        MessageBox.Show("Projekcija:" + p.projekcija_info() + " je uklonjena");
                        break;

                    }
                }
                cbListaProjekcija.Items.Clear();
                cbListaProjekcija.Text = "";
                foreach (Projekcija p in Projekcija.vrati_projekcije())
                {
                    cbListaProjekcija.Items.Add(p.projekcija_info_short());


                }
            }
            else
            {
                MessageBox.Show("Odaberite projekciju koju zelite da obrisete");
            }
        }

        private void btnObrisiKupca_Click(object sender, EventArgs e)
        {
            if (cbListaKupaca.SelectedIndex != -1)
            {
                
                string kupac_info = cbListaKupaca.SelectedItem.ToString();
                foreach (Kupac k in Kupac.vrati_listu_kupaca())
                {
                    if (k.info_short() == kupac_info)
                    {
                        Kupac.ukloni_kupca(k);
                        Kupac.upisi_kupca(Kupac.vrati_listu_kupaca());
                        MessageBox.Show($"Kupac je uklonjen:{k.info_short()}");
                        foreach(Rezervacije r in Rezervacije.vrati_listu_rezervacija().ToArray())
                        {
                            if(r.get_id_kupca() == k.get_id())
                            {
                                k.ukloni_rezervaciju(r);
                                Rezervacije.ukloni_rezervaciju(r);
                                Rezervacije.upisi_rezervaciju(Rezervacije.vrati_listu_rezervacija());
                                Rezervacije.upisi_rezervaciju(Rezervacije.vrati_listu_rezervacija());
                            }
                        }
                        
                        break;

                    }
                }
                
                
                cbListaKupaca.Items.Clear();
                cbListaKupaca.Text= "";
                foreach(Kupac k in Kupac.vrati_listu_kupaca())
                {
                    cbListaKupaca.Items.Add(k.info_short());


                }
            }
            else
            {
                MessageBox.Show("Odaberite kupca kog zelite da obrisete");
            }

        }

        private void btnObrisiSalu_Click(object sender, EventArgs e)
        {
            if (cbListaSala.SelectedIndex != -1)
            {

                int redni_broj_sale= Int32.Parse(cbListaSala.SelectedItem.ToString());
                foreach (Sala s in Sala.vrati_listu_sala())
                {
                    if (s.get_broj_sale() == redni_broj_sale)
                    {
                        Sala.ukloni_salu(s);
                        Sala.upisi_salu(Sala.vrati_listu_sala());
                        MessageBox.Show("Sala:" + s.get_broj_sale() + " je uklonjena");
                        break;

                    }
                }
                if(Projekcija.vrati_projekcije() != null)
                {
                    foreach (Projekcija p in Projekcija.vrati_projekcije())
                    {
                        if (p.get_sala().get_id() == redni_broj_sale)
                        {
                            Projekcija.ukloni_projekciju(p);
                            Projekcija.upisi_projekciju(Projekcija.vrati_projekcije());
                            MessageBox.Show($"Uklonjena projekcija" + p.projekcija_info());
                        }
                    }
                }
                cbListaSala.Items.Clear();
                cbListaSala.Text = "";
                foreach (Sala s in Sala.vrati_listu_sala())
                {
                    cbListaSala.Items.Add(s.get_broj_sale());


                }
            }
            else
            {
                MessageBox.Show("Odaberite salu kog zelite da obrisete");
            }
        }

        private void btnObrisiFilm_Click(object sender, EventArgs e)
        {
            if (cbListaFilmova.SelectedIndex != -1)
            {

                string naziv_filma= cbListaFilmova.SelectedItem.ToString();
                foreach (Film f in Film.vrati_film())
                {
                    if (f.get_naziv()== naziv_filma)
                    {
                        Film.ukloni_film(f);
                        Film.upisi_film(Film.vrati_film());
                        MessageBox.Show("Film:" + f.get_naziv() + " je uklonjen");
                        break;

                    }
                }
                if(Projekcija.vrati_projekcije() != null)
                {
                    foreach (Projekcija p in Projekcija.vrati_projekcije())
                    {
                        if (p.get_film().get_naziv() == naziv_filma)
                        {
                            Projekcija.ukloni_projekciju(p);
                            Projekcija.upisi_projekciju(Projekcija.vrati_projekcije());
                            MessageBox.Show($"Uklonjena projekcija" + p.projekcija_info());
                        }
                    }
                }
                cbListaFilmova.Items.Clear();
                cbListaFilmova.Text = "";
                foreach (Film f in Film.vrati_film())
                {
                    cbListaFilmova.Items.Add(f.get_naziv());



                }
            }
            else
            {
                MessageBox.Show("Odaberite film kog zelite da obrisete");
            }
        }
    }
}
