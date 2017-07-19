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
            int testNum;
            while (true)
            {
                try
                {
                    Console.WriteLine("What number do you want to calculate?");
                    testNum = Int32.Parse(Console.ReadLine());
                    if (testNum <= 0)
                        throw new Exception("The number must be positive.");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid integer (decimals not supported). Try again.");
                    Console.WriteLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("That number is too large. Try again with a smaller integer.");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
           

            int sigDig = sigDigRecursive(testNum);
            if (testNum % 10 == 0)
                sigDig--;
            Console.WriteLine("There are {0} significant figures in the integer. (Note this is very basic and does not count 0s correctly)", sigDig);
        }

        public static int sigDigRecursive(int x) { 
            if (x < 10)
                return 1;
            else
                return 1 + sigDigRecursive(x / 10);
        }
    }
}
