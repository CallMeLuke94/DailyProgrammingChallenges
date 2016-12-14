using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BinaryToDecimalAndBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(binary2Decimal(10));
            Console.WriteLine(decimal2Binary(10));

            Console.Read();
        }

        static int binary2Decimal(int n)
        {
            string pattern = @"[^01]+";
            string test = n.ToString();
            Match match = Regex.Match(test, pattern);
            if (match.Success)
                return 0;
            else
                return convert(n);
        }

        static string decimal2Binary(int n)
        {
            string result = null;
            while (n >= 2)
            {
                result = (n % 2) + result;
                n /= 2;
            }
            result = n + result;
            return result;
        }

        static int convert(int n)
        {
            int[] digits = getArray(n);
            double result = 0;

            for (int i = 0; i < digits.Length; i++)
                result += digits[i] * Math.Pow(2, i);
            return (int) result;
        }

        static int[] getArray(int n)
        {
            List<int> list = new List<int>();
            while (n > 0)
            {
                list.Add(n % 10);
                n /= 10;
            }
            return list.ToArray();
        }
    }
}
