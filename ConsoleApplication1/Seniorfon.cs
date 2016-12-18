using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Seniorfon : Telefon
    {
        public bool duzePrzyciski;

        public Seniorfon()
        { }

        public Seniorfon(string model, bool duzePrzyciski)
        {
            this.model = model;
            this.duzePrzyciski = duzePrzyciski == true;


        }

        public void ObliczCene()
        {
            cena = 100;
        }

    }
}
