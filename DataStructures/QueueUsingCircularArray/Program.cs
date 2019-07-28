using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingCircularArray
{
    class Program
    {
        public static int[] queue = new int[10];

        public static int front = -1;
        public static int rear = -1;

        public static bool isEmpty()
        {
            if (front == -1 && rear == -1)
                return true;
            else
                return false;
        }

        public static void Enqueue(int x)
        {
            if ((rear + 1) % queue.Length == front)
            {
                Console.WriteLine("Queue is full");
                return;
            }

            else if (isEmpty())
            {
                front = 0;
                rear = 0;
            }
            else
            {
                rear = (rear + 1) % queue.Length;
            }
            queue[rear] = x;
        }

        public static void Dequeue()
        {
            if (isEmpty())
                Console.WriteLine("Queue already empty");
            else if (queue.Length == 1)
            {
                rear = -1;
                front = -1;
            }
            else
                front = (front + 1) % queue.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //Circular area can be used to re-use old cells
            //If i is current position and n is size of the array:
            //Next position: (i + 1) % n
            //Prev position: (i + n - 1) % n
            Enqueue(1);
            Enqueue(2);
            Enqueue(3);
            Dequeue();
            Enqueue(4);
            Enqueue(5);
            Enqueue(6);
            Enqueue(7);
            Enqueue(8);
            Enqueue(9);
            Enqueue(10);
            Enqueue(11);
            Enqueue(12);
            Dequeue();
            Dequeue();
            Dequeue(); Dequeue(); Dequeue(); Dequeue();
            Console.WriteLine("Front: " + front + "\tRear: " + rear);
            for (int i = 0; i < queue.Length; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }
}
