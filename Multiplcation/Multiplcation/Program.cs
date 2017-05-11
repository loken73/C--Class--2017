using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplcation
{
    class Program
    {
        static void Main(string[] args)
        {
            string TableOfNumber;
            int number;
            bool input;

            do
            {
                Console.WriteLine("You need to learn your multiplication. Please enter a number to display its multiplication table.");
                TableOfNumber = Console.ReadLine();

                input = int.TryParse(TableOfNumber, out number);

            } while (input == false);

            TimesTable(number);
        }

        static void TimesTable(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int LineBase = (1 + j) * i;
                    Console.Write("{0} ", LineBase);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
