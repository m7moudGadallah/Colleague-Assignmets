# Heap
## Contents
- `Heap` class
- `MinHeap` class
- `MaxHeap` class

### Heap class
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
    - `reheapUP(node)`: abstract method which will implemented with [MinHeap]() & [MaxHeap](),is used to reheaping after insertion
    - `reheapDown(node)`: abstract method  which will implemented with [MinHeap]() & [MaxHeap]() ,is used to reheaping after deletation

### MinHeap
- this class associated with min Heap so it inhertes Heap class and implements `reheapUP(node)` and `reheapDown(node)` methods


### MaxHeap
- this class associated with max Heap so it inhertes Heap class and implements `reheapUP(node)` and `reheapDown(node)` methods