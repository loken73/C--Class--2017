using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Program
    {
        static string[] NumberInputs;

        static int max;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter comma separated numbers in order to find the maximum value.");
            string NumberString = Console.ReadLine();

            NumberInputs = NumberString.Split(',');

            int[] NumbersToInt = Array.ConvertAll(NumberInputs, int.Parse);

            MaxValue(NumbersToInt);

            Console.WriteLine(max);
            Console.ReadLine();
        }

        static int MaxValue(int[] num)
        {
            max = num.Max();

            return max;

        }
    }
}
