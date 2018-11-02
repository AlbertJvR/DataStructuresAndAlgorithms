using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var bt = new BinarySearchTree();
            int x;

            while (true)
            {
                Console.WriteLine("1. Display tree");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Insert a new node");
                Console.WriteLine("4. Delete a node");
                Console.WriteLine("5. PreOrder Traversal");
                Console.WriteLine("6. InOrder Traversal");
                Console.WriteLine("7. PostOrder Traversal");
                Console.WriteLine("8. Height of tree");
                Console.WriteLine("9. Find Minimum key");
                Console.WriteLine("10. Find Maximum key");
                Console.WriteLine("11. Quit");

                var choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 11)
                    break;

                switch (choice)
                {
                    case 1:
                        bt.Display();
                        break;
                    case 2:
                        Console.Write("Enter a key to be searched : ");
                        x = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(bt.Search(x) ? "Key was found" : "Key not found");
                        break;
                    case 3:
                        Console.Write("Enter a key to be Inserted : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        bt.Insert(x);
                        break;
                    case 4:
                        Console.Write("Enter a key to be Deleted : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        bt.Delete(x);
                        break;
                    case 5:
                        bt.PreOrder();
                        break;
                    case 6:
                        bt.InOrder();
                        break;
                    case 7:
                        bt.PostOrder();
                        break;
                    case 8:
                        Console.WriteLine($"The HEIGHT of the tree is : {bt.Height()}");
                        break;
                    case 9:
                        Console.WriteLine($"The MINIMUM key is : {bt.Min()}");
                        break;
                    case 10:
                        Console.WriteLine($"The MAXIMUM key is : {bt.Max()}");
                        break;
                    default:
                        Console.WriteLine("Invalid selection entered!!!");
                        break;
                }
            }
        }
    }
}
