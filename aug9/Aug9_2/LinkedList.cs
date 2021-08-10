using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug9_2
{
    public class LinkedList
    {
        Node front;
        Node rear;
        public LinkedList()
        {
            this.front = this.rear = null;
        }

        public void Enqueue(int key)
        {
            Node temp = new Node(key);

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            this.rear.next = temp;
            this.rear = temp;
        }

        public void Dequeue()
        {
            if (this.front == null)
                return;

            Node temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
                this.rear = null;
        }
    }
}
