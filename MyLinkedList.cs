using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal class MyLinkedList
    {
        internal Node head;

        public void InsertInFront(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            node.next = head;
            head = node;
        }

        public void InsertLast(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node last = GetLastNode();
                last.next = node;
            }
        }

        public Node GetLastNode()
        {
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
