using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 10; //capacity of the stacks
            Stack<int> sta1 = new Stack<int>(capacity);
            Stack<int> sta2 = new Stack<int>(capacity);
            int initialValue1 = 25;
            int initialValue2 = 20;

            //adding values to each stack
            for(int i = initialValue1; i > (initialValue1 - capacity); i--)
            {
                sta1.Push(i);
            }

            for(int i = initialValue2; i > (initialValue2 - capacity); i--)
            {
                sta2.Push(i);
            }

            printStacksSorted(sta1, sta2);
            Console.WriteLine("Finished program.");
        }

        static void printStacksSorted(Stack<int> stack1, Stack<int> stack2)
        {
            Console.WriteLine("The Ordered Combined List of Both Stacks is:");

            int count = stack1.Count() + stack2.Count();

            for(int i = 0; i < count; i++)
            {
                while(stack1.Count() != 0 && stack2.Count() != 0)
                {
                    if(stack1.Peek() < stack2.Peek())
                    {
                        Console.Write("{0}, ", stack1.Pop());
                    }
                    else if(stack2.Peek() < stack1.Peek())
                    {
                        Console.Write("{0}, ", stack2.Pop());
                    }
                    else if(stack1.Peek() == stack2.Peek())
                    {
                        Console.Write("{0}, ", stack1.Pop());
                        stack2.Pop();
                    }
                    else
                    {
                        Console.Write("\nAn error has occured. Exiting list...");
                        break;
                    }
                }
            }

            if (stack1.Count() != 0)
            {
                count = stack1.Count();
                for (int i = 0; i < count; i++)
                {
                    Console.Write("{0}, ", stack1.Pop());
                }
            }
            else if(stack2.Count() != 0)
            {
                count = stack2.Count();
                for(int i = 0; i < count; i++)
                {
                    Console.Write("{0}, ", stack2.Pop());
                }
            }

            Console.Write("\n");
            Console.WriteLine("End of List.");
        }
    }
}
