using System;

namespace BubbleSort
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

            ImprovedBubbleSort(intArray, n);

            Console.WriteLine("The sorted array is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{intArray[i]} ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        public static void BubbleSort(int[] arrayToSort, int n)
        {
            int x, j, temp;

            for (x = n-2; x >= 0; x--)
            {
                for (j = 0; j <= x; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = temp;
                    }
                }
            }
        }

        // Count the number of swops to detect when array is sorted and avoid redundant passes
        public static void ImprovedBubbleSort(int[] arrayToSort, int n)
        {
            int x, j, temp, swops;

            for (x = n - 2; x >= 0; x--)
            {
                swops = 0;
                for (j = 0; j <= x; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = temp;
                        swops++;
                    }
                }

                // If no swops happen on a pass, the array is sorted and execution is terminated
                if (swops == 0)
                {
                    break;
                }
            }
        }
    }
}
