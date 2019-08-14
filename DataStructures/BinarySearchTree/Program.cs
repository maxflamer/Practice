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


        public static BSTNode Delete(BSTNode node, int data)
        {
            if (node == null)
                return node;
            else if (node.data > data)
                node.left = Delete(node.left, data);
            else if (node.data < data)
                node.right = Delete(node.right, data);
            else
            {
                //Case 1: No children
                if (node.left == null && node.right == null)
                    node = null;
                //Case 2: One child
                else if (node.left == null)
                    node = node.right;
                else if (node.right == null)
                    node = node.left;
                //Case 3: Two children
                else
                {
                    BSTNode temp = FindMin(node.right);
                    node.data = temp.data;
                    node.right = Delete(node.right, temp.data);
                }
            }
            return node;
        }

        public static BSTNode FindMin(BSTNode node)
        {
            while (node.left != null)
            {
                node = node.left;
            }
            return node;
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


        public static int InorderSuccessor(BSTNode node, int data)
        {
            BSTNode current = Search(root, data);
            if (current == null)
                return -1;
            //Case 1: Node has right subtree
            if (node.right != null)
                return FindMin(node.right).data;
            //Case 2: No right subtree
            else
            {
                BSTNode successor = null;
                BSTNode ancestor = root;
                while (ancestor != current)
                {
                    if (current.data < ancestor.data)
                    {
                        successor = ancestor;
                        ancestor = ancestor.left;
                    }
                    else
                        ancestor = ancestor.right;
                }
                return successor.data;
            }
        }

        public static BSTNode Search(BSTNode node, int data)
        {
            if (node == null)
                return null;
            else if (node.data == data)
                return node;
            else if (node.data > data)
                return Search(node.left, data);
            else
                return Search(node.right, data);
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

            Delete(root, 9);

            bool present = SearchUsingRecursion(root, 9);
            
            int successor = InorderSuccessor(root, 11);
            if (successor == -1)
                Console.WriteLine("Element not found");

            BSTNode minUsingIteration = FindMinUsingIteration(root);
            BSTNode maxUsingIteration = FindMaxUsingIteration(root);

            BSTNode minUsingRecursion = FindMinUsingRecursion(root);
            BSTNode maxUsingRecursion = FindMaxUsingRecursion(root);
        }
    }
}
