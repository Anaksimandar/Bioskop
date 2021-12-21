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
    public partial class Izmeni_kupca : Form
    {

        Rezervacija nova_rezervacija = new Rezervacija();
        int trenutni_index_lb;

        Kupac trenutni_kupac;
        public Izmeni_kupca()
        {
            InitializeComponent();
            trenutni_kupac = new Kupac();
            
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Izmeni_kupca_Load(object sender, EventArgs e)
        {
            lblIDRez.Text = lblID.Text;
            
            foreach(Kupac k in Kupac.vrati_listu_kupaca())
            {
                if(k.get_id().ToString() == lblID.Text)
                {
                    trenutni_kupac = k;
                    tbIme.Text = k.get_ime();
                    tbPrezime.Text = k.get_prezime();
                    tbDatum_rodjenja.Text = $"{k.get_datum_rodjenja()}";
                    tbLozinka1.Text = k.get_lozinka();
                    tbLozinka2.Text = k.get_lozinka();
                    tbMail.Text = k.get_mail();
                    tbTelefon.Text = k.get_telefon();
                    if(k.get_pol() == "Muski")
                    {
                        rbMuski.Checked = true;

                    }
                    else
                    {
                        rbZenski.Checked = true;
                    }
                    break;
                    



                }

            }
            foreach(Rezervacije r in trenutni_kupac.vrati_rezervacije())
            {
                lbSveRezervacije.Items.Add(r.get_id_rezervacije());


            }
            
            

        }

        
        private void btnSacuvajKupca_Click(object sender, EventArgs e)
        {
            bool provera_ime = Validacija.proveraString(tbIme.Text);
            bool provera_prezime = Validacija.proveraString(tbPrezime.Text);
            bool provera_datum = Validacija.proveraDatum(tbDatum_rodjenja.Text);
            bool provera_telefona = Validacija.proveraTelefon(tbTelefon.Text);
            bool provera_mail = Validacija.proveraMail(tbMail.Text);
            bool provera_lozinki = Validacija.proveraLozinka(tbLozinka1.Text, tbLozinka2.Text);
            if(provera_ime && provera_prezime && provera_datum &&provera_lozinki &&provera_telefona && provera_mail)
            {
                foreach(Kupac k in Kupac.vrati_listu_kupaca())
                {
                    if(k.get_id() == Int32.Parse(lblID.Text))
                    {
                        k.set_ime(tbIme.Text);
                        k.set_prezime(tbPrezime.Text);
                        k.set_datum_rodjenja(tbDatum_rodjenja.Text);
                        k.set_lozinka1(tbLozinka1.Text);
                        k.set_lozinka2(tbLozinka2.Text);
                        k.set_telefon(tbTelefon.Text);
                        k.set_mail(tbMail.Text);
                        Kupac.upisi_kupca(Kupac.vrati_listu_kupaca());
                        MessageBox.Show($"Kupac uspesno izmenjen:{k.info()}");
                        break;
                    }


                }
            }
            else
            {
                MessageBox.Show("Proverite unete podatke");
            }
               

                    
                


            
            
            

        }

        private void PromenaIndeksa(object sender, EventArgs e)
        {
            trenutni_index_lb = Int32.Parse(lbSveRezervacije.SelectedItem.ToString());
            foreach(Rezervacije rez in  trenutni_kupac.vrati_rezervacije())
            {
                if(rez.get_id_rezervacije() == trenutni_index_lb)
                {
                    
                   
                    tbBroj_mestaRez.Text = rez.get_broj_mesta().ToString();
                    tbUkupna_cenaRez.Text = rez.get_ukupna_cena().ToString();
                    
                    
                }
            }
        }

        private void btnSacuvajRez_Click(object sender, EventArgs e)
        {
            int id_projekcije;
            int broj_rezervisanih_mesta;
            if (!String.IsNullOrEmpty(lbSveRezervacije.Text) && !String.IsNullOrEmpty(tbBroj_mestaRez.Text)&& !String.IsNullOrEmpty(tbUkupna_cenaRez.Text))
            {
                foreach(Rezervacije r in Rezervacije.vrati_listu_rezervacija())
                {
                    if (r.get_id_kupca() == Int32.Parse(lblID.Text))
                    {
                        
                        broj_rezervisanih_mesta = r.get_broj_mesta();
                        r.set_broj_mesta(+broj_rezervisanih_mesta);



                    }
                }
                
                foreach(Rezervacije r in trenutni_kupac.vrati_rezervacije())
                {
                    if(r.get_id_rezervacije() == trenutni_index_lb)
                    {
                        r.set_broj_mesta(Int32.Parse(tbBroj_mestaRez.Text));
                        r.set_ukupna_cena(Int32.Parse(tbUkupna_cenaRez.Text));
                        Rezervacije.upisi_rezervaciju(Rezervacije.vrati_listu_rezervacija());

                        MessageBox.Show($"Rezervacija je uspesno izmenjena{r.rezervacija_info()}");
                        break;
                    }
                }
                



            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
            


            
        }

        

        private void btnUkloniRezervaciju_Click(object sender, EventArgs e)
        {
            if (lbSveRezervacije.SelectedIndex != -1)
            {
                foreach (Rezervacije r in trenutni_kupac.vrati_rezervacije())
                {
                    if (r.get_id_rezervacije() == Int32.Parse(lbSveRezervacije.SelectedItem.ToString())) ;
                    {
                        
                        trenutni_kupac.ukloni_rezervaciju(r);
                        Rezervacije.ukloni_rezervaciju(r);
                        Rezervacije.upisi_rezervaciju(Rezervacije.vrati_listu_rezervacija());


                        MessageBox.Show($"Rezervacija je uspesno uklonjena{r.get_id_rezervacije()}");
                        break;
                    }
                }
                lbSveRezervacije.Items.Clear();
                foreach (Rezervacije r in trenutni_kupac.vrati_rezervacije())
                {
                    lbSveRezervacije.Items.Add(r.get_id_rezervacije());


                }
            }
            else
            {
                MessageBox.Show("Izaberite rezervaciju koju zelite da uklonite");
            }
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            if (nova_rezervacija.IsDisposed)
            {
                nova_rezervacija = new Rezervacija();
            }
            nova_rezervacija.Show();
            var kupac_id = nova_rezervacija.Controls.Find("lblIdKupac", true);
            var kupac_ime = nova_rezervacija.Controls.Find("lblImeKupca", true);
            kupac_id[0].Text = lblID.Text;
            foreach(Kupac k in Kupac.vrati_listu_kupaca())
            {
                if(k.get_id().ToString() == lblID.Text)
                {
                    kupac_ime[0].Text = k.info_short();
                    break;
                }
            }


        }
    }
}
