using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    class Node
    {
        /// <summary>
        /// The parameters for node class
        /// </summary>
        public Object data;
        public Node next;
        
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
