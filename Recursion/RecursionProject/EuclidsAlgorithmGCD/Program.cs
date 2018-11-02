using System;

namespace EuclidsAlgorithmGCD
{
    class Program
    {
        /**
         * This is an example of tail recursion...
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value for integer 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter value for integer 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"GCD = {GCD(a, b)}");
            Console.ReadLine();
        }

        private static int GCD(int a, int b)
        {
            if (b == 0) return a;

            return GCD(b, a % b);
        }
    }
}
