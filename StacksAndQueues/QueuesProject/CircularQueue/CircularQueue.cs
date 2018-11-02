using System;

namespace CircularQueue
{
    public class CircularQueue
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public CircularQueue()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public CircularQueue(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }

        public void Enqueue(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue overflow");
                return;
            }

            if (front == -1)
                front = 0;

            if (rear == queueArray.Length - 1)
                rear = 0;
            else
                rear = rear + 1;

            queueArray[rear] = x;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue Underflow");

            var x = queueArray[front];

            if (front == rear) // Case where queue only has one element
            {
                front = -1;
                rear = -1;
            }
            else if (front == queueArray.Length - 1)
                front = 0;
            else
                front += 1;

            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue Underflow");

            return queueArray[front];
        }

        public bool IsEmpty()
        {
            return front == -1;
        }

        public bool IsFull() => front == 0 && rear == queueArray.Length - 1 || (front == rear + 1);

        public int Size()
        {
            if (IsEmpty())
                return 0;

            if (IsFull())
                return queueArray.Length;

            int i = front;
            int sz = 0;

            if (front <= rear)
            {
                while (i <= rear)
                {
                    sz++;
                    i++;
                }
            }
            else
            {
                while (i <= queueArray.Length - 1)
                {
                    sz++;
                    i++;
                }

                i = 0;

                while (i <= rear)
                {
                    sz++;
                    i++;
                }
            }

            return sz;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty! \n");
                return;
            }

            Console.WriteLine("Queue is : \n\n");

            int i = front;
            if (front <= rear)
            {
                while(i <= rear)
                    Console.Write($"{queueArray[i]} ");
            }
            else
            {
                while (i <= queueArray.Length - 1)
                    Console.Write($"{queueArray[i]} ");

                i = 0;

                while (i <= rear)
                    Console.Write($"{queueArray[i]} ");
            }

            Console.WriteLine();
        }
    }
}
