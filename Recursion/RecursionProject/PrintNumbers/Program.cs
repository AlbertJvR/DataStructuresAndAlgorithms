using System;

namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number greater than 0");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers in Descending Order:");
            PrintDescending(n);
            Console.WriteLine();

            Console.WriteLine("Numbers in Ascending Order:");
            PrintAscending(n);
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void PrintAscending(int n)
        {
            if (n == 0) return;

            PrintAscending(n - 1);
            Console.Write($"{n} ");
        }

        private static void PrintDescending(int n)
        {
            if (n == 0) return;

            Console.Write($"{n} ");
            PrintDescending(n - 1);
        }
    }
}
