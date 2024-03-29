# Heap
## Contents
- `Heap` [class](https://github.com/m7moudGadallah/Colleague-Assignmets/tree/main/DataStructure/Assignment3#heap-class)
- `MinHeap` [class](https://github.com/m7moudGadallah/Colleague-Assignmets/tree/main/DataStructure/Assignment3#minheap)
- `MaxHeap` [class](https://github.com/m7moudGadallah/Colleague-Assignmets/tree/main/DataStructure/Assignment3#maxheap)
- `TestDriver` [class](https://github.com/m7moudGadallah/Colleague-Assignmets/tree/main/DataStructure/Assignment3#testing-class)

### [Heap class](./heap_Assignment/heap_Assignment/TestDriver.cs)
- is an abstract class thta contains all attributes methods of heap
    - `parent(node)`: to get index of node`s parent
    - `rightNode(node)`: to get index of node`s right child
    - `leftNode(node)`: to get index of node`s left child
    - `swap(index1, index2)`: to swap 2 elements by passing their indices
    - `size()`: to get size of Heap
    - `top()`: to get root Node of Heap
    - `serach(ele)`: to serach of an element in Heap
    - `isEmpty()`: to check if Heap is empty or not
    - `clear()`: to clear Heap
    - `printHeap()`: print Heap Nodes
    - `insert(ele)`: insert a new element to Heap
    - `delete()`: remove top of Heap
    - `reheapUP(node)`: abstract method which will implemented with [MinHeap](https://github.com/m7moudGadallah/Colleague-Assignmets/tree/main/DataStructure/Assignment3#minheap) & [MaxHeap](https://github.com/m7moudGadallah/Colleague-Assignmets/tree/main/DataStructure/Assignment3#maxheap),is used to reheaping after insertion
    - `reheapDown(node)`: abstract method  which will implemented with [MinHeap](https://github.com/m7moudGadallah/Colleague-Assignmets/tree/main/DataStructure/Assignment3#minheap) & [MaxHeap](https://github.com/m7moudGadallah/Colleague-Assignmets/tree/main/DataStructure/Assignment3#maxheap) ,is used to reheaping after deletation

### [MinHeap](./heap_Assignment/heap_Assignment/TestDriver.cs)
- this class associated with min Heap so it inhertes Heap class and implements `reheapUP(node)` and `reheapDown(node)` methods


### [MaxHeap](./heap_Assignment/heap_Assignment/TestDriver.cs)
- this class associated with max Heap so it inhertes Heap class and implements `reheapUP(node)` and `reheapDown(node)` methods


### [Testing Class](./heap_Assignment/heap_Assignment/TestDriver.cs)
![Testing](./testing.png)