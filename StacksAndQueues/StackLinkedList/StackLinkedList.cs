using System;

namespace StackLinkedList
{
    public class StackLinkedList
    {
        private Node top;

        public StackLinkedList()
        {
            top = null;
        }

        public int Size()
        {
            int s = 0;
            Node p = top;
            while (p != null)
            {
                p = p.next;
                s++;
            }

            return s;
        }

        public void Push(int item)
        {
            Node temp = new Node(item);
            temp.next = top;
            top = temp;
        }

        public int Pop()
        {
            int x;
            if(IsEmpty())
                throw new InvalidOperationException("Stack Underflow");

            x = top.info;
            top = top.next;

            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack Underflow");

            return top.info;
        }

        public void Display()
        {
            Node p = top;
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty!");
                return;
            }

            Console.WriteLine("The stack is : ");
            while (p != null) 
            {
                Console.WriteLine($"{p.info} ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
