using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_OpreaAndreea_1059D
{
    public class Magazin
    {
        public string nume;
        public string locatie;
        public List<Raion> listaRaioane = new List<Raion>();

        public Magazin()
        {
            
        }
        public Magazin(string n, string l)
        {
            this.nume = n;
            this.locatie = l;
            
        }
        public override string ToString()
        {
            return nume + " " + locatie;
        }
    }
}
