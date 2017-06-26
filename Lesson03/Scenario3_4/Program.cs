using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> productList = new LinkedList<String>();
            LinkedListNode<String> first = new LinkedListNode<String>("Soda");
            LinkedListNode<String> afterSoda = new LinkedListNode<String>("Cereal");
            LinkedListNode<String> afterCereal = new LinkedListNode<String>("Frozen Dinners");
            LinkedListNode<String> afterFrozenDinner = new LinkedListNode<String>("Salty Snacks");
            LinkedListNode<String> afterSaltySnacks = new LinkedListNode<String>("Milk");
            LinkedListNode<String> afterMilk = new LinkedListNode<String>("Laundry Detergent");
            LinkedListNode<String> afterDetergent = new LinkedListNode<String>("Eggs");
            LinkedListNode<String> afterEggs = new LinkedListNode<String>("PB&J");
            LinkedListNode<String> afterPB_J = new LinkedListNode<String>("Packaged Meats");
            LinkedListNode<String> last = new LinkedListNode<String>("Bread");

            int choice;
            String item;

            productList.AddFirst(first);
            productList.AddAfter(afterSoda, "Cereal");
            productList.AddAfter(afterCereal, "Frozen Dinners");
            productList.AddAfter(afterFrozenDinner, "Salty Snacks");
            productList.AddAfter(afterSaltySnacks, "Milk");
            productList.AddAfter(afterMilk, "Laundry Detergent");
            productList.AddAfter(afterDetergent, "Eggs");
            productList.AddAfter(afterEggs, "PB&J");
            productList.AddAfter(afterPB_J, "Packaged Meats");
            productList.AddLast(last);

            do
            {
                Console.WriteLine("What food item do you think is in the Top 10 Groceries bought by Americans?");
                item = Console.ReadLine();
                Console.WriteLine();

                if (productList.Contains(item))
                    Console.WriteLine("Correct!");
                else
                    Console.WriteLine("Incorrect, sorry.");

                Console.WriteLine();
                Console.WriteLine("Would you like to guess another item? (y/n)");
                choice = Console.Read();
                Console.WriteLine();
            } while (choice == 'Y' || choice == 'y');

            Console.WriteLine("End of program");
           
        }

    }
}
