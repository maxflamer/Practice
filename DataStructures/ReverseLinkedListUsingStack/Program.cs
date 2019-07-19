using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedListUsingStack
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

        public class LinkedList
        {
            public Node head;
            public void printAllNodes()
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Node new_node = new Node(1);
            Node second_node = new Node(2);
            Node third_node = new Node(3);

            new_node.next = second_node;
            second_node.next = third_node;

            LinkedList list = new LinkedList();
            list.head = new_node;
            //list.printAllNodes();

            Stack<Node> S = new Stack<Node>();
            Node current = list.head;
            while (current.next != null)
            {
                S.Push(current);
                current = current.next;
            }

            Console.WriteLine("Count of stack " + S.Count);

            list.head = current;

            while (S.Count != 0)
            {
                current.next = S.Peek();
                current = current.next;
                S.Pop();
            }

            current.next = null;

            list.printAllNodes();
        }
    }
}
