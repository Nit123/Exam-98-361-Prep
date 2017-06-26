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

            productList.AddFirst("Soda");
            productList.AddLast("Cereal");
            productList.AddLast( "Frozen Dinners");
            productList.AddLast("Salty Snacks");
            productList.AddLast("Milk");
            productList.AddLast("Laundry Detergent");
            productList.AddLast("Eggs");
            productList.AddLast("PB&J");
            productList.AddLast("Packaged Meats");
            productList.AddLast("Bread");

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
