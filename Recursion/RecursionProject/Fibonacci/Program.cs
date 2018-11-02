using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The fibonacci number for {n} is: {Fib(n)}");
            Console.ReadLine();
        }

        private static int Fib(int n)
        {
            if (n == 0) return 0;

            if (n == 1) return 1;

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
