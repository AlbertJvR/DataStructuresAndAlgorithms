namespace QueueLinkedListProject
{
    public class Node
    {
        public Node next;
        public int info;

        public Node(int item)
        {
            info = item;
            next = null;
        }
    }
}
