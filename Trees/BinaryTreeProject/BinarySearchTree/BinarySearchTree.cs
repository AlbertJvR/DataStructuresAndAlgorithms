using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public bool IsEmpty() => root == null;

        public void Insert(int x)
        {
            root = Insert(root, x);
        }

        private Node Insert(Node p, int x)
        {
            if(p == null)
                p = new Node(x);
            else if (x < p.info)
                p.lChild = Insert(p.lChild, x);
            else if (x > p.info)
                p.rChild = Insert(p.rChild, x);
            else
                Console.WriteLine($"{x} is already present in tree");

            return p;
        }

        public void InsertIterative(int x)
        {
            var p = root;
            Node par = null;

            while (p != null)
            {
                par = p;
                if (x < p.info)
                    p = p.lChild;
                else if (x > p.info)
                    p = p.rChild;
                else
                {
                    Console.WriteLine($"{x} is already present in the tree");
                    return;
                }
            }

            var temp = new Node(x);

            if (par == null)
                root = temp;
            else if (x < par.info)
                par.lChild = temp;
            else
                par.rChild = temp;
        }

        public bool Search(int x)
        {
            return (Search(root, x) != null);
        }

        private Node Search(Node p, int x)
        {
            if (p == null)
                return null; //Key was not found
            if (x < p.info)
                return Search(p.lChild, x); //Search continues in left subtree
            if (x > p.info)
                return Search(p.rChild, x); //Search continues in right subtree

            return p; //Key was found
        }

        public bool SearchIterative(int x)
        {
            var p = root;
            while (p != null)
            {
                if (x < p.info)
                    p = p.lChild; //Search continues in left subtree
                else if (x > p.info)
                    p = p.rChild; //Search continues in right subtree
                else
                    return true; //Key was found
            }

            return false;
        }

        public void Delete(int x)
        {
            root = Delete(root, x);
        }

        private Node Delete(Node p, int x)
        {
            Node ch, s;

            if (p == null)
            {
                Console.WriteLine($"{x} was not found");
                return p;
            }

            if (x < p.info)
                p.lChild = Delete(p.lChild, x); //Delete from left subtree
            else if (x > p.info)
                p.rChild = Delete(p.rChild, x); //Delete from right subtree
            else
            {
                //Key to be deleted was found
                if (p.lChild != null && p.rChild != null) //CASE: 2 children
                {
                    s = p.rChild;

                    while (s.lChild != null)
                        s = s.lChild;

                    p.info = s.info;
                    p.rChild = Delete(p.rChild, s.info);
                }
                else //CASE: 1 Child or no children
                {
                    if (p.lChild != null) //only left child
                        ch = p.lChild;
                    else //only right child
                        ch = p.rChild;

                    p = ch;
                }
            }

            return p;
        }

        public void DeleteIterative(int x)
        {
            var p = root;
            Node par = null;

            while (p != null)
            {
                if (x == p.info)
                    break;
                if (x < p.info)
                    p = p.lChild;
                else if (x > p.info)
                    p = p.rChild;
            }

            if (p == null)
            {
                Console.WriteLine($"{x} was not found");
                return;
            }

            /*
             * Case C: 2 Children
             * Find inorder successor and its parent
             */

            Node s, ps;

            if (p.lChild != null && p.rChild != null)
            {
                ps = p;
                s = p.rChild;
                while (s.lChild != null)
                {
                    ps = s;
                    s = s.lChild;
                }

                p.info = s.info;
                p = s;
                par = ps;
            }

            /*
             * Case B and Case A : 1 child or no children
             */
            Node ch;
            if (p.lChild != null) //node to be deleted has left child
                ch = p.lChild;
            else //node to be deleted has right child or no child
                ch = p.rChild;

            if (par == null) //node to be deleted is root node
                root = ch;
            else if (p == par.lChild) //node is left child of its parent
                par.lChild = ch;
            else //node is right child of its parent
                par.rChild = ch;

        }

        public int Min()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Tree is empty");

            return Min(root).info;
        }

        private Node Min(Node p)
        {
            if (p.lChild == null)
                return p;

            return Min(p.lChild);
        }

        public int Max()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Tree is empty");

            return Max(root).info;
        }

        private Node Max(Node p)
        {
            if (p.rChild == null)
                return p;

            return Max(p.rChild);
        }

        public int MinIterative()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Tree is empty");

            var p = root;
            while (p.lChild != null)
                p = p.lChild;

            return p.info;
        }

        public int MaxIterative()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Tree is empty");

            var p = root;
            while (p.rChild != null)
                p = p.rChild;

            return p.info;
        }

        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }

        private void Display(Node p, int level)
        {
            if (p == null)
                return;

            Display(p.rChild, level + 1);
            Console.WriteLine();

            for (int i = 0; i < level; i++)
                Console.Write("     ");

            Console.Write(p.info);

            Display(p.lChild, level + 1);
        }

        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine();
        }

        private void PreOrder(Node p)
        {
            if (p == null)
                return;

            Console.Write($"{p.info} ");
            PreOrder(p.lChild);
            PreOrder(p.rChild);
        }

        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }

        private void InOrder(Node p)
        {
            if (p == null)
                return;

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
            if (p == null)
                return;

            PostOrder(p.lChild);
            PostOrder(p.rChild);
            Console.Write($"{p.info} ");
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
    }
}
