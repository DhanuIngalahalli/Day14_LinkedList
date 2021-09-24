using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list");
            LinkedList list = new LinkedList(); //creating list
            list.Append(56);
            list.Append(30);
            list.Append(70);
            Console.WriteLine("Linked list elements are:");
            list.Display(); 
        }
    }
}
