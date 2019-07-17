using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
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

        internal class LinkedList
        {
            internal Node head;

            public void printAllNodes()
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }

            public void AddFirst(int d)
            {
                if (head == null)
                    head = new Node(d);
                else
                {
                    Node firstElement = new Node(d);
                    firstElement.data = d;
                    firstElement.next = head;
                    head = firstElement;
                }
            }

            public void AddLast(int d)
            {
                if (head == null)
                {
                    head = new Node(d);
                }
                else
                {
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    Node lastNode = new Node(d);
                    current.next = lastNode;
                }
            }

            public void removeFirst()
            {
                head = head.next;
            }

            public void removeLast()
            {
                if (head != null)
                {
                    if (head.next == null)
                        head = null;
                    else
                    {

                    }
                }
            }

            public void Reverse()
            {
                Node prev = null;
                Node current = head;
                Node temp = null;

                while (current != null)
                {
                    temp = current.next;
                    current.next = prev;
                    prev = current;
                    current = temp;
                }
                head = prev;
            }

            public void InsertAt(Node previousNode, int data)
            {
                if (previousNode == null)
                    Console.WriteLine("Can't be null");

                else
                {
                    Node newNode = new Node(data);
                    newNode.next = previousNode.next;
                    previousNode.next = newNode;
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

            /*Console.WriteLine("Node 1 data " + new_node.data);
            Console.WriteLine("Node 1 next " + new_node.next.ToString());
            Console.WriteLine("Node 2 data " + second_node.data);
            Console.WriteLine("Node 2 next " + second_node.next);
            Console.WriteLine("Node 3 data " + third_node.data);
            Console.WriteLine("Node 3 next " + third_node.next);*/

            LinkedList list = new LinkedList();
            list.head = new_node;
            //list.printAllNodes();
            //list.AddFirst(4);
            //list.AddLast(4);
            //list.removeFirst();
            //list.Reverse();
            //list.InsertAt(second_node, 4);
            //list.printAllNodes();
            list.printAllNodes();
        }
    }
}
