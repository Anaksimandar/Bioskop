using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bioskop
{   [Serializable]
    class Kupac : Korisnik
    {
        
        private static int ID = 0;
        private int id;
        private string datum_rodjenja;
        private string telefon;
        private string pol;
        private string mail;
        private string lozinka1;
        private string lozinka2;
        private static List<Kupac> lista_kupaca = new List<Kupac>();
        private  List<Rezervacije> lista_rezervacija_kupca = new List<Rezervacije>();
        private int godine;
        public Kupac()
        {
            
        }
        public Kupac(string ime,string prezime,string datum_rodjenja,string lozinka1, string lozinka2,string mail,string telefon,string pol)
        {
            
            Kupac.ID++;
            this.id = Kupac.ID;
            this.ime = ime;
            this.prezime = prezime;
            this.lozinka1 = lozinka1;
            this.lozinka2 = lozinka2;
            this.mail = mail;
            this.datum_rodjenja = datum_rodjenja;
            this.telefon = telefon;
            this.pol = pol;
            this.godine = broj_godina(datum_rodjenja);
            

        }

        public static void upisi_kupca(List<Kupac> lista_kupaca)
        {
            var fajl = new FileStream("kupci.bin", FileMode.OpenOrCreate);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(fajl, lista_kupaca);
            fajl.Flush();
            fajl.Close();
        }
        public static List<Kupac> iscitaj_kupca()
        {
            List<Kupac> lista_kupaca = new List<Kupac>();
            var fajl = new FileStream("kupci.bin", FileMode.Open);
            BinaryFormatter formater = new BinaryFormatter();
            var obj = formater.Deserialize(fajl) as List<Kupac>;
            lista_kupaca = obj;

            fajl.Close();
            return lista_kupaca;
        }
        public int broj_godina(string datum_rodjenja)
        {
            CultureInfo srbija = new CultureInfo("sr");
            string format = "dd/MM/yyyy";
            int godine;
            DateTime datum = DateTime.ParseExact(datum_rodjenja, format, srbija, DateTimeStyles.None);
            
            
            var razlika = DateTime.Now - datum;
            godine = razlika.Days / 365;
            return godine;

        }
        public string info_short()
        {
            string short_info = "";
            short_info = $"{this.id}_{this.ime}_{this.prezime}";
            return short_info;
        }
        public string info()
        {
            string info = "";
            info = $"{this.ime}{this.prezime}{this.id}{this.datum_rodjenja}{this.lozinka1}{this.lozinka2}{this.mail}{this.pol}{this.telefon}{this.godine}";
            return info;
        }
        public static void set_ID(int id)
        {
            Kupac.ID = id;
        }
        public int get_id()
        {
            return this.id;
        }
        public string get_mail()
        {
            return this.mail;
        }
        public string get_lozinka()
        {
            return this.lozinka1;
        }
        public string get_datum_rodjenja()
        {
            return this.datum_rodjenja;
        }
        public string get_telefon()
        {
            return this.telefon;
        }
        public string get_pol()
        {
            return this.pol;
        }
        public void set_lozinka1(String lozinka1)
        {
            this.lozinka1 = lozinka1;
        }
        public void set_lozinka2(string lozinka2)
        {
            this.lozinka2 = lozinka2;
        }
        public void set_mail(string novi_mail)
        {
            this.mail = novi_mail;
        }
        public void set_telefon(string telefon)
        {
            this.telefon = telefon;
        }
        public void set_datum_rodjenja(string datum_rodjenja)
        {
            this.datum_rodjenja = datum_rodjenja;
        }
        public void set_pol(String pol)
        {
            this.pol = pol;
        }
       
        public static void dodaj_kupca(Kupac novi_kupac)
        {
            lista_kupaca.Add(novi_kupac);
            
        }
        public static void ukloni_kupca(Kupac k)
        {
            Kupac.lista_kupaca.Remove(k);
        }
        public static List<Kupac> vrati_listu_kupaca()
        {
            return Kupac.lista_kupaca;
        }
        public  void dodaj_rezervaciju(Rezervacije rez)
        {
            lista_rezervacija_kupca.Add(rez);
        }
        public  void ukloni_rezervaciju(Rezervacije rez)
        {
            lista_rezervacija_kupca.Remove(rez);
        }
        public   List<Rezervacije> vrati_rezervacije()
        {
            return lista_rezervacija_kupca;
        }
    }
}
