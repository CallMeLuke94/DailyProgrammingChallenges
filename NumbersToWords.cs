using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsToWords
{
    class Program
    {
        static string[] digits = {"", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine "};
        static string[] tens = {"", "ten ", "hundred ", "thousand ", "ten thousand "};

        static void Main(string[] args)
        {
            Console.WriteLine(toWords(12535));

            Console.Read();
        }

        static string toWords(int n)
        {
            if (n < 0)
                return "Must be greater than zero.";
            else if (n > 999999)
                return "Your number is too big.";
            else if (n == 0)
                return "zero";
            else
            {
                return n + ": " + convert(n);
            }
        }

        static string convert(int n)
        {
            string[] digits = { "", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ", "ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventee ", "eighteen ", "nineteen " };
            string[] tenMults = { "", "ten", "twenty ", "thirty ", "fourty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety " };
            string[] tenPows = { "", "ten ", "hundred ", "thousand " };
            int[] d;
            string result = "coming soon";

            d = getDigits(n);

            if (n < 20)
                return digits[n];
            else if (n < 100)
                return tenMults[d[0]] + convert(d[1]);
            else if (n < 1000)
            {
                if (n - d[0] * 100 == 0)
                    return digits[d[0]] + tenPows[2] + convert(n - d[0] * 100);
                else
                    return digits[d[0]] + tenPows[2] + "and " + convert(n - d[0] * 100);
            }
            else if (n < 10000)
            {
                if (n - d[0] * 1000 > 99 || n - d[0] * 1000 == 0)
                    return digits[d[0]] + tenPows[3] + convert(n - d[0] * 1000);
                else
                    return digits[d[0]] + tenPows[3] + "and " + convert(n - d[0] * 1000);
            }
            else if (n < 100000)
            {
                if (n - (n / 1000) * 1000 > 99 || n - (n / 1000) * 1000 == 0)
                    return convert(n / 1000) + tenPows[3] + convert(n - (n / 1000) * 1000);
                else
                    return convert(n / 1000) + tenPows[3] + "and " + convert(n - (n / 1000) * 1000);
            }
            else if (n < 1000000)
            {
                if (n - (n / 1000) * 1000 > 99 || n - (n / 1000) * 1000 == 0)
                    return convert(n / 1000) + tenPows[3] + convert(n - (n / 1000) * 1000);
                else
                    return convert(n / 1000) + tenPows[3] + "and " + convert(n - (n / 1000) * 1000);
            }
            else
                return result;
        }

        static int[] getDigits(int num)
        {
            List<int> list = new List<int>();
            while (num > 0)
            {
                list.Add(num % 10);
                num = num / 10;
            }
            list.Reverse();
            return list.ToArray();
        }
    }
}
