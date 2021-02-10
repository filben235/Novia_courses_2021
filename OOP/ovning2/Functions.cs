using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2
{
    partial class Program
    {
        public static bool checkPoints(short points)
        {
            if (points >= 0 && points <= 30) return true;
            else return false;
        }
        
        public static short calculateGrade(short points)
        {
            if (points > 27) return 5;
            else if (points < 7) return 0;
            else return Convert.ToInt16((0.25 * points) - 1.5);
        }

        public static void renderFrequency(short[] studentPoints)
        {
            short[] count = new short[6];

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < studentPoints.Length; y++)
                {
                    if (studentPoints[y] == x)
                        count[x]++;
                }
            }

            for (int x = 0; x <= 5; x++)
                Console.WriteLine("Antal " + x + ": " + new String((char)x, count[x])); //'*'
        }


        //----------------------a----------------------
        //public static string gradeComment(short grade)
        //{
        //    string output;
        //    switch (grade)
        //    {
        //        case 1:
        //        case 2:
        //            output = "You scored a " + grade + ", that's ok\n";
        //            break;
        //        case 3:
        //        case 4:
        //            output = "You scored a " + grade + ", nice job :)\n";
        //            break;
        //        case 5:
        //            output = "You scored a 5, that's great :D\n";
        //            break;
        //        default:
        //            output = "You scored a 0, nice job :E\n";
        //            break;
        //    }
        //    return output;
        //}
    }
}
