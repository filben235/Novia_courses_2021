using System;
using System.Collections.Generic;

namespace ovning2
{
    partial class Program
    {
        static void Main()
        {
            List<short> list = new List<short>();
            short input;

            do
            {
                do
                {
                    Console.WriteLine("Enter students points (should be between 0 and 30): ");
                    input = Convert.ToInt16(Console.ReadLine());
                } while (!checkPoints(input));
                list.Add(calculateGrade(input));
                Console.WriteLine("To keep entering press [Any button], to stop entering press [ESC]");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            short[] studentPoints = list.ToArray();
            renderFrequency(studentPoints);
        }
    }
}
