using System;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding the nodes
            LinkedList list = new LinkedList();
            list.InsertAtFront(90);
            list.InsertAtLast(56);
            list.InsertAtLast(70);
            list.InsertAtLast(80);
             list.InsertInBetween(30, 56, 70);
            list.Print();

        }
    }
}
