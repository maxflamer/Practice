using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        internal class DNode
        {
            internal int data;
            internal DNode prev;
            internal DNode next;

            public DNode(int d)
            {
                data = d;
                prev = null;
                next = null;
            }
        }

        internal class DLinkedList
        {
            internal DNode head;

            public void printAllNodes()
            {
                DNode current = head;

                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }

            public void AddFirst(int d)
            {
                DNode firstElement = new DNode(d);
                firstElement.next = head;
                if (head != null)
                    head.prev = firstElement;

                head = firstElement;
            }

            public void AddLast(int d)
            {
                DNode current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                DNode lastElement = new DNode(d);
                lastElement.prev = current;
                current.next = lastElement;
            }

            public void RemoveFirst()
            {
                head = head.next;
            }

            public void RemoveLast()
            {
                if (head != null)
                {
                    if (head.next == null)
                        head = null;
                    else
                    {
                        DNode current = head;

                        while (current.next != null)
                        {
                            current = current.next;
                        }
                        DNode lastElement = current.prev;
                        lastElement.next = null;
                    }
                }
            }

            public void InsertAt(DNode previousNode, int data)
            {
                DNode current = head;
                while (current != previousNode)
                {
                    current = current.next;
                }
                DNode new_node = new DNode(data);
                new_node.prev = current;
                DNode next_node = current.next;
                new_node.next = next_node;
                if (next_node != null)
                    next_node.prev = new_node;
                current.next = new_node;
            }
        }

        static void Main(string[] args)
        {
            DNode new_dnode = new DNode(1);
            DNode second_dnode = new DNode(2);
            DNode third_dnode = new DNode(3);

            new_dnode.next = second_dnode;
            second_dnode.prev = new_dnode;
            second_dnode.next = third_dnode;
            third_dnode.prev = second_dnode;

            DLinkedList list = new DLinkedList();
            list.head = new_dnode;
            //list.AddFirst(4);
            //list.AddLast(4);
            //list.RemoveFirst();
            //list.RemoveLast();
            list.InsertAt(third_dnode, 5);
            list.printAllNodes();
        }
    }
}
