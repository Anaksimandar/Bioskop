using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bioskop
{
    [Serializable]
    class Projekcija
    {
        private static int ID = 0;
        private int id;
        private string datum_projekcije;
        private Sala sala = new Sala();
        private int cena_karte;
        private string vreme_pocetka_projekcije;
        private Film film = new Film();
        private static List<Projekcija> lista_projekcija = new List<Projekcija>();
        public Projekcija()
        {

        }
        public Projekcija(string datum_projekcije, Sala sala, int cena_karte, string vreme_pocetka_projekcije, Film film)
        {
            Projekcija.ID++;
            this.id = ID;

            this.datum_projekcije = datum_projekcije;
            this.sala = sala;
            this.cena_karte = cena_karte;
            this.vreme_pocetka_projekcije = vreme_pocetka_projekcije;
            this.film = film;
        }
        public static void upisi_projekciju(List<Projekcija> lista_projekcija)
        {
            var fajl = new FileStream("projekcija.bin", FileMode.OpenOrCreate);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(fajl, lista_projekcija);
            fajl.Flush();
            fajl.Close();
        }

        public static List<Projekcija> iscitaj_projekciju()
        {
            List<Projekcija> lista_projekcija = new List<Projekcija>();
            var fajl = new FileStream("projekcija.bin", FileMode.Open);
            BinaryFormatter formater = new BinaryFormatter();
            var obj = formater.Deserialize(fajl) as List<Projekcija>;
            lista_projekcija = obj;

            fajl.Close();
            return obj;
        }
        public string projekcija_info_short()
        {
            string info_short = "";
            info_short = $"Naziv filma:{this.film.get_naziv()}Sala:{this.get_sala().get_broj_sale()}Pocetak:{this.datum_projekcije}/{this.vreme_pocetka_projekcije}";
            return info_short;
        }
        public string projekcija_info()
        {
            string info = "";
            info = $"Naziv filma:{this.film.get_naziv()}Datum projekcije:{this.datum_projekcije}Vreme pocetka:{this.vreme_pocetka_projekcije}Sala:{this.sala.get_broj_sale()}Cena karte:{this.cena_karte}";
            return info;
        }
        public static void set_ID(int id)
        {
            Projekcija.ID = id;
        }
        public int get_id()
        {
            return this.id;
        }
        public string get_datum_projekcije()
        {
            return this.datum_projekcije;
        }
        public Sala get_sala()
        {
            return this.sala;
        }
        public int get_cena_karte()
        {
            return this.cena_karte;
        }
        public string get_vreme_pocetka_projekcije()
        {
            return this.vreme_pocetka_projekcije;
        }
        public Film get_film()
        {
            return this.film;
        }

        public void set_datum_projekcije(string novi_datum_projekcije)
        {
            this.datum_projekcije = datum_projekcije;

        }
        public void set_sala(Sala nova_sala)
        {
            this.sala = nova_sala;

        }
        public void set_cena_karte(int nova_cena_karte)
        {
            this.cena_karte = nova_cena_karte;

        }
        public void set_vreme_pocetka_projekcije(string novo_vreme_pocetka_projekcije)
        {
            this.vreme_pocetka_projekcije = novo_vreme_pocetka_projekcije;

        }
        public void set_film(Film novi_film)
        {
            this.film = novi_film;
        }
        public static List<Projekcija> vrati_projekcije()
        {
            return Projekcija.lista_projekcija;
        }
        public static void dodaj_projekciju(Projekcija nova_projekcija)
        {
            lista_projekcija.Add(nova_projekcija);
        }
        public static void ukloni_projekciju(Projekcija obrisi_projekciju)
        {
            Projekcija.lista_projekcija.Remove(obrisi_projekciju);
        }
        
        
    }
}
