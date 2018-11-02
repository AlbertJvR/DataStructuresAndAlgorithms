using System;

namespace ParenthesisEvaluateStack
{
    public class StackArray<T>
    {
        private T[] stackArray;
        private int top;

        public StackArray()
        {
            stackArray = new T[10];
            top = -1;
        }

        public StackArray(int maxSize)
        {
            stackArray = new T[maxSize];
            top = -1;
        }

        public int Size()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == stackArray.Length - 1;
        }

        public void Push(T x)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack overflow");
                return;
            }

            top += 1;
            stackArray[top] = x;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack Underflow");
            }

            var x = stackArray[top];
            top -= 1;
            return x;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack Underflow");
            }

            return stackArray[top];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty.");
                return;
            }

            Console.WriteLine("The stack is : ");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine($"{stackArray[i]} ");
            }
            Console.WriteLine();
        }
    }
}
