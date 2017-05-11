using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> salaries = new List<double>() { 28000, 32000, 40000, 50000, 100000 };

            Increase(salaries);

            foreach (int sal in salaries)
            {
                Console.WriteLine(sal);
            }
            Console.ReadLine(); 
        }

        public static List<double> Increase (List<double> salariesToIncrease)
        {
            List<int> newSalaries = new List<int>();

            for (int i = 0; i < salariesToIncrease.Count; i++)
            {
                if (i == salariesToIncrease.Count)
                    break;

                salariesToIncrease[i] *= 1.10f;
            }

            return salariesToIncrease;
        }
    }
}
