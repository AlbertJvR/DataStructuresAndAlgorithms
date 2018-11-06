using System;

namespace InsertionSort
{
    public class Program
    {
        public static void Main(string[] args)
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

            InsertionSort(intArray, n);

            Console.WriteLine("The sorted array is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{intArray[i]} ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        public static void InsertionSort(int[] arrayToSort, int n)
        {
            int i, j, temp;
            for (i = 0; i < n; i++)
            {
                temp = arrayToSort[i];

                for (j = i - 1; j >= 0 && arrayToSort[j] > temp; j--)
                {
                    arrayToSort[j + 1] = arrayToSort[j];
                }

                arrayToSort[j + 1] = temp;
            }
        }
    }
}
