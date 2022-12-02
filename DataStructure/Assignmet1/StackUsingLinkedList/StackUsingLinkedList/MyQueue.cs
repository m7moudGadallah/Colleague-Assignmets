using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList {
    internal class MyQueue<T> {
        MyStack<T> myQueue = new MyStack<T> ();

        public bool isEmpty() {
            return myQueue.isEmpty();
        }

        public int count() {
            return myQueue.count();
        }

        public void enQueue(T ele) {
            if (isEmpty()) {
                myQueue.push(ele);
                return;
            }

            MyStack<T> tmpStack = new MyStack<T>();

            while (!myQueue.isEmpty()) {
                tmpStack.push(myQueue.pop());
            }

            myQueue.push(ele);

            while (!tmpStack.isEmpty()) {
                myQueue.push(tmpStack.pop());
            }
        }

        public T deQueue() {
            return myQueue.pop();
        }

        public void clear() {
            myQueue.clear();
        }

        public void printQueue() {
            myQueue.printStack();
        }
    }
}
