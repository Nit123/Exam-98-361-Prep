﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_4
{
    class SampleClass : ISampleEvents
    {
        public event SampleDelegate SampleEvent;
        public void Invoke()
        {
            SampleEvent();
        }

    }
}