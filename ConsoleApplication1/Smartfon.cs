using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Smartfon : Telefon
    {
        private bool gps;
        private double rozmiarWyswietlacza;

        public Smartfon()
        { }

        public Smartfon(string model, double rozmiarWyswietlacza)
        {
            this.model = model;
            this.rozmiarWyswietlacza = rozmiarWyswietlacza;

        }
        public void ObliczCene()
        {
            cena = rozmiarWyswietlacza / 218;

            Console.WriteLine("Cena Smartfona:{0}", this.rozmiarWyswietlacza / 218);

        }





    }
}
