using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    class Program
    {
        public class Node
        {
            internal int data;
            internal Node next;


            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public static Node top;

        public class LinkedList
        {
           
            public void printAllNodes()
            {
                Node current = top;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }

        public static void Push(int d)
        {
            Node firstElement = new Node(d);
            firstElement.next = top;
            top = firstElement;
        }

        public static void Pop()
        {
            if (top == null)
                return;
            top = top.next;
        }

        static void Main(string[] args)
            {
            Node new_node = new Node(1);
            Node second_node = new Node(2);
            Node third_node = new Node(3);

            new_node.next = second_node;
            second_node.next = third_node;

            LinkedList list = new LinkedList();
            top = new_node;
            //list.printAllNodes();

            Push(4);
            Push(5);
            Push(6);
            Push(7);
            Pop();
            list.printAllNodes();
        }
        
    }
}
