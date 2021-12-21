using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bioskop
{
    [Serializable]
    class Film
    {
        private static int ID = 0;
        private int id;
        private string naziv;
        private string zanr;
        private int duzina;
        private int granica_godina;
        private static List<Film> lista_filmova = new List<Film>();
        public Film()
        {
           

            
        }
        public Film(string naziv, string zanr, int duzina, int granica_godina)
        {
            Film.ID++;
            this.id = ID;
            this.naziv = naziv;
            this.zanr = zanr;
            this.duzina = duzina;
            this.granica_godina = granica_godina;
        }
        public static void upisi_film(List<Film> lista_filmova)
        {
            var fajl = new FileStream("film.bin", FileMode.OpenOrCreate);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(fajl, lista_filmova);
            fajl.Flush();
            fajl.Close();
        }
        public static List<Film> iscitaj_film()
        {
            List<Film> lista_filmova = new List<Film>();
            var fajl = new FileStream("film.bin", FileMode.Open);
            BinaryFormatter formater = new BinaryFormatter();
            var obj = formater.Deserialize(fajl) as List<Film>;
            lista_filmova = obj;

            fajl.Close();
            return obj;
        }
        public string film_info()
        {
            string info = "";
            info = $"Naziv:{this.naziv}_Zanr:{this.zanr}_duzina trajanja:{this.duzina} min_granica godina:{this.granica_godina}";
            return info;
        }
        public static void set_ID(int id)
        {
            Film.ID = id;
        }
        public int get_id()
        {
            return this.id;
        }
        public string get_naziv()
        {
            return this.naziv;
        }
        public string get_zanr()
        {
            return this.zanr;
        }
        public int get_duzina()
        {
            return this.duzina;
        }
        public int get_granica()
        {
            return this.granica_godina;
        }
        public void set_naziv(string naziv)
        {
            this.naziv = naziv;

        }
        public void set_zanr(string zanr)
        {
            this.zanr =zanr;

        }
        public void set_duzina(int duzina)
        {
            this.duzina = duzina;

        }
        public void set_granice(int granice)
        {
            this.granica_godina = granice;

        }
        public static List<Film> vrati_film()
        {
            return Film.lista_filmova;
        }
        public static void dodaj_film(Film novi_film)
        {
            Film.lista_filmova.Add(novi_film);
        }
        public static void ukloni_film(Film obrisi_film)
        {
            Film.lista_filmova.Remove(obrisi_film);
        }

    }
}
