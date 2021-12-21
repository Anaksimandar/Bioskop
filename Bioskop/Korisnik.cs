using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioskop
{
    [Serializable]
    class Korisnik
    {
        
        public string ime;
        public string prezime;
        public Korisnik()
        {
            this.ime = "Nedodeljeno";
            this.prezime = "Nedodeljeno";

        }
        public Korisnik(string ime, string prezime)
        {
            
            this.ime = ime;
            this.prezime = prezime;
            


        }
        public string get_ime()
        {
            return this.ime;
        }
        public string get_prezime()
        {
            return this.prezime;
        }
        public void set_ime(string novo_ime)
        {
            this.ime = novo_ime;
        }
        public void set_prezime(string novo_prezime)
        {
            this.prezime = novo_prezime;
        }
    }
}
