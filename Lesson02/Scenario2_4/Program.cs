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
            c.SampleEvent += new SampleDelegate(c_Changed);
            c.Invoke();
        }

        static void c_Changed(object sender, EventArgs e) //this is the method that handles the event through the event handler (SampleDelegate)
        {
            SampleClass c = (SampleClass)sender;
            Console.WriteLine("It has been invoked.");
        }
    }
}
