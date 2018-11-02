namespace BinarySearchTree
{
    public class Node
    {
        public Node lChild;
        public int info;
        public Node rChild;

        public Node(int ch)
        {
            info = ch;
            lChild = null;
            rChild = null;
        }
    }
}
