using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
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

            ShellSort(intArray, n);

            Console.WriteLine("The sorted array is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{intArray[i]} ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        public static void ShellSort(int[] arrayToSort, int n)
        {
            int i, j, temp, h;

            Console.Write("Enter maximum increment(odd value) : ");
            h = Convert.ToInt32(Console.ReadLine());

            while (h >= 1)
            {
                for (i = h; i < n; i++)
                {
                    temp = arrayToSort[i];
                    for (j = i - h; j >= 0 && arrayToSort[j] > temp; j = j - h)
                    {
                        arrayToSort[j + h] = arrayToSort[j];
                    }

                    arrayToSort[j + h] = temp;
                }

                h = h - 2;
            }
        }
    }
}
