using System;

namespace aug9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a empty linkedlist
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();

            //add first node
            DNode first = new DNode();
            first.data = 4;
            first.next = null;
            first.prev = null;
            doubleLinkedList.head = first;

            //add second node
            DNode second = new DNode();
            second.data = 5;
            second.prev = first;
            second.next = null;
            first.next = second;

            //add third node
            DNode third = new DNode();
            third.data = 6;
            third.prev = second;
            third.next = null;
            second.next = third;

            //print the content of doubly linked list
            doubleLinkedList.PrintList();

            //removing a list with position
            doubleLinkedList.pop_at(2);
            Console.WriteLine();
            doubleLinkedList.PrintList();
        }
    }
}
