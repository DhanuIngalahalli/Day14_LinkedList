using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list");
            LinkedList list = new LinkedList(); //creating list
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Insert(3, 40);
            Console.WriteLine("Linked list elements are:");
            list.Display();
           
            list.Delete(40);
            Console.WriteLine("Linked list elements after deleting :");
            //list.RemoveLast();
            list.Display();

            //Console.WriteLine(list.Search(30));

        }
    }
}
