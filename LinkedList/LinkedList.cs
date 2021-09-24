using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList<T>
    {
        internal Node<T> head;
        /// <summary>
        /// creating method to add data
        /// </summary>
        /// <param name="data"></param>
        internal void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node<T> temp = head;
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
        public void Insert(int pos, T data)
        {
            Node<T> node = new Node<T>(data);
            if (pos < 1)
                Console.WriteLine("Invalid Position");
            else if (pos == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node<T> temp = head;

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
        internal Node<T> RemoveFirst()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        /// <summary>
        /// delete last elelment
        /// </summary>
        /// <returns></returns>
        internal Node<T> RemoveLast()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node<T> newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        /// <summary>
        /// method to search 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Search(int value)
        {
            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        /// <summary>
        /// finding size of linkedlist
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int a = 0;
            Node<T> temp = head;
            while (temp != null)
            {
                a++;
                temp = temp.next;
            }
            return a;
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
                Node<T> temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
