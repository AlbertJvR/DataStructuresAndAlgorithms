using System;

namespace QueueCircularLinkedListProject
{
    public class QueueCLL
    {
        private Node rear;

        public QueueCLL()
        {
            rear = null;
        }

        public bool IsEmpty()
        {
            return rear == null;
        }

        public void Enqueue(int x)
        {
            var temp = new Node(x);
            if (IsEmpty())
            {
                rear = temp;
                rear.next = rear;
            }
            else
            {
                temp.next = rear.next;
                rear.next = temp;
                rear = temp;
            }
        }

        public int Dequeue()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Stack Underflow");

            Node temp;
            if (rear.next == rear) // Case where there is only one element
            {
                temp = rear;
                rear = null;
            }
            else
            {
                temp = rear.next;
                rear.next = temp.next;
            }
            return temp.info;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack Underflow");

            return rear.next.info;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node p = rear.next;
            Console.Write("The Queue is : ");

            do
            {
                Console.Write($"{p.info} ");
                p = p.next;
            } while (p != null);

            Console.WriteLine();
        }

        public int Size()
        {
            if (IsEmpty()) return 0;

            int s = 0;
            Node p = rear.next;

            do
            {
                s++;
                p = p.next;
            } while (p != null);

            return s;
        }
    }
}
