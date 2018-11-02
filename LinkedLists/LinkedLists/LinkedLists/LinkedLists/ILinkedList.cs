namespace LinkedLists
{
    public interface ILinkedList
    {
        void DisplayList();
        void CountNodes();
        bool Search(int item);
        void CreateList();
        void InsertBack(int item);
        void InsertFront(int item);
        void InsertAtIndex(int item, int index);
        void InsertAfterItem(int insertItem, int afterItem);
        void InsertBeforeItem(int insertItem, int beforeItem);
        bool IsEmpty();
        void DeleteFirstNode();
        void DeleteLastNode();
        void DeleteNode(int item);
        void ReverseList();
        void BubbleSortExData();
        void BubbleSortExLinks();
        void MergeSort();
        bool HasCycle();
        void RemoveCycle();
        void InsertCycle(int x);
    }
}
