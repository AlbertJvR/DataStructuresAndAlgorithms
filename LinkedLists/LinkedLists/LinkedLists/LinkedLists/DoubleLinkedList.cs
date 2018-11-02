using System;

namespace LinkedLists
{
    public class DoubleLinkedList : ILinkedList
    {
        private DLLNode _head;

        public DoubleLinkedList()
        {
            _head = null;
        }

        public void BubbleSortExData()
        {
            throw new NotImplementedException();
        }

        public void BubbleSortExLinks()
        {
            throw new NotImplementedException();
        }

        public void CountNodes()
        {
            throw new NotImplementedException();
        }

        public void CreateList()
        {
            int i, n, data;

            Console.WriteLine("Please enter the number of nodes you want to create:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0) return;

            Console.Write("Enter the first element to be inserted: ");
            data = Convert.ToInt32(Console.ReadLine());

            InsertIntoEmptyList(data);

            for (i = 2; i <= n; i++)
            {
                Console.Write("Enter the next element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertBack(data);
            }

        }
        
        public void DeleteFirstNode()
        {
            if (_head == null) /* the list is empty */
                return;

            if (_head.next == null) /* the list only contains 1 node */
            {
                _head = null;
                return;
            }

            _head = _head.next;
            _head.prev = null;
        }

        public void DeleteLastNode()
        {
            if (_head == null) /* the list is empty */
                return;

            if (_head.next == null) /* the list only contains 1 node */
            {
                _head = null;
                return;
            }

            DLLNode p = _head;
            while (p.next != null)
                p = p.next;

            p.prev.next = null;
        }

        public void DeleteNode(int item)
        {
            if (_head == null) /* the list is empty */
                return;

            if (_head.next == null) /* the list only contains 1 node */
            {
                if (_head.info == item)
                    _head = null;
                else
                    Console.WriteLine($"{item} was not found in the list!");

                return;
            }

            if (_head.info == item) /* Deletion of the first node */
            {
                _head = _head.next;
                _head.prev = null;
                return;
            }

            DLLNode p = _head.next;
            while (p.next != null)
            {
                if (p.info == item) break;

                p = p.next;
            }

            if (p.next == null)
            {
                if (p.info == item)
                    p.prev.next = null;
                else
                    Console.WriteLine($"{item} was not found in the list!");
            }
            else
            {
                p.prev.next = p.next;
                p.next.prev = p.prev;
            }
        }

        public void DisplayList()
        {
            DLLNode p;
            if (_head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            p = _head;
            Console.Write("The list is : ");
            while (p != null)
            {
                Console.Write($"{p.info} ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public bool HasCycle()
        {
            throw new NotImplementedException();
        }

        public void InsertAfterItem(int insertItem, int afterItem)
        {
            var temp = new DLLNode(insertItem);

            DLLNode p = _head;
            while (p != null)
            {
                if (p.info == afterItem) break;

                p = p.next;
            }

            if(p == null)
                Console.WriteLine($"{afterItem} is not present in the list!");
            else
            {
                temp.prev = p;
                temp.next = p.next;

                if(p.next != null)
                    p.next.prev = temp; // conditional exists to check for last node special case

                p.next = temp;
            }
        }

        public void InsertAtIndex(int item, int index)
        {
            throw new NotImplementedException();
        }

        public void InsertBack(int item)
        {
            var temp = new DLLNode(item);
            DLLNode p = _head;
            while (p.next != null) p = p.next;

            p.next = temp;
            temp.prev = p;
        }

        public void InsertBeforeItem(int insertItem, int beforeItem)
        {
            if (_head == null)
            {
                Console.WriteLine("The list is empty!");
                return;
            }

            if (_head.info == beforeItem)
            {
                var temp = new DLLNode(insertItem);
                temp.next = _head;
                _head.prev = temp;
                _head = temp;
                return;
            }

            DLLNode p = _head;
            while (p != null)
            {
                if (p.info == beforeItem) break;

                p = p.next;
            }

            if(p == null)
                Console.WriteLine($"{beforeItem} is not present in the list!");
            else
            {
                DLLNode temp = new DLLNode(insertItem);
                temp.prev = p.prev;
                temp.next = p;
                p.prev.next = temp;
                p.prev = temp;
            }
        }

        public void InsertCycle(int x)
        {
            throw new NotImplementedException();
        }

        public void InsertFront(int item)
        {
            var newNode = new DLLNode(item);
            newNode.next = _head;
            _head.prev = newNode;
            _head = newNode;
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public void MergeSort()
        {
            throw new NotImplementedException();
        }

        public void RemoveCycle()
        {
            throw new NotImplementedException();
        }

        public void ReverseList()
        {
            if (_head == null) return;

            DLLNode p1 = _head;
            DLLNode p2 = p1.next;

            p1.next = null;
            p1.prev = p2;

            while (p2 != null)
            {
                p2.prev = p2.next;
                p2.next = p1;
                p1 = p2;
                p2 = p2.prev;
            }
            _head = p1;
        }

        public bool Search(int item)
        {
            throw new NotImplementedException();
        }

        private void InsertIntoEmptyList(int item)
        {
            _head = new DLLNode(item);
        }
    }
}
