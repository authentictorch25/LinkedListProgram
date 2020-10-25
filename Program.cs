using System;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding the nodes
            Node newNode = new Node(56);
            newNode.next = new Node(70);
            newNode.next.next = new Node(30);
        }
    }
}
