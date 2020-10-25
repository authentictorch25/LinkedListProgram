using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    public class LinkedList
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
        public Object InsertInBetween(object item, object before, object after)
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
                return 0;
            }
            else
            {
                beforeNode.next = newNode;
                newNode.next = afterNode;
                return item;
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
        public void RemoveFirstNode()
        {
            if (head == null)
                Console.WriteLine("The linked list is empty");
            else
            {
                head = head.next;
                Console.WriteLine("First node removed successfully");
            }
        }
        public int SearchNode(Object data)
        {
            int count = 0;
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == data)
                    count++;
                temp = temp.next;
            }
            if (count == 0)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine($"Element {data} is present and its count = {count}");
            return count;
        }
        /// <summary>
        /// UC 9 : Removes the node at which the entered data is present.
        /// </summary>
        /// <param name="data">The data.</param>
        public void RemoveNode(Object data)
        {
            Node temp = this.head;
            if (head == null)
                Console.WriteLine("The linked list is empty");
            /// Checks if the linked list has only one node
            else if (this.head.data == data)
            {
                this.head = null;
                Console.WriteLine("Node removed successfully");
            }
            else
            {
                /// Finding the node at which the data is present
                while (temp.next.data != data)
                {
                    temp = temp.next;
                }
                Console.WriteLine("Node removed successfuly");
                temp.next = temp.next.next;
            }
            Console.WriteLine("Size of the linked list = " + GetSize());
        }

        /// <summary>
        /// Gets the size of the linked list.
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
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
