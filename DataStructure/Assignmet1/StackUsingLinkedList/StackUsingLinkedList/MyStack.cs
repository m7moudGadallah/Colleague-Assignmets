using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList {
    class SNode<T> {
        public T value;                 
        public SNode<T> next;           

        public SNode() {
            value = default(T);
            next = null;
        }

        public SNode(T value) {
            this.value = value;
            next = null;
        }

        public SNode(T value, SNode<T> next) {
            this.value = value;
            this.next = next;
        }

        public SNode(SNode<T> spn) {
            this.value = spn.value;
            this.next = spn.next;
        }
    }
    internal class MyStack<T> {
        int numOfEle;              
        SNode<T> top;

        public MyStack() {
            top = null;
            numOfEle = 0;
        }

        public bool isEmpty() {
            return numOfEle == 0;
        }

        public int count() {
            return this.numOfEle;
        }

        public void push(T ele) {
            SNode<T> spn = new SNode<T> (ele, top);
            top = spn;
            ++numOfEle;
        }

        public T pop() {
            if (isEmpty()) {
                Console.WriteLine("stack underflow!!!!");
                return default(T);
            }

            SNode<T> spn = top;
            top = top.next;
            spn.next = null;
            --numOfEle;

            return spn.value;
        }

        public void clear() {
            SNode<T> spn = top;

            while (top != null) {
                spn = top;
                top = top.next;
                spn.next = null;
            }

            numOfEle = 0;
        }

        public void printStack() {
            SNode<T> spn = top;

            Console.Write("[");
            while (spn != null) {
                Console.Write(spn.value);
                spn = spn.next;

                if (spn != null) {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }
}
