using System;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            sortedLinkedList.AddElementsInSortedOrder(56);
            sortedLinkedList.AddElementsInSortedOrder(30);
            sortedLinkedList.AddElementsInSortedOrder(40);
            sortedLinkedList.AddElementsInSortedOrder(70);
            sortedLinkedList.AddElementsInSortedOrder(100);
            sortedLinkedList.AddElementsInSortedOrder(50);
            sortedLinkedList.AddElementsInSortedOrder(10);
            sortedLinkedList.Display();
            Console.ReadKey();

        }
    }
}
