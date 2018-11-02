using System;

namespace Heap
{
    public class Heap
    {
        private int[] a;
        private int n;

        public Heap()
        {
            a = new int[10];
            n = 0;
            a[0] = 99999;
        }

        public Heap(int maxSize)
        {
            a = new int[maxSize];
            n = 0;
            a[0] = 99999;
        }

        public void Insert(int value)
        {
            n++;
            a[n] = value;
            RestoreUp(n);
        }

        private void RestoreUp(int i)
        {
            int k = a[i];
            int iParent = i / 2;

            /*
             * If no sentinel value present -> while(iParent >= 1 && a[iParent] < k)
             */
            while (a[iParent] < k)
            {
                a[i] = a[iParent];
                i = iParent;
                iParent = i / 2;
            }

            a[i] = k;
        }

        public int DeleteRoot()
        {
            if(n == 0)
                throw new InvalidOperationException("Heap is empty");

            int maxValue = a[1];
            a[1] = a[n];
            n--;
            RestoreDown(1);

            return maxValue;
        }

        private void RestoreDown(int i)
        {
            int k = a[i];
            int lChild = 2 * i, rChild = lChild + 1;

            while (rChild <= n)
            {
                if (k >= a[lChild] && k >= a[rChild])
                {
                    a[i] = k;
                    return;
                }
                else if (a[lChild] > a[rChild])
                {
                    a[i] = a[lChild];
                    i = lChild;
                }
                else
                {
                    a[i] = a[rChild];
                    i = rChild;
                }

                lChild = 2 * i;
                rChild = lChild + 1;
            }

            /*
             * If the number of nodes in the heap is even
             */
            if (lChild == n && k < a[lChild])
            {
                a[i] = a[lChild];
                i = lChild;
            }

            a[i] = k;
        }

        public void Display()
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{a[i]} ");
            }

            Console.WriteLine();
        }
    }
}
