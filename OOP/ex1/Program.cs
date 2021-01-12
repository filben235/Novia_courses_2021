using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static string CreateMessage(string text)
        {
            string themessage = "The message is: " + text;
            return themessage;
        }

        static void SwitchPlace(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            return;
        }

        static void Main()
        {
            /*
            variabler, konstanter
            variabler av typen var dvs. en variabel vars datatyp som bestäms då den får ett värde
            */
            //string station;
            //double celcius, kelvin, fahrenheit;
            //const int currentyear = 2021;
            //var first = 5;
            //first = 100;

            ////inmatning från tangentbord och utskrift till skärm
            ////cin getline --> Readline()
            ////cout --> Write(), WriteLine()
            //Console.Write("Moro 2.0");
            //station = Console.ReadLine();
            //Console.Write("Celcius? ");
            ////readline läser alltid in data av typen string --> vi behöver konvertera till rätt datatyp
            //// 1. Parse - konverterar alltid från string till annan datatyp
            //celcius = double.Parse(Console.ReadLine());
            //// 2. Convert - konverterar från en datatyp till en annan
            //celcius = Convert.ToDouble(Console.ReadLine());
            //// 3. TryParse - konverterar från string till annan datatyp OCH returnerar false om det inte lyckas
            //// bool success = datatyp.TryParse(Console.Readline(), out variabel)
            //while (!double.TryParse(Console.ReadLine(), out celcius))
            //{
            //    Console.WriteLine("FEL - celcius måste vara numeriskt");
            //    Console.Write("Celcius? ");
            //}

            //Skriv ut alla udda heltal från 0-100
            //for (int i = 1; i <= 100; i += 2) Console.WriteLine(i);

            ////ex läs in ett antal heltal och skriv ut dem i omvänd ordningsföljd
            //int length;
            //Console.Write("Hur många platser ska arrayn ha? ");
            //length = int.Parse(Console.ReadLine());
            //int[] numbers = new int[length];
            //for (int i=0; i < length; i++)
            //{
            //    Console.Write("Tal nummer " + (i+1));
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine("Tal nummer {0} av {1} är  {2}.", i + 1, length, numbers[i]);
            //}

            //by value
            Console.WriteLine(CreateMessage("hello"));

            //by reference
            int t1 = 5, t2 = 10;
            SwitchPlace(ref t1, ref t2);
            Console.WriteLine(t1.ToString() + t2.ToString());


        }
    }
}
