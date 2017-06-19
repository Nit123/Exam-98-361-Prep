using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle { Length = 10, Width = 20 };
            Rectangle rect2 = new Rectangle { Length = 100, Width = 200 };
            Console.WriteLine(rect1.CompareTo(rect2));
        }
    }
}
