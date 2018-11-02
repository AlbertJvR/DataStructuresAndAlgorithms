using System;

namespace BaseConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{n} in binary is: ");
            ToBinary(n);
            Console.WriteLine();

            Console.WriteLine($"{n} in octal is: ");
            ConvertToBase(n, 8);
            Console.WriteLine();

            Console.WriteLine($"{n} in hexadecimal is: ");
            ConvertToBase(n, 16);
            Console.ReadLine();
        }

        private static void ConvertToBase(int n, int b)
        {
            if (n == 0) return;

            ConvertToBase(n/b, b);

            int remainder = n % b;

            if(remainder < 10)
                Console.Write(remainder);
            else
                Console.Write((char)(remainder - 10 + 'A'));
        }

        private static void ToBinary(int n)
        {
            if (n == 0) return;

            ToBinary(n / 2);
            Console.Write(n % 2);
        }
    }
}
