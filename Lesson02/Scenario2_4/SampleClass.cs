using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_4
{
    class SampleClass : ISampleEvents
    {
        public event SampleDelegate SampleEvent; //this is the event
        public void Invoke()
        {
            SampleEvent(this, EventArgs.Empty);
        }

    }
}
