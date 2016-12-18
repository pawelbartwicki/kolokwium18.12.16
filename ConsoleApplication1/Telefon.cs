using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Telefon
    {
        protected string model;
        protected double cena;

        public Telefon()
        {

        }

        public Telefon(string model, double cena)
        {
            this.model = model;
            this.cena = cena;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Info o Telefonie {0}", this.model, this.cena);
        }


    }
}
