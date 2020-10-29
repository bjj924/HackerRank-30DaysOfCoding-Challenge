using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_24
{
    public class Day24
    {
        public static void LinkedList()
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = Insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        public static Node Insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }

        public static Node removeDuplicates(Node head)
        {
            Node start = head;
            while (start.next != null)
            {
                if (start.data == start.next.data)
                {
                    start.next = start.next.next;
                }
                else
                {
                    start = start.next;
                }
            }
            return head;
        }
    }
}
