using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var bt  = new BinaryTree();

            bt.CreateTree();

            bt.Display();
            Console.WriteLine();

            Console.WriteLine("PreOrder : ");
            bt.Preorder();
            Console.WriteLine();

            Console.WriteLine("InOrder : ");
            bt.InOrder();
            Console.WriteLine();

            Console.WriteLine("PostOrder : ");
            bt.PostOrder();
            Console.WriteLine();

            Console.WriteLine("Level Order : ");
            bt.LevelOrder();
            Console.WriteLine();

            Console.WriteLine($"The height of the tree is {bt.Height()}");

            Console.ReadLine();
        }
    }
}
