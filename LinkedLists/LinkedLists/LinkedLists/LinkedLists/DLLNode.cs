namespace LinkedLists
{
    public class DLLNode
    {
        public DLLNode prev;
        public int info;
        public DLLNode next;

        public DLLNode(int i)
        {
            info = i;
            prev = null;
            next = null;
        }
    }
}
