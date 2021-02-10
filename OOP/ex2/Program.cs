using System;
using System.Text;

namespace ex2
{
    partial class Program
    {
        static void Main()
        {
            //datatyper såsom int, double osv --> skapar variabler
            //klasser såsom StringBuilder, DateTime --> skapar objekt

            //string vs StringBuilder
            string name1 = "Kalle Anka"; //"read only"
            string firstName = name1.Substring(0, 5);
            StringBuilder name2 = new StringBuilder("Kalle Anka");
            name2.Remove(5, 5);

            //DateTime, TimeSpan och klockslag
            DateTime idag = DateTime.Today;
            DateTime senasteJul = new DateTime(2020, 12, 24);
            DateTime exakttid = DateTime.Now;
            Console.WriteLine(idag.DayOfWeek.ToString());

            TimeSpan fjortondagar = new TimeSpan(14, 0, 0, 0);
            //returnerar vad klockan är nu + 14 dagar
            DateTime förfallodag = idag.Add(fjortondagar);
            Console.WriteLine(förfallodag.ToShortDateString());
            PrintDay();
        }
    }
}
