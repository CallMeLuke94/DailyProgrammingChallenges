using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            countCharacters("Hello My Name Is Luke.");
            Console.Read();
        }

        static void countCharacters(string input)
        {
            char[] unique = input.Distinct().ToArray();
            Array.Sort(unique);
            char[] all = input.ToArray();

            foreach (char u in unique)
            {
                int count = 0;
                foreach (char a in all)
                    if (u == a) count++;

                Console.WriteLine(u + " : " + count);
            }
        }
    }
}
