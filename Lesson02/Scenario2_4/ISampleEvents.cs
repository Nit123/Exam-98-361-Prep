using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_4
{
    public delegate void SampleDelegate(Object sender, EventArgs e); //this is the event handler
    interface ISampleEvents
    {
        event SampleDelegate SampleEvent; //this is the event needed to be handled
        void Invoke(); //this is the method that will invoke the event
    }
}
