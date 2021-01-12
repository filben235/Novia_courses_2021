using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ovning2
{
    class Program
    {
        public static bool checkPoints(short points)
        {
            if (points >= 0 && points <= 30) return true;
            else return false;
        }

        public static short calculateGrade(short points)
        {
            if (points > 27) return 5;
            return Convert.ToInt16((0.25 * points) - 1.5);
        }


        static void Main()
        {
            short studentPoints, grade;

            do {
                Console.WriteLine("Enter students points (should be between 0 and 30): ");
                studentPoints = Convert.ToInt16(Console.ReadLine());
            } while (!checkPoints(studentPoints));

            grade = calculateGrade(studentPoints);

            switch (grade)
            {
                case 1:
                case 2:
                    Console.WriteLine ("You scored a {0}, that's ok\n", grade);
                    break;
                case 3:
                case 4:
                    Console.WriteLine("You scored a {0}, nice job :)\n", grade);
                    break;
                case 5:
                    Console.WriteLine("You scored a 5, that's great :D\n");
                    break;
                default:
                    Console.WriteLine("You scored a 0, nice job :E\n");
                    break;
            }
        }
    }
}
