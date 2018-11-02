using System;

namespace StackLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;

            var stack = new StackLinkedList();

            while (true)
            {
                Console.WriteLine("1. Push an element on the stack.");
                Console.WriteLine("2. Pop an element from the stack.");
                Console.WriteLine("3. Display the top element.");
                Console.WriteLine("4. Display all stack elements.");
                Console.WriteLine("5. Display size of the stack.");
                Console.WriteLine("6. Quit.");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6) break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the element to be pushed : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        stack.Push(x);
                        break;
                    case 2:
                        x = stack.Pop();
                        Console.WriteLine($"The popped element is : {x}");
                        break;
                    case 3:
                        Console.WriteLine($"Element at the top is : {stack.Peek()}");
                        break;
                    case 4:
                        stack.Display();
                        break;
                    case 5:
                        Console.WriteLine($"The size of the stack is : {stack.Size()}");
                        break;
                    default:
                        Console.WriteLine("Your choice does not make sentence noob");
                        break;
                }
            }
        }
    }
}
