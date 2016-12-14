using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            calcChange(1.99, 2);

            Console.Read();
        }

        static void calcChange(double bill, double paid)
        {
            double change = paid - bill;
            if (change < 0)
                Console.WriteLine("Not enough money paid!");
            else
            {
                double[] money = { 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };
                string[] cash = { "£20", "£10", "£5", "£2", "£1", "50p", "20p", "10p", "5p", "2p", "1p" };
                double[] toGive = new double[money.Length];

                for (int m = 0; m < money.Length; m++)
                {
                    toGive[m] = 0;

                    while (change >= money[m])
                    {
                        change -= money[m];
                        toGive[m] += 1;
                    }

                    if (toGive[m] != 0)
                        Console.WriteLine(cash[m] + " : " + toGive[m]);
                }
            }
        }
    }
}
