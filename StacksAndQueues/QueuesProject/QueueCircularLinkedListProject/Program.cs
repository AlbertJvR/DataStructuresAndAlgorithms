using System;

namespace QueueCircularLinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;

            var queue = new QueueCLL();

            while (true)
            {
                Console.WriteLine("1. Insert an element in the queue");
                Console.WriteLine("2. Delete an element from the queue");
                Console.WriteLine("3. Display element at the front");
                Console.WriteLine("4. Display all the elements of the queue");
                Console.WriteLine("5. Display size of the queue");
                Console.WriteLine("6. Quit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6) break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the element to be inserted : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        queue.Enqueue(x);
                        break;
                    case 2:
                        x = queue.Dequeue();
                        Console.WriteLine($"The deleted element is : {x}");
                        break;
                    case 3:
                        Console.WriteLine($"Element at the front is : {queue.Peek()}");
                        break;
                    case 4:
                        queue.Display();
                        break;
                    case 5:
                        Console.WriteLine($"The size of the queue is : {queue.Size()}");
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
