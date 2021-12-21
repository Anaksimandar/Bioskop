
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
    class Sala
    {
        private static int ID = 0;
        private int id;
        private int broj_sale;
        private int broj_sedista;
        private static List<Sala> lista_sala = new List<Sala>();
        public Sala()
        {

        }

        public Sala(int broj_sale, int broj_sedista)
        {
            Sala.ID++;
            this.id = ID;
            this.broj_sale = broj_sale;
            this.broj_sedista = broj_sedista;
        }
        public string sala_info()
        {
            string info = "";
            info = $"Broj sale:{broj_sale}_broj_sedista{broj_sedista}";
            return info;
        }
        public static void upisi_salu(List<Sala> lista_sala)
        {
            var fajl = new FileStream("sala.bin", FileMode.OpenOrCreate);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(fajl, lista_sala);
            fajl.Flush();
            fajl.Close();
        }

        public static List<Sala> iscitaj_salu()
        {
            List<Sala> lista_sala = new List<Sala>();
            var fajl = new FileStream("sala.bin", FileMode.Open);
            BinaryFormatter formater = new BinaryFormatter();
            var obj = formater.Deserialize(fajl) as List<Sala>;
            lista_sala = obj;

            fajl.Close();
            return obj;
        }
        public static void set_ID(int id)
        {
            Sala.ID = id;
        }
        public int get_id()
        {
            return this.id;
        }
        public int get_broj_sale()
        {
            return this.broj_sale;
        }
        public int get_broj_sedista()
        {
            return this.broj_sedista;
        }
        public void set_broj_sale(int broj_sale)
        {
            this.broj_sale = broj_sale;

        }
        public void set_broj_sedista(int broj_sedista)
        {
            this.broj_sedista = broj_sedista;

        }
        public static List<Sala> vrati_listu_sala()
        {
            return Sala.lista_sala;
        }
        public static void dodaj_salu(Sala nova_sala)
        {
            lista_sala.Add(nova_sala);
            
        }
        public static void ukloni_salu(Sala ukloni_salu)
        {
            lista_sala.Remove(ukloni_salu);
        }
    }
}
