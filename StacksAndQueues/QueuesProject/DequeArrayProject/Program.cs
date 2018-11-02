using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;

            var deque = new DequeArray(8);

            while (true)
            {
                Console.WriteLine("1. Insert at front end");
                Console.WriteLine("2. Insert at rear end");
                Console.WriteLine("3. Delete from front end");
                Console.WriteLine("4. Delete from rear end");
                Console.WriteLine("5. Display all elements of deque");
                Console.WriteLine("6. Quit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6) break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the element to be inserted : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        deque.InsertFront(x);
                        break;
                    case 2:
                        Console.Write("Enter the element to be inserted : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        deque.InsertRear(x);
                        break;
                    case 3:
                        Console.WriteLine($"Element deleted from front end is {deque.DeleteFront()}");
                        break;
                    case 4:
                        Console.WriteLine($"Element deleted from rear end is {deque.DeleteRear()}");
                        break;
                    case 5:
                        deque.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid option chosen");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
