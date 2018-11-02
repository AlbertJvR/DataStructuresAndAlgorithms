using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum of the digits (Alberts Way) of {n} are:");
            Console.WriteLine($"{GetSumOfDigitsAlbert(n)}");
            Console.WriteLine();

            Console.WriteLine($"The sum of the digits (Ladies Way) of {n} are:");
            Console.WriteLine($"{GetSumOfDigitsLady(n)}");
            Console.ReadLine();
        }

        private static int GetSumOfDigitsLady(int n)
        {
            if (n / 10 == 0) return n;

            return GetSumOfDigitsLady(n / 10) + (n % 10);
        }

        private static int GetSumOfDigitsAlbert(int n)
        {
            var temp = n.ToString();
            if (temp.Length == 1) return n;

            var substring = temp.Substring(0, temp.Length - 1);
            return GetSumOfDigitsAlbert(Convert.ToInt32(substring)) + Convert.ToInt32(temp.Substring(temp.Length - 1));
        }
    }
}
