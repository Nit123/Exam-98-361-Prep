using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int[] BubbleSort(int[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++) // traverses the array
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        //swap
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped); //tests it until all swaps are done

            return numbers;
        }

        static int Partition (int[] numbers, int left, int right, int pivotIndex) //used to partition an array for Quicksort without creating seperate lists
        {
            int pivotValue = numbers[pivotIndex];

            //move pivot element to the end
            int temp = numbers[right];
            numbers[right] = numbers[pivotIndex];
            numbers[pivotIndex] = temp;

            //newPivot stores index of first number bigger than pivot
            int newPivot = left;
            for(int i = left; i < right; i++) 
            {
                //It swaps newPivot so that it will become the index of the first number greater than pivot
                if (numbers[i] <= pivotValue) 
                {
                    temp = numbers[newPivot];
                    numbers[newPivot] = numbers[i];
                    numbers[i] = temp;
                    newPivot++;
                }
            }

            //moves pivot element to its sorted position (makes number in pivot index currently right of the pivot and the pivot where it is suppposed to be)
            temp = numbers[right];
            numbers[right] = numbers[newPivot];
            numbers[newPivot] = temp;

            return newPivot;
        }

        static int[] Quicksort(int[] numbers, int left, int right)
        {
            if(right > left)
            {
                int pivotIndex = left + (right - left) / 2;
                //partition the array
                pivotIndex = Partition(numbers, left, right, pivotIndex);
                //sort left partition
                Quicksort(numbers, left, pivotIndex);
                //sort right partition
                Quicksort(numbers, pivotIndex + 1, right);
            }

            return numbers;
        }
    }
}
