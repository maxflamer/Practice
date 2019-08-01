using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        public class BSTNode
        {
            internal int data;
            internal BSTNode left;
            internal BSTNode right;

            public BSTNode(int d)
            {
                data = d;
                left = null;
                right = null;
            }
        }

        public static BSTNode root = null;

        public static void Insert(int data)
        {
            if (root == null)
                root = new BSTNode(data);
            else
            {
                BSTNode new_node = new BSTNode(data);
                BSTNode current = root;
                BSTNode parent = null;
                while (true)
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = new_node;
                            break;
                        }
                        else
                            parent = current;
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = new_node;
                            break;
                        }
                        else
                            parent = current;
                    }
                }
            }
        }

        public static bool SearchUsingRecursion(BSTNode node, int data)
        {
            if (node == null)
                return false;
            else if (node.data == data)
                return true;
            else if (node.data > data)
                return SearchUsingRecursion(node.left, data);
            else
                return SearchUsingRecursion(node.right, data);
        }

        public static BSTNode FindMinUsingIteration(BSTNode node)
        {
            if (node == null)
            {
                Console.WriteLine("Tree empty");
                return new BSTNode(-1);
            }

            else
            {
                BSTNode current = node;
                while (current.left != null)
                {
                    current = current.left;
                }
                return current;
            }
        }

        public static BSTNode FindMaxUsingIteration(BSTNode node)
        {
            if (node == null)
            {
                Console.WriteLine("Tree empty");
                return new BSTNode(-1);
            }
            else
            {
                BSTNode current = node;
                while (current.right != null)
                {
                    current = current.right;
                }
                return current;
            }
        }

        public static BSTNode FindMinUsingRecursion(BSTNode node)
        {
            if (node == null)
            {
                Console.WriteLine("Tree empty");
                return new BSTNode(-1);
            }
            else if (node.left == null)
                return node;

            return FindMinUsingRecursion(node.left);
        }

        public static BSTNode FindMaxUsingRecursion(BSTNode node)
        {
            if (node == null)
            {
                Console.WriteLine("Tree empty");
            }
            else if (node.right == null)
                return node;

            return FindMaxUsingRecursion(node.right);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Insert(5);
            Insert(3);
            Insert(8);
            Insert(2);
            Insert(4);
            Insert(6);
            Insert(7);
            Insert(9);

            bool present = SearchUsingRecursion(root, 9);
            Console.WriteLine("Element found: " + present);

            BSTNode minUsingIteration = FindMinUsingIteration(root);
            BSTNode maxUsingIteration = FindMaxUsingIteration(root);

            BSTNode minUsingRecursion = FindMinUsingRecursion(root);
            BSTNode maxUsingRecursion = FindMaxUsingRecursion(root);
        }
    }
}
