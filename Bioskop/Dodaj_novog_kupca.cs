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
    public partial class Dodaj_novog_kupca : Form
    {
        Kupac novi_kupac;
        public Dodaj_novog_kupca()
        {
            InitializeComponent();
            novi_kupac = new Kupac();

        }

        

        private void btnSacuvajKupca_Click(object sender, EventArgs e)
        {
            bool provera_ime = Validacija.proveraString(tbIme.Text);
            bool provera_prezime = Validacija.proveraString(tbPrezime.Text);
            bool provera_datum = Validacija.proveraDatum(tbDatum_rodjenja.Text);
            bool provera_telefona = Validacija.proveraTelefon(tbTelefon.Text);
            bool provera_mail = Validacija.proveraMail(tbMail.Text);
            bool provera_lozinki = Validacija.proveraLozinka(tbLozinka1.Text, tbLozinka2.Text);
            string pol;
            if (rbMuski.Checked == true)
            {
                pol = "Muski";
            }
            else
            {
                pol = "Zenski";
            }
            if (provera_ime && provera_prezime && provera_datum && provera_lozinki && provera_telefona && provera_mail)
            {
                novi_kupac = new Kupac(tbIme.Text, tbPrezime.Text, tbDatum_rodjenja.Text, tbLozinka1.Text, tbLozinka2.Text, tbMail.Text, tbTelefon.Text, pol);
                Kupac.dodaj_kupca(novi_kupac);
                Kupac.upisi_kupca(Kupac.vrati_listu_kupaca());
                MessageBox.Show("Kupac uspesno dodat" + novi_kupac.info());
                
            }
            else
            {
                MessageBox.Show("Proverite unete podatke");
            }
            

        }

        private void Dodaj_novog_kupca_Load(object sender, EventArgs e)
        {

        }
    }
}
