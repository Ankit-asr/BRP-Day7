using System;

namespace Day7Assignments
{
    public class SecondLargestAndSmallest
    {
        public void Second()
        {
            int size, largest, positionOfLargest = 0 , positionOfSmallest = 0, secondLargest, smallest, secondSmallest, i;
            Console.WriteLine("Input the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter Elements in the Array");
            for (i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            largest = array[0];
            for (i = 0; i < size; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                    positionOfLargest = i;
                }
            }
            smallest = array[0];
            for (i = 0; i < size; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                    positionOfSmallest = i;
                }
            }
            secondLargest = array[0];
            for (i = 0; i < size; i++)
            {
                if (i == positionOfLargest)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (secondLargest < array[i])
                    {
                        secondLargest = array[i];
                    }
                }
            }
            secondSmallest = array[0];
            for (i = 0; i < size; i++)
            {
                if (i == positionOfSmallest)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (secondSmallest > array[i])
                    {
                        secondSmallest = array[i];
                    }
                }
            }

            Console.WriteLine("The Second Largest element in the array is "+secondLargest);
            Console.WriteLine("The Second Smallest element in the array is " + secondSmallest);

        }
    }
}