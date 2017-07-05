using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario5_3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What text do you want to capitalize?");
           string text = Console.ReadLine();
           text = text.ToUpper();
           Console.WriteLine("\n{0}", text);
           Console.WriteLine("Finished program.");
        }
    }
}
