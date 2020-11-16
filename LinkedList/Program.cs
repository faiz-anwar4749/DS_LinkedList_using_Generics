using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked Lists Intro Problem");
            Linked_List list = new Linked_List();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list = new Linked_List();
            list.Append(70);
            list.Append(30);
            list.Append(56);
            list.Display();
            list = new Linked_List();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            list.Display();
            Console.WriteLine("First element popped out of the Linked List- " + list.RemoveFirstNode().data);
            list.Display();
            list.InsertAtParticularPosition(1, 56);
            list.Display();
            Console.WriteLine("Deleted last element of the Linked List- " + list.RemoveLastNode().data);
            list.Display();
            Console.WriteLine(list.Search(10));
            list.Display();
        }
    }
}
