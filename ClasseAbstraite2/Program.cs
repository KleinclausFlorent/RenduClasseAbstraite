using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ouvrier myOuv = new Ouvrier("Kleinclaus", "Florent", new DateTime(1994, 02, 18), "001", new DateTime(2017, 02, 18));
            Console.WriteLine(myOuv.ToString());
            Cadre myCadre = new Cadre("Kleinclaus", "Martial", new DateTime(1968, 06, 22), "002", 4);
            Console.WriteLine(myCadre.ToString());
            Patron myPatron = new Patron("Kleinclaus", "Lulu", new DateTime(2015, 06, 20), "003", 50);
            Console.WriteLine(myPatron.ToString());
        }
    }
}
