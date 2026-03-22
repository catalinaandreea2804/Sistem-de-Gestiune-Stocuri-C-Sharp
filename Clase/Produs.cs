using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_OpreaAndreea_1059D
{
    public class Produs
    {
        public string denumire;
        public double pret;
        public int stoc;

        public Produs() { }
        public Produs(string denumire, double pret, int stoc)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.stoc = stoc;
        }

        public override string ToString()
        {
            return denumire + ": " + pret + " ron - stoc: " + stoc;
        }
    }
}
