using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Name = "";
            Console.WriteLine("Product's current name is: {0}", p.Name);
            p.Name = null;
            Console.WriteLine("Product's current name is: {0}", p.Name);
            p.Name = "Some product";
            Console.WriteLine("Product's current name is: {0}", p.Name);
        }
    }
}
