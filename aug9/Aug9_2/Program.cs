//2.Implement the Queue Data structure using Linked list (similar to the  one created in first program)
//implement the Enqueue and Dequeue functions
//Note: These both are self learning activities which really helps to improve language and logical skills.

using System;

namespace Aug9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Enqueue(10);
            linkedList.Enqueue(20);
            linkedList.Dequeue();
            linkedList.Dequeue();
            linkedList.Enqueue(30);
            linkedList.Enqueue(40);
            linkedList.Dequeue();
            Console.WriteLine("Queue fornt: " + linkedList.front.key);
            Console.WriteLine("Queue fornt: " + linkedList.rear.key);


        }
    }
}
