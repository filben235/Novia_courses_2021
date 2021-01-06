using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        //static needed for procedural programming
        static void Main()
        {
            Console.WriteLine("moro");

            /*
            variabler, konstanter
            variabler av typen var dvs. en variabel vars datatyp som bestäms då den får ett värde
            */
            string station;
            double celcius, kelvin, fahrenheit;
            const int currentyear = 2021;
            var first = 5;
            first = 100;

            //inmatning från tangentbord och utskrift till skärm
            //cin getline --> Readline()
            //cout --> Write(), WriteLine()
            Console.Write("Moro 2.0");
            station = Console.ReadLine();
            Console.Write("Celcius? ");
            //readline läser alltid in data av typen string --> vi behöver konvertera till rätt datatyp
            // 1. Parse - konverterar alltid från string till annan datatyp
            celcius = double.Parse(Console.ReadLine());
            // 2. Convert - konverterar från en datatyp till en annan
            celcius = Convert.ToDouble(Console.ReadLine());
            // 3. TryParse - konverterar från string till annan datatyp OCH returnerar false om det inte lyckas
            // bool success = datatyp.TryParse(Console.Readline(), out variabel)
            while (!double.TryParse(Console.ReadLine(), out celcius))
            {
                Console.WriteLine("FEL - celcius måste vara numeriskt");
                Console.Write("Celcius? ");
            }
        }
    }
}
