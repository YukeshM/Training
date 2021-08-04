//a program to implement a singly linked list ,  where you can add , delete and display the nodes
using System;
using System.Collections.Generic;

namespace Aug_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedListNumbers = new LinkedList<int>();
            linkedListNumbers.AddFirst(1);
            linkedListNumbers.AddFirst(2);
            linkedListNumbers.AddFirst(3);
            linkedListNumbers.AddLast(4);
            linkedListNumbers.AddLast(5);

            foreach (int item in linkedListNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("remove method results: ");
            linkedListNumbers.RemoveFirst();
            foreach (int item in linkedListNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("removes first ");
            linkedListNumbers.Remove(linkedListNumbers.First);

            foreach (int item in linkedListNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("again removed a number: ");
            linkedListNumbers.RemoveLast();
            foreach (int item in linkedListNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            linkedListNumbers.Clear();

        }
    }
}
