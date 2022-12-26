using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace heap_Assignment {

    /* Heap class
     * abstract class that contains functions of heap and abstract methods of heapifing and
     * also function of inseration and deletion
     */
    #region Heap class
    public abstract class Heap {
        protected List<int> heap;

        public Heap() {
            heap = new List<int>();
        }
        protected int parent(int node) {
            return (node - 1) / 2;
        }
        protected int leftNode(int node) {
            int pos = (node * 2) + 1;
            return (pos >= heap.Count) ? -1 : pos;
        }
        protected int rightNode(int node) {
            int pos = (node * 2) + 2;
            return (pos >= heap.Count) ? -1 : pos;
        }
        
        protected void swap(int indx1, int indx2) {
            int temp = heap[indx1];
            heap[indx1] = heap[indx2];
            heap[indx2] = temp;
        }

        public int size() {
            return heap.Count;
        }
        
        public int top() {
            return heap[0];
        }

        public bool serach(int ele) {
            for (int i = 0; i < heap.Count; i++) {
                if (heap[i] == ele)
                    return true;
            }
            return false;
        }

        public bool isEmpty() {
            return heap.Count == 0;
        }

        public void clear() {
            heap.Clear();
        }
        
        public void printHeap() {
            Console.Write("[ ");
            for (int i = 0; i < heap.Count; ++i)
                Console.Write($"{heap[i]} ");
            Console.WriteLine(" ]");
        }
        public void insert(int ele) {
            heap.Add(ele);
            reheapUP(heap.Count - 1);
        }
        public  void delete () {
            swap(0, heap.Count - 1);
            heap.RemoveAt(heap.Count - 1);
            reheapDOWN(0);
        }
        protected abstract void reheapUP(int pos);

        protected abstract void reheapDOWN(int pos);
    }

    #endregion


    /*MinHeap class
     * this class inherate Heap class and implement reheapUP and reheapDown methods
     */
    #region MinHeap class
    public class MinHeap : Heap {
        protected override void reheapUP(int pos) {
            if (pos == 0 || heap[parent(pos)] < heap[pos])      //stop if we reach root or parent is samller
                return;

            swap(parent(pos), pos);
            reheapUP(parent(pos));
        }

        protected override void reheapDOWN(int pos) {
            if (pos == heap.Count - 1)          //stop if we reach end of heap
                return;

            int child = leftNode(pos);
            if (child == -1)
                return;

            int rightChild = rightNode(pos);

            if (rightChild != -1 && heap[rightChild] < heap[child])
                child = rightChild;

            if (heap[pos] > heap[child]) {          //stop if parent is smaller
                swap(pos, child);
                reheapDOWN(child);
            }
        }
    }
    #endregion


    /*MaxHeap class
     * this class inherate Heap class and implement reheapUP and reheapDown methods
     */
    #region MaxHeap
    public class MaxHeap:Heap {
        protected override void reheapUP(int pos) {
            if (pos == 0 || heap[parent(pos)] > heap[pos])  //stop if we reach root or parent is greater
                return;
            swap(parent(pos), pos);
            reheapUP(parent(pos));
        }

        protected override void reheapDOWN(int pos) {
            if (pos == heap.Count - 1)          //stop if we reach end of heap
                return;

            int child = leftNode(pos);
            if (child == -1)
                return;

            int rightChild = rightNode(pos);

            if (rightChild != -1 && heap[rightChild] > heap[child])
                child = rightChild;

            if (heap[pos] < heap[child]) {          //stop if parent is greater
                swap(pos, child);
                reheapDOWN(child);
            }
        }
    }
    #endregion

    #region TestDriver class
    internal class TestDriver {
        static void minHeapTester() {
            Console.WriteLine("***********************Min Heap Testing********************");
            MinHeap heap = new MinHeap();
            Console.WriteLine("inserting elements in heap......");
            heap.insert(10);        //test insert
            heap.insert(1);
            heap.insert(5);
            heap.insert(0);
            heap.insert(4);
            heap.insert(15);
            Console.WriteLine("Heap now....");
            heap.printHeap();

            Console.WriteLine($"Heap Size: {heap.size()}");

            Console.WriteLine("delete from heap.........");
            heap.delete();          //test delete
            Console.WriteLine("Heap now....");
            heap.printHeap();

            Console.WriteLine("delete from heap.........");
            heap.delete();          //test delete
            Console.WriteLine("Heap now....");
            heap.printHeap();

            Console.WriteLine($"Heap isEmpty: {heap.isEmpty()}");       //test isEmpty
            Console.WriteLine($"10 is in Heap: {heap.serach(10)}");     //test searching
            Console.WriteLine($"20 is in Heap: {heap.serach(20)}");

            Console.WriteLine("clear heap.........");
            heap.clear();          //test clear
            Console.WriteLine("Heap now....");
            heap.printHeap();
        }

        static void maxHeapTester() {
            Console.WriteLine("***********************Max Heap Testing********************");
            MaxHeap heap = new MaxHeap();
            Console.WriteLine("inserting elements in heap......");
            heap.insert(10);        //test insert
            heap.insert(1);
            heap.insert(5);
            heap.insert(0);
            heap.insert(4);
            heap.insert(15);
            Console.WriteLine("Heap now....");
            heap.printHeap();

            Console.WriteLine($"Heap Size: {heap.size()}");

            Console.WriteLine("delete from heap.........");
            heap.delete();          //test delete
            Console.WriteLine("Heap now....");
            heap.printHeap();

            Console.WriteLine("delete from heap.........");
            heap.delete();          //test delete
            Console.WriteLine("Heap now....");
            heap.printHeap();

            Console.WriteLine($"Heap isEmpty: {heap.isEmpty()}");       //test isEmpty
            Console.WriteLine($"10 is in Heap: {heap.serach(10)}");     //test searching
            Console.WriteLine($"5 is in Heap: {heap.serach(5)}");

            Console.WriteLine("clear heap.........");
            heap.clear();          //test clear
            Console.WriteLine("Heap now....");
            heap.printHeap();
        }
        static void Main(string[] args) {
            minHeapTester();            //test MinHeap
            Console.WriteLine("\n\n\n");
            maxHeapTester();            //test MaxHeap
        }
    }
    #endregion
}
