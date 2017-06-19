using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Triangle : Polygon
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing: Triangle");
        }
    }
}
