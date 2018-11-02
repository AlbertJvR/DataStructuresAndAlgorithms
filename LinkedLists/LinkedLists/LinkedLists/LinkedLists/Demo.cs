using System;

namespace LinkedLists
{
    public class Demo
    {
        public void Execute()
        {
            var list1 = new SingleLinkedList();
            var list2  = new SingleLinkedList();
            
            list1.CreateList();
            list2.CreateList();

            list1.BubbleSortExData();
            list2.BubbleSortExData();

            Console.WriteLine("First list - "); list1.DisplayList();
            Console.WriteLine("Second list - "); list2.DisplayList();

            var list3 = list1.Merge1(list2);
            Console.WriteLine("Merged list - "); list3.DisplayList();

            Console.WriteLine("First list - "); list1.DisplayList();
            Console.WriteLine("Second list - "); list2.DisplayList();

            list3 = list1.Merge2(list2);
            Console.WriteLine("Merged list - "); list3.DisplayList();

            Console.WriteLine("First list - "); list1.DisplayList();
            Console.WriteLine("Second list - "); list2.DisplayList();
        }
    }
}
