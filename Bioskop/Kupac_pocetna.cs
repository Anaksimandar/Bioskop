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
    partial class Kupac_pocetna : Form
    {
        Rezervacija dodaj_rezervaciju;
        Kupac trenutni_kupac;
        int trenutna_rezervacija;
        string vrednost_trenutnog_indeksa;
        public Kupac_pocetna()
        {
            InitializeComponent();
            dodaj_rezervaciju = new Rezervacija();
            trenutni_kupac = new Kupac();
            
        }

        private void Kupac_pocetna_Load(object sender, EventArgs e)
        {
            
        }

        

        

        private void btnPrikaziRezervacije_Click(object sender, EventArgs e)
        {
            cbKupacRezervacije.Items.Clear();
            cbKupacRezervacije.Text = "";
            foreach(Kupac k in Kupac.vrati_listu_kupaca())
            {
                if (k.get_id() == Int32.Parse(lblIdKupacPocetna.Text));
                trenutni_kupac = k;
                break;
            }
            foreach(Rezervacije r in trenutni_kupac.vrati_rezervacije())
            {
                cbKupacRezervacije.Items.Add(r.rezervacija_info());
            }
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            if (dodaj_rezervaciju.IsDisposed)
            {
                dodaj_rezervaciju = new Rezervacija();
            }
            dodaj_rezervaciju.Show();
            var id_kupca = dodaj_rezervaciju.Controls.Find("lblIdKupac",true);
            var ime_kupca = dodaj_rezervaciju.Controls.Find("lblImeKupca", true);
            id_kupca[0].Text = lblIdKupacPocetna.Text;
            ime_kupca[0].Text = lblImeKupcaPocetna.Text;


        }

        private void PromenaIndexa(object sender, EventArgs e)
        {
            if(cbKupacRezervacije.SelectedIndex != -1)
            {
                vrednost_trenutnog_indeksa = cbKupacRezervacije.SelectedItem.ToString();
                vrednost_trenutnog_indeksa = cbKupacRezervacije.SelectedItem.ToString();
                foreach(Rezervacije rez in Rezervacije.vrati_listu_rezervacija())
                {
                    if(rez.rezervacija_info() == vrednost_trenutnog_indeksa)
                    {
                        trenutna_rezervacija = rez.get_id_rezervacije();
                    }
                    break;
                }

                
            }
            else
            {
                MessageBox.Show("Selektujte rezervaciju");
            }
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            foreach(Rezervacije r in Rezervacije.vrati_listu_rezervacija())
            {
                if(r.get_id_rezervacije() == trenutna_rezervacija)
                {
                    Rezervacije.ukloni_rezervaciju(r);
                   
                    foreach(Kupac k in Kupac.vrati_listu_kupaca())
                    {
                        if(k.get_id().ToString() == lblIdKupacPocetna.Text)
                        {
                            k.ukloni_rezervaciju(r);
                            MessageBox.Show($"Rezervacija je uklonjena:{r.rezervacija_info()}");
                        }
                        break;
                    }
                    break;

                }
            }
            cbKupacRezervacije.Items.Clear();
            cbKupacRezervacije.Text = "";
            foreach(Rezervacije r in Rezervacije.vrati_listu_rezervacija())
            {
                cbKupacRezervacije.Items.Add(r.rezervacija_info());
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
