using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace DataStructures
{
    internal class DoubleLinkedList
    {
        internal DllNode head;

        public void AddInFront(int data)
        {
            DllNode dll = new DllNode(data);
            dll.next = head;
            dll.prev = null;

            if (head != null)
            {
                head.prev = dll;
            }
            head = dll;
        }

        public void AddInLast(int data)
        {
            DllNode dll = new DllNode(data);
            if (head == null)
            {
                dll.prev = null;
                head = dll;
                return;
            }
            DllNode lastN = GetLastNode();
            lastN.next = dll;
            dll.prev = lastN;

        }

        public DllNode GetLastNode()
        {
            DllNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;

        }
    }
}
