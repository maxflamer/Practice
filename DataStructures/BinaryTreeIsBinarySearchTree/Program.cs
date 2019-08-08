using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeIsBinarySearchTree
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

        public static bool IsSubTreeLesser(BSTNode node, int value)
        {
            if (node == null)
                return true;
            if (node.data < value && IsSubTreeLesser(node.left, value) && IsSubTreeLesser(node.right, value))
                return true;
            else
                return false;
        }

        public static bool IsSubTreeGreater(BSTNode node, int value)
        {
            if (node == null)
                return true;
            if (node.data > value && IsSubTreeGreater(node.left, value) && IsSubTreeGreater(node.right, value))
                return true;
            else
                return false;
        }

        public static bool IsBinarySearchTree(BSTNode node)
        {
            if (node == null)
                return true;
            if (IsSubTreeLesser(node.left, node.data) && IsSubTreeGreater(node.right, node.data) && IsBinarySearchTree(node.left) && IsBinarySearchTree(node.right))
                return true;
            else
                return false;
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

            Console.WriteLine(IsBinarySearchTree(root));
        }
    }
}
