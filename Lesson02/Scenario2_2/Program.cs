using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Location target = new Location();
            target.X = 50;
            target.Y = 34;
            target.Z = 20;

            Console.WriteLine("The target's 3D coordinates are ({0}, {1}, {2}).", target.X, target.Y, target.Z);
        }

        struct Location
        {
            public int X, Y, Z;
            //This is kinda dumb because the name of the scenario is Creating a Struct and it is asking what data structure I should create...smh
        }
    }
}
