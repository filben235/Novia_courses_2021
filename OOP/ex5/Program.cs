using System;
using System.Diagnostics.CodeAnalysis;

namespace ex5
{
    /*
     Interfaces
     I ett interface definierar man enbart vad klassen som "implementerar" interfacet
     måste innehålla, men tar inte ställnning till HUR innehållet ska se ut.

     Ett interface kan alltså innehålla deklarationer för properties och metoder. 
     Metoderna och propertie i ett interface har ingen räckvidd.

     En klass kan ärva från bara en basklass, men implementera flera interface

     Att implementera existerande .NET-interfaces:
     IComparable - för att jämföra två objekt med varandra --> behövs vid sortering
     ICloneable - för att skapa korrekta kopior av objekt
    */
    class Program
    {
        static void Main(string[] args)
        {
            //test av våra interface och våra klassser som implementerar dessa
            Drever dog1 = new Drever("Jerry", "drever", 2015, "rabbits", "male");
            IDog dog2 = new Drever("Bella", "dreverisch", 2018, "moose", "bitch");
            Chihuahua dog3 = new Chihuahua("Timo", "chihuahua", 2015);
            IDog dog4 = new Chihuahua("Pumba", "långhårig chihu", 2019);

            IDog[] dogarray = new IDog[4];
            dogarray[0] = dog1;
            dogarray[1] = dog2;
            dogarray[2] = dog3;
            dogarray[3] = dog4;

            Console.WriteLine(dog1.Name + ", " + dog1.Run() + ", " + dog1.Bark());
            //Console.WriteLine(dog2.Name + ", " + dog2.Run() + ", " + dog2.Bark());
            Array.Sort(dogarray);
            foreach (IDog dog in dogarray)
            {
                Console.WriteLine(dog.Name + ", " + dog.Breed + dog.Bark());
            }

            Drever nyhund = (Drever) dog1.Clone();
            nyhund.Name = "Tom";
        }
    }

    interface IDog: IComparable<IDog>
    {
        //properties
        string Name { get; set; }
        string Breed { get; set; }
        int Yearborn { get; set; }

        //metod
        string Bark();
    }

    interface IHuntingDog
    {
        string HuntingType { get; set; }
        string Run();
    }

    //klassen implementerar interfacen Dog och HuntingDog
    class Drever : IDog, IHuntingDog, ICloneable
    {
        //kan även ha konstuktorer/metoder som inte definieras i interfacet 
        public Drever(
                string name, 
                string breed, 
                int yearborn, 
                string huntingtype, 
                string gender
            )
        {
            Name = name;
            Breed = breed;
            Yearborn = yearborn;
            HuntingType = huntingtype;
            Gender = gender;
        }

        public string Gender { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        int yearborn;
        public int Yearborn {
            get { return yearborn; }
            set {
                if (DateTime.Today.Year - 20 <= value)
                {
                    yearborn = value;
                }
            } 
        }
        public string HuntingType { get; set; }

        public string Bark()
        {
            return "Woof Woof";
        }

        public string Run()
        {
            return "Spring, nosa, nosa";
        }

        public int CompareTo(IDog other)
        {
            return Name.CompareTo(other.Name);
        }

        public object Clone()
        {
            Drever dreverkopia = new Drever(
                    Name, 
                    Breed, 
                    Yearborn, 
                    HuntingType, 
                    Gender
                    );
            return dreverkopia;
            //eller return this.MemberwiseClone(); alternativ som
            //fungerar om data i klassen bara är valuetyper
        }
    }

    class Chihuahua : IDog
    {
        public Chihuahua(string name, string breed, int yearborn)
        {
            Name = name;
            Breed = breed;
            Yearborn = yearborn;
        }

        public string Name { get; set; }
        public string Breed { get; set; }

        int yearborn;
        public int Yearborn
        {
            get { return yearborn; }
            set
            {
                if (DateTime.Today.Year - 22 <= value)
                {
                    yearborn = value;
                }
            }
        }

        public string Bark()
        {
            return "Yap, yap";
        }

        public int CompareTo( IDog other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
