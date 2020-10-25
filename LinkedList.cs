﻿using System;
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