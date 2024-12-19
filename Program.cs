using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList ll = new MyLinkedList();

            char c;
            do
            {
                Console.WriteLine("Choose the Option:\n1.Add Elements\n2.Add Element in Front\n3.Search the Node\n4.Display List\n5.Count Nodes\n6.Reverse the List\n7.Delete a Node");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("\nEnter the Data:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        ll.InsertLast(n);
                        break;

                    case 2:
                        Console.WriteLine("\nEnter the Data:");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        ll.InsertInFront(n1);
                        break;

                    case 3:
                        Console.WriteLine("\nEnter the Element to find:");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        if (ll.SearchNode(n2))
                            Console.WriteLine("Data is present!");
                        else
                            Console.WriteLine("Data Not Found!");
                        break;

                    case 4:
                        ll.DisplayList();
                        break;

                    case 5:
                        Console.WriteLine("\nTotal Nodes are: " + ll.CountNode());
                        break;

                    case 6:
                        ll.Reverse();
                        ll.DisplayList();
                        break;

                    case 7:
                        Console.WriteLine("\nEnter the Element to delete:");
                        int n4 = Convert.ToInt32(Console.ReadLine());
                        ll.DeleteNode(n4);
                        Console.WriteLine("After Deleting: ");
                        ll.DisplayList();
                        break;

                    default:
                        Console.WriteLine("Enter the correct option:");
                        break;

                }
                //
                Console.WriteLine("Enter Y/y to do any operation or other key to exit");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y' || c == 'Y');
        }
    }
}
