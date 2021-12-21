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
    public partial class Novi_kupac : Form
    {
        Kupac novi_kupac;
        
        public Novi_kupac()
        {
            InitializeComponent();
            novi_kupac = new Kupac();
            
        }

        private void Novi_kupac_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvajKupca_Click(object sender, EventArgs e)
        {
            bool provera_ime = Validacija.proveraString(tbIme.Text);
            bool provera_prezime= Validacija.proveraString(tbPrezime.Text);
            bool provera_mail = Validacija.proveraMail(tbMail.Text);
            bool provera_lozinka= Validacija.proveraLozinka(tbLozinka1.Text,tbLozinka2.Text);
            bool provera_dat_rodjenja = Validacija.proveraDatum(tbDatum_rodjenja.Text);
            bool provera_telefon = Validacija.proveraTelefon(tbTelefon.Text);
            string pol = "";
            if (rbPolM.Checked)
            {
                pol = "Muski";
            }
            else
            {
                pol = "Zenski";
            }
            if (provera_ime == true && provera_prezime ==true && provera_mail == true && provera_lozinka == true && provera_telefon == true && provera_dat_rodjenja == true)
            {
                novi_kupac = new Kupac(tbIme.Text, tbPrezime.Text, tbDatum_rodjenja.Text, tbLozinka1.Text, tbLozinka2.Text, tbMail.Text, tbTelefon.Text,pol);
                Kupac.dodaj_kupca(novi_kupac);
                MessageBox.Show(novi_kupac.info());
                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                {
                    tb.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Neispravan unos");
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
