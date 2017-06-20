using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_1
{
    class Product
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Cannot make Name empty. Making Name blank...");
                    name = " ";
                }
                else if (value == null)
                {
                    Console.WriteLine("Cannot make Name null. Making Name blank...");
                    name = " ";
                }
                else
                    name = value;
                
            }
        }
    }
}
