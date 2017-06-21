using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SampleClass c = new SampleClass();
            c.SampleEventHandler += new EventHandler(c_Changed);
            c.Invoke();
        }

        static void c_Changed(object sender, EventArgs e)
        {
            SampleClass c = (SampleClass)sender;
            Console.WriteLine("It has been invoked.");
        }
    }
}
