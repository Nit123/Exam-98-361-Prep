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
            int discount = discountCalc(50);
            Console.WriteLine(discount + "%");
        }

        public static int discountCalc(int quantity) {
            int discountPercent;
            if (quantity < 10 && quantity > 0)
                discountPercent = 5;
            else if (quantity < 50 && quantity > 0)
                discountPercent = 10;
            else if (quantity < 100 && quantity > 0)
                discountPercent = 15;
            else if (quantity > 100 && quantity > 0)
                discountPercent = 20;
            else {
                Console.WriteLine("Cannot compute discount.");
                discountPercent = 0;
            }

            return discountPercent;
        }
    }
}
