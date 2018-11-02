using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArrayProject
{
    /*
     * This is this womans shitty implementation with which I dont fully agree. This queue can only process
     * a finite amount of items before it has to be reset as it becomes useless. Why not move the items along
     * the array instead of these two dodgey array indexes?
     */
    public class QueueArray
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public QueueArray()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public QueueArray(int maxSize)
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

            if (front == -1) front = 0;

            rear += 1;
            queueArray[rear] = x;
        }

        public int Dequeue()
        {
            int x;

            if(IsEmpty())
                throw new InvalidOperationException("Queue Underflow");

            x = queueArray[front];
            front += 1;
            return x;
        }

        public int Peek()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Queue Underflow");

            return queueArray[front];
        }

        public bool IsEmpty()
        {
            return front == -1 || front == rear + 1;
        }

        public bool IsFull()
        {
            return rear == queueArray.Length - 1;
        }

        public int Size()
        {
            if (IsEmpty()) return 0;

            return rear - front + 1;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty! \n");
                return;
            }

            Console.WriteLine("Queue is : \n\n");
            for (int i = front; i <= rear; i++)
            {
                Console.Write($"{queueArray[i]} ");
            }

            Console.WriteLine();
        }
    }
}
