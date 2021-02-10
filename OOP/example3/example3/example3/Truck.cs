using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    // En klass kan ärva från en basklass (Car)
    //en klass kan ha flera subklasser som ärver från den (Truck, kunde finnas Bus,...)

    //Basklassens konstruktor anropas vanligen (.base(,.)) innan den egna konstruktorkoden körs

    //Räckvidden för innehållet i en klass:
    //1. private (default)
    //2. protected - subklasserna har tillgång till innehållet
    //3. public

    //om subklassen ska ha en egen version av en property eller metod så måste metoden antecknas som virtual i basklassen,
    // och override i subklassen

    //överst i arvskedjan finns alltid en klass Object som alla klasserna automatiskt ärver från, antingen direkt, eller via sin basklass
    // t.ex. ToString()

    //Polymorfism innebär:
    //Att en basklass erbjuder gränssnittet med metoder, egenskaper etc...
    //Att subklasserna ansvarar för hur dessa metoder, egenskaper etc. utförs.


    class Truck : Car
    {






        public Truck(string regnr, string brand, int yearmodel, int kilometers, string motortype, int volume) : base(regnr, brand, yearmodel, kilometers, motortype)
        {
            //Volume
            Volume = volume;

        }

        public int Volume
        {
            get; set;
        }

        public override int Kilometers
        {
            get
            {
                return kilometers;
            }
            set
            {
                if(kilometers==0)
                {
                    kilometers = value;
                }
                else if(value + kilometers <=1000)
                {
                    kilometers = value;
                }
            }
        }

        public override string ToString()
        {
            string text = "Volume = " + Volume + '\n';
            return base.ToString();
        }


    }
}
