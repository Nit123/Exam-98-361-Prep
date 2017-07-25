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
            LinkedList<string> productList = new LinkedList<string>();
            LinkedListNode<string> soda = productList.AddFirst("Soda");
            LinkedListNode<string> bread = productList.AddLast("Bread");
            LinkedListNode<string> cereal = productList.AddAfter(soda, "Cereal");
            LinkedListNode<string> frozenDinner = productList.AddAfter(cereal, "Frozen Dinners");
            LinkedListNode<string> saltySnack = productList.AddAfter(frozenDinner, "Salty Snacks");
            LinkedListNode<string> milk = productList.AddAfter(saltySnack, "Milk");
            LinkedListNode<string> detergent = productList.AddAfter(milk, "Laundry Detergent");
            LinkedListNode<string> eggs = productList.AddAfter(milk, "Eggs");
            LinkedListNode<string> _PBJ = productList.AddAfter(eggs, "PB&J");
            LinkedListNode<string> meat = productList.AddBefore(bread, "Packaged meats");


            string choice;
            string item;

        
            do
            {
                Console.WriteLine("What food item do you think is in the Top 10 Groceries bought by Americans? (be specific)");
                item = Console.ReadLine();
                Console.WriteLine();

                if (productList.Contains(item))
                    Console.WriteLine("Correct!");
                else
                    Console.WriteLine("Incorrect, sorry.");

                Console.WriteLine();
                Console.WriteLine("Would you like to guess another item? (y/n)");
                choice = Console.ReadLine();
               Console.WriteLine();
            } while (choice == "Y" || choice == "y");

            Console.WriteLine("End of program");
           
        }

    }
}
