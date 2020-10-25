using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    class LinkedList
    {
        public Node head;

        
        public void InsertAtFront(Object item)
        {
            //Created the node containing new value
            Node newNode = new Node(item);
            //Adding reference to the head node
            newNode.next = head;
            //Head Note changes to newNode
            head = newNode;
        }
        public void InsertAtLast(Object item)
        {
            Node newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                Node endNode = temp;
                endNode.next = newNode;
            }
           
        }
        public void InsertInBetween(Object item, Object before, Object after)
        {
            Node beforeNode = head;
            Node afterNode = head;
            Node newNode = new Node(item);
            

            while (beforeNode.data != before)
            {
                beforeNode = beforeNode.next;
            }


            while (afterNode.data != after)
            {
                afterNode = afterNode.next;
            }

            if (beforeNode.next != afterNode && afterNode.next != beforeNode)
            {
                Console.WriteLine("The nodes are not consecutive");
            }
            else
            {
                beforeNode.next = newNode;
                newNode.next = afterNode;
            }
        }
        public void RemoveLastNode()
        {
            // If the linked list is empty
            if (head == null)
                Console.WriteLine("The linked list is empty");
            // If the linked list has only one node
            else if (head.next == null)
            {
                head = null;
                Console.WriteLine("Last node removed successfully");
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                //Removong the node
                temp.next = null;
                Console.WriteLine("Last node removed successfully");
            }
        }
        public void Print()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("The linked list is empty");
            }
            else
            {
               
                while (temp != null)
                {
                    Console.Write("|"+temp.data + "|-> ");
                    temp = temp.next;
                }
            }
        }
    }
}
