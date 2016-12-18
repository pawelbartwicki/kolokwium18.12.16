using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartfon smartfon1 = new Smartfon("Samsung", 5);
            Smartfon smartfon2 = new Smartfon("lg", 4);
            Seniorfon seniorfon1 = new Seniorfon("Microsoft", true);
            Seniorfon seniorfon2 = new Seniorfon("htc", true);

            Smartfon SART3 = new Smartfon();

            smartfon1.ObliczCene();
            smartfon1.WypiszInfo();
            smartfon2.ObliczCene();
            smartfon2.WypiszInfo();
            seniorfon1.ObliczCene();
            seniorfon1.WypiszInfo();
            seniorfon2.ObliczCene();
            seniorfon2.WypiszInfo();



        }
    }
}
