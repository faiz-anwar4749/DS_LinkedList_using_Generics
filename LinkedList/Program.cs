using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked Lists Intro Problem");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list = new LinkedList();
            list.Append(70);
            list.Append(30);
            list.Append(56);
            list.Display();
            list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            list.Display();
        }
    }
}
