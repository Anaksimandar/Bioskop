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
    class Rezervacije
    {
        private static int ID;
        private int id;
        private int id_kupca;
        private int broj_mesta;
        private int ukupna_cena;
        private static List<Rezervacije> lista_rezervacija = new List<Rezervacije>();
        public Rezervacije()
        {

        }
        public Rezervacije(int id_kupca, int broj_mesta, int ukupna_cena)
        {
            ID++;
            this.id = ID;
            this.id_kupca = id_kupca;
            this.broj_mesta = broj_mesta;
            this.ukupna_cena = ukupna_cena;
        }
        public string rezervacija_info()
        {
            string izlaz = "";
            izlaz = $"Id kupca:{this.get_id_kupca()}Broj mesta: {this.broj_mesta}Cena: {this.ukupna_cena}";
            return izlaz;

        }
        public static void upisi_rezervaciju(List<Rezervacije> lista_rezervacija)
        {
            var fajl = new FileStream("rezervacija.bin", FileMode.OpenOrCreate);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(fajl, lista_rezervacija);
            fajl.Flush();
            fajl.Close();
        }

        public static List<Rezervacije> iscitaj_rezervaciju()
        {
            List<Rezervacije> lista_rezervacija = new List<Rezervacije>();
            var fajl = new FileStream("rezervacija.bin", FileMode.Open);
            BinaryFormatter formater = new BinaryFormatter();
            var obj = formater.Deserialize(fajl) as List<Rezervacije>;
            lista_rezervacija = obj;

            fajl.Close();
            return obj;
        }
        public static void set_ID(int id)
        {
            Rezervacije.ID = id;
        }
        public int get_id_rezervacije()
        {
            return this.id;
        }
        public int get_id_kupca()
        {
            return this.id_kupca;
        }
        public int get_broj_mesta()
        {
            return this.broj_mesta;
        }
        public int get_ukupna_cena()
        {
            return this.ukupna_cena;
        }
        public void set_id_kupca(int novi_id_kupca)
        {
            this.id_kupca = novi_id_kupca;
            
        }
        public void set_broj_mesta(int novi_broj_mesta)
        {
            this.broj_mesta = novi_broj_mesta;
               
        }      
        public  void set_ukupna_cena(int nova_ukupna_cena)
        {
            this.ukupna_cena = nova_ukupna_cena;
            
        }
        public static List<Rezervacije> vrati_listu_rezervacija()
        {
            return lista_rezervacija;
        }
        public static void dodaj_rezervaciju(Rezervacije rezervacija)
        {
            lista_rezervacija.Add(rezervacija);
        }
        public static void ukloni_rezervaciju(Rezervacije obrisi_rezervaciju)
        {
            lista_rezervacija.Remove(obrisi_rezervaciju);
        }
    }
}
