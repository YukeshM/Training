using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug9_1
{
    //node structure
    public class DNode
    {
        public int data;
        public DNode prev;
        public DNode next;
        
    }
    public class DoubleLinkedList
    {
        public DNode head;
        public DoubleLinkedList()
        {
            //constructor to create an empty linked list
            this.head = null;
        }

        public void PrintList()
        {
            DNode temp = new DNode();
            temp = this.head;
            if(temp != null)
            {
                Console.WriteLine("the list contains: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("the list is empty");
            }
        }

        //Delete an element at the given position
        public void pop_at(int position)
        {
            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1 && head != null)
            {
                DNode nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;
                if (head != null)
                    head.prev = null;
            }
            else
            {
                DNode temp = new DNode();
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null && temp.next != null)
                {
                    DNode nodeToDelete = temp.next;
                    temp.next = temp.next.next;
                    if (temp.next.next != null)
                        temp.next.next.prev = temp.next;
                    nodeToDelete = null;
                }
                else
                {
                    Console.Write("\nThe node is already null.");
                }
            }
        }

    }
}
