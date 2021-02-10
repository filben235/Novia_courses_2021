using System;

namespace homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Borders.Print());
            Console.WriteLine(Person.OutputWeightClasses());
            Console.WriteLine(Borders.Print());

            //alternativ 1
            Console.WriteLine(Borders.Print('-', 40));
            Person person1= new Person();
            Console.Write("Name? ");
            person1.Name = Console.ReadLine();
            Console.Write("Gender (male/female)? ");
            person1.Gender = Console.ReadLine();
            Console.Write("Height in cm? ");
            person1.Height = int.Parse(Console.ReadLine());
            Console.Write("Weight in kg? ");
            person1.Weight = double.Parse(Console.ReadLine());
            Console.WriteLine(Borders.Print('-', 40));
            Console.WriteLine(Borders.Print('='));
            Console.WriteLine("BMI = " + person1.Bmi.ToString("##0.00"));
            Console.WriteLine("Weight type = " + person1.WeightType);
            Console.WriteLine(Borders.Print('='));

            Console.WriteLine(Borders.Print());
            Console.WriteLine("Antal objekt som skapats = " + Person.PersonCounter);
            Console.WriteLine(Borders.Print());
        }
    }

    class Person
    {
        public Person(string name, string gender, double weight, int height)
        {
            Name = name;
            Gender = gender;
            Weight = weight;
            Height = height;
            PersonCounter++;
        }

        public Person()
        {
            PersonCounter++;
        }

        static double thin = 20, normal = 27, overweight = 32;
        public string Name
        {
            get; set;
        }

        string gender;
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value.ToLower().Trim() == "male" || value.ToLower().Trim() == "female")
                {
                    gender = value.ToLower().Trim();
                }
            }
        }

        public double Weight
        {
            get; set;
        }

        public int Height
        {
            get; set;
        }
        public double Bmi
        {
            get
            {
                return Weight/(((double)Height/100.0) * ((double)Height / 100.0));
            }
        }
        public string WeightType
        {
            get
            {
                if (Bmi<thin)
                {
                    return "underweight";
                }
                else if (Bmi < normal)
                {
                    return "normal weight";
                }
                else if (Bmi < overweight)
                {
                    return "slightly overweight";
                }
                else
                {
                    return "overweight";
                }
            }
        }
        public static int PersonCounter
        {
            get;set;
        }

        public static string OutputWeightClasses()
        {
            string output = "Underweight if Bmi is < " + thin + '\n';
            output += "Normal weight if Bmi (" + thin + ',' + normal + ")\n";
            output += "Slightly overweight if Bmi > " + normal + '-' + overweight + '\n';
            output += "Overweight if Bmi > " + overweight + '\n';
            return output;
        }
    }

    static class Borders
    {
        public static string Print()
        {
            string row = "";
            for(int i=0;i<80;i++)
            {
                row += '*';
            }
            return row;
        }

        public static string Print(char c)
        {
            string row = "";
            for (int i = 0; i < 80; i++)
            {
                row += c;
            }
            return row;
        }

        public static string Print(char c, int n)
        {
            string row = "";
            for (int i = 0; i < n; i++)
            {
                row += c;
            }
            return row;
        }
    }
}
