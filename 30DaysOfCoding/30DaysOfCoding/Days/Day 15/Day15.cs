using _30DaysOfCoding.Days.Day_17;
using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_15
{
    public class Day15
    {
        public static void LinkedList()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }

            display(head);
        }

        private static Node insert(Node head, int data)
        {
            var node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                var currentNode = head;

                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }

                currentNode.next = node;
            }

            return head;
        }

        private static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
