using System;

namespace ovning2
{
    class Program
    {
        public static bool checkPoints(short points) {
            if (points >= 0 && points <= 30) return true;
            else return false;
        }

        public static short calculateGrade(short points) {
            if (points > 27) return 5;
            return Convert.ToInt16((0.25 * points) - 1.5);
        }

        public static string gradeComment(short grade) {
            string output;
            switch (grade)
            {
                case 1:
                case 2:
                    output = "You scored a " + grade + ", that's ok\n";
                    break;
                case 3:
                case 4:
                    output = "You scored a " + grade + ", nice job :)\n";
                    break;
                case 5:
                    output = "You scored a 5, that's great :D\n";
                    break;
                default:
                    output = "You scored a 0, nice job :E\n";
                    break;
            }
            return output;
        }

        static void Main()
        {
            short studentPoints, grade;

            do {
                Console.WriteLine("Enter students points (should be between 0 and 30): ");
                studentPoints = Convert.ToInt16(Console.ReadLine());
            } while (!checkPoints(studentPoints));

            grade = calculateGrade(studentPoints);
            Console.WriteLine(gradeComment(grade));
        }
    }
}
