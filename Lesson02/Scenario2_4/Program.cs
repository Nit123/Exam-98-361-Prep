using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_4
{
    class Program
    {
        public delegate void SampleEventHandler(SampleClass);
        static void Main(string[] args)
        {
            SampleClass c = new SampleClass();
            SampleEventHandler sEH;
            sEH += c.Invoke;
            


        }
    }
}
