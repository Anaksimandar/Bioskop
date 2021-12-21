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
    public partial class Kupac_Login : Form
    {
        string login_mail;
        string login_loz;
        bool dozvoljen_pristup;
        Kupac_pocetna pocetna_kupac;
        Kupac trenutni_kupac;
        
        
        
        
        public Kupac_Login()
        {
            InitializeComponent();
            dozvoljen_pristup = false;
            pocetna_kupac = new Kupac_pocetna();
            trenutni_kupac = new Kupac();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void Kupac_Login_Load(object sender, EventArgs e)
        {
            panelKupacLogin.Location= new Point(
            this.ClientSize.Width / 2 - panelKupacLogin.Size.Width / 2,
            this.ClientSize.Height / 2 - panelKupacLogin.Size.Height / 2);
        }
        
        private void btnLoginKupac_Click(object sender, EventArgs e)
        {
            login_mail = tbKupacLogMail.Text;
            login_loz = tbKupacLoginLoz.Text;
            
            List<Kupac> lista_kupaca = Kupac.vrati_listu_kupaca();
            foreach(Kupac k in lista_kupaca)
            {
                
                if(k.get_mail() == login_mail&& k.get_lozinka() == login_loz)
                {
                    dozvoljen_pristup = true;
                    trenutni_kupac = k;
                }
                
            }
            if(dozvoljen_pristup){
                MessageBox.Show("Dobrodosli");
                if (pocetna_kupac.IsDisposed)
                {
                    pocetna_kupac = new Kupac_pocetna();
                    

                }
                pocetna_kupac.Show();
                
                var kupac_id = pocetna_kupac.Controls.Find("lblIdKupacPocetna", true);
                var kupac_ime = pocetna_kupac.Controls.Find("lblImeKupcaPocetna", true);
                kupac_id[0].Text = $"{trenutni_kupac.get_id()}";
                kupac_ime[0].Text = $"{trenutni_kupac.get_ime()} {trenutni_kupac.get_prezime()}";
                 
                
            }
            else
            {
                MessageBox.Show("Ne postoji korisnik koji sadrzi unete podatke");
            }
            
            
        }

        private void panelKupacLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
