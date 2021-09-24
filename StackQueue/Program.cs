using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO STACK AND QUEUE PROGRAM");
            StackLinkedList<int> stack = new StackLinkedList<int>();//creating object 
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.display();
            Console.WriteLine("*******************************");
            stack.peek();
            Console.WriteLine("*******************************");
            stack.Pop();
            

        }

    }
}
