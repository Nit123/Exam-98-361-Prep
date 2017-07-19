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
            int n;
            while (true){
                Console.WriteLine("What number do you wish to find the factorial of?");
                try
                {
                    n = Int32.Parse(Console.ReadLine());
                    if (n <= 0)
                        throw new Exception("Number must be positive. Try again.");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid positive integer. Try again.");
                    Console.WriteLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too large. Try again.");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
                    
            }

            double factorialResult = factorialAlgorithm(n);
            Console.WriteLine("The factorial of {0} is {1}", n, factorialResult);


        }

        public static double factorialAlgorithm(int n) {
            double fact = 1;
            
                while (n > 1)
                {
                    fact *= n;
                    n--;
                 
                }
            
            
            return fact;
        }
    }

}
