using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }

        /**
         * Displays the binary tree from left to right
         */
        private void Display(Node p, int level)
        {
            if (p == null) return;

            Display(p.rChild, level + 1);
            Console.WriteLine();

            for (int i = 0; i < level; i++)
                Console.Write("     ");
            Console.Write(p.info);

            Display(p.lChild, level + 1);
        }

        public void Preorder()
        {
            Preorder(root);
            Console.WriteLine();
        }

        private void Preorder(Node p)
        {
            if (p == null) return;

            Console.Write($"{p.info} ");
            Preorder(p.lChild);
            Preorder(p.rChild);
        }

        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }

        private void InOrder(Node p)
        {
            if (p == null) return;

            InOrder(p.lChild);
            Console.Write($"{p.info} ");
            InOrder(p.rChild);
        }

        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }

        private void PostOrder(Node p)
        {
            if (p == null) return;

            PostOrder(p.lChild);
            PostOrder(p.rChild);
            Console.Write($"{p.info} ");
        }

        public void LevelOrder()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
                return;
            }

            var q = new Queue<Node>();
            q.Enqueue(root);

            Node p;
            while (q.Count != 0)
            {
                p = q.Dequeue();
                Console.Write($"{p.info} ");

                if(p.lChild != null)
                    q.Enqueue(p.lChild);

                if(p.rChild != null)
                    q.Enqueue(p.rChild);
            }

            Console.WriteLine();
        }

        public int Height()
        {
            return Height(root);
        }

        private int Height(Node p)
        {
            if (p == null)
                return 0;

            int heightLeft = Height(p.lChild);
            int heightRight = Height(p.rChild);

            if (heightLeft > heightRight)
                return 1 + heightLeft;
            else
                return 1 + heightRight;
        }

        public void CreateTree()
        {
            root = new Node('P');
            root.lChild = new Node('Q');
            root.rChild = new Node('R');
            root.lChild.lChild = new Node('A');
            root.lChild.rChild = new Node('B');
            root.rChild.lChild = new Node('X');
        }
    }
}
