using System;

namespace PriorityQueue
{
    public class PriorityQueue
    {
        private Node front;

        public PriorityQueue()
        {
            front = null;
        }

        public void Insert(int element, int elementPriority)
        {
            Node temp, p;

            temp = new Node(element, elementPriority);

            // Queue is empty or element to be added has priority more than first element
            if (IsEmpty() || elementPriority < front.priority)
            {
                temp.next = front;
                front = temp;
            }
            else
            {
                p = front;
                while (p.next != null && p.next.priority <= elementPriority)
                {
                    p = p.next;
                }

                temp.next = p.next;
                p.next = temp;
            }
        }

        public int Delete()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Queue Underflow");

            int element = front.info;
            front = front.next;

            return element;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void Display()
        {
            Node p = front;
            if (IsEmpty())
            {
                Console.WriteLine("The Queue is empty \n");
                return;
            }

            Console.WriteLine("The queue is : ");
            Console.WriteLine("Element      Priority");

            while (p != null) 
            {
                Console.WriteLine($"{p.info}                {p.priority}");
                p = p.next;
            }

            Console.WriteLine();
        }
    }
}
