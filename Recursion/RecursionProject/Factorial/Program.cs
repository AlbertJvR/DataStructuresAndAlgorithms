using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value for n:");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The factorial of {n} is {CalculateFactorial(n)}");
            Console.ReadLine();
        }

        private static long CalculateFactorial(int n)
        {
            if (n == 0) return 1;

            return n * CalculateFactorial(n - 1);
        }
    }
}
