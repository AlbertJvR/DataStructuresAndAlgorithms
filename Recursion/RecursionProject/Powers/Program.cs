using System;

namespace Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value for base:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter value for power:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"{b}^{n} = {Pow(b, n)}");
            Console.ReadLine();
        }

        private static int Pow(int b, int n)
        {
            if (n == 0) return 1;

            return b * Pow(b, n - 1);
        }
    }
}
