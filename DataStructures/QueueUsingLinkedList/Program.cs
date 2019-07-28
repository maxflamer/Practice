using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkedList
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

        public static Node front;
        public static Node rear;


        public static void Enqueue(int x)
        {
            Node new_node = new Node(x);
            if (front == null && rear == null)
            {
                front = new_node;
                rear = new_node;
                return;
            }
            rear.next = new_node;
            rear = new_node;
        }

        public static void Dequeue()
        {
            if (front == null)
                Console.WriteLine("Queue already empty");
            else if (front == rear)
            {
                front = null;
                rear = null;
            }
            else
            {
                front = front.next;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Enqueue(1);
            Enqueue(2);
            Enqueue(3);
            Enqueue(4);
            Dequeue();
            Dequeue();
            Enqueue(5);

            Console.WriteLine("Front: " + front.data + "\tRear: " + rear.data);
            Node current = front;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
