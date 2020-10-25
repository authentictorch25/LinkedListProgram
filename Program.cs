using System;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding the nodes
            LinkedList list = new LinkedList();
            list.InsertAtLast(56);
            list.InsertAtLast(30);
            list.InsertAtLast(70);
            list.Print();

        }
    }
}
