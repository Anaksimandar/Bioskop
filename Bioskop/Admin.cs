using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioskop
{
    class Admin
    {
        private string korisnicko_ime;
        private string lozinka;
        private bool odobren_pristup;
        public Admin()
        {
            odobren_pristup = false;
        }
        public Admin(string korisnicko_ime ,string lozinka)
        {
            this.korisnicko_ime = korisnicko_ime;
            if (provera_lozinke(lozinka))
            {
                odobren_pristup = true;
                
            }
            else
            {
                odobren_pristup = false;

            }
        }
        public string getKorisnickoIme()
        {
            return this.korisnicko_ime;
        }
        private bool provera_lozinke(string lozinka)
        {
            if(lozinka == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool tacna_lozinka()
        {
            return odobren_pristup;

        }
        

    }
}
