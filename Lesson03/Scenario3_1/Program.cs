using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] numbers = new int[4][];
            int value = 10; //lowest value
            int largest;

            //initializing array
            for(int i = 0; i < 4; i++)
            {
                numbers[i] = new int[5];
            }

            //entering values
            for(int rows = 0; rows < numbers.Length; rows++)
            {
                for(int columns = 0; columns < numbers[rows].Length; columns++)
                {
                    numbers[rows][columns] = value;
                    value++;
                }
            }

            //finding the largest
            for(int rows = 0; rows < numbers.Length; rows++)
            {
                largest = findLargest(numbers[rows]);
                Console.WriteLine("The largest number in row {0} is {1}.", rows, largest);
            }
        }

        static int findLargest(int[] numbers)
        {
            int largest = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                    largest = numbers[i];
            }

            return largest;
        }
    }
}
