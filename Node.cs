﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
