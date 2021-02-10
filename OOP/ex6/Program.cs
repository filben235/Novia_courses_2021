using System;

namespace ex6
{
    //generiska metoder, collections och klasser
    //datatyp bestäms vid anropet/ vid instansieringen

    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 1, 2, 3, 4, 5 };
            string[] stringarray = { "aaa", "bbb", "ccc", "ddd" };
            Car[] cararray =
            {
                new Car() {Brand="Volvo", Yearmodel=2015},
                new Car() {Brand="Honda", Yearmodel=2018},
                new Car() {Brand="Opel", Yearmodel=2020}
            };
            //uppgift: sväng om innehållet i de tre arraysen

            //alternativ 1: olika funktioner för olika datatyper
            SwitchInt(ref intarray);
            SwitchString(ref stringarray);
            SwitchCar(ref cararray);

            //alternativ 2: en enda funktion som hanterar datatypen object
            object[] objectarray1 = new object[intarray.Length];
            Array.Copy(intarray, objectarray1, intarray.Length);
            SwitchObject(ref objectarray1);
            Array.Copy(objectarray1, intarray, intarray.Length);

            object[] objectarray2 = new object[stringarray.Length];
            Array.Copy(stringarray, objectarray1, intarray.Length);
            SwitchObject(ref objectarray1);
            Array.Copy(objectarray2, stringarray, stringarray.Length);

            object[] objectarray3 = new object[cararray.Length];
            Array.Copy(cararray, objectarray1, intarray.Length);
            SwitchObject(ref objectarray3);
            Array.Copy(objectarray3, cararray, cararray.Length);

            //alternativ 3: använd en generisk funktion
            Switch<int>(ref intarray);
            Switch<string>(ref stringarray);
            Switch<Car>(ref cararray);


            //alternativ 1
            static void SwitchString(ref string[] unsorted)
            {
                for (int i = 0, k = unsorted.Length - 1; i < k; i++, k--)
                {
                    string temp = unsorted[i];
                    unsorted[i] = unsorted[k];
                    unsorted[k] = temp;
                }
                return;
            }

            static void SwitchInt(ref int[] unsorted)
            {
                for (int i = 0, k = unsorted.Length - 1; i < k; i++, k--)
                {
                    int temp = unsorted[i];
                    unsorted[i] = unsorted[k];
                    unsorted[k] = temp;
                }
                return;
            }

            static void SwitchCar(ref Car[] unsorted)
            {
                for (int i = 0, k = unsorted.Length - 1; i < k; i++, k--)
                {
                    Car temp = unsorted[i];
                    unsorted[i] = unsorted[k];
                    unsorted[k] = temp;
                }
                return;
            }

            //alternativ 2
            static void SwitchObject(ref object[] unsorted)
            {
                for (int i = 0, k = unsorted.Length - 1; i < k; i++, k--)
                {
                    object temp = unsorted[i];
                    unsorted[i] = unsorted[k];
                    unsorted[k] = temp;
                }
                return;
            }

            //alternativ 3, generisk funktion
            static void Switch<T>(ref T[] unsorted)
            {
                for (int i = 0, k = unsorted.Length - 1; i < k; i++, k--)
                {
                    T temp = unsorted[i];
                    unsorted[i] = unsorted[k];
                    unsorted[k] = temp;
                }
                return;
            }

            //generiska collections --> ex7

            //generiska klasser --> se Stall
            Stall<Car> garage = new Stall<Car>();
            garage.Samling = new Car[3];
            garage.Samling[0] = new Car() { Brand = "Toyota", Yearmodel = 2019 };
            garage.Samling[1] = new Car() { Brand = "Toyota", Yearmodel = 2019 };
            garage.Samling[2] = new Car() { Brand = "Toyota", Yearmodel = 2019 };

            Stall<Horse> horsestable = new Stall<Horse>();
            horsestable.Samling = new Horse[2];
            horsestable.Samling[0] = new Horse() { Name = "Drilla", Breed = "Gotlandsruss" };
            horsestable.Samling[1] = new Horse() { Name = "Donna", Breed = "New Forest" };
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public int Yearmodel { get; set; }
    }

    class Horse
    {
        public string Name { get; set; }
        public string Breed { get; set; }
    }

    class Stall<T>
    {
        public T[] Samling { get; set; }
    }
}
