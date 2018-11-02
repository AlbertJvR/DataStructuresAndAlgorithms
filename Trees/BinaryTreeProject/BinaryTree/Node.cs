namespace BinaryTree
{
    public class Node
    {
        public Node lChild;
        public char info;
        public Node rChild;

        public Node(char ch)
        {
            info = ch;
            lChild = null;
            rChild = null;
        }
    }
}
