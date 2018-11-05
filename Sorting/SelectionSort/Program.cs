using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            var intArray = new int[20];
            Console.WriteLine("Enter the number of elements : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1} : ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            SelectionSort(intArray, n);

            Console.WriteLine("The sorted array is : ");
            for ( i = 0; i < n; i++)
            {
                Console.Write($"{intArray[i]} ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
        
        public static void SelectionSort(int[] arrayToSort, int n)
        {
            int minIndex, temp, i, j;

            for (i = 0; i < n - 1; i++)
            {
                minIndex = i;
                for (j = i + 1; j < n; j++)
                {
                    if (arrayToSort[j] < arrayToSort[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (i != minIndex)
                {
                    temp = arrayToSort[i];
                    arrayToSort[i] = arrayToSort[minIndex];
                    arrayToSort[minIndex] = temp;
                }
            }
        }
    }
}
