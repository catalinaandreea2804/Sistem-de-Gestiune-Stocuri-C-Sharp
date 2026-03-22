using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_OpreaAndreea_1059D
{
    public class Raion
    {
        public string nume;
        public List<Produs> listaProduse = new List<Produs>();

        public Raion() { }

        public Raion(string nume)
        {
            this.nume = nume;
        }

        public override string ToString()
        {
            //return "Raionul " + nume + " are " + listaProduse.Count + " tipuri de produse";
            return "Raionul " + nume;
        }
    }
}
