using System;

namespace LinkedLists
{
    public class SingleLinkedList : ILinkedList
    {
        private Node _head;

        public SingleLinkedList()
        {
            _head = null;
        }

        public void CountNodes()
        {
            int count = 0;
            Node p = _head;
            while (p != null)
            {
                count++;
                p = p.next;
            }
            Console.WriteLine($"There are {count} node(s) in the list.");
        }

        public void DisplayList()
        {
            Node p;
            if (_head == null)
            {
                Console.WriteLine("List is empty.");
            }

            Console.WriteLine("The List is : ");

            p = _head;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.next;
            }

            Console.WriteLine();
        }

        public bool Search(int item)
        {
            int position = 1;
            Node p = _head;
            while (p != null)
            {
                if (p.info == item) break;

                position++;
                p = p.next;
            }

            if (p == null)
            {
                Console.WriteLine($"Item {item} was not found in the list");
                return false;
            }
           
            Console.WriteLine($"The item {item} was found at position {position}");
            return true;
        }

        public void CreateList()
        {
            Console.WriteLine($"Please enter the number of nodes to be created: ");
            var nodeCount = Convert.ToInt32(Console.ReadLine());

            while (nodeCount > 0)
            {
                Console.WriteLine("Enter an element to be inserted: ");
                var data = Convert.ToInt32(Console.ReadLine());
                InsertBack(data);

                nodeCount--;
            }

            DisplayList();
        }

        public void InsertBack(int item)
        {
            Node newNode = new Node(item);

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            Node p = _head;
            while (p.next != null)
            {
                p = p.next;
            }

            p.next = newNode;
        }

        public void InsertFront(int item)
        {
            if (_head == null)
            {
                _head = new Node(item);
                return;
            }

            var newNode = new Node(item);
            newNode.next = _head;
            _head = newNode;
        }

        public void InsertAtIndex(int item, int index)
        {
            if ((_head == null && index > 1) || index < 1)
            {
                Console.WriteLine("The specified index is out of bounds of array.");
                return;
            }

            var newNode = new Node(item);
            var p = _head;
            var position = 1;

            if (index == 1)
            {
                InsertFront(item);
                return;
            }

            while (p.next != null)
            {
                if (position == index - 1) break;

                position++;
                p = p.next;
            }

            if (index > position && p.next == null)
            {
                Console.WriteLine("The specified index is out of bounds of array.");
            }

            newNode.next = p.next;
            p.next = newNode;
        }

        public void InsertAfterItem(int insertItem, int afterItem)
        {
            Node p = _head;
            while (p != null)
            {
                if (p.info == afterItem) break;
                p = p.next;
            }

            if (p == null)
            {
                Console.WriteLine($"{afterItem} is not present in the list!");
                return;
            }

            var newNode = new Node(insertItem);
            newNode.next = p.next;
            p.next = newNode;
        }

        public void InsertBeforeItem(int insertItem, int beforeItem)
        {
            /* If the list is empty */
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
                return;
            }

            /* x is in the first node, new node is to be inserted before first node */
            if (insertItem == _head.info)
            {
                InsertFront(insertItem);
                return;
            }

            /* Find reference to predecessor of node containing beforeItem */
            Node p = _head;
            while (p.next != null)
            {
                if (p.next.info == beforeItem) break;

                p = p.next;
            }

            if (p.next == null)
            {
                Console.WriteLine($"{beforeItem} is not present in the list.");
                return;
            }

            var newNode = new Node(insertItem);
            newNode.next = p.next;
            p.next = newNode;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public void DeleteFirstNode()
        {
            if (IsEmpty()) return;

            _head = _head.next;
        }

        public void DeleteLastNode()
        {
            if (IsEmpty()) return;

            if (_head.next == null)
            {
                _head = null;
                return;
            }

            Node p = _head;
            while (p.next.next != null) p = p.next;

            p.next = null;
        }

        public void DeleteNode(int item)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty \n");
                return;
            }

            /* Deletion of first node */
            if (_head.info == item)
            {
                DeleteFirstNode();
                return;
            }

            /* Deletion inbetween or at the end of the list */
            Node p = _head;
            while (p.next != null)
            {
                if (p.next.info == item) break;
                p = p.next;
            }

            if (p.next == null)
            {
                Console.WriteLine($"Element {item} is not in the list.");
                return;
            }

            p.next = p.next.next;
        }

        public void ReverseList()
        {
            Node prev = null, p = _head;

            while (p != null)
            {
                var next = p.next;
                p.next = prev;
                prev = p;
                p = next;
            }
            _head = prev;
        }

        public void BubbleSortExData()
        {
            Node end, p, q;

            for (end = null; end != _head.next; end = p)
            {
                for (p = _head; p.next != end; p = p.next)
                {
                    q = p.next;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }

        public void BubbleSortExLinks()
        {
            Node end, r, p, q, temp;

            for (end = null; end != _head.next; end = p)
            {
                for (r = p = _head; p.next != end; r = p, p = p.next)
                {
                    q = p.next;
                    if (p.info > q.info)
                    {
                        p.next = q.next;
                        q.next = p;

                        if (p != _head) r.next = q;
                        else _head = q;

                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }

        /* Ensure that lists are sorted before merging */
        public SingleLinkedList Merge1(SingleLinkedList list)
        {
            var mergeList = new SingleLinkedList();
            mergeList._head = Merge1(_head, list._head);
            return mergeList;
        }

        /* Merges two lists without modifying the original lists */
        private Node Merge1(Node p1, Node p2)
        {
            Node startM;

            if (p1.info <= p2.info)
            {
                startM = new Node(p1.info);
                p1 = p1.next;
            }
            else
            {
                startM = new Node(p2.info);
                p2 = p2.next;
            }

            Node pM = startM;

            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.next = new Node(p1.info);
                    p1 = p1.next;
                }
                else
                {
                    pM.next = new Node(p2.info);
                    p2 = p2.next;
                }
                pM = pM.next;
            }

            /* If the second list has finished adn elements left in first list */
            while (p1 != null)
            {
                pM.next = new Node(p1.info);
                p1 = p1.next;
                pM = pM.next;
            }

            /* If the first list has finished and elements left in the second list */
            while (p2 != null)
            {
                pM.next = new Node(p2.info);
                p2 = p2.next;
                pM = pM.next;
            }
            return startM;
        }

        /* Ensure that lists are sorted before merging */
        public SingleLinkedList Merge2(SingleLinkedList list)
        {
            var mergeList = new SingleLinkedList();
            mergeList._head = Merge2(_head, list._head);
            return mergeList;
        }

        /* Merges two lists by rearranging the links of the original lists */
        private Node Merge2(Node p1, Node p2)
        {
            Node startM;

            if (p1.info <= p2.info)
            {
                startM = p1;
                p1 = p1.next;
            }
            else
            {
                startM = p2;
                p2 = p2.next;
            }

            Node pM = startM;

            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.next = p1;
                    pM = pM.next;
                    p1 = p1.next;
                }
                else
                {
                    pM.next = p2;
                    pM = pM.next;
                    p2 = p2.next;
                }
            }

            pM.next = p1 ?? p2;

            return startM;
        }

        public void MergeSort()
        {
            _head = MergeSortRecursive(_head);
        }

        private Node MergeSortRecursive(Node listHead)
        {
            // if the list is empty or only has one node
            if (listHead == null || listHead.next == null) return listHead;

            //if the list has more than one element
            var head1 = listHead;
            var head2 = DivideList(listHead);
            head1 = MergeSortRecursive(head1);
            head2 = MergeSortRecursive(head2);
            var startM = Merge2(head1, head2);
            return startM;
        }

        private Node DivideList(Node p)
        {
            var q = p.next.next;
            while (q != null && q.next != null)
            {
                p = p.next;
                q = q.next.next;
            }

            var start2 = p.next;
            p.next = null;
            return start2;
        }

        public bool HasCycle()
        {
            return (FindCycle() != null);
        }

        /* Cycle detection using Floyds algorithm (Tortoise and the hare algorithm) */
        private Node FindCycle()
        {
            if (_head == null || _head.next == null) return null;

            Node slowR = _head, fastR = _head;

            while (fastR != null && fastR.next != null)
            {
                slowR = slowR.next;
                fastR = fastR.next.next;

                if (slowR == fastR) return slowR;
            }
            return null;
        }

        public void RemoveCycle()
        {
            Node c = FindCycle();
            if (c == null) return;

            Console.WriteLine($"Node at which the cycle was detected is {c.info}");

            Node p = c, q = c;
            int lenCycle = 0;
            do
            {
                lenCycle++;
                q = q.next;
            } while (p != q);

            Console.WriteLine($"The length of the cycle is {lenCycle}");

            int lenRemList = 0;
            p = _head;
            while (p != q)
            {
                lenRemList++;
                p = p.next;
                q = q.next;
            }

            Console.WriteLine($"The number of nodes not included in the cycle are : {lenRemList}");

            int lengthList = lenCycle + lenRemList;
            Console.WriteLine($"Length of the list is {lengthList}");

            p = _head;
            for (int i = 1; i <= lengthList - 1; i++) p = p.next;

            p.next = null;
        }

        public void InsertCycle(int x)
        {
            if (_head == null) return;

            Node p = _head, px = null, prev = null;

            while (p != null)
            {
                if (p.info == x) px = p;

                prev = p;
                p = p.next;
            }

            if (px != null) prev.next = px;
            else
            {
                Console.WriteLine($"{x} is not present in the list");
            }
        }

        public void Concatenate(SingleLinkedList list)
        {
            if (_head == null)
            {
                _head = list._head;
                return;
            }

            if (list._head == null) return;

            Node p = _head;
            while (p.next != null)
                p = p.next;

            p.next = list._head;
        }
    }
}
