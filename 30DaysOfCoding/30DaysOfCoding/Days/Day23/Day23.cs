using _30DaysOfCoding.Days.Day_22;
using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day23
{
    public class Day23
    {
        static Queue<Node> nodeQ = new Queue<Node>();
        static void levelOrder(Node root)
        {
            nodeQ.Enqueue(root);
            while (nodeQ.Count > 0)
            {
                var n = nodeQ.Dequeue();
                Console.Write(n.data + " ");
                if (n.left != null)
                    nodeQ.Enqueue(n.left);
                if (n.right != null)
                    nodeQ.Enqueue(n.right);
            }
        }
        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        public static void Search()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }
    }
}
