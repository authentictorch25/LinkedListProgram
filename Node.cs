using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    class Node
    {
        Object data;
        Node next;
        
        /// <summary>
        /// Constructor for the Node class
        /// </summary>
        /// <param name="data"></param>
        public Node(Object data)
        {
            this.data = data;
            next = null;
        }
    }
}
