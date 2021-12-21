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
    public partial class Registracija_Kupca : Form
    {
        Kupac novi_kupac;
        public Registracija_Kupca()
        {
            InitializeComponent();
            novi_kupac = new Kupac();
        }
        private void Registracija_Kupca_Load(object sender, EventArgs e)
        {
            korisnikPanel.Location = new Point(
            this.ClientSize.Width / 2 - korisnikPanel.Size.Width / 2,
            this.ClientSize.Height / 2 - korisnikPanel.Size.Height / 2);
        }
       

        private void btnPotvrdaKorisnik_Click(object sender, EventArgs e)
        {
            
                bool k_ime;
                bool k_prezime;
                bool k_mail;
                bool k_loz;
                bool k_tel;
                bool k_datum;
                string pol;
                if (rbKorisnikPolM.Checked)
                {
                    pol = "Muski";
                }
                else
                {
                    pol = "Zenski";
                }

                k_ime = Validacija.proveraString(tbKorisnikIme.Text);
                k_prezime = Validacija.proveraString(tbKorisnikPrezime.Text);
                k_mail = Validacija.proveraMail(tbKorisnikMail.Text);
                k_loz = Validacija.proveraLozinka(tbKorisnikLoz1.Text, tbKorisnikLoz2.Text);
                k_tel = Validacija.proveraTelefon(tbKorisnikTelefon.Text);
                k_datum = Validacija.proveraDatum(tbKorisnikDatumRodjenja.Text);
                if (k_ime == true && k_prezime == true && k_loz == true && k_datum == true && k_mail && k_tel == true)
                {
                    novi_kupac = new Kupac(tbKorisnikIme.Text, tbKorisnikPrezime.Text, tbKorisnikDatumRodjenja.Text, tbKorisnikLoz1.Text, tbKorisnikLoz2.Text, tbKorisnikMail.Text, tbKorisnikTelefon.Text, pol);
                    Kupac.dodaj_kupca(novi_kupac);
                    MessageBox.Show($"Uspesna registracija");
                    Kupac.upisi_kupca(Kupac.vrati_listu_kupaca());
                

            }
            else
                {
                    if (!k_ime) { MessageBox.Show("Neispravno ime"); }
                    if (!k_prezime) { MessageBox.Show("Neispravno prezime"); }
                    if (!k_mail) { MessageBox.Show("Neispravan mail"); }
                    if (!k_loz) { MessageBox.Show("Neispravna lozinka"); }
                    if (!k_tel) { MessageBox.Show("Neispravan broj telefona"); }
                    if (!k_datum) { MessageBox.Show("Neispravan datum"); }
                }




            }

        
    }
}
