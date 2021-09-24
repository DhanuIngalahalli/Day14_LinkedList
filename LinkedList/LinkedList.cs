using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        internal Node head;
        /// <summary>
        /// creating method to add data
        /// </summary>
        /// <param name="data"></param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted", node.data);
        }
        /// <summary>
        /// inserting at particular position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        public void Insert(int pos, int data)
        {
            Node node = new Node(data);
            if (pos < 1)
                Console.WriteLine("Invalid Position");
            else if (pos == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (pos > 2)
                {
                    temp = temp.next;
                    pos--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }
        /// <summary>
        /// removing first element
        /// </summary>
        /// <returns></returns>
        internal Node RemoveFirst()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        /// <summary>
        /// creating method for display
        /// </summary>
        internal void Display()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
