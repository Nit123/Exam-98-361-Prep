using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int testNum = 430;
            int sigDig = sigDigRecursive(testNum);
            if (testNum % 10 == 0)
                sigDig--;
            Console.WriteLine("There are {0} significant figures in the integer.", sigDig);
        }

        public static int sigDigRecursive(int x) {
            if (x < 10)
                return 1;
            else
                return 1 + sigDigRecursive(x / 10);
        }
    }
}
