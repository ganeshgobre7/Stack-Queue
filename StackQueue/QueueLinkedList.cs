using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    class QueueLinkedList<Gtype>
    {
        NodeStack<Gtype> head = null;

        public void Enqueue(Gtype data)
        {
            NodeStack<Gtype> node = new NodeStack<Gtype>(data);
            if(this.head==null)
            {
                this.head = node;
            }
            else
            {
                NodeStack<Gtype> temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Element added in Queue" + node.data);
        }

        public void Display()
        {
            NodeStack<Gtype> temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Queue is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }         
        }
    }
}
