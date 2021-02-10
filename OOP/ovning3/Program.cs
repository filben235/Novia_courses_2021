using System;
using System.Text.RegularExpressions;

namespace ovning3
{
    class Program
    {
        static string checkGender(int kön)
        {
            if (kön % 2 == 0)
            {
                return "Kvinna";
            }
            else return "Man";
        }

        static int checkBirthYear(string födelseDatum, char århundrade)
        {
            if (århundrade == '+')
            {
                return Convert.ToInt32(1800 + Convert.ToInt32(födelseDatum.Substring(4, 2)));
            } else if (århundrade == '-')
            {
                return Convert.ToInt32(1900 + Convert.ToInt32(födelseDatum.Substring(4, 2)));
            } else
            {

                return Convert.ToInt32(2000 + Convert.ToInt32(födelseDatum.Substring(4, 2)));
            }
        }

        static int hasBirthdayPassed(DateTime idag, DateTime veckodag)
        {
            if ((idag.DayOfYear - veckodag.DayOfYear) < 0)
            {
                return (idag.Year - veckodag.Year) - 1;
            } else
            {
                return (idag.Year - veckodag.Year);
            }
        }
        static void Main()
        {
            string personSignum;
            Console.Write("Skriv in ditt personsignum: ");
            personSignum = (Console.ReadLine());
             
            int könNummer;
            string födelseDatum;
            char århundrade, kontrollTecken;

            //"slicear" inputen till olika delar
            födelseDatum = personSignum.Substring(0, 6);
            århundrade = Convert.ToChar(personSignum.Substring(6, 1));
            könNummer = Convert.ToInt32(personSignum.Substring(7, 3));
            kontrollTecken = Convert.ToChar(personSignum.Substring(10, 1));

            int födelseÅr = checkBirthYear(födelseDatum, århundrade);

            DateTime födelseDag = new DateTime(födelseÅr,
                Convert.ToInt32(födelseDatum.Substring(2, 2)),
                Convert.ToInt32(födelseDatum.Substring(0, 2)));
            DateTime idag = DateTime.Today;

            string kön = checkGender(könNummer);
            int ålder = hasBirthdayPassed(idag, födelseDag);

            Console.WriteLine("Du är: \n {0} \n {1} år gammal \n Du föddes den {2}\n vilket var en {3}"
                , kön, ålder, födelseDatum, födelseDag.DayOfWeek);

            Regex regex = new Regex(@"^(0[1-9]|[12]\d|3[01])(0[1-9]|1[0-2])([5-9]\d\+|\d\d-|[01]\dA)\d{3}[\dABCDEFHJKLMNPRSTUVWXY]$");
           
            if (regex.IsMatch(personSignum))
            {
                Console.Write("Giltigt personsignum");
            } else
            {
                Console.Write("Ogiltigt personsignum");
            }

        }
    }
}
