using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_4
{
    public delegate void SampleDelegate();
    interface ISampleEvents
    {
        event SampleDelegate SampleEvent;
        void Invoke();
    }
}
