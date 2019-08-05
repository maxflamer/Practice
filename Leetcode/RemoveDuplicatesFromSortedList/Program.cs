using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedList
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        static void Main(string[] args)
        {
            ListNode one = new ListNode(1);
            ListNode two = new ListNode(1);
            ListNode three = new ListNode(1);
            ListNode four = new ListNode(2);
            ListNode five = new ListNode(2);
            ListNode six = new ListNode(3);
            ListNode seven = new ListNode(3);
            ListNode eight = new ListNode(3);
            ListNode nine = new ListNode(3);
            ListNode ten = new ListNode(4);
            ListNode eleven = new ListNode(4);
            ListNode twelve = new ListNode(4);
            ListNode thirteen = new ListNode(4);

            ListNode head = one;
            one.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
            five.next = six;
            six.next = seven;
            seven.next = eight;
            eight.next = nine;
            nine.next = ten;
            ten.next = eleven;
            eleven.next = twelve;

            if (head == null)
            {
                Console.WriteLine("Null");
            }
            else
            {
                ListNode current = head;
                ListNode next = head;
                while (current.next != null)
                {
                    if (current.val != current.next.val)
                    {
                        next.next = current.next;
                        next = next.next;
                    }
                    current = current.next;
                }
                ListNode temp = head;
                while (temp.next != null)
                {
                    if (temp.val == temp.next.val)
                    {
                        temp.next = null;
                        break;
                    }
                    temp = temp.next;
                }
                ListNode sorted = head;
                while (sorted != null)
                {
                    Console.WriteLine(sorted.val);
                    sorted = sorted.next;
                }
            }
        }
    }
}
