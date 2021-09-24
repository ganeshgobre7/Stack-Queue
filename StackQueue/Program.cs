using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO STACK AND QUEUE PROGRAM");
            /*StackLinkedList<int> stack = new StackLinkedList<int>();//creating object 
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.display();
            Console.WriteLine("*******************************");
            stack.peek();
            Console.WriteLine("*******************************");
            stack.pop();
            Console.WriteLine("*******************************");
            stack.isEmpty();
            stack.display();*/

            QueueLinkedList<int> queue = new QueueLinkedList<int>();
            queue.Enqueue(70);
            queue.Enqueue(30);
            queue.Enqueue(56);
            queue.Display();



        }

    }
}
