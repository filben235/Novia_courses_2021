using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    // en statisk klass kan bara ha statiskt innehåll
    //man kan inte skapa objekt i en statisk klass
    static class Decorator
    {
        public static string Decorate()
        {
            string line = "";
            for (int i = 0; i < 80; i++)
            {
                line += '*';
            }
            return line;
        }

        public static string Decorate(char symbol)
        {
            string line = "";
            for (int i = 0; i < 80; i++)
            {
                line += symbol;
            }
            return line;
        }
    }
}
