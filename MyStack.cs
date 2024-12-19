using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal class MyStack
    {
        public int count { get; private set; }
        private int[] stack;

        public MyStack(int size)
        {
            stack = new int[size];
            count = 0;
        }

        public void Push(int n)
        {
            if(count == stack.Length)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                stack[count++] = n;
            }
        }

        public int Pop()
        {
            int res = -1;
            if (count == 0)
            {
                Console.WriteLine("Stack is Empty!");
            }
            else
            {
                res = stack[--count];
            }
            return res;
        }

        public void Display()
        {
            if(count == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Stack:");
                for (int i = count - 1; i >= 0; i--)
                    Console.WriteLine(stack[i]);

            }
        }
    }
}
