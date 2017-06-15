using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileTest();
        }

        private static void WhileTest() {
            int i = 1;
            while(i <= 5)
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
        }
    }
}
