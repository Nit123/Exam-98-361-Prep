using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 10; //capacity of the queues
            Queue<int> que1 = new Queue<int>(capacity);
            Queue<int> que2 = new Queue<int>(capacity);
            int initalValue1 = 10;
            int initalValue2 = 5;

            //adding values to the queue
            for(int i = initalValue1; i < (initalValue1 + capacity); i++)
            {
                que1.Enqueue(i);
            }

            for (int i = initalValue2; i < (initalValue2 + capacity); i++)
            {
                que2.Enqueue(i);
            }

            PrintQueueSorted(que1, que2);

            Console.WriteLine("Finished program");
            
        }

       
        static void PrintQueueSorted(Queue<int> queue1, Queue<int> queue2)
        {

            Console.Write("The Ordered Combined List of Both Queues is: ");

            int count = queue1.Count() + queue2.Count();

            for(int i = 0; i < count; i++)
            {
                while (queue1.Count() != 0 && queue2.Count() != 0)
                {
                    if (queue1.Peek() < queue2.Peek())
                    {
                        Console.Write("{0}, ", queue1.Dequeue());
                    }
                    else if (queue2.Peek() < queue1.Peek())
                    {
                        Console.Write("{0}, ", queue2.Dequeue());
                    }
                    else if (queue1.Peek() == queue2.Peek())
                    {
                        Console.Write("{0}, ", queue1.Dequeue());
                        queue2.Dequeue();
                    }
                    else
                    {
                        Console.Write("\nError has occured. Will exit list");
                        break;
                    }
                }
            }

            if(queue1.Count() != 0)
            {
                count = queue1.Count();

                for (int i = 0; i < count; i++)
                    Console.Write("{0}, ", queue1.Dequeue());
            }
            else if(queue2.Count() != 0)
            {
                count = queue2.Count();

                for (int i = 0; i < count; i++)
                    Console.Write("{0}, ", queue2.Dequeue());
            }

            Console.Write("\n");
            Console.WriteLine("Finished listing.");
        }

    }
}
