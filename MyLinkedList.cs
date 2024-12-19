using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal class MyLinkedList
    {
        internal Node head;

        public bool SearchNode(int data)
        {
            Node temp = head;
            while(temp!= null)
            {
                if(temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public void DisplayList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "=>");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }

        public int CountNode()
        {
            int count = 0;
            Node temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        public void Reverse()
        {
            Node prev = null;
            Node curr = head;
            Node next = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }

        public void DeleteNode(int data)
        {
            Node temp = head;
            if(head == null)
            {
                return;
            }
            if(head.data == data)
            {
                head = head.next;
                return;
            }
            
            while(temp.next != null && temp.next.data != data)
            {
                temp = temp.next;
            }
            if(temp.next != null)
            {
                temp.next = temp.next.next;
            }
        }
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
