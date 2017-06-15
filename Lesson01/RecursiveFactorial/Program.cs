using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = Factorial(5);
            Console.WriteLine(n);
        }

        public static int Factorial(int n) {
            if (n == 0)
                return 1; //base case
            else
                return n * Factorial(n - 1);
        }
    }
}
