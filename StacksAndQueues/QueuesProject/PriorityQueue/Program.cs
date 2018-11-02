using System;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, element, elementPriority;

            var pq = new PriorityQueue();

            while (true)
            {
                Console.WriteLine("1. Insert new element");
                Console.WriteLine("2. Delete an element");
                Console.WriteLine("3. Display queue");
                Console.WriteLine("4. Quit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4) break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element to be inserted : ");
                        element = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter element priority : ");
                        elementPriority = Convert.ToInt32(Console.ReadLine());
                        pq.Insert(element,elementPriority);
                        break;
                    case 2:
                        Console.WriteLine($"The deleted element is {pq.Delete()}");
                        break;
                    case 3:
                        pq.Display();
                        break;
                    default:
                        Console.WriteLine("Wrong choice bro");
                        break;
                }
            }
        }
    }
}
