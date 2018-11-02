using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class CircularLinkedList : ILinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }

        public void DisplayList()
        {
            if (last == null)
            {
                Console.WriteLine("The list is empty! \n");
                return;
            }

            Node p = last.next;
            do
            {
                Console.Write(p.info + " ");
                p = p.next;
            } while (p != last.next);

            Console.WriteLine();
        }

        public void CountNodes()
        {
            throw new NotImplementedException();
        }

        public bool Search(int item)
        {
            throw new NotImplementedException();
        }

        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0) return;

            Console.Write("Enter the element to be inserted : ");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for (i = 2; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted : ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertBack(data);
            }
        }

        public void InsertBack(int item)
        {
            if (IsEmpty())
            {
                InsertInEmptyList(item);
                return;
            }

            Node temp = new Node(item);
            temp.next = last.next;
            last.next = temp;
            last = temp;
        }

        public void InsertFront(int item)
        {
            if (IsEmpty())
            {
                InsertInEmptyList(item);
                return;
            }

            var newNode = new Node(item);
            newNode.next = last.next;
            last.next = newNode;
        }

        private void InsertInEmptyList(int item)
        {
            var newNode = new Node(item);
            last = newNode;
            last.next = last;
        }

        public void InsertAtIndex(int item, int index)
        {
            throw new NotImplementedException();
        }

        public void InsertAfterItem(int insertItem, int afterItem)
        {
            Node p = last.next;
            do
            {
                if (p.info == afterItem) break;

                p = p.next;
            } while (p != last.next);

            if(p == last.next && p.info != afterItem)
                Console.WriteLine($"{afterItem} is not present in the list!");
            else
            {
                Node temp = new Node(insertItem);
                temp.next = p.next;
                p.next = temp;

                if (p == last) last = temp;
            }
        }

        public void InsertBeforeItem(int insertItem, int beforeItem)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return last == null;
        }

        public void DeleteFirstNode()
        {
            if (last == null) /* List is empty */
                return;

            if (last.next == last) /* List only has one node */
            {
                last = null;
                return;
            }

            last.next = last.next.next;
        }

        public void DeleteLastNode()
        {
            if (last == null) /* List is empty */
                return;

            if (last.next == last) /* List only has one node */
            {
                last = null;
                return;
            }

            Node p = last.next;
            while (p.next != last)
                p = p.next;

            p.next = last.next;
            last = p;
        }

        public void DeleteNode(int item)
        {
            if (last == null) /* List is empty */
                return;

            if (last.next == last && last.info == item) /* Deletion of the only node */
            {
                last = null;
                return;
            }

            if (last.next.info == item) /* Deletion of first node */
            {
                last.next = last.next.next;
                return;
            }

            Node p = last.next;
            while (p.next != last.next)
            {
                if(p.next.info == item) break;

                p = p.next;
            }

            if(p.next == last.next)
                Console.WriteLine($"{item} was not found in the list!");
            else
            {
                p.next = p.next.next;
                if (last.info == item)
                    last = p;
            }
        }

        public void ReverseList()
        {
            throw new NotImplementedException();
        }

        public void BubbleSortExData()
        {
            throw new NotImplementedException();
        }

        public void BubbleSortExLinks()
        {
            throw new NotImplementedException();
        }

        public void MergeSort()
        {
            throw new NotImplementedException();
        }

        public bool HasCycle()
        {
            throw new NotImplementedException();
        }

        public void RemoveCycle()
        {
            throw new NotImplementedException();
        }

        public void InsertCycle(int x)
        {
            throw new NotImplementedException();
        }
    }
}
