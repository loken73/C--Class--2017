using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static int i;
        static int j;

        static void Main(string[] args)
        {
            string i1;
            string w2;
            bool input1;
            bool input2;

            do
            {
                Console.WriteLine("You have a rectangle, and I can help you find the area. Please enter the rectangle's length.");
                i1 = Console.ReadLine();

                input1 = int.TryParse(i1, out i);

            } while (input1 == false);

            do
            {
                Console.WriteLine("Please enter the rectangle's width.");
                w2 = Console.ReadLine();

                input2 = int.TryParse(w2, out j);

            } while (input2 == false);

            var area = CalculateRect(i, j);

            Console.WriteLine("The area of the rectangle is {0}.", area);
            Console.ReadLine();

        }

        public static int CalculateRect(int i, int j)
        {
            return i * j;
        }

    }
}
