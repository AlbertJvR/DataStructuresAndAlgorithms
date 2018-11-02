namespace PriorityQueue
{
    public class Node
    {
        public int priority;
        public int info;
        public Node next;

        public Node(int i, int pr)
        {
            info = i;
            priority = pr;
            next = null;
        }
    }
}
