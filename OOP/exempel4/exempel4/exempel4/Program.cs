using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempel4
{
    class Program
    {
        /*
         
        Abstrakta klasser, metoder och properties
        En abstrakt metod eller property har deklaration, men saknar innehåll.
        Innehålllet måste subklasserna som ärver från klassen skapa.
        Om en enda av en klass metoder eller properties är abstrakt, så måste hela klassen vara abstakt
        Man kan inte instansiera (skapa) objekt i en abstrakt klass.
         
         */
        static void Main(string[] args)
        {
            Vehicle[] all_vehicles = new Vehicle[4];
            all_vehicles[0] = new Bicycle("Tunturi", 2);
            all_vehicles[1] = new Motorcycle("Suzuki", 2, 60);
            all_vehicles[2] = new Bicycle("Nopsa", 3);
            all_vehicles[3] = new Motorcycle("HD", 2, 300);
            for (int i=0; i<4;i++)
            {
                Console.WriteLine(all_vehicles[i].Drive());
            }


            //dummy
            Console.ReadLine();
        }

        abstract class Vehicle
        {
            public Vehicle(string brand,int wheels)
            {
                Brand = brand;
                Wheels = wheels;
            }

            public string Brand
            {
                get; set;
            }
            public int Wheels
            {
                get; set;
            }

            public abstract string Drive();
        }

        class Bicycle:Vehicle
        {
            public Bicycle(string brand, int wheels):base(brand, wheels)
            {
                Brand = brand;
            }
            public override string Drive()
            {
                return "Tramp, tramp, tramp,..." + " med en " + Brand;
            }
            public string Brand
            {
                get; set;
            }
        }

        class Motorcycle:Vehicle
        {
            public Motorcycle(string brand, int wheels, int horsepowers):base(brand, wheels)
            {
                HorsePowers = horsepowers;
            }

            public int HorsePowers
            {
                get; set;
            }

            public override string Drive()
            {
                return "Bruuuuuummmmm, bruuuuuuuuuuuuummmmmmm, bruuuuuuuuuuuuuuuuuuuuuuuuuuummmmmm... med " + HorsePowers + " Hästkrafter";
            }

        }

    }
}
