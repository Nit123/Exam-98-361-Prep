using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int quant;
            while (true)
            {
                Console.WriteLine("How much of the product did you buy?");
                try
                {
                    quant = Int32.Parse(Console.ReadLine());
                    if (quant <= 0)
                        throw new Exception("Quantity must be larger than 0 and smaller than 100.");
                    Console.WriteLine();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You did not enter valid whole number.");
                    Console.WriteLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Your number is too big. Try again");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                } 
            }

            int discount = discountCalc(quant);
            Console.WriteLine("You get a discount of {0} percent.", discount);
            
            
        }

        public static int discountCalc(int quantity) {
            int discountPercent;
            if (quantity < 10)
                discountPercent = 5;
            else if (quantity < 50)
                discountPercent = 10;
            else if (quantity < 100)
                discountPercent = 15;
            else if (quantity >= 100)
                discountPercent = 20;
            else {
                Console.WriteLine("Cannot compute discount.");
                discountPercent = -1;
            }

            return discountPercent;
        }
    }
}
