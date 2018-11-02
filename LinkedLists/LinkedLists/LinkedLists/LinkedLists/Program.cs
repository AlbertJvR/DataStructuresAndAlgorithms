using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int data, k, x;

            // var list = new SingleLinkedList();
            var list = new DoubleLinkedList();
            list.CreateList();

            while (true)
            {
                Console.WriteLine("Select an option from the following:");

                Console.WriteLine("1. Display list.");
                Console.WriteLine("2. Count the number of nodes.");
                Console.WriteLine("3. Search for an element.");
                Console.WriteLine("4. Insert in empty list/Insert in beginning of the list.");
                Console.WriteLine("5. Insert a node at the end of the list.");
                Console.WriteLine("6. Insert a node after a specified node.");
                Console.WriteLine("7. Insert a node before a specified node.");
                Console.WriteLine("8. Insert node at given position.");
                Console.WriteLine("9. Delete first node.");
                Console.WriteLine("10. Delete last node.");
                Console.WriteLine("11. Delete node with value.");
                Console.WriteLine("12. Reverse the list.");
                Console.WriteLine("13. Bubble sort by exchanging data.");
                Console.WriteLine("14. Bubble sort by exchanging links.");
                Console.WriteLine("15. MergeSort.");
                Console.WriteLine("16. Insert Cycle.");
                Console.WriteLine("17. Detect Cycle.");
                Console.WriteLine("18. Remove Cycle.");
                Console.WriteLine("19. Demo merging of lists.");

                Console.WriteLine("999. Exit");

                var option = Convert.ToInt32(Console.ReadLine());

                if (option == 999) break;

                switch (option)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.WriteLine("Please enter an int to be searched");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;
                    case 4:
                        Console.WriteLine("Please enter an int to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertFront(data);
                        break;
                    case 5:
                        Console.WriteLine("Please enter an int to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertBack(data);
                        break;
                    case 6:
                        Console.WriteLine("Please enter an int to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter item for insertion after");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfterItem(data, k);
                        break;
                    case 7:
                        Console.WriteLine("Please enter an int to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter item for insertion before");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertBeforeItem(data, k);
                        break;
                    case 8:
                        Console.WriteLine("Please enter an int to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter index for insertion");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtIndex(data, k);
                        break;
                    case 9:
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        list.DeleteLastNode();
                        break;
                    case 11:
                        Console.WriteLine("Please enter an int of item to be nuked");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 12:
                        list.ReverseList();
                        break;
                    case 13:
                        list.BubbleSortExData();
                        break;
                    case 14:
                        list.BubbleSortExLinks();
                        break;
                    case 15:
                        list.MergeSort();
                        break;
                    case 16:
                        Console.WriteLine("Please enter an int of item to target for cycle");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertCycle(data);
                        break;
                    case 17:
                        Console.WriteLine($"Cycle detected: {list.HasCycle()}");
                        break;
                    case 18:
                        list.RemoveCycle();
                        break;
                    case 19:
                        var demo = new Demo();
                        demo.Execute();
                        break;

                }
            }
        }
    }
}
