using System;

namespace QueueLinkedListProject
{
    public class QueueLinkedList
    {
        private Node front;
        private Node rear;

        public QueueLinkedList()
        {
            front = null;
            rear = null;
        }

        public int Size()
        {
            int size = 0;
            Node p = front;
            while (p != null)
            {
                size++;
                p = p.next;
            }

            return size;
        }

        public void Enqueue(int x)
        {
            var temp = new Node(x);

            // If the queue is empty
            if (front == null)
                front = temp;
            else
                rear.next = temp;

            rear = temp;
        }

        public int Dequeue()
        {
            int x;
            if(IsEmpty())
                throw new InvalidOperationException("Stack Underflow");

            x = front.info;
            front = front.next;

            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack Underflow");

            return front.info;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty");
                return;
            }

            Node p = front;
            Console.WriteLine("The queue is : ");
            while (p != null)
            {
                Console.Write($"{p.info} ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
