using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_22
{
    public class Day22
    {
        public static void NodeRoot()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
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

        static int getHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }

            return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
        }
    }
}
