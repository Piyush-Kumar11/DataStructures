using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal class DllNode
    {
        internal int data;
        internal DllNode prev;
        internal DllNode next;

        public DllNode(int data)
        {
            this.data = data;
            prev = null;
            next = null;
        }
    }
}
