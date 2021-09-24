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
        /// <summary>
        /// Method to push the element in stack
        /// </summary>
        /// <param name="value"></param>
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
        /// <summary>
        /// Method to display the element in Stack
        /// </summary>
        public void display()
        {
            NodeStack<Gtype> temp = this.top;
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp=temp.next;
            }
        }
        /// <summary>
        /// Method to remove the element without deleting
        /// </summary>
        public void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is UnderFlow");
            }
            Console.WriteLine("{0} is on the top of Stack", this.top.data);
        }
        /// <summary>
        /// Method to delete the element in stack
        /// </summary>
        public void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack UnderFlow");
            }
            Console.WriteLine("Item Popped is :" + this.top.data);
            this.top = top.next;
        }
        public void isEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
        }
    }
}
