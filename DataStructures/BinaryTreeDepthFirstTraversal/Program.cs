using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDepthFirstTraversal
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

        public static void PreOrderTraversal(BSTNode node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.data);
            PreOrderTraversal(node.left);
            PreOrderTraversal(node.right);
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
            
            PreOrderTraversal(root);
        }
    }
}
