using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    /*
         en klass kan innehålla:
            - konstruktorer (funktioner som har samma namn som klassen och anropas då ett nytt objekt ska skapas(new) dvs instansieras,
                om man inte kodan någon konstruktor, så skapas en tom konstruktor vid kompileringen, publika)
            - variabler (vanligen privata)
            - metoder (funktioner) både privata och publika
            - egenskaper (properties, mellanting mellan variabler och metoder och kan ha getter-metod och setter-metod, vanligen publika, inget returvärde)
            - (destruktorer 
                    - funktion som har samma namn som klassen + tilde ~klassnamn, 
                    - används sällan i C#, 
                    - körs automatiskt då objekt raderas ur minnet, 
                    - i C# används automatic garbage collection så vi vet inte exakt när objektet raderas ur minnet)


            - en klass kan förutom instansvariabler, - konstruktorer, -properties, -metoder ochså ha statisk innehåll
            - statiska variabler, konstruktor, properties och metoder delas av alla objekt ( instanser ) i klassen

     */
    class Car
    {
        /*Statisk konstruktor : 
                -   bara en, 
                -   ingen räckvidd (private, public), 
                -   inga parametrar
                -   anropas automatiskt innan första objektet skapas i klassen
                -   har tillgång bara till statiska variabler, properties och metoder
        */
        static Car()
        {
            counter = 99;
        }

        //konstruktorer
        public Car(string regnbr, string brand, int yearmodel, int kilometers, string motortype)
        {
            Regnbr = regnbr;
            Brand = brand;
            Yearmodel = yearmodel;
            Kilometers = kilometers;
            counter++;
            CarEngine = new Engine(motortype);  //lagrar med new då CarEngine är ett objekt i klassen Engine
        }


        public Car(string regnbr, string brand, int yearmodel, string motortype)
        {
            Regnbr = regnbr;
            Brand = brand;
            Yearmodel = yearmodel;
            Kilometers = 100000;
            counter++;
            CarEngine = new Engine(motortype);  //lagrar med new då CarEngine är ett objekt i klassen Engine
        }

        public Car()
        {
            counter++;
        }

        //STATISK VARIABEL - gemensam för alla objekt i klassen
        static int counter;



        //Variabler (private)
        protected int kilometers;
        int yearmodel;

        //Properties (vanligen publika)

        public virtual int Kilometers
        {
            get //för att avläsa kilometers (Get måste alltid returnera någonting)
            {
                return kilometers;
            }
            set //för att lagra kilometers
            {
                if(value >= 0)
                {
                    kilometers = value;
                }
                
            }
        }

        public double Mile
        {
            get
            {
                return kilometers / 1.62;
            }
        }

        public string Regnbr    //autoimplementerad property, variablen och innehållet genereras automatiskt
        {
            get; set;
        }

        public string Brand
        {
            get;
            set;
        }


        //Yearmodel - kollar att årsmodellen ligger mellan aktuellt årtal och 30 år tillbaka i tiden

        public int Yearmodel
        {
            get
            {
                return Yearmodel;
            }
            set
            {
                int currentyear = DateTime.Today.Year;
                if(CheckIntervall(value, currentyear-30, currentyear))
                {
                    yearmodel = value;
                }
            }
            
        }


        //en bil har en motor, arv av typen has-a
        //man kan använda Engine där man normalt använder datatyper
        public Engine CarEngine
        {
            get; set;
        }

        // statisk metod ( kunde även vara property)
        //      -   kan bara använda sådant osm är statiskt i klassen
        //      -   anropas med klassnamnet inte objektnamnet
        public static string DecorateRow()
        {
            string line = "";
            for(int i = 0; i<80;i++)
            {
                line += '*';
            }
            return line;
        }


        //privat metod
        private bool CheckIntervall(int valuetocheck, int min, int max)   //Private e default, behöver inte stå där
        {
            if ( valuetocheck < min || valuetocheck > max)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }


        // publik metod
        public string PrintCar()
        {
            return CarEngine.Start() + Regnbr + ": " + Brand + ", " + yearmodel + ", " + Kilometers + " kilometers = " + Mile + " miles" + CarEngine.Stop();
        }

        public override string ToString()
        {
            string text = "";
            text += "Regnbr = " + Regnbr + '\n';
            text += "Brand = " + Brand + '\n';
            //text += "Yearmodel = " + Yearmodel + '\n';
            text += "Kilometers = " + Kilometers + '\n';
            text += "Miles = " + Mile + '\n';
            text += "Motor = " + CarEngine.EngineType + '\n';
            return text;
        }

        //Destruktor???? onödig
        ~Car()
        {
            Console.WriteLine("Destruktor Körs");
        }




        ////DateTime, TimeSpan för datum och klockslag
        //DateTime idag = DateTime.Today;
        //DateTime senastejul = new DateTime(2020, 12, 24);
        //DateTime exakttid = DateTime.Now;
        //Console.WriteLine(idag.DayOfWeek.ToString());
        //    Console.WriteLine(senastejul.ToShortDateString());
        //    Console.WriteLine(exakttid.ToLocalTime());
        //    TimeSpan fjortondagar = new TimeSpan(14, 0, 0, 0);
        //DateTime förfallodag = idag.Add(fjortondagar);
        //Console.WriteLine(förfallodag.ToShortDateString());

        //    PrintToday();
    }
}
