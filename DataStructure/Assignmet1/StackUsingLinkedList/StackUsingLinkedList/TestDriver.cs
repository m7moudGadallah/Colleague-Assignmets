using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("*************Test MyStack*****************\n");
            MyStack<int> mystack = new MyStack<int>();
            mystack.push(1);
            mystack.push(2);
            mystack.push(3);
            Console.Write("stack items: ");
            mystack.printStack();
            Console.WriteLine(mystack.pop());
            Console.Write("stack items: ");
            mystack.printStack();
            Console.WriteLine($"NO. elements: {mystack.count()}");
            mystack.clear();
            Console.WriteLine("Now stack is cleared");
            Console.Write("stack items: ");
            mystack.printStack();

            Console.WriteLine("\n\n***********Test MyQueue***********\n");
            MyQueue<int> myQueue = new MyQueue<int>();
            myQueue.enQueue(1);
            myQueue.enQueue(2);
            Console.WriteLine(myQueue.count());
            Console.Write("queue items: ");
            myQueue.printQueue();
            Console.WriteLine(myQueue.deQueue());
            Console.Write("queue items: ");
            myQueue.printQueue();
            myQueue.clear();
            Console.Write("queue items: ");
            myQueue.printQueue();
        }
    }
}
