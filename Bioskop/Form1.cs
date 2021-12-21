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
    public partial class Form1 : Form
    {
        
        Registracija_Kupca reg_kupac;
        Kupac_Login log_kupac;
       

        Administracija f_admin;
        
        String admin_ime;
        String admin_prezime;
        String admin_lozinka;
        



        public Form1()
        {
            InitializeComponent();
            
            f_admin = new Administracija();
            reg_kupac = new Registracija_Kupca();
            log_kupac = new Kupac_Login();
            
            
            




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var lista_kupaca_datoteka = Kupac.iscitaj_kupca();// iscitavanje iz txt - a 
                if (lista_kupaca_datoteka != null)
                {
                    foreach (Kupac k in lista_kupaca_datoteka)
                    {
                        Kupac.dodaj_kupca(k);
                        
                    }
                    
                }
                Kupac.set_ID(Kupac.vrati_listu_kupaca().Count);
            }
            catch(Exception)
            {

            }
            try
            {
                var lista_sala_datoteka = Sala.iscitaj_salu();
                if (lista_sala_datoteka != null)
                {
                    foreach (Sala s in lista_sala_datoteka)
                    {
                        Sala.dodaj_salu(s);
                        
                    }
                    Sala.set_ID(Sala.vrati_listu_sala().Count);
                }
            }
            catch (Exception)
            {

                
            }
            try
            {
                var lista_projekcija_datoteka = Projekcija.iscitaj_projekciju();
                if (lista_projekcija_datoteka != null)
                {
                    foreach (Projekcija p in lista_projekcija_datoteka)
                    {
                        Projekcija.dodaj_projekciju(p);
                        
                    }
                    Projekcija.set_ID(Projekcija.vrati_projekcije().Count);
                }
            }
            catch (Exception)
            {

               
            }
            try
            {
                var lista_filmova_datoteka = Film.iscitaj_film();
                if (lista_filmova_datoteka != null)
                {
                    foreach (Film f in lista_filmova_datoteka)
                    {
                        Film.dodaj_film(f);
                       
                    }
                    Film.set_ID(Film.vrati_film().Count);
                }
            }
            catch (Exception)
            {

                
            }
            try
            {
                var lista_rezervacija_datoteka = Rezervacije.iscitaj_rezervaciju();
                if (lista_rezervacija_datoteka != null)
                {
                    foreach (Rezervacije r in lista_rezervacija_datoteka)
                    {
                        Rezervacije.dodaj_rezervaciju(r);
                        
                    }
                    Rezervacije.set_ID(Rezervacije.vrati_listu_rezervacija().Count);
                }
            }
            catch (Exception)
            {

                
            }
            
            
            
            
            

            adminPanel.Location = new Point(
            this.ClientSize.Width / 2 - adminPanel.Size.Width / 2,
            this.ClientSize.Height / 2 - adminPanel.Size.Height / 2);
            
            






        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnPotvrdaRegistracijeAdmin_Click(object sender, EventArgs e)
        {
            admin_ime = tbAdminKorisnickoIme.Text;
            
            admin_lozinka = tbAdminLozinka.Text;
            
            Admin admin = new Admin(admin_ime, admin_lozinka);
            if (admin.tacna_lozinka())
            {
                MessageBox.Show($"Dobrodosli {admin.getKorisnickoIme()}");
                if (f_admin.IsDisposed)
                {
                    f_admin = new Administracija();
                }
                f_admin.Show();


            }
            else
            {
                MessageBox.Show("Neispravna lozinka");
            }
        }

        private void adminStrana_Click(object sender, EventArgs e)
        {

        }

        

        private void korisnikStrana_Click(object sender, EventArgs e)
        {

        }

        private void btnUlogujSe_Click(object sender, EventArgs e)
        {
            if (log_kupac.IsDisposed)
            {
                log_kupac = new Kupac_Login();
            }
            log_kupac.Show();

        }

        private void btnRegistrujSe_Click(object sender, EventArgs e)
        {
            if (reg_kupac.IsDisposed)
            {
                reg_kupac = new Registracija_Kupca();
            }
            reg_kupac.Show();

        }
    }
}
