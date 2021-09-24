using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    class StackLinkedList<Gtype>
    {
        public NodeStack<Gtype> top;
        public StackLinkedList()
        {
            this.top = null;
        }
        public void push(Gtype value)
        {
            NodeStack<Gtype> node = new NodeStack<Gtype>(value);
            if(this.top==null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            this.top = node;
            Console.WriteLine("Pushed to Stack :" + value);
        }
        public void display()
        {
            NodeStack<Gtype> temp = this.top;
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp=temp.next;
            }
        }
    }
}
