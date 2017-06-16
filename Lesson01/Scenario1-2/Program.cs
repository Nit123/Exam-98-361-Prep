using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            factorialAlgorithm(31); //goes up to 31!
        }

        public static void factorialAlgorithm(int n) {
            int fact = 1;
            while (n > 1) {
                fact *= n;
                n--;
            }

            Console.WriteLine(fact);
        }
    }

}
