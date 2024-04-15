using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaFinal
{
    internal class KalkulackaFinal
    {
        public double aktualniVysledek = 0;

        //metody na matematické operace
        public void Pricti(double cislo)
        {
            aktualniVysledek += cislo;
        }

        public void Odecti(double cislo)
        {
            aktualniVysledek -= cislo;
        }

        public void Nasobeni(double cislo)
        {
            aktualniVysledek *= cislo;
        }

        public void Deleni(double cislo)
        {
            aktualniVysledek /= cislo;
        }

        public void Mocneni(double cislo)
        {
            aktualniVysledek = Math.Pow(aktualniVysledek, cislo);
        }

        public double VratAktualniVysledek()
        {
            return aktualniVysledek;
        }
    }
}
