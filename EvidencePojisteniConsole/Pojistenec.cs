using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniConsole
{
    internal class Pojistenec
    {
        private string Jmeno { get; set; }
        private string Prijmeni { get; set; }

        private string TelefonniCislo { get; set; }
        private int Vek { get; set; }
        public Pojistenec(string jmeno, string prijmeni, string telefonniCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelefonniCislo = telefonniCislo;
            Vek = vek;
        }

        public string vratJmeno()
        {
            return this.Jmeno;
        }
        public string vratPrijmeni()
        {
            return this.Prijmeni;
        }
        public override string ToString()
        {
            return this.Jmeno.PadRight(15) + " " + this.Prijmeni.PadRight(15) +"  " + this.Vek.ToString().PadRight(5) + " " + this.TelefonniCislo;
        }
    }

}
