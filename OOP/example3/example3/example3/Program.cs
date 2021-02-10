using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Car.DecorateRow());
            Car backsbil = new Car("ILG-335", "BMW", 2001, 255000,"bensinmotor");  //Has-a-arv, vi överlåter åt Car att skapa Engine-objekt
            Console.WriteLine(backsbil.PrintCar());
            backsbil.Kilometers += 100;
            Console.WriteLine(backsbil.PrintCar());
            //backsbil.Brand = "Biemari";     //Funkar int p.g.a private set

            Car annanbil = new Car() { Regnbr = "KMO-731", Kilometers = 450000, Yearmodel = 2003, CarEngine=new Engine("Bensin") }; //has-a arv, där anroparen ansvarar för att engine-objekt skapas
            Car tredjebil;
            tredjebil = new Car();
            tredjebil.Regnbr = "CCC-333";
            tredjebil.Kilometers = 69669696;
            tredjebil.Yearmodel = 2020;
            tredjebil.CarEngine = new Engine("El");
            Console.WriteLine(Car.DecorateRow());

            Auto kajsbil = new Auto("Saab", 2015);

            Car sussiskopia = backsbil;     //Referenstyp
            sussiskopia.Brand = "Honda";

            Auto kajskopia = kajsbil;       //Valuetyp
            kajskopia.Brand = "Volvo";

            // användning av statisk klass
            Console.WriteLine(Decorator.Decorate());
            Console.WriteLine(Decorator.Decorate('='));


            // Arv (inheritance)
            Truck bigtruck = new Truck("dawff54", "Sisu", 2021, 100, "BigEngine", 100);
            Console.WriteLine(Decorator.Decorate('X'));
            bigtruck.Kilometers += 499;
            Console.WriteLine(bigtruck.PrintCar());


            // Arvskedjan
            Console.WriteLine(Decorator.Decorate('!'));
            Console.WriteLine(backsbil.ToString()); //ToString är default så den kan även utelämnas
            Console.WriteLine(bigtruck.ToString());
            Console.WriteLine(Decorator.Decorate('!'));


            //Polymorfism
            Car[] cararray = new Car[4];
            cararray[0] = backsbil;
            cararray[1] = bigtruck;
            cararray[2] = sussiskopia;
            cararray[3] = new Truck("xxx", "Volvo", 2000, 2000000, "V8", 200);
            for( int i=0;i<4;i++)
            {
                Console.WriteLine(cararray[i].ToString());
            }




            //dummy
            Console.ReadLine();
        }
    }
}
